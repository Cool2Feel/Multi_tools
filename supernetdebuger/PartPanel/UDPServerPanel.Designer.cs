namespace LeafSoft.PartPanel
{
    partial class UDPServerPanel
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
            this.tabDataReceiver = new LeafSoft.Units.TabDataReceive();
            this.Configer = new LeafSoft.Units.NetUDPServer();
            this.DataSender = new LeafSoft.Units.DataSend();
            this.SuspendLayout();
            // 
            // tabDataReceiver
            // 
            this.tabDataReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDataReceiver.Location = new System.Drawing.Point(2, 262);
            this.tabDataReceiver.Name = "tabDataReceiver";
            this.tabDataReceiver.Size = new System.Drawing.Size(797, 235);
            this.tabDataReceiver.TabIndex = 8;
            // 
            // Configer
            // 
            this.Configer.AutoSize = true;
            this.Configer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Configer.Location = new System.Drawing.Point(3, 2);
            this.Configer.Name = "Configer";
            this.Configer.Size = new System.Drawing.Size(174, 252);
            this.Configer.TabIndex = 7;
            this.Configer.DataReceived += new LeafSoft.Lib.LeafEvent.DataReceivedHandler(this.Configer_DataReceived);
            // 
            // DataSender
            // 
            this.DataSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSender.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataSender.Location = new System.Drawing.Point(181, 3);
            this.DataSender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataSender.Name = "DataSender";
            this.DataSender.Size = new System.Drawing.Size(616, 250);
            this.DataSender.TabIndex = 4;
            this.DataSender.EventDataSend += new LeafSoft.Lib.LeafEvent.DataSendHandler(this.DataSender_EventDataSend);
            // 
            // UDPServerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tabDataReceiver);
            this.Controls.Add(this.Configer);
            this.Controls.Add(this.DataSender);
            this.Name = "UDPServerPanel";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Units.DataSend DataSender;
        private Units.NetUDPServer Configer;
        private Units.TabDataReceive tabDataReceiver;

    }
}
