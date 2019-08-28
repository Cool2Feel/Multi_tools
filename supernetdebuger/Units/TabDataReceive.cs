using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PopupTool;

namespace LeafSoft.Units
{
    public partial class TabDataReceive : UserControl
    {
        List<Units.DataReceive> lstDataReceive = new List<DataReceive>();

        public TabDataReceive()
        {
            InitializeComponent();
            tabData.ContextMenuStrip = CMenu;
        }

        private Units.DataReceive AddNewDataReceive(string SourceName)
        {
            TabPage tpage = new TabPage();
            tpage.Disposed += new EventHandler(tpage_Disposed);
            tpage.Text = SourceName;
            Units.DataReceive UDataReceive = new DataReceive();
            UDataReceive.Name = SourceName;
            tpage.Controls.Add(UDataReceive);
            UDataReceive.Dock = DockStyle.Fill;
            lstDataReceive.Add(UDataReceive);
            
            this.Invoke(new MethodInvoker(delegate
            {
                tabData.TabPages.Add(tpage);
            }));
            return UDataReceive;
        }

        void tpage_Disposed(object sender, EventArgs e)
        {
            TabPage tpage = (TabPage)sender;
            lstDataReceive.Remove(lstDataReceive.Find(p => p.Name == tpage.Text));
        }

        #region 公有方法
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="SourceName">来源名称</param>
        /// <param name="data">字节数组</param>
        public void AddData(string SourceName, byte[] data)
        {
            Units.DataReceive UDataReceive = lstDataReceive.Find(p => p.Name == SourceName);
            if (UDataReceive == null)
            {
                UDataReceive = AddNewDataReceive(SourceName);
            }
            UDataReceive.AddData(data);
        }
        #endregion

        #region Tab页标题快捷菜单
        private void tabData_DoubleClick(object sender, EventArgs e)
        {
            this.tabData.SelectedTab.Dispose();
        }

        private void MS_Close_Click(object sender, EventArgs e)
        {
            this.tabData.SelectedTab.Dispose();
        }

        private void MS_CloseALL_Click(object sender, EventArgs e)
        {
            foreach(TabPage tpage in this.tabData.TabPages)
            {
                tpage.Dispose();
            }
        }

        private void MS_CloseOthers_Click(object sender, EventArgs e)
        {
            foreach (TabPage tpage in this.tabData.TabPages)
            {
                if (tpage != this.tabData.SelectedTab)
                {
                    tpage.Dispose();
                }
            }
        }

        #endregion
        #region Tab 页关闭
        private Image icon = Properties.Resources.close;
        private int iconWidth = 20;
        private Brush biaocolor = Brushes.LightGray; //选项卡的背景色
        private void tabData_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = tabData.GetTabRect(e.Index);
            if (e.Index == tabData.SelectedIndex)    //当前选中的Tab页，设置不同的样式以示选中
            {
                Brush selected_color = Brushes.DeepSkyBlue; //选中的项的背景色
                g.FillRectangle(selected_color, r); //改变选项卡标签的背景色
                string title = tabData.TabPages[e.Index].Text + "  ";
                g.DrawString(title, this.Font, new SolidBrush(Color.Black), new PointF(r.X + 3, r.Y + 6));//PointF选项卡标题的位置
                r.Offset(r.Width - iconWidth, 2);
                g.DrawImage(icon, new Point(r.X - 2, r.Y));//选项卡上的图标的位置 fntTab = new System.Drawing.Font(e.Font, FontStyle.Bold);
            }
            else//非选中的
            {
                g.FillRectangle(biaocolor, r); //改变选项卡标签的背景色
                string title = tabData.TabPages[e.Index].Text + "  ";
                g.DrawString(title, this.Font, new SolidBrush(Color.Black), new PointF(r.X + 3, r.Y + 6));//PointF选项卡标题的位置
                r.Offset(r.Width - iconWidth, 2);
                g.DrawImage(icon, new Point(r.X - 2, r.Y ));//选项卡上的图标的位置
            }
        }

        private void tabData_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X, y = e.Y;
                //计算关闭区域   
                Rectangle myTabRect = this.tabData.GetTabRect(this.tabData.SelectedIndex);

                myTabRect.Offset(myTabRect.Width - iconWidth, 2);
                myTabRect.Width = 20;
                myTabRect.Height = 20;

                //如果鼠标在区域内就关闭选项卡   
                bool isClose = x > myTabRect.X && x < myTabRect.Right && y > myTabRect.Y && y < myTabRect.Bottom;
                if (isClose == true)
                {
                    //this.tabData.TabPages.Remove(this.tabData.SelectedTab);
                    this.tabData.SelectedTab.Dispose();
                }
            }
        }
        #endregion
    }
}
