using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft.Lib
{
    public class FormHelper
    {
        //这是XML文档物理文件名（包含物理路径）
        private static string xmlFileName = Application.StartupPath + @"\Config\parameter.xml";
        //这是XML文档根节点名
        private static string rootNodeName = "Forms";

        /// <summary>
        /// 保存控件参数
        /// 放到FormClosing事件里
        /// </summary>
        /// <param name="c"></param>
        public static void SetFormParam(Control c)
        {
            CreatXml();
            string str = "";
            GetParam(c, ref str);
            str = str.TrimEnd('|');
            //保存xml文档
            string xpath = "/" + rootNodeName;  //这是新节点的父节点路径/Forms
            string nodename = "FormName";　//这是新节点名称,在父节点下新增
            string nodetext = c.Text;//窗体名
            bool isSuccess = XMLHelper.CreateOrUpdateXmlNodeByXPath(xmlFileName, xpath, nodename, "", "Name", nodetext);

            string xpath2 = xpath + "/" + nodename;  //这是新子节点的父节点路径/Forms/FormName
            string nodename2 = "parm";　//这是新子节点名称,在父节点下新增
            string nodetext2 = str;//窗体控件参数字符串
            isSuccess = XMLHelper.CreateOrUpdateXmlNodeByXPath(xmlFileName, xpath2, nodename2, nodetext2, nodetext);
        }

        /// <summary>
        /// 加载控件参数
        /// 放到Load事件尾
        /// </summary>
        /// <param name="c"></param>
        public static void LoadFormParam(Control c)
        {
            //获取xml参数文档
            if (System.IO.File.Exists(xmlFileName))
            {
                string xpath = "/" + rootNodeName + "/FormName";
                string parm = XMLHelper.GetXmlByAttribute(xmlFileName, xpath, "parm", "Name", c.Text);
                SetParam(c, parm);
            }
        }
        private static void CreatXml()
        {
            if (!System.IO.File.Exists(xmlFileName))
            {
                if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(xmlFileName)))
                    System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(xmlFileName));
                XMLHelper.CreateXmlDocument(xmlFileName, rootNodeName, "1.0", "utf-8", null);
                //MessageBox.Show("XML文档创建成功:" + xmlFileName);
            }
        }

        private static void GetParam(Control c, ref string str)
        {
            try
            {
                foreach (Control ctl in c.Controls)
                {
                    if (ctl is TextBox)
                    {
                        TextBox tx = ctl as TextBox;
                        str += tx.Name + "$" + tx.Text + "|";
                    }
                    if (ctl is CheckBox)
                    {
                        CheckBox tx = ctl as CheckBox;
                        str += tx.Name + "$" + tx.Checked + "|";
                    }
                    if (ctl is ComboBox)
                    {
                        ComboBox tx = ctl as ComboBox;
                        str += tx.Name + "$" + tx.SelectedIndex.ToString() + "|";
                    }
                    if (ctl.Controls.Count > 0) GetParam(ctl, ref str);
                }
            }
            catch (Exception)
            {
            }
        }
        private static void SetParam(Control c, string parm)
        {
            try
            {
                foreach (Control ctl in c.Controls)
                {
                    foreach (string str in parm.Split('|'))
                    {
                        if (ctl.Name == str.Split('$')[0])
                        {
                            if (ctl is TextBox)
                            {
                                TextBox tx = ctl as TextBox;
                                tx.Text = str.Split('$')[1];
                            }
                            if (ctl is CheckBox)
                            {
                                CheckBox tx = ctl as CheckBox;
                                tx.Checked = Convert.ToBoolean(str.Split('$')[1]);
                            }
                            if (ctl is ComboBox)
                            {
                                ComboBox tx = ctl as ComboBox;
                                tx.SelectedIndex = Convert.ToInt32(str.Split('$')[1]);
                            }
                        }
                    }
                    if (ctl.Controls.Count > 0) SetParam(ctl, parm);
                }
            }
            catch (Exception)
            {
            }
        }

        #region 参数保存
        private static string xmlparamFileName = Application.StartupPath + @"\Config\param.xml";
        /// <summary>
        /// 保存参数
        /// </summary>
        /// <param name="paramname">参数名</param>
        /// <param name="paramvalues">参数值</param>
        public static void SetValue(string paramname, object paramvalues)
        {
            setvalues(paramname, paramvalues.ToString());
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <param name="paramname">参数名</param>
        /// <param name="def">默认值</param>
        /// <returns></returns>
        public static string GetValue(string paramname, string def = "")
        {
            string str = getvalues(paramname);
            if (str == "") str = def;
            return str;
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <param name="paramname">参数名</param>
        /// <param name="def">默认值</param>
        /// <returns></returns>
        public static bool GetBoolValue(string paramname, bool def = false)
        {
            bool b = false;
            try
            {
                string str = getvalues(paramname);
                if (str == "") return def;
                b = Convert.ToBoolean(str.Trim());
            }
            catch (Exception)
            {
                b = def;
            }
            return b;
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <param name="paramname">参数名</param>
        /// <param name="def">默认值</param>
        /// <returns></returns>
        public static int GetIntValue(string paramname, int def = -1)
        {
            try
            {
                double val = GetDoubleValue(paramname, def);
                return Convert.ToInt32(val);
            }
            catch (Exception)
            {
                return def;
            }
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <param name="paramname">参数名</param>
        /// <param name="def">默认值</param>
        /// <returns></returns>
        public static double GetDoubleValue(string paramname, double def = -1)
        {
            try
            {
                string str = getvalues(paramname);
                if (str == "") return def;
                return Convert.ToDouble(str.Trim());
            }
            catch (Exception)
            {
                return def;
            }
        }
        private static void setvalues(string paramname, string paramvalues)
        {
            string root = "params";
            if (!System.IO.File.Exists(xmlparamFileName))
            {
                if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(xmlparamFileName)))
                    System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(xmlparamFileName));
                XMLHelper.CreateXmlDocument(xmlparamFileName, root, "1.0", "utf-8", null);
            }

            string xpath = "/" + root;  //这是新节点的父节点路径/Forms
            string nodename = "param";　//这是新节点名称,在父节点下新增
            string nodetext = paramname;
            bool isSuccess = XMLHelper.CreateOrUpdateXmlNodeByXPath(xmlparamFileName, xpath, nodename, paramvalues, "Name", nodetext);
        }
        private static string getvalues(string paramname)
        {
            string str = string.Empty;
            //获取xml参数文档
            if (System.IO.File.Exists(xmlparamFileName))
            {
                string xpath = "/params/param";
                str = XMLHelper.GetXmlByAttribute(xmlparamFileName, xpath, "Name", paramname);
            }
            return str;
        }
        #endregion
    }
}
