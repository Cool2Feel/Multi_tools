namespace LeafSoft.PartPanel
{
    partial class PingPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPing = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nmPingCount = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MSI_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.nmInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textInterval = new System.Windows.Forms.TextBox();
            this.textPingCount = new System.Windows.Forms.TextBox();
            this.txtServerIP = new IpBoxControl.IpTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtCmd = new LeafSoft.LeafControl.CMDTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmPingCount)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmInterval)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnPing
            // 
            resources.ApplyResources(this.btnPing, "btnPing");
            this.btnPing.Name = "btnPing";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // nmPingCount
            // 
            resources.ApplyResources(this.nmPingCount, "nmPingCount");
            this.nmPingCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmPingCount.Name = "nmPingCount";
            this.nmPingCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmPingCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmPingCount_KeyPress);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSI_Clear});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            // 
            // MSI_Clear
            // 
            resources.ApplyResources(this.MSI_Clear, "MSI_Clear");
            this.MSI_Clear.Name = "MSI_Clear";
            this.MSI_Clear.Click += new System.EventHandler(this.MSI_Clear_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // nmInterval
            // 
            resources.ApplyResources(this.nmInterval, "nmInterval");
            this.nmInterval.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.nmInterval.Name = "nmInterval";
            this.nmInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmInterval_KeyPress);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.textInterval);
            this.panel1.Controls.Add(this.textPingCount);
            this.panel1.Controls.Add(this.txtServerIP);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnPing);
            this.panel1.Controls.Add(this.nmInterval);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nmPingCount);
            this.panel1.Name = "panel1";
            // 
            // textInterval
            // 
            resources.ApplyResources(this.textInterval, "textInterval");
            this.textInterval.Name = "textInterval";
            this.textInterval.TextChanged += new System.EventHandler(this.textInterval_TextChanged);
            this.textInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPingCount_KeyPress);
            // 
            // textPingCount
            // 
            resources.ApplyResources(this.textPingCount, "textPingCount");
            this.textPingCount.Name = "textPingCount";
            this.textPingCount.TextChanged += new System.EventHandler(this.textPingCount_TextChanged);
            this.textPingCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPingCount_KeyPress);
            // 
            // txtServerIP
            // 
            resources.ApplyResources(this.txtServerIP, "txtServerIP");
            this.txtServerIP.Name = "txtServerIP";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5")});
            this.comboBox1.Name = "comboBox1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Name = "textBox1";
            this.textBox1.TabStop = false;
            this.textBox1.WaterColor = System.Drawing.Color.DarkGray;
            this.textBox1.WaterText = ">Enter the CMD command: Enter (Enter Confirmation)";
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // txtCmd
            // 
            resources.ApplyResources(this.txtCmd, "txtCmd");
            this.txtCmd.BackColor = System.Drawing.Color.Black;
            this.txtCmd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCmd.ContextMenuStrip = this.contextMenuStrip1;
            this.txtCmd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCmd.ForeColor = System.Drawing.Color.White;
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.ReadOnly = true;
            this.txtCmd.TabStop = false;
            this.txtCmd.Click += new System.EventHandler(this.txtCmd_Click);
            // 
            // PingPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCmd);
            this.Name = "PingPanel";
            this.Load += new System.EventHandler(this.PingPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmPingCount)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmInterval)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPing;
        private LeafControl.CMDTextBox txtCmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmPingCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MSI_Clear;
        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinWaterTextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private IpBoxControl.IpTextBox txtServerIP;
        private System.Windows.Forms.TextBox textInterval;
        private System.Windows.Forms.TextBox textPingCount;
    }
}
