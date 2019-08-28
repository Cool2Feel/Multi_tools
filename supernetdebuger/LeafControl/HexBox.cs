using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft.Units
{
    public class HexBox : TextBox
    {
        public HexBox()
        {
        }
        #region 输入控制
        protected override void OnTextChanged(EventArgs e)
        {
            this.Text = this.Text.TrimEnd().ToUpper();
            this.SelectionStart = this.Text.Length;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9')//数字0-9键   
                     || (e.KeyChar >= 'A' && e.KeyChar <= 'F')//字母A-F 
                     || (e.KeyChar >= 'a' && e.KeyChar <= 'f')//字母a-f 
                     || e.KeyChar == 0x08//退格键
                     || e.KeyChar == 0x03//拷贝
                     || e.KeyChar == 0x18)//剪切
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }
        #endregion
    }
}
