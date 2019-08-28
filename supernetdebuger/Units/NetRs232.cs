using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using LeafSoft.Lib;
using System.Linq;

namespace LeafSoft.Units
{
    public partial class NetRs232 :UserControl, ICommunication
    {
        private SerialPort ComDevice = new SerialPort();

        private IniFiles settingFile;//配置文件
        public NetRs232()
        {
            InitializeComponent();
            settingFile = new IniFiles(Application.StartupPath + "\\IniFile\\setting.ini");
            if (LanguageSet.Language == "0")
            {
                LanguageSet.SetLang("", this, typeof(NetRs232));
            }
            else
            {
                LanguageSet.SetLang("en-US", this, typeof(NetRs232));
            }
            drpComList.Items.Clear();
            drpComList.Items.AddRange(SerialPort.GetPortNames().Distinct().ToArray());
            if (drpComList.Items.Count > 0)
            {
                drpComList.SelectedIndex = 0;
                btnCom.Enabled = true;
            }
            drpBaudRate.SelectedIndex = 5;
            drpParity.SelectedIndex = 0;
            drpDataBits.SelectedIndex = 0;
            drpStopBits.SelectedIndex = 0;
            ComDevice.DataReceived+=new SerialDataReceivedEventHandler(Com_DataReceived);
        }
        
        /*
        // 系统消息常量
        public const int WM_DEVICE_CHANGE = 0x219;             //设备改变           
        public const int DBT_DEVICEARRIVAL = 0x8000;          //设备插入
        public const int DBT_DEVICE_REMOVE_COMPLETE = 0x8004; //设备移除
        /// <summary>
        /// 串口插拔的消息处理
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_DEVICE_CHANGE)        // 捕获USB设备的拔出消息WM_DEVICECHANGE
            {
                switch (m.WParam.ToInt32())
                {
                    case DBT_DEVICE_REMOVE_COMPLETE:    // USB拔出      
                        {
                            if (ComDevice.IsOpen)
                            {
                                bool com = false;
                                String[] serialPorts = System.IO.Ports.SerialPort.GetPortNames();
                                for (int i = 0; i < serialPorts.Length; i++)//找出所有串口，并选择文件中的
                                {
                                    if (serialPorts[i].Equals(ComDevice.PortName))
                                        com = true;
                                    //Console.WriteLine(serialPorts[i]);
                                }
                                if (!com)
                                {
                                    drpComList.Items.Clear();
                                    drpComList.Items.AddRange(SerialPort.GetPortNames());
                                    if (drpComList.Items.Count > 0)
                                    {
                                        drpComList.SelectedIndex = 0;
                                        //btnCom.Enabled = true;
                                    }
                                    MessageBox.Show("串口已拔出！", "Tips");
                                }
                            }
                        }
                        break;
                    case DBT_DEVICEARRIVAL:             // USB插入获取对应串口名称
                        {
                            drpComList.Items.Clear();
                            drpComList.Items.AddRange(SerialPort.GetPortNames());
                            if (drpComList.Items.Count > 0)
                            {
                                drpComList.SelectedIndex = 0;
                                //btnCom.Enabled = true;
                            }
                        }
                        break;
                }
            }
            base.WndProc(ref m);
        }
        */

        /// <summary>
        /// 输出数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[ComDevice.BytesToRead];
            ComDevice.Read(ReDatas, 0, ReDatas.Length);//读取数据
            DataReceived(this,ReDatas);//输出数据

            LogHelper.WriteLog("串口 DataReceived：" + Encoding.Default.GetString(ReDatas));

            ExceptionLog.getLog().WriteLogFile(ReDatas, DateTime.Now.ToString("yyyyMMdd") + "log.txt");
        }

