using System.Windows.Forms;
using LeafSoft.LeafControl;
using System.Net;
using System.Threading;
using LeafSoft.Model;
using LeafSoft.PartPanel;
using EASkins;
using EASkins.Controls;
using System;
using PopupTool;
using System.Drawing;
using LeafSoft.Units;
using System.Configuration;
using LeafSoft.Lib;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace LeafSoft
{
    public partial class MainForm : MaterialForm
    {
        #region primary
        private readonly MaterialSkinManager materialSkinManager;
        frmCheck fc = new frmCheck();
        frmBytes fb = new frmBytes();
        private Popup _pop;
        private ColorPopup _popControl;
        private IniFiles settingFile;//配置文件
        //private string language = "0";
        #endregion
        public MainForm()
        {
            InitializeComponent();

            int GID = Guid.NewGuid().ToString().Length;
            fc.TopMost = true;
            fb.TopMost = true;
            this.Text = Lib.AppInfor.AssemblyCompany + Lib.AppInfor.AssemblyTitle + "[v" + Lib.AppInfor.AssemblyVersion + "]";
            settingFile = new IniFiles(Application.StartupPath + "\\IniFile\\setting.ini");
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            tabPage10.Parent = null;
            tabPage10.Hide();

            string lan = settingFile.ReadString("SETTING", "Language", "1");
            string language = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
            switch (language)
            {
                case "zh-CN":
                    lan = "0";
                    break;
                case "en-US":
                    lan = "1";
                    break;
                default:
                    lan = "1";
                    break;
            }
            if (lan == "0")
            {
                //language = "0";
                LanguageSet.Language = "0";
                LanguageSet.SetLang("", this, typeof(MainForm));
                this.Text = Lib.AppInfor.AssemblyCompany + Lib.AppInfor.AssemblyTitle + "[v" + Lib.AppInfor.AssemblyVersion + "]";
            }
            else
            {
                //language = "1";
                LanguageSet.Language = "1";
                LanguageSet.SetLang("en-US", this, typeof(MainForm));
                this.Text = Lib.AppInfor.AssemblyCompany + "-Communication debugging tool" + "[v" + Lib.AppInfor.AssemblyVersion + "]";
            }
            //Console.WriteLine(Screen.AllScreens.Count() + ":" + Screen.FromControl(this).DeviceName);
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey900, Primary.BlueGrey100, Accent.LightBlue200, TextShade.WHITE);

        }
        #region 插拔串口

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
                            this.comPanel3.Configer.ChangePort();
                            //MessageBox.Show("串口已拔出！", "Tips");
                        }
                        break;
                    case DBT_DEVICEARRIVAL:             // USB插入获取对应串口名称
                        {
                            this.comPanel3.Configer.ChangePort();
                            //MessageBox.Show("串口插入！", "Tips");
                        }
                        break;
                }
            }
            base.WndProc(ref m);
        }


        #endregion

        #region 主题背景
        private void materialRaisedButton1_Click(object sender, System.EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

        //private int colorSchemeIndex;
        private void materialRaisedButton2_Click(object sender, System.EventArgs e)
        {
            _pop.Show(this, materialRaisedButton2.Location.X - 130, materialRaisedButton2.Location.Y + 36);
            /*
            colorSchemeIndex++;
            if (colorSchemeIndex > 3) colorSchemeIndex = 0;

            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    break;
                case 3:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey700, Primary.Grey300, Accent.Orange100, TextShade.WHITE);
                    break;
            }
            */
        }

        public void Change_ColorScheme(int key)
        {
            try
            {
                switch (key)
                {
                    case 0:
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey600, Primary.BlueGrey200, Accent.LightBlue200, TextShade.WHITE);
                        break;
                    case 1:
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo700, Primary.Indigo500, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                        break;
                    case 2:
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green600, Primary.Green200, Accent.Red100, TextShade.WHITE);
                        break;
                    case 3:
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey700, Primary.Grey200, Accent.Amber100, TextShade.WHITE);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void ClosePop()
        {
            _pop.Close();
        }

        #endregion
        #region 折叠控制
        bool size = false;
        private void naviBar1_Resize(object sender, System.EventArgs e)
        {
            //Console.WriteLine("====" + naviBar1.Width);
            if (!size && naviBar1.Width == 33)
            {
                materialTabControl1.Width += 125;
                materialTabControl1.Location = new System.Drawing.Point(materialTabControl1.Location.X - 125, materialTabControl1.Location.Y);

                materialTabSelector1.Width += 100;
                materialTabSelector1.Location = new System.Drawing.Point(materialTabSelector1.Location.X - 100, materialTabSelector1.Location.Y);
                size = true;
            }
            else if (size && naviBar1.Width == 165)
            {
                materialTabControl1.Width -= 125;
                materialTabControl1.Location = new System.Drawing.Point(materialTabControl1.Location.X + 125, materialTabControl1.Location.Y);
                materialTabSelector1.Width -= 100;
                materialTabSelector1.Location = new System.Drawing.Point(materialTabSelector1.Location.X + 100, materialTabSelector1.Location.Y);
                size = false;
            }
        }
        #endregion
        #region 计算器
        private void materialFlatButton_crc_Click(object sender, EventArgs e)
        {
            if (fc.IsDisposed == true)
            {
                fc = new frmCheck();
                fc.TopMost = true;
            }
            fc.Show();
        }

        private void materialFlatButton_num_Click(object sender, EventArgs e)
        {
            if (fb.IsDisposed == true)
            {
                fb = new frmBytes();
                fb.TopMost = true;
            }
            fb.Show();
        }
        #endregion
        #region 调试窗口
        /// <summary>
        /// 新建调试窗口
        /// </summary>
        /// <param name="p"></param>
        /// <param name="title"></param>
        /// <param name="icon"></param>
        private void CreateNewTest(object p, string title, Icon icon)
        {
            Form frm = new Form();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Icon = icon;
            frm.Controls.Add((Control)p);
            frm.Width = 800;
            frm.Height = 500;
            frm.ShowIcon = true;
            frm.Text = title;
            frm.FormClosing += new FormClosingEventHandler(frm_FormClosing);
            frm.Show();
            /*
            if (Screen.AllScreens.Count() == 2)
            {
                frm.Left = ((Screen.AllScreens[1].Bounds.Width - this.Width) / 2);
                frm.Top = ((Screen.AllScreens[1].Bounds.Height - this.Height) / 2);
                //frm.Size = new System.Drawing.Size(Screen.AllScreens[1].Bounds.Width, Screen.AllScreens[1].Bounds.Height);
                //Console.WriteLine(Screen.AllScreens[1].Bounds.Width + Screen.AllScreens[1].Bounds.Height);
            }
            */
        }

        void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = (Form)sender;
            PartPanel.BasePanel bp = (PartPanel.BasePanel)frm.Controls[0];
            bp.ClearSelf();
            FormHelper.SetFormParam(bp);
        }

        private void materialFlatButton_srai_Click(object sender, EventArgs e)
        {
            ComPanel tp = new ComPanel();
            tp.Dock = DockStyle.Fill;
            if (LanguageSet.Language == "0")
                CreateNewTest(tp, "串口通讯[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.com1);
            else
                CreateNewTest(tp, "Serial communication[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.com1);
        }

        private void materialFlatButton_tcps_Click(object sender, EventArgs e)
        {
            TCPServerPanel nwin = new TCPServerPanel();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "TCP Server[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.tcp);
        }

        private void materialFlatButton_tcpc_Click(object sender, EventArgs e)
        {
            TCPClientPanel nwin = new TCPClientPanel();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "TCP Client[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.tcp);
        }

        private void materialFlatButton_udps_Click(object sender, EventArgs e)
        {
            UDPServerPanel nwin = new UDPServerPanel();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "UDP Server[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.udp);
        }

        private void materialFlatButton_udpc_Click(object sender, EventArgs e)
        {
            UDPClientPanel nwin = new UDPClientPanel();
            nwin.Dock = DockStyle.Fill;
            CreateNewTest(nwin, "UDP Client[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.udp);
        }
        #endregion
        #region 监视窗口
        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            SocketMonitor nwin = new SocketMonitor();
            nwin.Dock = DockStyle.Fill;
            if (LanguageSet.Language == "0")
                CreateNewTest(nwin, "Socket 通信监视器[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.monitor_socket_icon);
            else
                CreateNewTest(nwin, "Socket Communication monitor[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.monitor_socket_icon);
        }


        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            ComMonitor nwin = new ComMonitor();
            nwin.Dock = DockStyle.Fill;
            if (LanguageSet.Language == "0")
                CreateNewTest(nwin, "串口通信监视器[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.monitor_com_icon);
            else
                CreateNewTest(nwin, "Serial communication monitor[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.monitor_com_icon);

        }

        #endregion
        #region 关于
        private void naviBand4_Click(object sender, EventArgs e)
        {
            new AboutMe().ShowDialog();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            new AboutMe().ShowDialog();
        }
        #endregion
        #region Load、Close
        /// <summary>
        /// 初始化加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //string key = config.AppSettings.Settings["ColorIndex"].Value;
            string sPath = Application.StartupPath + "\\IniFile";
            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }
            string key = settingFile.ReadString("SETTING", "ColorIndex", "0");
            Change_ColorScheme(int.Parse(key));
            _popControl = new ColorPopup(this);
            _pop = new Popup(_popControl);
            this.comPanel3.Configer.Init_ConfigCom();
            this.wolPanel1.Load_Inifile();
            naviBar1.Collapsed = true;
            AnimateWindow(this.Handle, 800, AW_SLIDE + AW_CENTER);
        }

        private void ApplyResource()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            foreach (Control ctl in this.Controls)
            {
                resources.ApplyResources(ctl, ctl.Name);
            }
            foreach (Control ctl in naviBar1.Controls)
            {
                resources.ApplyResources(ctl, ctl.Name);
            }
            foreach (Control ctl in naviGroup_new.Controls)
            {
                resources.ApplyResources(ctl, ctl.Name);
            }
            foreach (Control ctl in naviGroup_calc.Controls)
            {
                resources.ApplyResources(ctl, ctl.Name);
            }
            foreach (Control ctl in materialTabControl1.Controls)
            {
                resources.ApplyResources(ctl, ctl.Name);
            }

            resources.ApplyResources(materialRaisedButton2, materialRaisedButton2.Name);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.comPanel3.Configer.Save_ConfigCom();
            this.comPanel3.Configer.ClearSelf();
            this.comPanel3.DataSender.CMD_Saved_default();
            this.tcpServerPanel3.DataSender.CMD_Saved_default();
            this.tcpClientPanel3.DataSender.CMD_Saved_default();
            this.udpClientPanel3.DataSender.CMD_Saved_default();
            this.wolPanel1.WOL_Saved_default();
            this.adbPanel1.Save_ConfigAdb();
            settingFile.WriteString("SETTING", "Language", LanguageSet.Language);
            //this.pingPanel3.OutPutForm_FormClosing();
            LogHelper.WriteLog("Multi-tool Stop: Closed...");
            HideFXCenter(this.Handle, 400);
            System.Environment.Exit(0);
        }
        #endregion
        #region 窗体关闭效果

        #region 私有方法
        [DllImportAttribute("user32.dll")]
        private static extern bool AnimateWindow(IntPtr whnd, int dwtime, int dwflag);
        #endregion
        /*
        1. AW_SLIDE : 使用滑动类型, 默认为该类型. 当使用 AW_CENTER 效果时, 此效果被忽略
        2. AW_ACTIVE: 激活窗口, 在使用了 AW_HIDE 效果时不可使用此效果
        3. AW_BLEND: 使用淡入效果
        4. AW_HIDE: 隐藏窗口
        5. AW_CENTER: 与 AW_HIDE 效果配合使用则效果为窗口几内重叠,  单独使用窗口向外扩展.
        6. AW_HOR_POSITIVE : 自左向右显示窗口
        7. AW_HOR_NEGATIVE: 自右向左显示窗口
        8. AW_VER_POSITVE: 自顶向下显示窗口
        9. AW_VER_NEGATIVE : 自下向上显示窗口
        */
        public const Int32 AW_HOR_POSITIVE = 0x00000001;
        public const Int32 AW_HOR_NEGATIVE = 0x00000002;
        public const Int32 AW_VER_POSITIVE = 0x00000004;
        public const Int32 AW_VER_NEGATIVE = 0x00000008;
        public const Int32 AW_CENTER = 0x00000010;
        public const Int32 AW_HIDE = 0x00010000;
        public const Int32 AW_ACTIVATE = 0x00020000;
        public const Int32 AW_SLIDE = 0x00040000;
        public const Int32 AW_BLEND = 0x00080000;

        /// <summary>
        /// 由边界向中心扩展渐进关闭窗口
        /// </summary>
        public static void HideFXCenter(IntPtr wnd, int dwtime)
        {
            AnimateWindow(wnd, dwtime, AW_CENTER | AW_HIDE | AW_SLIDE);

        }

        #endregion

    }
}
