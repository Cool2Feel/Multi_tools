namespace LeafSoft.Units
{
    partial class NetTCPServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetTCPServer));
            this.btnListen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nmServerPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lstConn = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Clearn = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxServerIP = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmServerPort)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            resources.ApplyResources(this.btnListen, "btnListen");
            this.btnListen.Name = "btnListen";
            this.toolTip1.SetToolTip(this.btnListen, resources.GetString("btnListen.ToolTip"));
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // nmServerPort
            // 
            resources.ApplyResources(this.nmServerPort, "nmServerPort");
            this.nmServerPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmServerPort.Name = "nmServerPort";
            this.toolTip1.SetToolTip(this.nmServerPort, resources.GetString("nmServerPort.ToolTip"));
            this.nmServerPort.Value = new decimal(new int[] {
            2756,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // lstConn
            // 
            resources.ApplyResources(this.lstConn, "lstConn");
            this.lstConn.ContextMenuStrip = this.contextMenuStrip1;
            this.lstConn.DisplayMember = "Name";
            this.lstConn.FormattingEnabled = true;
            this.lstConn.Name = "lstConn";
            this.lstConn.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.toolTip1.SetToolTip(this.lstConn, resources.GetString("lstConn.ToolTip"));
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Delete,
            this.MS_Clearn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.toolTip1.SetToolTip(this.contextMenuStrip1, resources.GetString("contextMenuStrip1.ToolTip"));
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // MS_Delete
            // 
            resources.ApplyResources(this.MS_Delete, "MS_Delete");
            this.MS_Delete.Name = "MS_Delete";
            this.MS_Delete.Click += new System.EventHandler(this.MS_Delete_Click);
            // 
            // MS_Clearn
            // 
            resources.ApplyResources(this.MS_Clearn, "MS_Clearn");
            this.MS_Clearn.Name = "MS_Clearn";
            this.MS_Clearn.Click += new System.EventHandler(this.MS_Clearn_Click);
            // 
            // cbxServerIP
            // 
            resources.ApplyResources(this.cbxServerIP, "cbxServerIP");
            this.cbxServerIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cbxServerIP.DropDownHeight = 100;
            this.cbxServerIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServerIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.cbxServerIP.FormattingEnabled = true;
            this.cbxServerIP.Items.AddRange(new object[] {
            resources.GetString("cbxServerIP.Items")});
            this.cbxServerIP.Name = "cbxServerIP";
            this.toolTip1.SetToolTip(this.cbxServerIP, resources.GetString("cbxServerIP.ToolTip"));
            // 
            // NetTCPServer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.cbxServerIP);
            this.Controls.Add(this.lstConn);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmServerPort);
            this.Controls.Add(this.label1);
            this.Name = "NetTCPServer";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            ((System.ComponentModel.ISupportInitialize)(this.nmServerPort)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmServerPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstConn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_Delete;
        private System.Windows.Forms.ComboBox cbxServerIP;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem MS_Clearn;
    }
}
