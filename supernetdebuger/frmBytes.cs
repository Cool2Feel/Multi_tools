﻿using LeafSoft.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft
{
    public partial class frmBytes : Form
    {
        public frmBytes()
        {
            InitializeComponent();
            if (LanguageSet.Language == "0")
            {
                LanguageSet.SetLang("", this, typeof(frmBytes));
            }
            else
            {
                LanguageSet.SetLang("en-US", this, typeof(frmBytes));
            }
        }

        private void CMS_Main_VisibleChanged(object sender, EventArgs e)
        {
            if (CMS_Main.Visible == true)
            {//当前显示为Hex模式，且菜单被显示
                string[] SelectData = txtData.Text.TrimEnd().TrimStart().Split(' ');//获取选中部分文本
                if (SelectData.Length == 2)
                {
                    MS_ToInt.Enabled = true;
                    MS_ToFloat.Enabled = false;
                    MS_ToDouble.Enabled = false;
                }
                else if (SelectData.Length == 4)
                {
                    MS_ToInt.Enabled = true;
                    MS_ToFloat.Enabled = true;
                    MS_ToDouble.Enabled = false;
                }
                else if (SelectData.Length == 8)
                {
                    MS_ToInt.Enabled = false;
                    MS_ToFloat.Enabled = false;
                    MS_ToDouble.Enabled = true;
                }
                else
                {
                    MS_ToInt.Enabled = false;
                    MS_ToFloat.Enabled = false;
                    MS_ToDouble.Enabled = false;
                }
            }
        }

        private void MS_Clear_Click(object sender, EventArgs e)
        {
            txtData.Clear();
        }

        #region 数值转换
        /// <summary>
        /// 2字节或4字节转换为整数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_ToInt_Click(object sender, EventArgs e)
        {
            string[] SelectData = txtData.Text.TrimEnd().TrimStart().Split(' ');//获取选中部分文本
            byte[] IntByte = StringsToBytes(SelectData);
            if (BitConverter.IsLittleEndian) // 若为 小端模式
            {
                Array.Reverse(IntByte); // 转换为 大端模式  
            }
            if (IntByte.Length == 2)
            {
                txtValue.Text = BitConverter.ToInt16(IntByte, 0).ToString();
            }
            else if (IntByte.Length == 4)
            {
                txtValue.Text = BitConverter.ToInt32(IntByte, 0).ToString();
            }
        }
        /// <summary>
        /// 4字节转换为单精度浮点数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_ToFloat_Click(object sender, EventArgs e)
        {
            string[] SelectData = txtData.Text.TrimEnd().TrimStart().Split(' ');//获取选中部分文本
            byte[] IntByte = StringsToBytes(SelectData);
            if (BitConverter.IsLittleEndian) // 若为 小端模式
            {
                Array.Reverse(IntByte); // 转换为 大端模式  
            }
            txtValue.Text = BitConverter.ToSingle(IntByte, 0).ToString();
        }
        /// <summary>
        /// 8字节转换为双精度浮点数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_ToDouble_Click(object sender, EventArgs e)
        {
            string[] SelectData = txtData.Text.TrimEnd().TrimStart().Split(' ');//获取选中部分文本
            byte[] IntByte = StringsToBytes(SelectData);
            if (BitConverter.IsLittleEndian) // 若为 小端模式
            {
                Array.Reverse(IntByte); // 转换为 大端模式  
            }
            txtValue.Text = BitConverter.ToDouble(IntByte, 0).ToString();
        }

        /// <summary>
        /// 16进制字符串数组转byte数组
        /// </summary>
        /// <param name="B"></param>
        /// <returns></returns>
        private byte[] StringsToBytes(string[] B)
        {
            byte[] BToInt32 = new byte[B.Length];
            for (int i = 0; i < B.Length; i++)
            {
                BToInt32[i] = (byte)Convert.ToInt32(B[i], 16);
            }
            return BToInt32;
        }
        #endregion

        #region 字节转换
        private void MS_ClearValue_Click(object sender, EventArgs e)
        {
            txtValue.Clear();
        }

        private void MS_ShortToBytes_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = BitConverter.GetBytes(Convert.ToInt16(txtValue.Text));
                //Array.Reverse(b);
                if (BitConverter.IsLittleEndian) // 若为 小端模式
                {
                    Array.Reverse(b); // 转换为 大端模式  
                }
                txtData.SetCMD(new Model.CMD(Lib.EnumType.DataEncode.Hex,b));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                                + "\n Int16 MinValue：" + Int16.MinValue.ToString()
                                + "\n Int16 MaxValue：" + Int16.MaxValue.ToString());
            }
        }

        private void MS_IntToBytes_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = BitConverter.GetBytes(Convert.ToInt32(txtValue.Text));
                if (BitConverter.IsLittleEndian) // 若为 小端模式
                {
                    Array.Reverse(b); // 转换为 大端模式  
                }
                txtData.SetCMD(new Model.CMD(Lib.EnumType.DataEncode.Hex, b));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                                 + "\n Int32 MinValue：" + Int32.MinValue.ToString()
                                 + "\n Int32 MaxValue：" + Int32.MaxValue.ToString());
            }
        }

        private void MS_FloatToBytes_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = BitConverter.GetBytes(Convert.ToSingle(txtValue.Text));
                if (BitConverter.IsLittleEndian) // 若为 小端模式
                {
                    Array.Reverse(b); // 转换为 大端模式  
                }
                txtData.SetCMD(new Model.CMD(Lib.EnumType.DataEncode.Hex, b));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                                + "\n Float MinValue：" + Single.MinValue.ToString()
                                + "\n Float MinValue：" + Single.MinValue.ToString());
            }
        }

        private void MS_DoubleToBytes_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = BitConverter.GetBytes(Convert.ToDouble(txtValue.Text));
                if (BitConverter.IsLittleEndian) // 若为 小端模式
                {
                    Array.Reverse(b); // 转换为 大端模式  
                }
                txtData.SetCMD(new Model.CMD(Lib.EnumType.DataEncode.Hex, b));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                                + "\n Double MinValue：" + Double.MinValue.ToString()
                                + "\n Double MaxValue：" + Double.MaxValue.ToString());
            }
        }

        #endregion

        private void CMS_Main_Opening(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtData.Text))
            {
                MS_ToInt.Enabled = false;
                MS_ToFloat.Enabled = true;
                MS_ToDouble.Enabled = false;
            }
            else
            {
                MS_ToInt.Enabled = true;
                MS_ToFloat.Enabled = false;
                MS_ToDouble.Enabled = true;
            }
        }

        private void CMS_Value_Opening(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtValue.Text))
            {
                MS_ShortToBytes.Enabled = false;
                MS_IntToBytes.Enabled = false;
                MS_FloatToBytes.Enabled = false;
                MS_DoubleToBytes.Enabled = false;
            }
            else
            {
                MS_ShortToBytes.Enabled = true;
                MS_IntToBytes.Enabled = true;
                MS_FloatToBytes.Enabled = true;
                MS_DoubleToBytes.Enabled = true;
            }
        }
    }
}
