using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using LeafSoft.Lib;
using System.Threading;
using System.IO;

namespace LeafSoft.Units
{
    public partial class DataSend : UserControl
    {
        BindingList<Model.CMD> lstCMD = new BindingList<Model.CMD>();
        private IniFiles settingFile;//配置文件
        //private string lan;
        public event LeafEvent.DataSendHandler EventDataSend;

        /// <summary>
        /// 是否在自动循环发送状态
        /// </summary>
        bool AutoSend = false;

        public DataSend()
        {
            InitializeComponent();

            settingFile = new IniFiles(Application.StartupPath + "\\IniFile\\setting.ini");
            dgCMD.AutoGenerateColumns = false;
            lstCMD.Add(new Model.CMD(EnumType.DataEncode.ASCII, new ASCIIEncoding().GetBytes("Test!")));
            dgCMD.DataSource = lstCMD;
            //byte[] data = new byte[] { 0xFF, 0xFD, 0x18, 0x0D };
            //lstCMD.Add(new Model.CMD(EnumType.DataEncode.Hex, data));
            
            if (LanguageSet.Language == "0")
            {
                LanguageSet.SetLang("", this, typeof(DataSend));
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("");
                ApplyResource();
            }
            else
            {

                LanguageSet.SetLang("en-US", this, typeof(DataSend));
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                ApplyResource();
            }
        }

