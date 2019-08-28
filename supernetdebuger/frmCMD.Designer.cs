namespace LeafSoft
{
    partial class frmCMD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCMD));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MSI_Hex = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_ASCII = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_UTF8 = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_GB2312 = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_Check = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CheckSum = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_KTC = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRC16 = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRCPoly = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRCPolyH = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CRCPolyL = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ami_Tips = new EASkins.Ami_TextBox();
            this.txtContent = new LeafSoft.LeafControl.BytesBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSI_Hex,
            this.MSI_ASCII,
            this.MSI_UTF8,
            this.MSI_GB2312,
            this.CM_Check,
            this.CM_Clear});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            // 
            // MSI_Hex
            // 
            resources.ApplyResources(this.MSI_Hex, "MSI_Hex");
            this.MSI_Hex.Name = "MSI_Hex";
            this.MSI_Hex.Click += new System.EventHandler(this.MSI_Hex_Click);
            // 
            // MSI_ASCII
            // 
            resources.ApplyResources(this.MSI_ASCII, "MSI_ASCII");
            this.MSI_ASCII.Name = "MSI_ASCII";
            this.MSI_ASCII.Click += new System.EventHandler(this.MSI_ASCII_Click);
            // 
            // MSI_UTF8
            // 
            resources.ApplyResources(this.MSI_UTF8, "MSI_UTF8");
            this.MSI_UTF8.Name = "MSI_UTF8";
            this.MSI_UTF8.Click += new System.EventHandler(this.MSI_UTF8_Click);
            // 
            // MSI_GB2312
            // 
            resources.ApplyResources(this.MSI_GB2312, "MSI_GB2312");
            this.MSI_GB2312.Name = "MSI_GB2312";
            this.MSI_GB2312.Click += new System.EventHandler(this.MSI_GB2312_Click);
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
            // CM_Clear
            // 
            resources.ApplyResources(this.CM_Clear, "CM_Clear");
            this.CM_Clear.Name = "CM_Clear";
            this.CM_Clear.Click += new System.EventHandler(this.CM_Clear_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ami_Tips
            // 
            resources.ApplyResources(this.ami_Tips, "ami_Tips");
            this.ami_Tips.BackColor = System.Drawing.Color.Transparent;
            this.ami_Tips.ForeColor = System.Drawing.Color.DimGray;
            this.ami_Tips.MaxLength = 32767;
            this.ami_Tips.Multiline = false;
            this.ami_Tips.Name = "ami_Tips";
            this.ami_Tips.ReadOnly = false;
            this.ami_Tips.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ami_Tips.UseSystemPasswordChar = false;
            // 
            // txtContent
            // 
            resources.ApplyResources(this.txtContent, "txtContent");
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContent.ContextMenuStrip = this.contextMenuStrip1;
            this.txtContent.EncodeType = LeafSoft.Lib.EnumType.DataEncode.Hex;
            this.txtContent.Name = "txtContent";
            // 
            // frmCMD
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.ami_Tips);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCMD";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LeafControl.BytesBox txtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MSI_ASCII;
        private System.Windows.Forms.ToolStripMenuItem CM_Check;
        private System.Windows.Forms.ToolStripMenuItem CM_Clear;
        private System.Windows.Forms.ToolStripMenuItem MS_CheckSum;
        private System.Windows.Forms.ToolStripMenuItem MS_CRC16;
        private System.Windows.Forms.ToolStripMenuItem MS_CRCPoly;
        private System.Windows.Forms.ToolStripMenuItem MS_CRCPolyH;
        private System.Windows.Forms.ToolStripMenuItem MS_CRCPolyL;
        private System.Windows.Forms.ToolStripMenuItem MSI_Hex;
        private System.Windows.Forms.ToolStripMenuItem MSI_UTF8;
        private System.Windows.Forms.ToolStripMenuItem MSI_GB2312;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem MS_KTC;
        private System.Windows.Forms.Label label3;
        private EASkins.Ami_TextBox ami_Tips;
    }
}