using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft.Lib
{
    public class GetMac
    {
        string _strMac = "";
        string _strName = "";
        string _strIp = "";
        public GetMac(string ip)
        {
            byte[] bs = new byte[50] { 0x0, 0x00, 0x0, 0x10, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x20, 0x43, 0x4b, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x0, 0x0, 0x21, 0x0, 0x1 };
            byte[] Buf = new byte[500];
            byte[,] recv = new byte[18, 28];
            string str = "", strHost = "", Group = "", User = "", strMac = "";
            int receive, macline = 0, usernum = 0;
            string[] domainuser = new string[2];
            domainuser[0] = "";
            domainuser[1] = "";

            try
            {
                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
                EndPoint Remote = (EndPoint)sender;

                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), 137);

                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 3000);
                server.SendTo(bs, bs.Length, SocketFlags.None, ipep);
                receive = server.ReceiveFrom(Buf, ref Remote);
                server.Close();

                if (receive > 0)
                {
                    recv = new byte[18, (receive - 56) % 18];

                    for (int k = 0; k < (receive - 56) % 18; k++)
                    {
                        for (int j = 0; j < 18; j++)
                        {
                            recv[j, k] = Buf[57 + 18 * k + j];
                        }
                    }

                    for (int k = 0; k < (receive - 56) % 18; k++)
                    {
                        str = "";
                        if (System.Convert.ToString(recv[15, k], 16) == "0" && (System.Convert.ToString(recv[16, k], 16) == "4" || System.Convert.ToString(recv[16, k], 16) == "44"))
                        {
                            for (int j = 0; j < 15; j++)
                            {
                                str += System.Convert.ToChar(recv[j, k]).ToString();
                            }
                            strHost = str.Trim();
                        }

                        if (System.Convert.ToString(recv[15, k], 16) == "0" && (System.Convert.ToString(recv[16, k], 16) == "84" || System.Convert.ToString(recv[16, k], 16).ToUpper() == "C4"))
                        {
                            for (int j = 0; j < 15; j++)
                            {
                                str += System.Convert.ToChar(recv[j, k]).ToString();
                            }
                            Group = str.Trim();
                        }

                        if (System.Convert.ToString(recv[15, k], 16) == "3" && (System.Convert.ToString(recv[16, k], 16) == "4" || System.Convert.ToString(recv[16, k], 16) == "44"))
                        {
                            for (int j = 0; j < 15; j++)
                            {
                                str += System.Convert.ToChar(recv[j, k]).ToString();
                            }
                            domainuser[usernum] = str.Trim();
                            usernum++;
                        }

                        if (System.Convert.ToString(recv[15, k], 16) == "0" && System.Convert.ToString(recv[16, k], 16) == "0" && System.Convert.ToString(recv[17, k], 16) == "0")
                        {
                            macline = k;

                            for (int i = 0; i < 6; i++)
                            {
                                if (i < 5)
                                {
                                    strMac += System.Convert.ToString(recv[i, macline], 16).PadLeft(2, '0').ToUpper() + ":";
                                }
                                if (i == 5)
                                {
                                    strMac += System.Convert.ToString(recv[i, macline], 16).PadLeft(2, '0').ToUpper();
                                }
                            }
                            k = (receive - 56) % 18;
                        }
                    }
                    //User = domainuser[1];
                    //if (string.IsNullOrEmpty(domainuser[1])) { User = domainuser[0]; }
                    //Console.WriteLine(strHost);
                    //Console.WriteLine(Group);
                    //Console.WriteLine(User);
                    //Console.WriteLine(strMac);
                    _strMac = strMac;
                    _strName = strHost;
                    _strIp = ip;
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show("获取远程主机的MAC错误：连接的目标主机没有反应！", "提示");
                //Console.WriteLine(ex.Message);
            }
        }

        public string MAC
        {
            get { return _strMac; }
        }
        public string NAME
        {
            get { return _strName; }
        }
        public string IP
        {
            get { return _strIp; }
        }
    }
}
