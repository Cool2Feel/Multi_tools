using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft.PartPanel
{
    public partial class UDPServerPanel : BasePanel
    {
        public UDPServerPanel()
        {
            InitializeComponent();
        }

        private bool DataSender_EventDataSend(byte[] data)
        {
            return Configer.SendData(data);
        }

        private void Configer_DataReceived(object sender, byte[] data)
        {
            tabDataReceiver.AddData(sender.ToString(), data);
        }

        public override void ClearSelf()
        {
            Configer.ClearSelf();
        }
    }
}
