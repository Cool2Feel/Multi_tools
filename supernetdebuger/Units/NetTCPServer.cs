﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using LeafSoft.Model;
using LeafSoft.Lib;

namespace LeafSoft.Units
{
    public partial class NetTCPServer :UserControl, ICommunication
    {
        /// <summary>
        /// TCP服务端监听
        /// </summary>
        TcpListener tcpsever = null;
        /// <summary>
        /// 监听状态
        /// </summary>
        bool isListen = false;

        public event Lib.LeafEvent.DataReceivedHandler DataReceived;

        /// <summary>
        /// 当前已连接客户端集合
        /// </summary>
        public BindingList<LeafTCPClient> lstClient = new BindingList<LeafTCPClient>();
        //private string lan;
        //private IniFiles settingFile;//配置文件
        public NetTCPServer()
        {
            InitializeComponent();
            if (LanguageSet.Language == "0")
            {
                LanguageSet.SetLang("", this, typeof(NetTCPServer));
            }
            else
            {
                LanguageSet.SetLang("en-US", this, typeof(NetTCPServer));
            }
            if (this.DesignMode == false)
            {
                //cbxServerIP.SelectedIndex = 0;
                cbxServerIP.Items.Clear();
                IPHostEntry ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in ipHostEntry.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {//筛选IPV4
                        cbxServerIP.Items.Add(ip.ToString());
                    }
                }
            }
            if(cbxServerIP.Items.Count > 0)
                cbxServerIP.SelectedIndex = 0;
        }
        private void ApplyResource()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetTCPServer));
            foreach (Control ctl in this.Controls)
            {
                resources.ApplyResources(ctl, ctl.Name);
            }
        }

        /// <summary>
        /// 绑定客户端列表
        /// </summary>
        private void BindLstClient()
        {
            lstConn.Invoke(new MethodInvoker(delegate{
                lstConn.DataSource = null;
                lstConn.DataSource = lstClient;
                lstConn.DisplayMember = "Name";
            }));
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (isListen == false)
            {//监听已停止
                StartTCPServer();
            }
            else
            {//监听已开启
                StopTCPServer();
            }
            cbxServerIP.Enabled = !isListen;
            nmServerPort.Enabled = !isListen;
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
        /// 开启TCP监听
        /// </summary>
        /// <returns></returns>
        private void StartTCPServer()
        {
            try
            {
                if (cbxServerIP.SelectedIndex == -1)
                {
                    tcpsever = new TcpListener(IPAddress.Any, (int)nmServerPort.Value);
                }
                else
                {
                    tcpsever = new TcpListener(IPAddress.Parse(cbxServerIP.SelectedItem.ToString()), (int)nmServerPort.Value);
                }
                tcpsever.Start();
                tcpsever.BeginAcceptTcpClient(new AsyncCallback(Acceptor), tcpsever);
                isListen = true;

                LogHelper.WriteLog("TCP Server Connect: open");
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
        /// 停止TCP监听
        /// </summary>
        /// <returns></returns>
        private void StopTCPServer()
        {
            tcpsever.Stop();
            isListen = false;
            LogHelper.WriteLog("TCP Server Connect: close");
        }

        /// <summary>
        /// 客户端连接初始化
        /// </summary>
        /// <param name="o"></param>
        private void Acceptor(IAsyncResult o)
        {
            TcpListener server = o.AsyncState as TcpListener;
            try
            {
                //初始化连接的客户端
                LeafTCPClient newClient = new LeafTCPClient();
                newClient.NetWork = server.EndAcceptTcpClient(o);
                lstClient.Add(newClient);
                BindLstClient();
                newClient.NetWork.GetStream().BeginRead(newClient.buffer, 0, newClient.buffer.Length, new AsyncCallback(TCPCallBack), newClient);
                server.BeginAcceptTcpClient(new AsyncCallback(Acceptor), server);//继续监听客户端连接
            }
            catch (ObjectDisposedException ex)
            { //监听被关闭
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
        /// 对当前选中的客户端发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
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


                        LogHelper.WriteLog("TCP Server Send date:" + Encoding.Default.GetString(data));
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
                    MessageBox.Show("无可用客户端", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("No client available", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// 客户端通讯回调函数
        /// </summary>
        /// <param name="ar"></param>
        private void TCPCallBack(IAsyncResult ar)
        {
            LeafTCPClient client = (LeafTCPClient)ar.AsyncState;
            if (client.NetWork.Connected)
            {
                try
                {
                    NetworkStream ns = client.NetWork.GetStream();
                    byte[] recdata = new byte[ns.EndRead(ar)];
                    if (recdata.Length > 0)
                    {
                        Array.Copy(client.buffer, recdata, recdata.Length);
                        if (DataReceived != null)
                        {
                            DataReceived.BeginInvoke(client.Name, recdata, null, null);//异步输出数据
                        }

                        LogHelper.WriteLog("TCP Server Received: " + Encoding.Default.GetString(recdata));
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
        /// 清理
        /// </summary>
        public void ClearSelf()
        {
            foreach (LeafTCPClient client in lstClient)
            {
                client.DisConnect();
            }
            lstClient.Clear();
            if (tcpsever != null)
            {
                tcpsever.Stop();
            }
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
