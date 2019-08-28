using LeafSoft.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft
{
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
            if (LanguageSet.Language == "0")
            {
                LanguageSet.SetLang("", this, typeof(frmCheck));
            }
            else
            {
                LanguageSet.SetLang("en-US", this, typeof(frmCheck));
            }
        }

        #region 校验码计算
        /// <summary>
        /// 校验和
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_CheckSum_Click(object sender, EventArgs e)
        {
            Model.CMD cmd = txtContent.GetCMD();
            if (cmd != null)
            {
                byte check = Lib.BytesCheck.GetXOR(cmd.Bytes);
                txtContent.AppendText(Convert.ToString(check, 16).PadLeft(2, '0'));
            }
        }

        /// <summary>
        /// KTC CRC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_KTC_Click(object sender, EventArgs e)
        {
            Model.CMD cmd = txtContent.GetCMD();
            if (cmd != null)
            {
                byte check = Lib.BytesCheck.GetKTC(cmd.Bytes);
                txtContent.AppendText(Convert.ToString(check, 16).PadLeft(2, '0'));
            }
        }

        /// <summary>
        /// Modbus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_CRC16_Click(object sender, EventArgs e)
        {
            Model.CMD cmd = txtContent.GetCMD();
            if (cmd != null)
            {
                AppendToContent(Lib.BytesCheck.GetCRC16(cmd.Bytes, false));
            }
        }

        /// <summary>
        /// 多项式CRC16 高位在前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_CRCPolyH_Click(object sender, EventArgs e)
        {
            Model.CMD cmd = txtContent.GetCMD();
            if (cmd != null)
            {
                frmPoly fpoly = new frmPoly();
                if (fpoly.ShowDialog() == DialogResult.OK)
                {
                    AppendToContent(Lib.BytesCheck.GetCRC16ByPoly(cmd.Bytes, fpoly.Poly, true));
                }
            }
        }

        /// <summary>
        /// 多项式CRC16 低位在前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_CRCPolyL_Click(object sender, EventArgs e)
        {
            Model.CMD cmd = txtContent.GetCMD();
            if (cmd != null)
            {
                frmPoly fpoly = new frmPoly();
                if (fpoly.ShowDialog() == DialogResult.OK)
                {
                    AppendToContent(Lib.BytesCheck.GetCRC16ByPoly(cmd.Bytes, fpoly.Poly, false));
                }
            }
        }

        private void AppendToContent(byte[] check)
        {
            foreach (byte b in check)
            {
                txtContent.AppendText(string.Format("{0:X2}", b));
            }
        }
        #endregion

        private void CM_Clear_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
        }

        private void MS_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtContent.Text);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(txtContent.Text == "")
            {
                CM_Check.Enabled = false;
                MS_Copy.Enabled = false;
            }
            else
            {
                CM_Check.Enabled = true;
                MS_Copy.Enabled = true;
            }
        }
    }
}
