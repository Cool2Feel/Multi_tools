using LeafSoft.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace LeafSoft
{
    partial class AboutMe : Form
    {
        public AboutMe()
        {
            InitializeComponent();
            if (LanguageSet.Language == "0")
            {
                LanguageSet.SetLang("", this, typeof(AboutMe));
                this.Text = string.Format("About {0}", Lib.AppInfor.AssemblyProduct);
                this.label1.Text = string.Format("Product: {0}", Lib.AppInfor.AssemblyProduct);
                this.textBoxDescription.Text = Lib.AppInfor.AssemblyDescription;
            }
            else
            {
                LanguageSet.SetLang("en-US", this, typeof(AboutMe));
                this.Text = string.Format("About Multi-tools");
                this.label1.Text = string.Format("Product: Communication debugging tool");
                this.textBoxDescription.Text = "The main functions of this software are as follows: \r\n" +
     "● Serial port, TCP server/client, UDP server/client communication debugging\r\n" +
     "● Support Hex, ASCII, UTF8, GB2312 code debugging \r\n" +
     "● Receive data can be calculated by the right-click menu with one button to calculate the value of Hex\r\n" +
     "● Byte Calculator / Test Value Calculator (CRC16, Custom Polynomial CRC16, XOR)\r\n" +
     "● Serial Hyper Terminal\r\n" +
     "●Socket Communication Monitor\r\n" +
     "●WOL remote wakeup\r\n" +
     "●ADB debugging function";
            }
            this.label1.Text = string.Format("Product: {0}", Lib.AppInfor.AssemblyProduct);
            this.label2.Text = string.Format("Version: {0}", Lib.AppInfor.AssemblyVersion);
            this.label3.Text = string.Format("Copyright: {0}", Lib.AppInfor.AssemblyCopyright);
            this.label4.Text = string.Format("Company: {0}", Lib.AppInfor.AssemblyCompany);
        }

    }
}