        private void dgCMD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex>=0)
            {//点击了发送按钮 
                if (EventDataSend != null)
                {
                    if (EventDataSend(lstCMD[e.RowIndex].Bytes) == false)
                    {
                        StopAutoSend();
                    }
                    else
                    {
                        lblCount.Invoke(new MethodInvoker(delegate
                        {
                            lblCount.Text = (int.Parse(lblCount.Text) + lstCMD[e.RowIndex].Bytes.Length).ToString();
                        }));
                    }
                }
            }
        }

        private void dgCMD_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgCMD.Rows[e.RowIndex].Cells[3].Value = lstCMD[e.RowIndex].Tips;
            if (LanguageSet.Language == "0")
                dgCMD.Rows[e.RowIndex].Cells[4].Value = "发送";
            else
                dgCMD.Rows[e.RowIndex].Cells[4].Value = "send";
        }

        /// <summary>
        /// 添加调试命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_Add_Click(object sender, EventArgs e)
        {
            frmCMD fCmd = new frmCMD();
            if (fCmd.ShowDialog() == DialogResult.OK)
            {
                lstCMD.Add(fCmd.NewCMD);
            }
        }

        /// <summary>
        /// 编辑调试命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_Edit_Click(object sender, EventArgs e)
        {
            if (dgCMD.SelectedRows.Count > 0)
            {
                frmCMD fCmd = new frmCMD(lstCMD[dgCMD.SelectedRows[0].Index]);
                if (fCmd.ShowDialog() == DialogResult.OK)
                {
                    lstCMD[dgCMD.SelectedRows[0].Index] = fCmd.NewCMD;
                }
            }
        }

        /// <summary>
        /// 删除调试命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_Delete_Click(object sender, EventArgs e)
        {
            if (dgCMD.SelectedRows.Count > 0)
            {
                lstCMD.RemoveAt(dgCMD.SelectedRows[0].Index);
            }
        }

        private bool CheckAutoSend()
        {
            for (int i = 0; i < lstCMD.Count; i++)
            {
                object cbxValue = dgCMD.Rows[i].Cells[0].Value;
                if (cbxValue is bool && cbxValue.Equals(true))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 自动发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutoSend_Click(object sender, EventArgs e)
        {
            if (AutoSend == false)
            {
                if (LanguageSet.Language == "0")
                    btnAutoSend.Text = "停止循环";
                else
                    btnAutoSend.Text = "Stop loop";
                btnAutoSend.ForeColor = Color.Red;
                dgCMD.Enabled = false;
                nmDelay.Enabled = false;
                AutoSend = true;
                if (CheckAutoSend())
                {
                    Thread ThTestL = new Thread(new ParameterizedThreadStart(TAutoSend));
                    ThTestL.IsBackground = true;
                    ThTestL.Start(nmDelay.Value);
                }
                else
                {
                    if(LanguageSet.Language == "0")
                        MessageBox.Show("没有发送的指令选项!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("No command option sent!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    StopAutoSend();
                }
            }
            else
            {
                StopAutoSend();
            }
        }

        /// <summary>
        /// 自动发送命令线程
        /// </summary>
        private void TAutoSend(object Interval)
        {
            try
            {
                object sendlock = new object();
                int SendInterval = Convert.ToInt32(Interval);
                while (AutoSend)
                {
                    for (int i = 0; i < lstCMD.Count; i++)
                    {
                        if (AutoSend)
                        {
                            this.Invoke(new MethodInvoker(delegate
                            {
                                object cbxValue = dgCMD.Rows[i].Cells[0].Value;
                                if (cbxValue is bool && cbxValue.Equals(true))
                                {
                                    if (EventDataSend != null)
                                    {
                                        if (EventDataSend(lstCMD[i].Bytes) == false)
                                        {
                                            StopAutoSend();
                                        }
                                        else
                                        {
                                            lblCount.Invoke(new MethodInvoker(delegate
                                            {
                                                lblCount.Text = (int.Parse(lblCount.Text) + lstCMD[i].Bytes.Length).ToString();
                                            }));
                                        }
                                    }
                                }
                            }));
                            Thread.Sleep(SendInterval);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            catch { };
        }

        /// <summary>
        /// 停止循环发送
        /// </summary>
        private void StopAutoSend()
        {
            AutoSend = false;
            if (LanguageSet.Language == "0")
                btnAutoSend.Text = "循环发送";
            else
                btnAutoSend.Text = "Cyclic send";
            btnAutoSend.ForeColor = Color.Black;
            dgCMD.Enabled = true;
            nmDelay.Enabled = true;
        }

        private void lblCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblCount.Text = "0";
        }
        #region 编码处理
        private string SetType(EnumType.DataEncode EncodeType)
        {
            string ss = "";
            switch (EncodeType)
            {
                case EnumType.DataEncode.Hex:
                    ss = "H";
                    break;
                case EnumType.DataEncode.ASCII:
                    ss = "A";
                    break;
                case EnumType.DataEncode.UTF8:
                    ss = "U";
                    break;
                case EnumType.DataEncode.GB2312:
                    ss = "G";
                    break;
                default:
                    ss = "H";
                    break;
            }
            return ss;
        }

        private EnumType.DataEncode GetType(string key)
        {
            EnumType.DataEncode EncodeType = EnumType.DataEncode.Hex;
            switch (key)
            {
                case "H":
                    EncodeType = EnumType.DataEncode.Hex;
                    break;
                case "A":
                    EncodeType = EnumType.DataEncode.ASCII;
                    break;
                case "U":
                    EncodeType = EnumType.DataEncode.UTF8;
                    break;
                case "G":
                    EncodeType = EnumType.DataEncode.GB2312;
                    break;
                default:
                    EncodeType = EnumType.DataEncode.Hex;
                    break;
            }
            return EncodeType;
        }
        #endregion
        private void Load_Inifile(string key)
        {
            try
            {
                //string s = settingFile.ReadString("SETTING", "COM", "COM1");
                int count = settingFile.ReadInteger("SETTING", key + "COUNT", 0);
                lstCMD.Clear();
                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        string data = settingFile.ReadString(key + "DATA", "N" + i, "");
                        if (!data.Equals(""))
                        {
                            string[] str = data.Split(',');
                            EnumType.DataEncode Type = GetType(str[0]);
                            //byte[] byteArray = Encoding.Default.GetBytes(str[1]);
                            Model.CMD cmd = new Model.CMD(Type, str[1]);
                            cmd.Tips = str[2];
                            lstCMD.Add(cmd);
                            //Console.Write(data);
                        }
                    }

                }
            }
            catch
            {

            }
        }

        private void Save_Inifile(string key)
        {
            try
            {
                settingFile.WriteInteger("SETTING", key + "COUNT", lstCMD.Count);
                if (lstCMD.Count > 0)
                {
                    for (int i = 0; i < lstCMD.Count; i++)
                    {
                        string type = SetType(lstCMD[i].ContentType);
                        string cmd = lstCMD[i].Text + "," + lstCMD[i].Tips;
                        string data = type + "," + cmd ;
                        settingFile.WriteString(key + "DATA", "N" + i, data);
                    }
                }
                else
                {
                    settingFile.EraseSection(key + "DATA");
                }
            }
            catch(Exception x)
            {
                LogHelper.WriteLog(x.Message);
                //Console.WriteLine(x.Message);
            }
            
        }

        private void DataSend_Load(object sender, EventArgs e)
        {
            settingFile = new IniFiles(Application.StartupPath + "\\IniFile\\setting.ini");
            string tab =  this.Parent.Name;
            //Console.WriteLine(tab);
            if (tab == "comPanel3" || tab == "ComPanel")
                Load_Inifile("COM");
            else if(tab == "tcpServerPanel3" || tab == "TCPServerPanel")
                Load_Inifile("TCPS");
            else if (tab == "tcpClientPanel3" || tab == "TCPClientPanel")
                Load_Inifile("TCPC");
            else if (tab == "udpClientPanel3" || tab == "UDPClientPanel" || tab == "udpServerPanel3" || tab == "UDPServerPanel")
                Load_Inifile("UDP");
            else
                Load_Inifile("COM");
            FormHelper.LoadFormParam(nmDelay);
        }

        private void ApplyResource()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSend));
            foreach (Control ctl in this.Controls)
            {
                resources.ApplyResources(ctl, ctl.Name);
            }
            foreach (Control ctl in contextMenuStrip1.Controls)
            {
                resources.ApplyResources(ctl, ctl.Name);
            }
            resources.ApplyResources(MS_Add, MS_Add.Name);
            resources.ApplyResources(MS_Edit, MS_Edit.Name);
            resources.ApplyResources(MS_Delete, MS_Delete.Name);
            resources.ApplyResources(MS_Select, MS_Select.Name);
            resources.ApplyResources(MS_Saved, MS_Saved.Name); 
            resources.ApplyResources(MS_Input, MS_Input.Name);
            resources.ApplyResources(MS_SaveAs, MS_SaveAs.Name);
            resources.ApplyResources(IsAutoSend, IsAutoSend.Name);
            resources.ApplyResources(CType, CType.Name);
            resources.ApplyResources(CMDText, CMDText.Name);
            resources.ApplyResources(CMDTips, CMDTips.Name);
            resources.ApplyResources(btnSend, btnSend.Name);
        }

        public void CMD_Saved_default()
        {
            settingFile = new IniFiles(Application.StartupPath + "\\IniFile\\setting.ini");
            string tab = this.Parent.Name;
            if (tab == "comPanel3" || tab == "ComPanel")
                Save_Inifile("COM");
            else if (tab == "tcpServerPanel3" || tab == "TCPServerPanel")
                Save_Inifile("TCPS");
            else if (tab == "tcpClientPanel3" || tab == "TCPClientPanel")
                Save_Inifile("TCPC");
            else if (tab == "udpClientPanel3" || tab == "UDPClientPanel")
                Save_Inifile("UDP");
            else
                Save_Inifile("COM");
            FormHelper.SetFormParam(nmDelay);
        }
        /// <summary>
        /// 默认保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_Saved_Click(object sender, EventArgs e)
        {
            CMD_Saved_default();
        }
        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_Input_Click(object sender, EventArgs e)
        {
            openFileRead.InitialDirectory = Application.StartupPath + "\\IniFile";
            openFileRead.Filter = "命令文件|*.ini";
            openFileRead.FilterIndex = 1;
            openFileRead.RestoreDirectory = true;
            if (openFileRead.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileRead.FileName;
                //Console.WriteLine(filename);
                settingFile = new IniFiles(filename);
                string tab = this.Parent.Name;
                if (tab == "comPanel3" || tab == "ComPanel")
                    Load_Inifile("COM");
                else if (tab == "tcpServerPanel3" || tab == "TCPServerPanel")
                    Load_Inifile("TCPS");
                else if (tab == "tcpClientPanel3" || tab == "TCPClientPanel")
                    Load_Inifile("TCPC");
                else if (tab == "udpClientPanel3" || tab == "UDPClientPanel")
                    Load_Inifile("UDP");
                else
                    Load_Inifile("COM");
            }
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_SaveAs_Click(object sender, EventArgs e)
        {
            saveFileInit.InitialDirectory = Application.StartupPath + "\\IniFile";
            saveFileInit.Filter = "命令文件|*.ini";
            saveFileInit.FilterIndex = 1;
            saveFileInit.RestoreDirectory = true;
            saveFileInit.AddExtension = true;
            if (saveFileInit.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileInit.FileName;
                //Console.WriteLine(filename);
                settingFile = new IniFiles(filename);
                string tab = this.Parent.Name;
                if (tab == "comPanel3" || tab == "ComPanel")
                    Save_Inifile("COM");
                else if (tab == "tcpServerPanel3" || tab == "TCPServerPanel")
                    Save_Inifile("TCPS");
                else if (tab == "tcpClientPanel3" || tab == "TCPClientPanel")
                    Save_Inifile("TCPC");
                else if (tab == "udpClientPanel3" || tab == "UDPClientPanel")
                    Save_Inifile("UDP");
                else
                    Save_Inifile("COM");
            }
            //settingFile = new IniFiles(Application.StartupPath + "\\IniFile\\setting.ini");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(lstCMD.Count <= 0 && dgCMD.SelectedRows.Count <= 0)
            {
                MS_Edit.Enabled = false;
                MS_Delete.Enabled = false;
                MS_Saved.Enabled = false;
                MS_Select.Enabled = false;
                //MS_Input.Enabled = false;
                MS_SaveAs.Enabled = false;
            }
            else
            {
                MS_Edit.Enabled = true;
                MS_Delete.Enabled = true;
                MS_Saved.Enabled = true;
                MS_Select.Enabled = true;
                //.Enabled = true;
                MS_SaveAs.Enabled = true;
            }
        }
        /*
        private void dgCMD_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.toolTip1.Hide(this.dgCMD);//鼠标移出单元格后隐藏提示工具     
        }

        private int cellColumnIndex = -1;//列索引
        private int cellRowIndex = -1;//行索引
        private void dgCMD_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //判断选择单元格的有效性
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            this.toolTip1.Hide(this.dgCMD);
            this.cellColumnIndex = e.ColumnIndex;//获取列索引
            this.cellRowIndex = e.RowIndex;//获取行索引

            if (this.cellColumnIndex >= 0 && this.cellRowIndex >= 0)
            {
                Point mousePos = PointToClient(MousePosition);//获取鼠标当前的位置
                //获取鼠标移入的单元格中的值
                string tip = this.dgCMD[2, this.cellRowIndex].Value.ToString();
                this.toolTip1.Show(tip, this.dgCMD, mousePos);//在指定位置显示提示工具
                Console.WriteLine(tip);
            }
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.AliceBlue, e.Bounds);
            e.Graphics.DrawRectangle(Pens.Chocolate, new Rectangle(0, 0, e.Bounds.Width - 1, e.Bounds.Height - 1));
            e.Graphics.DrawString(this.toolTip1.ToolTipTitle + e.ToolTipText, e.Font, Brushes.Red, e.Bounds);
        }
        */
        /// <summary>
        /// 提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgCMD_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && lstCMD.Count > 0)
            {
                e.ToolTipText = "tips：" + lstCMD[e.RowIndex].Tips;
            }
        }

        private void nmDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt32(e.KeyChar);
            if (!(48 <= key && key <= 58 || key == 8)) //数字、 Backspace
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        bool all_select = false;
        private void MS_Select_Click(object sender, EventArgs e)
        {
            if (all_select)
            {
                for (int i = 0; i < dgCMD.Rows.Count; i++)
                {
                    if ((Convert.ToBoolean(dgCMD.Rows[i].Cells[0].Value) == true))
                    {
                        dgCMD.Rows[i].Cells[0].Value = "False";
                    }
                    else
                        continue;
                }
                all_select = false;
            }
            else
            {
                for (int i = 0; i < dgCMD.Rows.Count; i++)
                {
                    if ((Convert.ToBoolean(dgCMD.Rows[i].Cells[0].Value) == false))
                    {
                        dgCMD.Rows[i].Cells[0].Value = "True";
                    }
                    else
                        continue;
                }
                all_select = true;
            }
            dgCMD.Refresh();
        }
    }
}
