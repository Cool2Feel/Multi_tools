using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using LeafSoft.Model;
using System.Net;
using System.Net.Sockets;
using LeafSoft.Lib;

namespace LeafSoft.Units
{
    public partial class NetTCPClient :UserControl, ICommunication
    {
        /// <summary>
        /// 当前已连接客户端集合
        /// </summary>
        public BindingList<LeafTCPClient> lstClient = new BindingList<LeafTCPClient>();

        public event Lib.LeafEvent.DataReceivedHandler DataReceived;
        
        public NetTCPClient()
        {
            InitializeComponent();
            if (LanguageSet.Language == "0")
            {
                LanguageSet.SetLang("", this, typeof(NetTCPClient));
            }
            else
            {
                LanguageSet.SetLang("en-US", this, typeof(NetTCPClient));
            }
            if (this.DesignMode == false)
            {
                IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in ipHostEntry.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {//筛选IPV4
                        txtServerIP.Text = ip.ToString();
                    }
                }
            }
        }
        
        /// <summary>
        /// 绑定客户端列表
        /// </summary>
        private void BindLstClient()
        {
            lstConn.Invoke(new MethodInvoker(delegate
            {
                lstConn.DataSource = null;
                lstConn.DataSource = lstClient;
                lstConn.DisplayMember = "Name";
            }));
        }

        /// <summary>
        /// 连接新的服务端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConn_Click(object sender, EventArgs e)
        {
            LeafTCPClient client = new LeafTCPClient();
            try
            {
                client.NetWork= new TcpClient();
                client.NetWork.Connect(txtServerIP.Text.Trim(), (int)nmServerPort.Value);//连接服务端
                client.SetName();
                client.NetWork.GetStream().BeginRead(client.buffer, 0, client.buffer.Length, new AsyncCallback(TCPCallBack), client);
                lstClient.Add(client);
                BindLstClient();

                LogHelper.WriteLog("TCP Client Connect: " + txtServerIP.Text);
            }
            catch (Exception ex)
            {
                client.DisConnect();
                if(LanguageSet.Language == "0")
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 回调函数
        /// </summary>
        /// <param name="ar"></param>
        private void TCPCallBack(IAsyncResult ar)
        {
            LeafTCPClient client = (LeafTCPClient)ar.AsyncState;
            if (client.NetWork.Connected)
            {
                NetworkStream ns = client.NetWork.GetStream();
                try
                {
                    byte[] recdata = new byte[ns.EndRead(ar)];
                    Array.Copy(client.buffer, recdata, recdata.Length);
                    if (recdata.Length > 0)
                    {
                        if (DataReceived != null)
                        {
                            DataReceived.BeginInvoke(client.Name, recdata, null, null);//异步输出数据
                        }
                        LogHelper.WriteLog("TCP Client Received: " + Encoding.Default.GetString(recdata));
                        ns.BeginRead(client.buffer, 0, client.buffer.Length, new AsyncCallback(TCPCallBack), client);
                    }
                    else
                    {
                        client.DisConnect();
                        lstClient.Remove(client);
                        BindLstClient();
                    }
                }
                catch (Exception ex)
                {
                    if (LanguageSet.Language == "0")
                        MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    client.DisConnect();
                    lstClient.Remove(client);
                    BindLstClient();
                }
            }
        }


        public bool SendData(byte[] data)
        {
            if (lstConn.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lstConn.SelectedItems.Count; i++)
                {
                    LeafTCPClient selClient = (LeafTCPClient)lstConn.SelectedItems[i];
                    try
                    {
                        selClient.NetWork.GetStream().Write(data, 0, data.Length);

                        LogHelper.WriteLog("TCP Client Send data: " + Encoding.Default.GetString(data));
                    }
                    catch (Exception ex)
                    {
                        if (LanguageSet.Language == "0")
                            MessageBox.Show(selClient.Name + ":" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show(selClient.Name + ":" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return true;
            }
            else
            {
                if (LanguageSet.Language == "0")
                    MessageBox.Show("无可用连接", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("No connection available", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void MS_Delete_Click(object sender, EventArgs e)
        {
            if (lstConn.SelectedItems.Count > 0)
            {
                List<LeafTCPClient> WaitRemove = new List<LeafTCPClient>();
                for (int i = 0; i < lstConn.SelectedItems.Count; i++)
                {
                    WaitRemove.Add((LeafTCPClient)lstConn.SelectedItems[i]);
                }
                foreach (LeafTCPClient client in WaitRemove)
                {
                    client.DisConnect();
                    lstClient.Remove(client);
                }
            }
        }

        /// <summary>
        /// 关闭所有连接
        /// </summary>
        public void ClearSelf()
        {
            foreach (LeafTCPClient client in lstClient)
            {
                client.DisConnect();
            }
            lstClient.Clear();
            BindLstClient();
        }

        private void MS_Clearn_Click(object sender, EventArgs e)
        {
            if (lstConn.Items.Count > 0)
            {
                List<LeafTCPClient> WaitRemove = new List<LeafTCPClient>();
                for (int i = 0; i < lstConn.Items.Count; i++)
                {
                    WaitRemove.Add((LeafTCPClient)lstConn.Items[i]);
                }
                foreach (LeafTCPClient client in WaitRemove)
                {
                    client.DisConnect();
                    lstClient.Remove(client);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (lstConn.Items.Count > 0)
            {
                MS_Delete.Enabled = true;
                MS_Clearn.Enabled = true;
            }
            else
            {
                MS_Delete.Enabled = false;
                MS_Clearn.Enabled = false;
            }
        }
    }
}
