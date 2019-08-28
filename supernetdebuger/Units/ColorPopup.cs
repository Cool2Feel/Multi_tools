using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using LeafSoft.Lib;

namespace LeafSoft.Units
{
    public partial class ColorPopup : UserControl
    {
        private MainForm _main;
        //private Configuration config;
        private IniFiles settingFile;//配置文件
        public ColorPopup(MainForm main)
        {
            InitializeComponent();
            _main = main;
            skinButton1.BackColor = Color.FromArgb(0xff, 84, 110, 122);
            skinButton2.BackColor = Color.FromArgb(0xff, 63, 81, 181);
            skinButton3.BackColor = Color.FromArgb(0xff, 67, 160, 71);
            skinButton4.BackColor = Color.FromArgb(0xff, 66, 66, 66);
            //config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            settingFile = new IniFiles(Application.StartupPath + "\\IniFile\\setting.ini");

            string lan = settingFile.ReadString("SETTING", "Language", "1");
            if (lan == "0")
            {
                LanguageSet.SetLang("", this, typeof(ColorPopup));
            }
            else
            {
                LanguageSet.SetLang("en-US", this, typeof(ColorPopup));
            }
            //string key = config.AppSettings.Settings["ColorIndex"].Value;
            string key = settingFile.ReadString("SETTING", "ColorIndex", "0");
            if (key == "0")
                materialRadioButton1.Checked = true;
            else if(key == "1")
                materialRadioButton2.Checked = true;
            else if (key == "2")
                materialRadioButton3.Checked = true;
            else if (key == "3")
                materialRadioButton4.Checked = true;
            else
                materialRadioButton1.Checked = true;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            materialRadioButton1.Checked = true;
            _main.Change_ColorScheme(0);
            //config.AppSettings.Settings["ColorIndex"].Value = "0";
            settingFile.WriteString("SETTING", "ColorIndex", "0");
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            materialRadioButton2.Checked = true;
            _main.Change_ColorScheme(1);
            //config.AppSettings.Settings["ColorIndex"].Value = "1";
            settingFile.WriteString("SETTING", "ColorIndex", "1");
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            materialRadioButton3.Checked = true;
            _main.Change_ColorScheme(2);
            //config.AppSettings.Settings["ColorIndex"].Value = "2";
            settingFile.WriteString("SETTING", "ColorIndex", "2");
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            materialRadioButton4.Checked = true;
            _main.Change_ColorScheme(3);
            //config.AppSettings.Settings["ColorIndex"].Value = "3";
            settingFile.WriteString("SETTING", "ColorIndex", "3");
        }

        private void materialRadioButton1_Click(object sender, EventArgs e)
        {
            if(materialRadioButton1.Checked)
            {
                _main.Change_ColorScheme(0);
                //config.AppSettings.Settings["ColorIndex"].Value = "0";
                settingFile.WriteString("SETTING", "ColorIndex", "0");
            }
        }

        private void materialRadioButton2_Click(object sender, EventArgs e)
        {
            if (materialRadioButton2.Checked)
            {
                _main.Change_ColorScheme(1);
                //config.AppSettings.Settings["ColorIndex"].Value = "1";
                settingFile.WriteString("SETTING", "ColorIndex", "1");
            }
        }

        private void materialRadioButton3_Click(object sender, EventArgs e)
        {
            if (materialRadioButton3.Checked)
            {
                _main.Change_ColorScheme(2);
                //config.AppSettings.Settings["ColorIndex"].Value = "2";
                settingFile.WriteString("SETTING", "ColorIndex", "2");
            }
        }

        private void materialRadioButton4_Click(object sender, EventArgs e)
        {
            if (materialRadioButton4.Checked)
            {
                _main.Change_ColorScheme(3);
                //config.AppSettings.Settings["ColorIndex"].Value = "3";
                settingFile.WriteString("SETTING", "ColorIndex", "3");
            }
        }
    }
}
