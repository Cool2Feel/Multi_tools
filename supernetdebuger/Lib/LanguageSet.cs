using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft.Lib
{
    class LanguageSet
    {
        //private static string language = "0";

        public static string Language = "0";
        

        /// <summary>
        /// 设置当前程序的界面语言
        /// </summary>
        /// <param name="lang">language:zh-CN, en-US</param>
        /// <param name="form">窗体实例</param>
        /// <param name="formType">窗体类型</param>
        public static void SetLang(string lang, Form form, Type formType)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            if (form != null)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(formType);
                resources.ApplyResources(form, "$this");
                AppLang(form, resources);
            }
        }
        public static void SetLang(string lang, UserControl form, Type formType)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            if (form != null)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(formType);
                resources.ApplyResources(form, "$this");
                AppLang(form, resources);
            }
        }

        /// <summary>
        /// 遍历窗体所有控件，针对其设置当前界面语言
        /// </summary>
        /// <param name="control"></param>
        /// <param name="resources"></param>
        private static void AppLang(Control control, System.ComponentModel.ComponentResourceManager resources)
        {
            if (control is MenuStrip)
            {
                //将资源应用与对应的属性
                resources.ApplyResources(control, control.Name);
                MenuStrip ms = (MenuStrip)control;
                if (ms.Items.Count > 0)
                {
                    foreach (ToolStripMenuItem c in ms.Items)
                    {
                        //调用 遍历菜单 设置语言
                        AppLang(c, resources);
                    }
                }
            }

            foreach (Control c in control.Controls)
            {
                if (c.Name == "MacTextBox")
                    continue;
                if (c.Name == "txtServerIP")
                    continue;
                if (c.Name == "TextMac")
                    continue;
                if (c.Name == "TextIp")
                    continue;
                resources.ApplyResources(c, c.Name);
                AppLang(c, resources);
            }
        }

        /// <summary>
        /// 遍历菜单
        /// </summary>
        /// <param name="item"></param>
        /// <param name="resources"></param>
        private static void AppLang(ToolStripMenuItem item, System.ComponentModel.ComponentResourceManager resources)
        {
            if (item is ToolStripMenuItem)
            {
                resources.ApplyResources(item, item.Name);
                ToolStripMenuItem tsmi = (ToolStripMenuItem)item;
                if (tsmi.DropDownItems.Count > 0)
                {
                    foreach (ToolStripMenuItem c in tsmi.DropDownItems)
                    {
                        //if (tsmi != ToolStripSeparator)
                        //{ }
                        AppLang(c, resources);
                    }
                }
            }
        }
    }
}
