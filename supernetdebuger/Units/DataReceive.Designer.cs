namespace LeafSoft.Units
{
    partial class DataReceive
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataReceive));
            this.txtData = new System.Windows.Forms.TextBox();
            this.CMS_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToInt = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToFloat = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToDouble = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxAutoLine = new System.Windows.Forms.CheckBox();
            this.rbtnHex = new System.Windows.Forms.RadioButton();
            this.rbtnASCII = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.LinkLabel();
            this.rbtnUTF8 = new System.Windows.Forms.RadioButton();
            this.rbtnGB2312 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CMS_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtData
            // 
            resources.ApplyResources(this.txtData, "txtData");
            this.txtData.ContextMenuStrip = this.CMS_Main;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Click += new System.EventHandler(this.txtData_Click);
            // 
            // CMS_Main
            // 
            resources.ApplyResources(this.CMS_Main, "CMS_Main");
            this.CMS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Find,
            this.MS_Clear,
            this.MS_ToInt,
            this.MS_ToFloat,
            this.MS_ToDouble});
            this.CMS_Main.Name = "contextMenuStrip1";
            this.CMS_Main.ShowImageMargin = false;
            this.CMS_Main.VisibleChanged += new System.EventHandler(this.CMS_Main_VisibleChanged);
            // 
            // MS_Find
            // 
            resources.ApplyResources(this.MS_Find, "MS_Find");
            this.MS_Find.Name = "MS_Find";
            this.MS_Find.Click += new System.EventHandler(this.MS_Find_Click);
            // 
            // MS_Clear
            // 
            resources.ApplyResources(this.MS_Clear, "MS_Clear");
            this.MS_Clear.Name = "MS_Clear";
            this.MS_Clear.Click += new System.EventHandler(this.MS_Clear_Click);
            // 
            // MS_ToInt
            // 
            resources.ApplyResources(this.MS_ToInt, "MS_ToInt");
            this.MS_ToInt.Name = "MS_ToInt";
            this.MS_ToInt.Click += new System.EventHandler(this.MS_ToInt_Click);
            // 
            // MS_ToFloat
            // 
            resources.ApplyResources(this.MS_ToFloat, "MS_ToFloat");
            this.MS_ToFloat.Name = "MS_ToFloat";
            this.MS_ToFloat.Click += new System.EventHandler(this.MS_ToFloat_Click);
            // 
            // MS_ToDouble
            // 
            resources.ApplyResources(this.MS_ToDouble, "MS_ToDouble");
            this.MS_ToDouble.Name = "MS_ToDouble";
            this.MS_ToDouble.Click += new System.EventHandler(this.MS_ToDouble_Click);
            // 
            // cbxAutoLine
            // 
            resources.ApplyResources(this.cbxAutoLine, "cbxAutoLine");
            this.cbxAutoLine.Checked = true;
            this.cbxAutoLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoLine.Name = "cbxAutoLine";
            this.cbxAutoLine.UseVisualStyleBackColor = true;
            // 
            // rbtnHex
            // 
            resources.ApplyResources(this.rbtnHex, "rbtnHex");
            this.rbtnHex.Checked = true;
            this.rbtnHex.Name = "rbtnHex";
            this.rbtnHex.TabStop = true;
            this.rbtnHex.UseVisualStyleBackColor = true;
            this.rbtnHex.CheckedChanged += new System.EventHandler(this.rbtnHex_CheckedChanged);
            // 
            // rbtnASCII
            // 
            resources.ApplyResources(this.rbtnASCII, "rbtnASCII");
            this.rbtnASCII.Name = "rbtnASCII";
            this.rbtnASCII.UseVisualStyleBackColor = true;
            this.rbtnASCII.CheckedChanged += new System.EventHandler(this.rbtnASCII_CheckedChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lblCount
            // 
            resources.ApplyResources(this.lblCount, "lblCount");
            this.lblCount.Name = "lblCount";
            this.lblCount.TabStop = true;
            this.lblCount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCount_LinkClicked);
            // 
            // rbtnUTF8
            // 
            resources.ApplyResources(this.rbtnUTF8, "rbtnUTF8");
            this.rbtnUTF8.Name = "rbtnUTF8";
            this.rbtnUTF8.UseVisualStyleBackColor = true;
            this.rbtnUTF8.CheckedChanged += new System.EventHandler(this.rbtnUTF8_CheckedChanged);
            // 
            // rbtnGB2312
            // 
            resources.ApplyResources(this.rbtnGB2312, "rbtnGB2312");
            this.rbtnGB2312.Name = "rbtnGB2312";
            this.rbtnGB2312.UseVisualStyleBackColor = true;
            this.rbtnGB2312.CheckedChanged += new System.EventHandler(this.rbtnGB2312_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Name = "label2";
            // 
            // DataReceive
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnGB2312);
            this.Controls.Add(this.rbtnUTF8);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.rbtnASCII);
            this.Controls.Add(this.rbtnHex);
            this.Controls.Add(this.cbxAutoLine);
            this.Name = "DataReceive";
            this.CMS_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.CheckBox cbxAutoLine;
        private System.Windows.Forms.RadioButton rbtnHex;
        private System.Windows.Forms.RadioButton rbtnASCII;
        private System.Windows.Forms.ContextMenuStrip CMS_Main;
        private System.Windows.Forms.ToolStripMenuItem MS_Clear;
        private System.Windows.Forms.ToolStripMenuItem MS_ToInt;
        private System.Windows.Forms.ToolStripMenuItem MS_ToFloat;
        private System.Windows.Forms.ToolStripMenuItem MS_ToDouble;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lblCount;
        private System.Windows.Forms.RadioButton rbtnUTF8;
        private System.Windows.Forms.RadioButton rbtnGB2312;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem MS_Find;
    }
}