        /// <summary>
        /// 串口打开/关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCom_Click(object sender, EventArgs e)
        {
            if (ComDevice.IsOpen==false)
            {
                if (string.IsNullOrEmpty(drpComList.Text))
                {
                    if (LanguageSet.Language == "0")
                        MessageBox.Show("串口没有选中或不存在,无法打开！", "提示");
                    else
                        MessageBox.Show("The serial port is not selected or does not exist and cannot be opened！", "Tips");
                    return;
                }

                ComDevice.PortName = drpComList.SelectedItem.ToString();
                ComDevice.BaudRate = Convert.ToInt32(drpBaudRate.SelectedItem.ToString());
                ComDevice.Parity = (Parity)Convert.ToInt32(drpParity.SelectedIndex.ToString());
                ComDevice.DataBits = Convert.ToInt32(drpDataBits.SelectedItem.ToString());
                ComDevice.StopBits = (StopBits)Convert.ToInt32(drpStopBits.SelectedItem.ToString());
                try
                {
                    if (!string.IsNullOrEmpty(ComDevice.PortName))
                        ComDevice.Open();
                    else
                    {
                        if (LanguageSet.Language == "0")
                            MessageBox.Show("串口无法打开！", "提示");
                        else
                            MessageBox.Show("Serial port cannot be opened！", "Tips");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    if (LanguageSet.Language == "0")
                        MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LogHelper.WriteLog(btnCom.Text);
                if (LanguageSet.Language == "0")
                    btnCom.Text = "关闭串口";
                else
                    btnCom.Text = "Close";
                picComStatus.BackgroundImage = Properties.Resources.greenlight;
            }
            else
            {
                try
                {
                    ComDevice.Close();
                }
                catch (Exception ex)
                {
                    if (LanguageSet.Language == "0")
                        MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LogHelper.WriteLog(btnCom.Text);
                if (LanguageSet.Language == "0")
                    btnCom.Text = "打开串口";
                else
                    btnCom.Text = "Open";
                picComStatus.BackgroundImage = Properties.Resources.redlight;
            }

            drpComList.Enabled = !ComDevice.IsOpen;
            drpBaudRate.Enabled = !ComDevice.IsOpen;
            drpParity.Enabled = !ComDevice.IsOpen;
            drpDataBits.Enabled = !ComDevice.IsOpen;
            drpStopBits.Enabled = !ComDevice.IsOpen;
        }

        public event LeafEvent.DataReceivedHandler DataReceived;
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        public bool SendData(byte[] data)
        {
            if (ComDevice.IsOpen)
            {
                try
                {
                    ComDevice.Write(data, 0, data.Length);//发送数据

                    LogHelper.WriteLog("串口 Send Data:" + data);
                    return true;
                }
                catch (Exception ex)
                {
                    if (LanguageSet.Language == "0")
                        MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (LanguageSet.Language == "0")
                    MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Serial port is not open", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        /// <summary>
        /// 关闭串口
        /// </summary>
        public void ClearSelf()
        {
            if (ComDevice.IsOpen)
            {
                ComDevice.Close();
            }
        }
        public void ChangePort()
        {
            drpComList.Items.Clear();
            drpComList.Items.AddRange(SerialPort.GetPortNames().Distinct().ToArray());
            if (drpComList.Items.Count > 0)
            {
                drpComList.SelectedIndex = 0;
                //btnCom.Enabled = true;
            }
        }

        public void Init_ConfigCom()
        {
            string s = settingFile.ReadString("SETTING", "COM", "COM1");
            drpComList.SelectedIndex = drpComList.Items.IndexOf(s);
            if (drpComList.Items.IndexOf(s) == -1 && drpComList.Items.Count > 0)
                drpComList.SelectedIndex = 0;
            s = settingFile.ReadString("SETTING", "Baud", "9600");
            drpBaudRate.SelectedIndex = drpBaudRate.Items.IndexOf(s);
            s = settingFile.ReadString("SETTING", "Parity", "None");
            drpParity.SelectedIndex = drpParity.Items.IndexOf(s);
            s = settingFile.ReadString("SETTING", "Data", "8");
            drpDataBits.SelectedIndex = drpDataBits.Items.IndexOf(s);
            s = settingFile.ReadString("SETTING", "Stop", "1");
            drpStopBits.SelectedIndex = drpStopBits.Items.IndexOf(s);
        }

        public void Save_ConfigCom()
        {
            settingFile.WriteString("SETTING", "COM", drpComList.Text);
            settingFile.WriteString("SETTING", "Baud", drpBaudRate.Text);
            settingFile.WriteString("SETTING", "Parity", drpParity.Text);
            settingFile.WriteString("SETTING", "Data", drpDataBits.Text);
            settingFile.WriteString("SETTING", "Stop", drpStopBits.Text);
        }

        private void drpComList_Click(object sender, EventArgs e)
        {
            ChangePort();
            //Console.WriteLine(drpComList.Items.Count);
        }
    }
}
