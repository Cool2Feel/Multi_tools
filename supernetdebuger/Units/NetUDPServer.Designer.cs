namespace LeafSoft.Units
{
    partial class NetUDPServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetUDPServer));
            this.btnListen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nmLocalPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lstConn = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Clearn = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxLocalIP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmLocalPort)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            resources.ApplyResources(this.btnListen, "btnListen");
            this.btnListen.Name = "btnListen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // nmLocalPort
            // 
            resources.ApplyResources(this.nmLocalPort, "nmLocalPort");
            this.nmLocalPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmLocalPort.Name = "nmLocalPort";
            this.nmLocalPort.Value = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lstConn
            // 
            resources.ApplyResources(this.lstConn, "lstConn");
            this.lstConn.ContextMenuStrip = this.contextMenuStrip1;
            this.lstConn.FormattingEnabled = true;
            this.lstConn.Name = "lstConn";
            this.lstConn.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Delete,
            this.MS_Clearn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
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
            // cbxLocalIP
            // 
            resources.ApplyResources(this.cbxLocalIP, "cbxLocalIP");
            this.cbxLocalIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cbxLocalIP.DropDownHeight = 100;
            this.cbxLocalIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocalIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.cbxLocalIP.FormattingEnabled = true;
            this.cbxLocalIP.Items.AddRange(new object[] {
            resources.GetString("cbxLocalIP.Items")});
            this.cbxLocalIP.Name = "cbxLocalIP";
            // 
            // NetUDPServer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.cbxLocalIP);
            this.Controls.Add(this.lstConn);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmLocalPort);
            this.Name = "NetUDPServer";
            ((System.ComponentModel.ISupportInitialize)(this.nmLocalPort)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmLocalPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstConn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_Delete;
        private new System.Windows.Forms.ComboBox cbxLocalIP;
        private System.Windows.Forms.ToolStripMenuItem MS_Clearn;
    }
}
