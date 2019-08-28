namespace LeafSoft.PartPanel
{
    partial class ComPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComPanel));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_ClearCMD = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_FontSet = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnSuper = new System.Windows.Forms.Button();
            this.DataSender = new LeafSoft.Units.DataSend();
            this.Configer = new LeafSoft.Units.NetRs232();
            this.txtCmd = new LeafSoft.LeafControl.CMDTextBox();
            this.DataReceiver = new LeafSoft.Units.DataReceive();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_ClearCMD,
            this.MS_FontSet,
            this.MS_SelectAll,
            this.MS_Copy});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // MS_ClearCMD
            // 
            this.MS_ClearCMD.Name = "MS_ClearCMD";
            resources.ApplyResources(this.MS_ClearCMD, "MS_ClearCMD");
            this.MS_ClearCMD.Click += new System.EventHandler(this.MS_ClearCMD_Click);
            // 
            // MS_FontSet
            // 
            this.MS_FontSet.Name = "MS_FontSet";
            resources.ApplyResources(this.MS_FontSet, "MS_FontSet");
            this.MS_FontSet.Click += new System.EventHandler(this.MS_FontSet_Click);
            // 
            // MS_SelectAll
            // 
            this.MS_SelectAll.Name = "MS_SelectAll";
            resources.ApplyResources(this.MS_SelectAll, "MS_SelectAll");
            this.MS_SelectAll.Click += new System.EventHandler(this.MS_SelectAll_Click);
            // 
            // MS_Copy
            // 
            this.MS_Copy.Name = "MS_Copy";
            resources.ApplyResources(this.MS_Copy, "MS_Copy");
            this.MS_Copy.Click += new System.EventHandler(this.MS_Copy_Click);
            // 
            // btnSuper
            // 
            resources.ApplyResources(this.btnSuper, "btnSuper");
            this.btnSuper.Name = "btnSuper";
            this.btnSuper.UseVisualStyleBackColor = true;
            this.btnSuper.Click += new System.EventHandler(this.btnSuper_Click);
            // 
            // DataSender
            // 
            resources.ApplyResources(this.DataSender, "DataSender");
            this.DataSender.Name = "DataSender";
            this.DataSender.EventDataSend += new LeafSoft.Lib.LeafEvent.DataSendHandler(this.DataSender_EventDataSend);
            // 
            // Configer
            // 
            this.Configer.BackColor = System.Drawing.Color.White;
            this.Configer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Configer, "Configer");
            this.Configer.Name = "Configer";
            this.Configer.DataReceived += new LeafSoft.Lib.LeafEvent.DataReceivedHandler(this.Configer_DataReceived);
            // 
            // txtCmd
            // 
            resources.ApplyResources(this.txtCmd, "txtCmd");
            this.txtCmd.BackColor = System.Drawing.Color.Black;
            this.txtCmd.ContextMenuStrip = this.contextMenuStrip1;
            this.txtCmd.ForeColor = System.Drawing.Color.White;
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.DataSend += new LeafSoft.Lib.LeafEvent.DataSendHandler(this.txtCmd_DataSend);
            // 
            // DataReceiver
            // 
            resources.ApplyResources(this.DataReceiver, "DataReceiver");
            this.DataReceiver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataReceiver.Name = "DataReceiver";
            // 
            // ComPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.txtCmd);
            this.Controls.Add(this.DataReceiver);
            this.Controls.Add(this.btnSuper);
            this.Controls.Add(this.DataSender);
            this.Controls.Add(this.Configer);
            this.Name = "ComPanel";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_ClearCMD;
        private System.Windows.Forms.ToolStripMenuItem MS_FontSet;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnSuper;
        public Units.DataSend DataSender;
        public Units.NetRs232 Configer;
        private LeafControl.CMDTextBox txtCmd;
        private Units.DataReceive DataReceiver;
        private System.Windows.Forms.ToolStripMenuItem MS_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem MS_Copy;
    }
}
