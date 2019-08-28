using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Net;
using LeafSoft.Lib;

namespace LeafSoft.PartPanel
{
    public partial class SocketMonitor : BasePanel
    {
        Lib.SnifferSocket sniffer = new Lib.SnifferSocket();
        BindingList<Model.IPPacket> lstRecPacket = new BindingList<Model.IPPacket>();

        /// <summary>
        /// Socket通讯监视器
        /// </summary>
        public SocketMonitor()
        {
            InitializeComponent();
            if (LanguageSet.Language == "0")
            {
                Console.WriteLine("0000");
                LanguageSet.SetLang("", this, typeof(SocketMonitor));
            }
            else
            {
                LanguageSet.SetLang("en-US", this, typeof(SocketMonitor));
                Console.WriteLine("1111");
            }
            //cbxProtocol.SelectedIndex = 0;
            IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in ipHostEntry.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {//筛选IPV4
                    cbxServerIP.Items.Add(ip.ToString());
                }
            }
            if(cbxServerIP.Items.Count > 0)
            {
                cbxServerIP.SelectedIndex = 0;
                btnMonitor.Enabled = true;
            }
            dgPacket.AutoGenerateColumns = false;
            dgPacket.DataSource = lstRecPacket;
            sniffer.RecPacket += new Lib.LeafEvent.PacketReceived(sniffer_RecPacket);

            cbxProtocol.SelectedIndex = 0;
        }

        void sniffer_RecPacket(Model.IPPacket packet)
        {
            dgPacket.Invoke(new MethodInvoker(delegate
            {
                lstRecPacket.Insert(0,packet);
            }));
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            if (sniffer.IsMonitor == false)
            {
                if (sniffer.Start(cbxServerIP.SelectedItem.ToString()))
                {
                    btnMonitor.Text = "停止";
                }
            }
            else
            {
                sniffer.Stop();
                btnMonitor.Text = "监视";
            }
        }

        private void dgPacket_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPacket.SelectedRows.Count > 0)
            {
                Model.IPPacket packet = lstRecPacket[dgPacket.SelectedRows[0].Index];
                string strCMD = "";
                foreach (byte b in packet.ReceiveBuffer)
                {
                    strCMD += string.Format("{0:X2} ", b);
                }
                //strCMD = packet.RecTime +"]: "+ strCMD;
                txtData.Text = strCMD;
                //strCMD += packet.Protocol + "\n";
                //strCMD += packet.RecTime + "\n";
                //strCMD += Encoding.ASCII.GetString(packet.ReceiveBuffer) + "\n";
                //Console.WriteLine(strCMD);
            }
        }

        public override void ClearSelf()
        {
            sniffer.Close();
        }

        #region 筛选条件变更
        /// <summary>
        /// 协议类型变更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProtocol.SelectedIndex == 0)
            {
                sniffer.Protocol = "";
            }
            else
            {
                sniffer.Protocol = cbxProtocol.SelectedItem.ToString();
            }
        }
        private void nmSourcePort_ValueChanged(object sender, EventArgs e)
        {
            sniffer.SourcePort = (int)nmSourcePort.Value;
        }

        private void nmTargetPort_ValueChanged(object sender, EventArgs e)
        {
            sniffer.TargetPort = (int)nmTargetPort.Value;
        }
        #endregion

        private void MS_Clear_Click(object sender, EventArgs e)
        {
            lstRecPacket.Clear();
        }

        private void SocketMonitor_Load(object sender, EventArgs e)
        {
            FormHelper.LoadFormParam(this);
        }
    }
}
