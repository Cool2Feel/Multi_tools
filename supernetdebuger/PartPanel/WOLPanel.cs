using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using LeafSoft.Lib;
using System.Threading;

namespace LeafSoft.PartPanel
{
    public partial class WOLPanel : UserControl
    {
        BindingList<Model.WOL> lstWOL = new BindingList<Model.WOL>();
        //List<string> ipList = new List<string>();
        private IniFiles settingFile;//配置文件
        /// <summary>
        /// 是否在唤醒状态
        /// </summary>
        bool AutoSend = false;

        public WOLPanel()
        {
            InitializeComponent();
            dgWOL.AutoGenerateColumns = false;
            if (LanguageSet.Language == "0")
            {
                LanguageSet.SetLang("", this, typeof(WOLPanel));
            }
            else
            {
                LanguageSet.SetLang("en-US", this, typeof(WOLPanel));
            }
            /*
            IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in ipHostEntry.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {//筛选IPV4
                    ipList.Add(ip.ToString());
                }
            }
            string ip1 = ipList[0];
            */
            //lstWOL.Add(new Model.WOL("00:51:62:48:51:02","dwl","192.168.3.69"));
            dgWOL.DataSource = lstWOL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MacTextBox.Text))
            {
                //byte[] mac = MacToBytes(MacTextBox.Text);

                //SendWakeOnLanPacket(mac);
                WOL.AquilaWolLibrary.WakeUp(MacTextBox.Text);

                LogHelper.WriteLog("WOL Date: " + MacTextBox.Text);

                if (LanguageSet.Language == "0")
                    MessageBox.Show("已发送唤醒数据信息！", "提示");
                else
                    MessageBox.Show("Wakeup data message sent！", "Tips");
            }
            else
            {
                if (LanguageSet.Language == "0")
                    MessageBox.Show("请输入正确的MAC地址进行唤醒！", "提示");
                else
                    MessageBox.Show("Please enter the correct MAC address to wake up！", "Tips");
            }
        }

        private static void SendWakeOnLanPacket(byte[] mac)
        {
            //
            // WOL 包通过 UDP 255.255.255.0:40000 发送。
            //
            UdpClient client = new UdpClient();
            client.Connect(IPAddress.Broadcast, 40000);

            //
            // WOL 包含了6个字节的属部和16倍6字节序列包含MAC地址.
            //
            byte[] packet = new byte[17 * 6];

            //
            // 尾部6倍的 0xFF.
            //
            for (int i = 0; i < 6; i++)
                packet[i] = 0xFF;

            //
            // 魔术包主体部分包含了16倍的MAC地址。
            //
            for (int i = 1; i <= 16; i++)
                for (int j = 0; j < 6; j++)
                    packet[i * 6 + j] = mac[j];

            //
            // 发送唤醒包。
            //
            client.Send(packet, packet.Length);
        }
        private static void SendWakeOnLanPacket(byte[] mac, string ip)
        {
            //
            // WOL 包通过 UDP 255.255.255.0:40000 发送。
            //
            UdpClient client = new UdpClient();
            client.Connect(IPAddress.Parse(ip), 40000);

            //
            // WOL 包含了6个字节的属部和16倍6字节序列包含MAC地址.
            //
            byte[] packet = new byte[17 * 6];

            //
            // 尾部6倍的 0xFF.
            //
            for (int i = 0; i < 6; i++)
                packet[i] = 0xFF;

            //
            // 魔术包主体部分包含了16倍的MAC地址。
            //
            for (int i = 1; i <= 16; i++)
                for (int j = 0; j < 6; j++)
                    packet[i * 6 + j] = mac[j];

            //
            // 发送唤醒包。
            //
            client.Send(packet, packet.Length);
        }

        //private GetMac GM;
        private void btMac_Click(object sender, EventArgs e)
        {
            //GM = new GetMac(ipList[0]);
            //lstWOL.Add(new Model.WOL(GM.MAC,GM.NAME,GM.IP));
            frmGetMac fMac = new frmGetMac();
            if (fMac.ShowDialog() == DialogResult.OK)
            {
                lstWOL.Add(fMac.NewWOL);
            }
        }

        private void dgWOL_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (LanguageSet.Language == "0")
                dgWOL.Rows[e.RowIndex].Cells[4].Value = "唤醒";
            else
                dgWOL.Rows[e.RowIndex].Cells[4].Value = "wake";
            dgWOL.Rows[e.RowIndex].Cells[0].Value = false;
        }

        private byte[] MacToBytes(string macString)
        {
            try
            {
                if (null != macString && macString.Split(':').Length == 6)
                {
                    string[] macStringArray = macString.Split(':');
                    byte[] macByteArray = new byte[6];
                    for (int i = 0; i < 6; i++)
                    {
                        macByteArray[i] = Convert.ToByte(macStringArray[i], 16);
                    }
                    return macByteArray;
                }
            }
            catch
            {
                MessageBox.Show("请检查您输入的MAC地址格式，例如：70:71:BC:22:AE:3A");
            }
            return null;
        }
        /// <summary>
        /// 唤醒点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgWOL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {//点击了唤醒按钮 
                string macString = dgWOL.Rows[e.RowIndex].Cells[1].Value.ToString();
                string ipString = dgWOL.Rows[e.RowIndex].Cells[3].Value.ToString();
                //byte[] macByte = MacToBytes(macString);
                if (null != macString)
                {

                    WOL.AquilaWolLibrary.WakeUp(macString);
                    WOL.AquilaWolLibrary.WakeUp(macString, ipString);
                    //SendWakeOnLanPacket(macByte, ipString);
                    LogHelper.WriteLog("WOL Date: " + macString);
                    if (LanguageSet.Language == "0")
                        MessageBox.Show("已发送唤醒数据信息！", "提示");
                    else
                        MessageBox.Show("Wakeup data message sent！", "Tips");
                }
            }
        }

        private void dgWOL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                string macString = dgWOL.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (macString != "")
                {
                    MacTextBox.Text = macString;
                }
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgWOL.SelectedRows.Count > 0)
            {
                lstWOL.RemoveAt(dgWOL.SelectedRows[0].Index);
            }
            else
            {
                if (LanguageSet.Language == "0")
                    MessageBox.Show("没有选中需要删除的设备对象！", "提示");
                else
                    MessageBox.Show("Device object that needs to be deleted is not selected！", "Tips");
            }
        }

        private bool CheckSelectSend()
        {
            for (int i = 0; i < dgWOL.Rows.Count; i++)
            {
                //object cbxValue = dgWOL.Rows[i].Cells[0].Value;
                if ((Convert.ToBoolean(dgWOL.Rows[i].Cells[0].Value) == true))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 一键唤醒
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAllsend_Click(object sender, EventArgs e)
        {
            if (AutoSend == false)
            {
                if (LanguageSet.Language == "0")
                    btAllsend.Text = "停止唤醒";
                else
                    btAllsend.Text = "Stop wake";
                AutoSend = true;
                if (CheckSelectSend())
                {
                    dgWOL.Enabled = false;
                    this.Cursor = Cursors.AppStarting;
                    Thread ThTestL = new Thread(new ThreadStart(TWakeSend));
                    ThTestL.IsBackground = true;
                    ThTestL.Start();
                }
                else
                {
                    if (LanguageSet.Language == "0")
                        MessageBox.Show("没有勾选需要唤醒的设备！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Unchecked devices that need to be woken up！", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    StopWakeSend();
                }
            }
            else
            {
                StopWakeSend();
            }
        }

        private void TWakeSend()
        {
            try
            {
                //while (AutoSend)
                {
                    for (int i = 0; i < dgWOL.Rows.Count; i++)
                    {
                        if (AutoSend)
                        {
                            this.Invoke(new MethodInvoker(delegate
                            {
                                if ((Convert.ToBoolean(dgWOL.Rows[i].Cells[0].Value) == true))
                                {
                                    string macString = dgWOL.Rows[i].Cells[1].Value.ToString();
                                    string ipString = dgWOL.Rows[i].Cells[3].Value.ToString();
                                    byte[] macByte = MacToBytes(macString);
                                    if (null != macByte)
                                    {
                                        //SendWakeOnLanPacket(macByte, ipString);
                                        WOL.AquilaWolLibrary.WakeUp(macString);
                                        WOL.AquilaWolLibrary.WakeUp(macString, ipString);
                                        LogHelper.WriteLog("WOL Date: " + macString);
                                    }
                                }
                            }));
                            Thread.Sleep(200);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            catch
            { }
            this.Invoke(new MethodInvoker(delegate
            {
                StopWakeSend();
            }));
        }

        /// <summary>
        /// 停止唤醒
        /// </summary>
        private void StopWakeSend()
        {
            AutoSend = false;
            this.Cursor = Cursors.Default;
            dgWOL.Enabled = true;
            if (LanguageSet.Language == "0")
            {
                btAllsend.Text = "一键唤醒";
                MessageBox.Show("已对所以选中的设备进行唤醒操作！", "提示");
            }
            else
            {
                btAllsend.Text = "wake-up";
                MessageBox.Show("The selected device has been woken up！", "Tips");
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmAWOL fCmd = new frmAWOL();
            if (fCmd.ShowDialog() == DialogResult.OK)
            {
                lstWOL.Add(fCmd.NewWOL);
            }
        }

        #region 加载和保存
        public void Load_Inifile()
        {
            try
            {
                settingFile = new IniFiles(Application.StartupPath + "\\WOL\\WOL.ini");
                //string s = settingFile.ReadString("SETTING", "COM", "COM1");
                int count = settingFile.ReadInteger("SETTING", "COUNT", 0);
                lstWOL.Clear();
                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        string data = settingFile.ReadString("DATA", "W" + i, "");
                        if (!data.Equals(""))
                        {
                            string[] str = data.Split(',');
                            //byte[] byteArray = Encoding.Default.GetBytes(str[1]);
                            Model.WOL cmd = new Model.WOL(str[0], str[1], str[2]);
                            lstWOL.Add(cmd);
                            //Console.Write(data);
                        }
                    }

                }
            }
            catch
            {
            }
            MacTextBox.Text = FormHelper.GetValue("wolip");
        }

        private void Save_Inifile()
        {
            try
            {
                settingFile.WriteInteger("SETTING", "COUNT", lstWOL.Count);
                if (lstWOL.Count > 0)
                {
                    for (int i = 0; i < lstWOL.Count; i++)
                    {
                        string data = lstWOL[i].MAC + "," + lstWOL[i].NAME + "," + lstWOL[i].IP;
                        settingFile.WriteString("DATA", "W" + i, data);
                    }
                }
                else
                {
                    settingFile.EraseSection("DATA");
                }
            }
            catch
            { }
            FormHelper.SetValue("wolip", MacTextBox.Text);
        }
        private void WOLPanel_Load(object sender, EventArgs e)
        {
            
            //Load_Inifile();
        }

        public void WOL_Saved_default()
        {
            settingFile = new IniFiles(Application.StartupPath + "\\WOL\\WOL.ini");
            Save_Inifile();
        }
        #endregion
        /// <summary>
        /// 编辑修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Eidt_Click(object sender, EventArgs e)
        {
            if (dgWOL.SelectedRows.Count > 0)
            {
                frmAWOL fCmd = new frmAWOL(lstWOL[dgWOL.SelectedRows[0].Index]);
                if (fCmd.ShowDialog() == DialogResult.OK)
                {
                    //lstWOL.Add(fCmd.NewWOL);
                    lstWOL[dgWOL.SelectedRows[0].Index] = fCmd.NewWOL;
                }
            }
            else
            {
                if(LanguageSet.Language == "0")
                    MessageBox.Show("没有选中需要编辑的设备对象！", "提示");
                else
                    MessageBox.Show("Device object to be edited is not selected！", "Tips");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (lstWOL.Count <= 0 && dgWOL.SelectedRows.Count > 0)
            {
                MS_eidt.Enabled = false;
                MS_delete.Enabled = false;
                MS_wake.Enabled = false;
                //MS_Input.Enabled = false;
                MS_select.Enabled = false;
            }
            else
            {
                MS_eidt.Enabled = true;
                MS_delete.Enabled = true;
                MS_wake.Enabled = true;
                //.Enabled = true;
                MS_select.Enabled = true;
            }
        }

        bool all_select = false;
        private void MS_select_Click(object sender, EventArgs e)
        {
            try
            {
                dgWOL.EndEdit();
                if (all_select)
                {
                    for (int i = 0; i < dgWOL.Rows.Count; i++)
                    {
                        //Console.WriteLine(dgWOL.Rows[i].Cells[0].Value);
                        if ((Convert.ToBoolean(dgWOL.Rows[i].Cells[0].Value) == true))
                        {
                            dgWOL.Rows[i].Cells[0].Value = "False";
                        }
                        else
                            continue;
                    }
                    all_select = false;
                }
                else
                {
                    for (int i = 0; i < dgWOL.Rows.Count; i++)
                    {
                        if ((Convert.ToBoolean(dgWOL.Rows[i].Cells[0].Value) == false))
                        {
                            dgWOL.Rows[i].Cells[0].Value = "True";
                        }
                        else
                            continue;
                    }
                    all_select = true;
                }
                dgWOL.Refresh();
            }
            catch
            { }
        }

        private void dgWOL_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgWOL.IsCurrentCellDirty)
            {
                this.dgWOL.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
            Console.WriteLine(dgWOL.Rows[0].Cells[0].Value);
        }

        private void dgWOL_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                string macString = dgWOL.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (macString != "")
                {
                    MacTextBox.Text = macString;
                }
            }
        }
        
    }
}
