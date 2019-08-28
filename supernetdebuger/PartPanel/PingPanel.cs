using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Diagnostics;
using System.IO;
using LeafSoft.Lib;
using System.Text.RegularExpressions;

namespace LeafSoft.PartPanel
{
    public partial class PingPanel : UserControl
    {
        bool IsPingAllow = false;
        int PingCount = 0;
        int Interval = 1000;

        public PingPanel()
        {
            InitializeComponent();
            if (LanguageSet.Language == "0")
            {
                LanguageSet.SetLang("", this, typeof(PingPanel));
            }
            else
            {
                LanguageSet.SetLang("en-US", this, typeof(PingPanel));
            }
            comboBox1.SelectedIndex = 0;
            btnPing.Focus();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            if (IsPingAllow == false)
            {
                string ip = txtServerIP.Text;
                Regex regex = new Regex("^[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}$");
                if (!regex.IsMatch(ip))
                {
                    if (LanguageSet.Language == "0")
                        MessageBox.Show("输入的 IP 地址无效!", "提示");
                    else
                        MessageBox.Show("Invalid IP address entered!", "Tips");
                    return;
                }
                if (LanguageSet.Language == "0")
                    btnPing.Text = "停止";
                else
                    btnPing.Text = "Stop";
                txtServerIP.Enabled = false;
                nmPingCount.Enabled = false;
                nmInterval.Enabled = false;
                PingCount = int.Parse(textPingCount.Text);
                Interval = int.Parse(textInterval.Text);
                if (PingCount > 0 && Interval >= 0)
                {
                    IsPingAllow = true;
                    Thread ThPing = new Thread(new ParameterizedThreadStart(PingThread));
                    ThPing.IsBackground = true;
                    ThPing.Start(txtServerIP.Text.Trim());
                }
                else
                {
                    if(LanguageSet.Language == "0")
                        MessageBox.Show("设置的Ping次数或间隔时间不符合!", "提示");
                    else
                        MessageBox.Show("The set number of pings or interval does not match!", "Tips");
                }
            }
            else
            {
                IsPingAllow = false;
                btnPing.Enabled = false;
            }
        }

        private void PingThread(object ServerIP)
        {
            txtCmd.Invoke(new MethodInvoker(delegate
            {
                if (LanguageSet.Language == "0")
                    txtCmd.AppendText("正在 Ping " + ServerIP.ToString()+"：\r\n");
                else
                    txtCmd.AppendText("Pinging " + ServerIP.ToString() + "：\r\n");
            }));
            Ping p = new Ping();
            int pcount=0;
            long MinRT = -1;
            long MaxRT = -1;
            long AvgRT = -1;
            long TotalRT=0;
            int SuccessRT = 0;
            while (pcount < PingCount || PingCount==0)
            {
                PingReply pr = p.Send(ServerIP.ToString());
                txtCmd.Invoke(new MethodInvoker(delegate
                {
                    if (pr.Status == IPStatus.Success)
                    {
                        SuccessRT++;
                        if (LanguageSet.Language == "0")
                            txtCmd.AppendText("来自 " + pr.Address.ToString() + " 的答复：字节=" + pr.Buffer.Length + " 时间=" + pr.RoundtripTime + " TTL=" + pr.Options.Ttl + "\r\n");
                        else
                            txtCmd.AppendText("From " + pr.Address.ToString() + " reply：bytes=" + pr.Buffer.Length + " time=" + pr.RoundtripTime + " TTL=" + pr.Options.Ttl + "\r\n");
                        if (MinRT == -1 || pr.RoundtripTime < MinRT)
                        {
                            MinRT = pr.RoundtripTime;
                        }
                        if (MaxRT == -1 || pr.RoundtripTime > MaxRT)
                        {
                            MaxRT = pr.RoundtripTime;
                        }
                        TotalRT += pr.RoundtripTime;
                        AvgRT = TotalRT / SuccessRT;
                    }
                    else
                    {
                        txtCmd.AppendText(pr.Status.ToString()+"\r\n");
                        this.txtCmd.AppendText("");
                        this.txtCmd.Focus();
                    }
                }));
                pcount++;
                if (IsPingAllow == false)
                {
                    break;
                }
                Thread.Sleep(Interval);
            }
            this.Invoke(new MethodInvoker(delegate
            {
                if (LanguageSet.Language == "0")
                {
                    txtCmd.AppendText("Ping统计信息：\r\n");
                    txtCmd.AppendText("数据包：已发送 = " + pcount + ",已接收 = " + SuccessRT + ",丢失 = " + (pcount - SuccessRT) + " <" + (int)((1 - (float)SuccessRT / (float)pcount) * 100) + "%丢失>\r\n");
                    txtCmd.AppendText("往返行程估计时间：最短 = " + MinRT + "ms,最长 = " + MaxRT + "ms,平均 = " + AvgRT + "ms\r\n\r\n");
                }
                else
                {
                    txtCmd.AppendText("Ping statistics：\r\n");
                    txtCmd.AppendText("Packet: sent = " + pcount + ",received = " + SuccessRT + ",lost = " + (pcount - SuccessRT) + " <" + (int)((1 - (float)SuccessRT / (float)pcount) * 100) + "%lost>\r\n");
                    txtCmd.AppendText("Round trip estimated time：shortest = " + MinRT + "ms,longest = " + MaxRT + "ms,average = " + AvgRT + "ms\r\n\r\n");
                }
                this.txtCmd.AppendText("");
                this.txtCmd.Focus();
                btnPing.Enabled = true;
                txtServerIP.Enabled = true;
                nmPingCount.Enabled = true;
                nmInterval.Enabled = true;
                btnPing.Text = "Ping";
            }));
            IsPingAllow = false;
        }

