﻿namespace LeafSoft.Units
{
    partial class NetTCPClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetTCPClient));
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConn = new System.Windows.Forms.Button();
            this.lstConn = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Clearn = new System.Windows.Forms.ToolStripMenuItem();
            this.nmServerPort = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmServerPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // txtServerIP
            // 
            resources.ApplyResources(this.txtServerIP, "txtServerIP");
            this.txtServerIP.Name = "txtServerIP";
            this.toolTip1.SetToolTip(this.txtServerIP, resources.GetString("txtServerIP.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // btnConn
            // 
            resources.ApplyResources(this.btnConn, "btnConn");
            this.btnConn.Name = "btnConn";
            this.toolTip1.SetToolTip(this.btnConn, resources.GetString("btnConn.ToolTip"));
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
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
            // nmServerPort
            // 
            resources.ApplyResources(this.nmServerPort, "nmServerPort");
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
            // NetTCPClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lstConn);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.nmServerPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.label2);
            this.Name = "NetTCPClient";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmServerPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.ListBox lstConn;
        private System.Windows.Forms.NumericUpDown nmServerPort;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_Delete;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem MS_Clearn;
    }
}
