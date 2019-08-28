using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using LeafSoft.Lib;

namespace LeafSoft.PartPanel
{
    public partial class ComPanel : BasePanel
    {
        public ComPanel()
        {
            InitializeComponent();
            if (LanguageSet.Language == "0")
            {
                LanguageSet.SetLang("", this, typeof(ComPanel));
            }
            else
            {
                LanguageSet.SetLang("en-US", this, typeof(ComPanel));
            }
        }

        private bool DataSender_EventDataSend(byte[] data)
        {
            return Configer.SendData(data);
        }
        //EnumType.DataEncode de = EnumType.DataEncode.UTF8;
        private void Configer_DataReceived(object sender, byte[] data)
        {
            if (txtCmd.Visible == true)
            {
                if(data.Length>1)
                {
                    string ss = new UTF8Encoding().GetString(data);
                    if (ss.Contains("\r\n"))
                    {

                    }
                    else if(ss.Contains("\r"))
                    {
                        ss = ss.Replace("\r", "\r\n");
                    }
                    else
                    {
                        ss = ss + "\r\n";
                    }
                    txtCmd.Invoke(new MethodInvoker(delegate
                    {
                        //txtCmd.AppendText(new UTF8Encoding().GetString(data).Replace("\r", "\r\n"));
                        RichTextBoxExtension.AppendTextColorful(txtCmd, ss, Color.LightGreen);
                        txtCmd.SelectionStart = txtCmd.Text.Length;  
                    }));
                }
            }
            else
            {
                DataReceiver.AddData(data);
            }
        }

        public override void ClearSelf()
        {
            Configer.ClearSelf();
        }

        private void btnSuper_Click(object sender, EventArgs e)
        {
            txtCmd.Visible = !txtCmd.Visible;
            if (txtCmd.Visible)
            {
                if (LanguageSet.Language == "0")
                    btnSuper.Text = "关闭超级终端";
                else
                    btnSuper.Text = "HyperTerminal Off";
                btnSuper.ForeColor = Color.Red;
            }
            else
            {
                if (LanguageSet.Language == "0")
                    btnSuper.Text = "启动超级终端";
                else
                    btnSuper.Text = "HyperTerminal On";
                btnSuper.ForeColor = Color.Black;
            }
            txtCmd.Focus();
        }

        private bool txtCmd_DataSend(byte[] cmd)
        {
           return Configer.SendData(cmd);
        }
        /*
        private static void AppendTextColorful(this RichTextBox rtBox, string text, Color color, bool addNewLine = true)
        {
            if (addNewLine)
            {
                text += Environment.NewLine;
            }
            rtBox.SelectionStart = rtBox.TextLength;
            rtBox.SelectionLength = 0;
            rtBox.SelectionColor = color;
            rtBox.AppendText(text);
            rtBox.SelectionColor = rtBox.ForeColor;
        }
        */
        private void MS_ClearCMD_Click(object sender, EventArgs e)
        {
            txtCmd.Clear();
            txtCmd.Refresh();
        }

        private void MS_FontSet_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = txtCmd.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCmd.Font = fontDialog1.Font;
                //txtCmd.Font = fontDialog1.Font;
            }
        }

        private void MS_SelectAll_Click(object sender, EventArgs e)
        {
            txtCmd.SelectAll();
        }

        private void MS_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtCmd.SelectedText);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtCmd.Text))
            {
                MS_ClearCMD.Enabled = false;
                MS_FontSet.Enabled = false;
                MS_SelectAll.Enabled = false;
                MS_Copy.Enabled = false;
            }
            else
            {
                MS_ClearCMD.Enabled = true;
                MS_FontSet.Enabled = true;
                MS_SelectAll.Enabled = true;
                MS_Copy.Enabled = true;
            }
        }
        
    }

    public static class RichTextBoxExtension
    {
        public static void AppendTextColorful(this RichTextBox rtBox, string text, Color color, bool addNewLine = true)
        {
            if (addNewLine)
            {
                text += Environment.NewLine;
            }
            rtBox.SelectionStart = rtBox.TextLength;
            rtBox.SelectionLength = 0;
            rtBox.SelectionColor = color;
            rtBox.AppendText(text);
            rtBox.SelectionColor = rtBox.ForeColor;
        }
    }

}
