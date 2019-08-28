using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace LeafSoft.PartPanel
{
    public partial class ComMonitor : BasePanel
    {
        /// <summary>
        /// 串口通讯监视器
        /// </summary>
        public ComMonitor()
        {
            InitializeComponent();
            comSelect.Items.AddRange(SerialPort.GetPortNames());
            if (comSelect.Items.Count > 0)
            {
                comSelect.SelectedIndex = 0;
            }

        }

        bool fPause = false;
        bool fActive = false;
        long dwReadTotal = 0;
        long dwWriteTotal = 0;

        const int IRP_MJ_CREATE = 0x00;
        const int IRP_MJ_CLOSE = 0x02;
        const int IRP_MJ_READ = 0x03;
        const int IRP_MJ_WRITE = 0x04;
        const int IRP_MJ_DEVICE_CONTROL = 0x0E;
        const int IRP_MJ_CLEANUP = 0x12;
        const int IRP_MJ_MAXIMUM_FUNCTION = 0x1B;
        const int IRP_MJ_FLUSH_BUFFERS = 0x09;


        private void comStart_Click(object sender, EventArgs e)
        {
            if (!fActive)
                fActive = axCCommMonitorX1.StartMonitor("", this.comSelect.Text);
            else
            {
                axCCommMonitorX1.StopMonitor();
                fActive = false;
            }

            if (fActive)
            {
                comStart.Text = "Stop";
                comStart.ForeColor = Color.Blue;

            }
            else
            {
                comStart.Text = "Start";
                comStart.ForeColor = Color.Black;
            }
        }

        private void comPause_Click(object sender, EventArgs e)
        {
            if (axCCommMonitorX1.PauseMonitor(fPause))
                fPause = !fPause;

            if (fPause)
            {
                comPause.Text = "Continue";
                comPause.ForeColor = Color.Black;
            }
            else
            {
                comPause.Text = "Pause";
                comPause.ForeColor = Color.Blue;
            }
        }

        private void axCCommMonitorX1_OnAscii(object sender, AxCommMonitorX.ICommMonitorXEvents_OnAsciiEvent e)
        {
            if (chk_R.Checked)
                return;

            switch (e.dwCtrlCode)
            {
                case IRP_MJ_CLOSE:
                    this.redtData.AppendText(string.Format("{0}: Close\r\n", e.sPortName));
                    break;
                case IRP_MJ_CREATE:
                    this.redtData.AppendText(string.Format("{0}: Open\r\n", e.sPortName));
                    break;
                case IRP_MJ_READ:
                    {
                        dwReadTotal += e.dwSize;
                        this.redtData.SelectionColor = Color.Blue;
                        this.redtData.AppendText(string.Format("{0}, Read({1:D}): {2}\r\n", e.sPortName, e.dwSize, e.sData));
                        break;
                    }
                case IRP_MJ_WRITE:
                    {
                        dwWriteTotal += e.dwSize;
                        this.redtData.SelectionColor = Color.Green;
                        this.redtData.AppendText(string.Format("{0}, Write({1:D}): {2}\r\n", e.sPortName, e.dwSize, e.sData));
                        break;
                    }
                default:
                    {
                        if (e.dwCtrlCode > 0x400)
                            ctlData.AppendText(string.Format("{0}, CTLCode({1:D}): {2}\r\n", e.sPortName, e.dwCtrlCode, e.sData));
                        break;
                    }
            }

            if ((e.dwCtrlCode == IRP_MJ_READ) || (e.dwCtrlCode == IRP_MJ_WRITE))
            {
                lblTip.Text = string.Format("Write: {0:D}(Bytes), Read: {1:D}(Bytes)", dwWriteTotal, dwReadTotal);

            }
        }

        private void axCCommMonitorX1_OnMonitor(object sender, AxCommMonitorX.ICommMonitorXEvents_OnMonitorEvent e)
        {
            string ss = "";
            if (!chk_R.Checked)
                return;

            if ((e.dwSize > 0) && ((e.dwCtrlCode == IRP_MJ_READ) || (e.dwCtrlCode == IRP_MJ_WRITE)))
            {
                byte[] numbers = (byte[])e.vtData;
                ss = Encoding.GetEncoding("GB2312").GetString(numbers);
            }
            

            switch (e.dwCtrlCode)
            {
                case IRP_MJ_CLOSE:
                    this.redtData.AppendText(string.Format("{0}: Close\r\n", e.sPortName));
                    break;
                case IRP_MJ_CREATE:
                    this.redtData.AppendText(string.Format("{0}: Open\r\n", e.sPortName));
                    break;
                case IRP_MJ_READ:
                    {
                        dwReadTotal += e.dwSize;
                        this.redtData.SelectionColor = Color.Blue;
                        this.redtData.AppendText(string.Format("{0}, Read({1:D}): {2}\r\n",
                             e.sPortName, e.dwSize, ss));
                        break;
                    }
                case IRP_MJ_WRITE:
                    {
                        dwWriteTotal += e.dwSize;
                        this.redtData.SelectionColor = Color.Green;
                        this.redtData.AppendText(string.Format("{0}, Write({1:D}): {2}\r\n",
                            e.sPortName, e.dwSize, ss));
                        break;
                    }
                default:
                    {
                        if (e.dwCtrlCode > 0x400)
                            ctlData.AppendText(string.Format("{0}, CTLCode({1:D}): {2}\r\n",
                                e.sPortName, e.dwCtrlCode, ss));
                        break;
                    }
            }

            if ((e.dwCtrlCode == IRP_MJ_READ) || (e.dwCtrlCode == IRP_MJ_WRITE))
            {
                lblTip.Text = string.Format("Write: {0:D}(Bytes), Read: {1:D}(Bytes)",dwWriteTotal, dwReadTotal);

            }
        }

        private void textClear_Click(object sender, EventArgs e)
        {
            this.redtData.Clear();
            this.ctlData.Clear();
        }
    }
}
