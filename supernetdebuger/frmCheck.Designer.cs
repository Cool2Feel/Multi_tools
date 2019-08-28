namespace LeafSoft
{
    partial class frmCheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheck));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CM_Check = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CheckSum = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_KTC = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRC16 = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRCPoly = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRCPolyH = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRCPolyL = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContent = new LeafSoft.LeafControl.BytesBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CM_Check,
            this.MS_Copy,
            this.CM_Clear});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // CM_Check
            // 
            resources.ApplyResources(this.CM_Check, "CM_Check");
            this.CM_Check.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_CheckSum,
            this.MS_KTC,
            this.MS_CRC16,
            this.MS_CRCPoly});
            this.CM_Check.Name = "CM_Check";
            // 
            // MS_CheckSum
            // 
            resources.ApplyResources(this.MS_CheckSum, "MS_CheckSum");
            this.MS_CheckSum.Name = "MS_CheckSum";
            this.MS_CheckSum.Click += new System.EventHandler(this.MS_CheckSum_Click);
            // 
            // MS_KTC
            // 
            resources.ApplyResources(this.MS_KTC, "MS_KTC");
            this.MS_KTC.Name = "MS_KTC";
            this.MS_KTC.Click += new System.EventHandler(this.MS_KTC_Click);
            // 
            // MS_CRC16
            // 
            resources.ApplyResources(this.MS_CRC16, "MS_CRC16");
            this.MS_CRC16.Name = "MS_CRC16";
            this.MS_CRC16.Click += new System.EventHandler(this.MS_CRC16_Click);
            // 
            // MS_CRCPoly
            // 
            resources.ApplyResources(this.MS_CRCPoly, "MS_CRCPoly");
            this.MS_CRCPoly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_CRCPolyH,
            this.MS_CRCPolyL});
            this.MS_CRCPoly.Name = "MS_CRCPoly";
            // 
            // MS_CRCPolyH
            // 
            resources.ApplyResources(this.MS_CRCPolyH, "MS_CRCPolyH");
            this.MS_CRCPolyH.Name = "MS_CRCPolyH";
            this.MS_CRCPolyH.Click += new System.EventHandler(this.MS_CRCPolyH_Click);
            // 
            // MS_CRCPolyL
            // 
            resources.ApplyResources(this.MS_CRCPolyL, "MS_CRCPolyL");
            this.MS_CRCPolyL.Name = "MS_CRCPolyL";
            this.MS_CRCPolyL.Click += new System.EventHandler(this.MS_CRCPolyL_Click);
            // 
            // MS_Copy
            // 
            resources.ApplyResources(this.MS_Copy, "MS_Copy");
            this.MS_Copy.Name = "MS_Copy";
            this.MS_Copy.Click += new System.EventHandler(this.MS_Copy_Click);
            // 
            // CM_Clear
            // 
            resources.ApplyResources(this.CM_Clear, "CM_Clear");
            this.CM_Clear.Name = "CM_Clear";
            this.CM_Clear.Click += new System.EventHandler(this.CM_Clear_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Name = "label3";
            // 
            // txtContent
            // 
            resources.ApplyResources(this.txtContent, "txtContent");
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContent.ContextMenuStrip = this.contextMenuStrip1;
            this.txtContent.EncodeType = LeafSoft.Lib.EnumType.DataEncode.Hex;
            this.txtContent.Name = "txtContent";
            // 
            // frmCheck
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCheck";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LeafControl.BytesBox txtContent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CM_Check;
        private System.Windows.Forms.ToolStripMenuItem MS_CheckSum;
        private System.Windows.Forms.ToolStripMenuItem MS_CRC16;
        private System.Windows.Forms.ToolStripMenuItem MS_CRCPoly;
        private System.Windows.Forms.ToolStripMenuItem MS_CRCPolyH;
        private System.Windows.Forms.ToolStripMenuItem MS_CRCPolyL;
        private System.Windows.Forms.ToolStripMenuItem CM_Clear;
        private System.Windows.Forms.ToolStripMenuItem MS_Copy;
        private System.Windows.Forms.ToolStripMenuItem MS_KTC;
        private System.Windows.Forms.Label label3;
    }
}