        private void MSI_Clear_Click(object sender, EventArgs e)
        {
            txtCmd.Clear();
        }

        private StreamReader reader;
        private StreamWriter writer;
        private delegate void AppendRichText(string str);
        private Process p = null;
        private Thread t;
        private bool running = false;
        //private Cmd c;
        private void PingPanel_Load(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(ExecuteCMD));
            t.Start();
            running = true;
        }

        private void ExecuteCMD()
        {
            p = new Process();
            p.StartInfo = new ProcessStartInfo();
            p.StartInfo.FileName = "cmd.exe";
            //p.StartInfo.Arguments = "/c adb.exe";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            reader = p.StandardOutput;
            writer = p.StandardInput;

            while (true)
            {
                if (reader.EndOfStream) break;
                string cmdoutput = reader.ReadLine();
                this.Invoke(new AppendRichText(AppendText), cmdoutput);

            }
            p.WaitForExit();
            p.Close();
            running = true;
            if (LanguageSet.Language == "0")
                MessageBox.Show("cmd 命令不正确！");
            else
                MessageBox.Show("cmd The command is incorrect！");
        }

        private void ExecuteADB(object obj)
        {
            string cmd = obj.ToString();
            String adb = Application.StartupPath + "\\adb.exe";
            ProcessHelper.RunResult r = ProcessHelper.Run(adb, cmd);
            if (r.Success)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    this.txtCmd.AppendText(r.OutputString + "\n");
                }));
            }
            else
            {
                if (LanguageSet.Language == "0")
                    MessageBox.Show("adb 命令出错！");
                else
                    MessageBox.Show("adb Command error！");
            }
        }

        private void AppendText(string text)
        {
            this.txtCmd.AppendText(text + "\n");
            this.txtCmd.AppendText("");
            this.txtCmd.Focus();
        }

        private void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                StringBuilder sb = new StringBuilder(this.txtCmd.Text);
                this.txtCmd.Text = sb.AppendLine(outLine.Data).ToString();
                this.txtCmd.SelectionStart = this.txtCmd.Text.Length;
                this.txtCmd.ScrollToCaret();
            }
        }

        public void OutPutForm_FormClosing()
        {
            if(t.IsAlive)
                t.Abort();
            if (!p.HasExited) p.Kill();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.Enter)
            {
                string cmd = this.textBox1.Text;
                try
                {
                    if (running)
                    {
                        t = new Thread(new ThreadStart(ExecuteCMD));
                        t.Start();
                        running = false;
                        textBox1.Text = "";
                        txtCmd.Focus();
                        //writer.WriteLine(cmd);
                        //Console.WriteLine("-=-=");
                    }
                    else
                    {
                        writer.WriteLine(cmd);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtCmd_Click(object sender, EventArgs e)
        {
            //textBox1.Focus();
        }

        private void nmPingCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt32(e.KeyChar);
            if (!(48 <= key && key <= 58 || key == 8)) //数字、 Backspace
            {
                //this.Text = "keyChar:" + key.ToString();
                decimal value = nmPingCount.Value;
                if (value < 1 || value > 100)
                {
                    if (LanguageSet.Language == "0")
                        MessageBox.Show("Ping次数限制在(0-100)之间。", "提示");
                    else
                        MessageBox.Show("The number of pings is limited to between (0 and 100).", "Tips");
                    nmPingCount.Value = 1;
                }
                e.Handled = true;
            }
            else this.Text = "";
        }

        private void nmInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt32(e.KeyChar);
            if (!(48 <= key && key <= 58 || key == 8)) //数字、 Backspace
            {
                //this.Text = "keyChar:" + key.ToString();
                decimal value = nmInterval.Value;
                if (value < 0 || value > 3600000)
                {
                    if (LanguageSet.Language == "0")
                        MessageBox.Show("Ping间隔限制在(0-3600000)s之间。", "提示");
                    else
                        MessageBox.Show("The ping interval is limited to between (0 and 3600000)s.", "Tips");
                    nmInterval.Value = 1;
                }
                e.Handled = true;
            }
            else this.Text = "";
        }

        private void textPingCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textPingCount_TextChanged(object sender, EventArgs e)
        {
            if (textPingCount.Text.Length > 0)
            {
                int value = int.Parse(textPingCount.Text);
                if (value < 1)
                {
                    textPingCount.Text = "1";
                    if(LanguageSet.Language == "0")
                        MessageBox.Show("小于目标设置范围(1-100)！", "提示");
                    else
                        MessageBox.Show("Less than the target setting range(1-100)！", "Tips");
                }
                else if (value > 100)
                {
                    textPingCount.Text = "100";
                    if (LanguageSet.Language == "0")
                        MessageBox.Show("大于目标设置范围(1-100)！", "提示");
                    else
                        MessageBox.Show("Greater than the target setting range(1-100)！", "Tips");
                }
            }
        }

        private void textInterval_TextChanged(object sender, EventArgs e)
        {
            if (textInterval.Text.Length > 0)
            {
                int value = int.Parse(textInterval.Text);
                if (value < 1000)
                {
                    textInterval.Text = "1000";
                    if (LanguageSet.Language == "0")
                        MessageBox.Show("小于目标设置范围(1-100)！", "提示");
                    else
                        MessageBox.Show("Less than the target setting range(1-100)！", "Tips");
                }
                else if (value > 3600000)
                {
                    textInterval.Text = "3600000";
                    if (LanguageSet.Language == "0")
                        MessageBox.Show("大于目标设置范围(1-100)！", "提示");
                    else
                        MessageBox.Show("Greater than the target setting range(1-100)！", "Tips");
                }
            }
        }
    }
}
