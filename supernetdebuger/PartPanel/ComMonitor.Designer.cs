namespace LeafSoft.PartPanel
{
    partial class ComMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComMonitor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textClear = new System.Windows.Forms.Button();
            this.chk_R = new System.Windows.Forms.CheckBox();
            this.axCCommMonitorX1 = new AxCommMonitorX.AxCCommMonitorX();
            this.comPause = new System.Windows.Forms.Button();
            this.comStart = new System.Windows.Forms.Button();
            this.comSelect = new System.Windows.Forms.ComboBox();
            this.comPort = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.appHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.redtData = new System.Windows.Forms.RichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.ctlData = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCCommMonitorX1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textClear);
            this.panel1.Controls.Add(this.chk_R);
            //this.panel1.Controls.Add(this.axCCommMonitorX1);
            this.panel1.Controls.Add(this.comPause);
            this.panel1.Controls.Add(this.comStart);
            this.panel1.Controls.Add(this.comSelect);
            this.panel1.Controls.Add(this.comPort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 54);
            this.panel1.TabIndex = 0;
            // 
            // textClear
            // 
            this.textClear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textClear.Location = new System.Drawing.Point(567, 16);
            this.textClear.Name = "textClear";
            this.textClear.Size = new System.Drawing.Size(89, 25);
            this.textClear.TabIndex = 22;
            this.textClear.Text = "Clear";
            this.textClear.UseVisualStyleBackColor = true;
            this.textClear.Click += new System.EventHandler(this.textClear_Click);
            // 
            // chk_R
            // 
            this.chk_R.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_R.AutoSize = true;
            this.chk_R.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chk_R.Location = new System.Drawing.Point(461, 18);
            this.chk_R.Name = "chk_R";
            this.chk_R.Size = new System.Drawing.Size(81, 21);
            this.chk_R.TabIndex = 21;
            this.chk_R.Text = "Raw data";
            this.chk_R.UseVisualStyleBackColor = true;
            // 
            // axCCommMonitorX1
            // 
            this.axCCommMonitorX1.Location = new System.Drawing.Point(673, 15);
            this.axCCommMonitorX1.Name = "axCCommMonitorX1";
            this.axCCommMonitorX1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCCommMonitorX1.OcxState")));
            this.axCCommMonitorX1.Size = new System.Drawing.Size(95, 27);
            this.axCCommMonitorX1.TabIndex = 20;
            this.axCCommMonitorX1.Visible = false;
            this.axCCommMonitorX1.OnMonitor += new AxCommMonitorX.ICommMonitorXEvents_OnMonitorEventHandler(this.axCCommMonitorX1_OnMonitor);
            this.axCCommMonitorX1.OnAscii += new AxCommMonitorX.ICommMonitorXEvents_OnAsciiEventHandler(this.axCCommMonitorX1_OnAscii);
            // 
            // comPause
            // 
            this.comPause.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comPause.Location = new System.Drawing.Point(258, 16);
            this.comPause.Name = "comPause";
            this.comPause.Size = new System.Drawing.Size(89, 25);
            this.comPause.TabIndex = 3;
            this.comPause.Text = "Pause";
            this.comPause.UseVisualStyleBackColor = true;
            this.comPause.Click += new System.EventHandler(this.comPause_Click);
            // 
            // comStart
            // 
            this.comStart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comStart.Location = new System.Drawing.Point(158, 16);
            this.comStart.Name = "comStart";
            this.comStart.Size = new System.Drawing.Size(89, 25);
            this.comStart.TabIndex = 2;
            this.comStart.Text = "Start";
            this.comStart.UseVisualStyleBackColor = true;
            this.comStart.Click += new System.EventHandler(this.comStart_Click);
            // 
            // comSelect
            // 
            this.comSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comSelect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comSelect.FormattingEnabled = true;
            this.comSelect.Location = new System.Drawing.Point(65, 16);
            this.comSelect.Name = "comSelect";
            this.comSelect.Size = new System.Drawing.Size(68, 25);
            this.comSelect.TabIndex = 1;
            // 
            // comPort
            // 
            this.comPort.AutoSize = true;
            this.comPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comPort.Location = new System.Drawing.Point(18, 20);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(44, 17);
            this.comPort.TabIndex = 0;
            this.comPort.Text = "串口：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTip,
            this.appHint,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 386);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(771, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTip
            // 
            this.lblTip.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblTip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(378, 17);
            this.lblTip.Spring = true;
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // appHint
            // 
            this.appHint.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.appHint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.appHint.Name = "appHint";
            this.appHint.Size = new System.Drawing.Size(378, 17);
            this.appHint.Spring = true;
            this.appHint.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 54);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 332);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // redtData
            // 
            this.redtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redtData.Location = new System.Drawing.Point(3, 54);
            this.redtData.Name = "redtData";
            this.redtData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.redtData.Size = new System.Drawing.Size(768, 227);
            this.redtData.TabIndex = 25;
            this.redtData.Text = "";
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(3, 281);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(768, 3);
            this.splitter2.TabIndex = 24;
            this.splitter2.TabStop = false;
            // 
            // ctlData
            // 
            this.ctlData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctlData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctlData.Location = new System.Drawing.Point(3, 284);
            this.ctlData.Name = "ctlData";
            this.ctlData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ctlData.Size = new System.Drawing.Size(768, 102);
            this.ctlData.TabIndex = 23;
            this.ctlData.Text = "";
            // 
            // ComMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.redtData);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.ctlData);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "ComMonitor";
            this.Size = new System.Drawing.Size(771, 408);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCCommMonitorX1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button comPause;
        private System.Windows.Forms.Button comStart;
        private System.Windows.Forms.ComboBox comSelect;
        private System.Windows.Forms.Label comPort;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTip;
        private System.Windows.Forms.ToolStripStatusLabel appHint;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private AxCommMonitorX.AxCCommMonitorX axCCommMonitorX1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RichTextBox redtData;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.RichTextBox ctlData;
        private System.Windows.Forms.CheckBox chk_R;
        private System.Windows.Forms.Button textClear;
    }
}
