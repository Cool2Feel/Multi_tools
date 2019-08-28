using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using LeafSoft.Model;
using LeafSoft.Lib;

namespace LeafSoft.Units
{
    public partial class NetUDPServer :UserControl, ICommunication
    {
        /// <summary>
        /// UDP服务端监听
        /// </summary>
        LeafUDPClient udpserver = new LeafUDPClient();

        BindingList<string> lstClient = new BindingList<string>();

        public event Lib.LeafEvent.DataReceivedHandler DataReceived;

        //private IniFiles settingFile;//配置文件
        /// <summary>
        /// 监听状态
        /// </summary>
        bool isListen = false;

        /// <summary>
        /// TCP服务端
        /// </summary>
        public NetUDPServer()
        {
            InitializeComponent();
            if (LanguageSet.Language == "0")
            {
                LanguageSet.SetLang("", this, typeof(NetUDPServer));
            }
            else
            {
                LanguageSet.SetLang("en-US", this, typeof(NetUDPServer));
            }
            //cbxLocalIP.SelectedIndex = 0;
            if (this.DesignMode == false)
            {
                cbxLocalIP.Items.Clear();
                IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in ipHostEntry.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {//筛选IPV4
                        cbxLocalIP.Items.Add(ip.ToString());
                    }
                }
            }
            if(cbxLocalIP.Items.Count > 0)
                cbxLocalIP.SelectedIndex = 0;
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
            }));
        }

        /// <summary>
        /// TCP/UDP监听开启/停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListen_Click(object sender, EventArgs e)
        {
            if (isListen == false)
            {//监听已停止
                StartUDPServer();
            }
            else
            {//监听已开启
                StopUDPServer();
            }
            cbxLocalIP.Enabled = !isListen;
            nmLocalPort.Enabled = !isListen;
            if (isListen)
            {
                if (LanguageSet.Language == "0")
                    btnListen.Text = "停止";
                else
                    btnListen.Text = "Stop";
            }
            else
            {
                if (LanguageSet.Language == "0")
                    btnListen.Text = "监听";
                else
                    btnListen.Text = "Listen";
            }
        }
       
        /// <summary>
        /// 开启UDP监听
        /// </summary>
        /// <returns></returns>
        private void StartUDPServer()
        {
            try
            {
                IPEndPoint ipLocalEndPoint;
                if (cbxLocalIP.SelectedIndex == 0)
                {
                    ipLocalEndPoint = new IPEndPoint(IPAddress.Any, (int)nmLocalPort.Value);
                }
                else
                {
                    ipLocalEndPoint = new IPEndPoint(IPAddress.Parse(cbxLocalIP.SelectedItem.ToString()), (int)nmLocalPort.Value);
                }
                udpserver.NetWork = new UdpClient(ipLocalEndPoint);
                udpserver.ipLocalEndPoint = ipLocalEndPoint;
                udpserver.NetWork.BeginReceive(new AsyncCallback(ReceiveCallback), udpserver);
                isListen = true;
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
        /// 停止UDP监听
        /// </summary>
        /// <returns></returns>
        private void StopUDPServer()
        {
            udpserver.NetWork.Close();
            lstClient.Clear();
            isListen = false;
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        public bool SendData(byte[] data)
        {
            if (lstConn.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lstConn.SelectedItems.Count; i++)
                {
                    string[] ClientInfor = lstConn.SelectedItems[i].ToString().Split('>');
                    string[] IPAddress=ClientInfor[1].Split(':');
                    try
                    {
                        udpserver.NetWork.Send(data, data.Length, IPAddress[0], int.Parse(IPAddress[1]));
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
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_Delete_Click(object sender, EventArgs e)
        {
            if (lstConn.SelectedItems.Count > 0)
            {
                List<string> WaitRemove = new List<string>();
                for (int i = 0; i < lstConn.SelectedItems.Count; i++)
                {
                    WaitRemove.Add((string)lstConn.SelectedItems[i]);
                }
                foreach (string client in WaitRemove)
                {
                    lstClient.Remove(client);
                }
                BindLstClient();
            }
        }

        /// <summary>
        /// 接收到数据
        /// </summary>
        /// <param name="ar"></param>
        public void ReceiveCallback(IAsyncResult ar)
        {
            LeafUDPClient userver = (LeafUDPClient)ar.AsyncState;
            string ConnName = "";
            try
            {
                if (userver.NetWork.Client != null)
                {
                    IPEndPoint fclient = userver.ipLocalEndPoint;
                    Byte[] recdata = userver.NetWork.EndReceive(ar, ref fclient);
                    ConnName = userver.ipLocalEndPoint.Port + "->" + fclient.ToString();
                    if (DataReceived != null)
                    {
                        DataReceived.BeginInvoke(ConnName, recdata, null, null);//异步输出数据
                    }
                    if (lstClient.Contains(ConnName) == false)
                    {//新的客户端
                        lstClient.Add(ConnName);
                        BindLstClient();
                    }
                }
            }
            catch (ObjectDisposedException ex){}
            catch (Exception ex)
            {
                if (LanguageSet.Language == "0")
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                if (userver.NetWork.Client != null)
                {
                    userver.NetWork.BeginReceive(new AsyncCallback(ReceiveCallback), userver);//继续异步接收数据
                }
            }
        }

        /// <summary>
        /// 清理
        /// </summary>
        public void ClearSelf()
        {
            if (udpserver.NetWork != null)
            {
                udpserver.NetWork.Close();
            }
        }

        private void MS_Clearn_Click(object sender, EventArgs e)
        {
            if (lstConn.Items.Count > 0)
            {
                List<string> WaitRemove = new List<string>();
                for (int i = 0; i < lstConn.Items.Count; i++)
                {
                    WaitRemove.Add((string)lstConn.Items[i]);
                }
                foreach (string client in WaitRemove)
                {
                    lstClient.Remove(client);
                }
                BindLstClient();
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
