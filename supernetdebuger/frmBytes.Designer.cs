namespace LeafSoft
{
    partial class frmBytes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBytes));
            this.txtData = new LeafSoft.LeafControl.BytesBox();
            this.CMS_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToInt = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToFloat = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToDouble = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.CMS_Value = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_ClearValue = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ShortToBytes = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_IntToBytes = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_FloatToBytes = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_DoubleToBytes = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.CMS_Main.SuspendLayout();
            this.CMS_Value.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtData
            // 
            resources.ApplyResources(this.txtData, "txtData");
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.ContextMenuStrip = this.CMS_Main;
            this.txtData.EncodeType = LeafSoft.Lib.EnumType.DataEncode.Hex;
            this.txtData.Name = "txtData";
            // 
            // CMS_Main
            // 
            resources.ApplyResources(this.CMS_Main, "CMS_Main");
            this.CMS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Clear,
            this.MS_ToInt,
            this.MS_ToFloat,
            this.MS_ToDouble});
            this.CMS_Main.Name = "contextMenuStrip1";
            this.CMS_Main.ShowImageMargin = false;
            this.CMS_Main.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_Main_Opening);
            this.CMS_Main.VisibleChanged += new System.EventHandler(this.CMS_Main_VisibleChanged);
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtValue
            // 
            resources.ApplyResources(this.txtValue, "txtValue");
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.ContextMenuStrip = this.CMS_Value;
            this.txtValue.Name = "txtValue";
            // 
            // CMS_Value
            // 
            resources.ApplyResources(this.CMS_Value, "CMS_Value");
            this.CMS_Value.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_ClearValue,
            this.MS_ShortToBytes,
            this.MS_IntToBytes,
            this.MS_FloatToBytes,
            this.MS_DoubleToBytes});
            this.CMS_Value.Name = "contextMenuStrip1";
            this.CMS_Value.ShowImageMargin = false;
            this.CMS_Value.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_Value_Opening);
            // 
            // MS_ClearValue
            // 
            resources.ApplyResources(this.MS_ClearValue, "MS_ClearValue");
            this.MS_ClearValue.Name = "MS_ClearValue";
            this.MS_ClearValue.Click += new System.EventHandler(this.MS_ClearValue_Click);
            // 
            // MS_ShortToBytes
            // 
            resources.ApplyResources(this.MS_ShortToBytes, "MS_ShortToBytes");
            this.MS_ShortToBytes.Name = "MS_ShortToBytes";
            this.MS_ShortToBytes.Click += new System.EventHandler(this.MS_ShortToBytes_Click);
            // 
            // MS_IntToBytes
            // 
            resources.ApplyResources(this.MS_IntToBytes, "MS_IntToBytes");
            this.MS_IntToBytes.Name = "MS_IntToBytes";
            this.MS_IntToBytes.Click += new System.EventHandler(this.MS_IntToBytes_Click);
            // 
            // MS_FloatToBytes
            // 
            resources.ApplyResources(this.MS_FloatToBytes, "MS_FloatToBytes");
            this.MS_FloatToBytes.Name = "MS_FloatToBytes";
            this.MS_FloatToBytes.Click += new System.EventHandler(this.MS_FloatToBytes_Click);
            // 
            // MS_DoubleToBytes
            // 
            resources.ApplyResources(this.MS_DoubleToBytes, "MS_DoubleToBytes");
            this.MS_DoubleToBytes.Name = "MS_DoubleToBytes";
            this.MS_DoubleToBytes.Click += new System.EventHandler(this.MS_DoubleToBytes_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Name = "label3";
            // 
            // frmBytes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBytes";
            this.CMS_Main.ResumeLayout(false);
            this.CMS_Value.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LeafControl.BytesBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ContextMenuStrip CMS_Main;
        private System.Windows.Forms.ToolStripMenuItem MS_Clear;
        private System.Windows.Forms.ToolStripMenuItem MS_ToInt;
        private System.Windows.Forms.ToolStripMenuItem MS_ToFloat;
        private System.Windows.Forms.ToolStripMenuItem MS_ToDouble;
        private System.Windows.Forms.ContextMenuStrip CMS_Value;
        private System.Windows.Forms.ToolStripMenuItem MS_ClearValue;
        private System.Windows.Forms.ToolStripMenuItem MS_IntToBytes;
        private System.Windows.Forms.ToolStripMenuItem MS_FloatToBytes;
        private System.Windows.Forms.ToolStripMenuItem MS_DoubleToBytes;
        private System.Windows.Forms.ToolStripMenuItem MS_ShortToBytes;
        private System.Windows.Forms.Label label3;
    }
}