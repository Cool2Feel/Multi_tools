using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Net;
using LeafSoft.Model;
using System.Net.Sockets;
using LeafSoft.Lib;

namespace LeafSoft.Units
{
    public partial class NetUDPClient: UserControl, ICommunication
    {
        BindingList<LeafUDPClient> lstClient = new BindingList<LeafUDPClient>();

        public event Lib.LeafEvent.DataReceivedHandler DataReceived;
        //private string lan;
        //private IniFiles settingFile;//配置文件
        public NetUDPClient()
        {
            InitializeComponent();
            //settingFile = new IniFiles(Application.StartupPath + "\\IniFile\\setting.ini");
            //lan = settingFile.ReadString("SETTING", "Language", "1");
            if (LanguageSet.Language == "0")
            {
                LanguageSet.SetLang("", this, typeof(NetUDPClient));
            }
            else
            {
                LanguageSet.SetLang("en-US", this, typeof(NetUDPClient));
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

        private void MS_Delete_Click(object sender, EventArgs e)
        {
            if (lstConn.SelectedItems.Count > 0)
            {
                List<LeafUDPClient> WaitRemove = new List<LeafUDPClient>();
                for (int i = 0; i < lstConn.SelectedItems.Count; i++)
                {
                    WaitRemove.Add((LeafUDPClient)lstConn.SelectedItems[i]);
                }
                foreach (LeafUDPClient client in WaitRemove)
                {
                    client.NetWork.Close();
                    lstClient.Remove(client);
                }
            }
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            try
            {
                LeafUDPClient client = new LeafUDPClient();
                client.NetWork = new UdpClient();
                client.NetWork.Connect(txtServerIP.Text.Trim(), (int)nmServerPort.Value);
                client.ipLocalEndPoint = (IPEndPoint)client.NetWork.Client.LocalEndPoint;
                client.Name = client.ipLocalEndPoint.Port + "->" + client.NetWork.Client.RemoteEndPoint.ToString();
                client.NetWork.BeginReceive(new AsyncCallback(ReceiveCallback), client);//继续异步接收数据
                lstClient.Add(client);
                BindLstClient();

                LogHelper.WriteLog("UDP Add Connect: " + txtServerIP.Text);
            }
            catch (Exception ex)
            {
                if (LanguageSet.Language == "0")
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 接收到数据
        /// </summary>
        /// <param name="ar"></param>
        public void ReceiveCallback(IAsyncResult ar)
        {
            LeafUDPClient uclient = (LeafUDPClient)ar.AsyncState;
            try
            {
                if (uclient.NetWork.Client != null && uclient.NetWork.Client.Connected)
                {
                    IPEndPoint fclient = uclient.ipLocalEndPoint;
                    Byte[] recdata = uclient.NetWork.EndReceive(ar, ref fclient);
                    string ConnName = uclient.ipLocalEndPoint.Port + "->" + fclient.ToString();
                    if (DataReceived != null)
                    {
                        DataReceived.BeginInvoke(ConnName, recdata, null, null);//异步输出数据

                        LogHelper.WriteLog("UDP Receive Date: " + Encoding.Default.GetString(recdata));
                    }
                    uclient.NetWork.BeginReceive(new AsyncCallback(ReceiveCallback), uclient);//继续异步接收数据
                }
            }
            catch (Exception ex)
            {
                if (LanguageSet.Language == "0")
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool SendData(byte[] data)
        {
            if (lstConn.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lstConn.SelectedItems.Count; i++)
                {
                    try
                    {
                        LeafUDPClient client = (LeafUDPClient)lstConn.SelectedItems[i];
                        client.NetWork.Send(data, data.Length);

                        LogHelper.WriteLog("UDP Send Date: " + Encoding.Default.GetString(data));
                    }
                    catch (Exception ex)
                    {
                        if (LanguageSet.Language == "0")
                            MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return true;
            }
            else
            {
                if (LanguageSet.Language == "0")
                    MessageBox.Show("无可用客户端", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("No client available", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// 清理
        /// </summary>
        public void ClearSelf()
        {
            foreach (LeafUDPClient client in lstClient)
            {
                client.Close();
            }
            lstClient.Clear();
        }

        private void MS_Clearn_Click(object sender, EventArgs e)
        {
            if (lstConn.Items.Count > 0)
            {
                List<LeafUDPClient> WaitRemove = new List<LeafUDPClient>();
                for (int i = 0; i < lstConn.Items.Count; i++)
                {
                    WaitRemove.Add((LeafUDPClient)lstConn.Items[i]);
                }
                foreach (LeafUDPClient client in WaitRemove)
                {
                    client.NetWork.Close();
                    lstClient.Remove(client);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(lstConn.Items.Count > 0)
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
