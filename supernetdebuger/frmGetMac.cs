using LeafSoft.Lib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LeafSoft
{
    public partial class frmGetMac : Form
    {
        [DllImport("ws2_32.dll")]
        private static extern int inet_addr(string cp);

        [DllImport("IPHLPAPI.dll")]
        private static extern int SendARP(Int32 DestIP, Int32 SrcIP, ref Int64 pMacAddr, ref Int32 PhyAddrLen);


        public Model.WOL NewWOL = null;
        private GetMac GM;
        public frmGetMac()
        {
            InitializeComponent();
            if (LanguageSet.Language == "0")
            {
                LanguageSet.SetLang("", this, typeof(frmGetMac));
            }
            else
            {
                LanguageSet.SetLang("en-US", this, typeof(frmGetMac));
            }
            //GetAllIPAndMac();
        }

        /// <summary>
        /// 获得所有的IP 和 MAC
        /// </summary>
        public static Dictionary<string, string> GetAllIPAndMac()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            DirectoryEntry entryPC = new DirectoryEntry("WinNT:");

            foreach (DirectoryEntry child in entryPC.Children)
            {
                foreach (DirectoryEntry pc in child.Children)
                {
                    try
                    {
                        IPHostEntry hostent = Dns.GetHostEntry(pc.Name); // 主机信息
                        Array addrs = hostent.AddressList;            // IP地址数组
                        IEnumerator it = addrs.GetEnumerator();       // 迭代器
                        while (it.MoveNext())
                        {                     // 循环到下一个IP 地址
                            IPAddress ip = (IPAddress)it.Current;      // 获得 IP 地址
                            string mac = GetMacAddress(ip.ToString()); //获得MAC地址
                            dic.Add(ip.ToString(), mac);
                            //Console.WriteLine(ip + " = " + mac);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }

                }
            }

            return dic;
        }

        /// <summary>
        /// 根据MAC地址获得IP地址
        /// </summary>
        /// <param name="macaddr"></param>
        /// <returns></returns>
        public static string GetIPAddress(string macaddr)
        {
            string ipAddr = "";
            DirectoryEntry entryPC = new DirectoryEntry("WinNT:");
            foreach (DirectoryEntry child in entryPC.Children)
            {
                foreach (DirectoryEntry pc in child.Children)
                {
                    try
                    {
                        IPHostEntry hostent = Dns.GetHostEntry(pc.Name); // 主机信息
                        Array addrs = hostent.AddressList;            // IP地址数组
                        IEnumerator it = addrs.GetEnumerator();       // 迭代器
                        while (it.MoveNext())
                        {                     // 循环到下一个IP 地址
                            IPAddress ip = (IPAddress)it.Current;      // 获得 IP 地址
                            string mac = GetMacAddress(ip.ToString()).ToLower(); //获得MAC地址
                            if (mac == macaddr)
                            {
                                ipAddr = ip.ToString();
                                //Console.WriteLine(ip   " "   mac);
                                break;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine(ex);
                    }

                    if (ipAddr != "")
                    {
                        break;
                    }
                }

                if (ipAddr != "")
                {
                    break;
                }
            }

            return ipAddr;
        }

        /// <summary>
        /// 根据ip地址获得MAC地址
        /// </summary>
        /// <param name="hostip"></param>
        /// <returns></returns>
        public static string GetMacAddress(string hostip)//获取远程IP（不能跨网段）的MAC地址
        {
            string Mac = "";
            try
            {
                Int32 ldest = inet_addr(hostip); //将IP地址从 点数格式转换成无符号长整型
                Int64 macinfo = new Int64();
                Int32 len = 6;
                SendARP(ldest, 0, ref macinfo, ref len);
                string TmpMac = Convert.ToString(macinfo, 16).PadLeft(12, '0');//转换成16进制　　注意有些没有十二位
                Mac = TmpMac.Substring(0, 2).ToUpper();//
                for (int i = 2; i < TmpMac.Length; i = i + 2)
                {
                    Mac = TmpMac.Substring(i, 2).ToUpper() +  ":" + Mac;
                }
            }
            catch (Exception Mye)
            {
                //Mac = "获取远程主机的MAC错误：" +  Mye.Message;
                if(LanguageSet.Language == "0")
                    MessageBox.Show("获取远程主机的MAC错误：" + Mye.Message,"提示");
                else
                    MessageBox.Show("Get the MAC error of the remote host：" + Mye.Message, "Tips");
            }
            if (Mac == "00:00:00:00:00:00")
                Mac = "";
            return Mac;
        }

        private void btGet_Click(object sender, EventArgs e)
        {
            string ip = TextIp.Text;
            Regex regex = new Regex("^[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}$");
            if (!regex.IsMatch(ip))
            {
                MessageBox.Show("输入一个无效的 IP 地址!", "提示");
                return;
            }
            GM = new GetMac(ip);
            TextName.Text = GM.NAME;
            TextMac.Text = GM.MAC;
            //TextMac.Text = GetMacAddress(ip);
            //lstWOL.Add(new Model.WOL(GM.MAC,GM.NAME,GM.IP));
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(TextMac.Text != "" && TextIp.Text != "")
            {
                Regex r = new Regex(@"^([A-Fa-f0-9][A-Fa-f0-9]:[A-Fa-f0-9][A-Fa-f0-9]:[A-Fa-f0-9][A-Fa-f0-9]:[A-Fa-f0-9][A-Fa-f0-9]:[A-Fa-f0-9][A-Fa-f0-9]:[A-Fa-f0-9][A-Fa-f0-9])$");
                //NewWOL = new Model.WOL();
                string mac = TextMac.Text;
                if (!r.IsMatch(mac))
                {
                    if(LanguageSet.Language == "0")
                        MessageBox.Show("输入的 MAC 地址无效!", "提示");
                    else
                        MessageBox.Show("Invalid MAC address entered!", "提示");
                    return;
                }
                string name = TextName.Text;
                string ip = TextIp.Text;
                Regex regex = new Regex("^[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}$");
                if (!regex.IsMatch(ip))
                {
                    if(LanguageSet.Language == "0")
                        MessageBox.Show("输入的 IP 地址无效!", "提示");
                    else
                        MessageBox.Show("Invalid IP address entered!", "提示");
                    return;
                }
                NewWOL = new Model.WOL(mac, name, ip);
            }
            if (NewWOL != null)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ip = TextIp.Text;
            Regex regex = new Regex("^[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}$");
            if (!regex.IsMatch(ip))
            {
                if (LanguageSet.Language == "0")
                    MessageBox.Show("输入的 IP 地址无效!", "提示");
                else
                    MessageBox.Show("Invalid IP address entered!", "提示");
                return;
            }
            TextMac.Text = GetMacAddress(ip);
            //lstWOL.Add(new Model.WOL(GM.MAC,GM.NAME,GM.IP));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mac = TextMac.Text;
            Regex regex = new Regex(@"^([A-Fa-f0-9][A-Fa-f0-9]:[A-Fa-f0-9][A-Fa-f0-9]:[A-Fa-f0-9][A-Fa-f0-9]:[A-Fa-f0-9][A-Fa-f0-9]:[A-Fa-f0-9][A-Fa-f0-9]:[A-Fa-f0-9][A-Fa-f0-9])$");
            if (!regex.IsMatch(mac))
            {
                if (LanguageSet.Language == "0")
                    MessageBox.Show("输入的 MAC 地址无效!", "提示");
                else
                    MessageBox.Show("Invalid MAC address entered!", "提示");
                return;
            }
            TextIp.Text = GetIPAddress(mac);
        }
    }
}
