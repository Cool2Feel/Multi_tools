namespace LeafSoft.Units
{
    partial class DataSend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSend));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgCMD = new System.Windows.Forms.DataGridView();
            this.IsAutoSend = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMDText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMDTips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSend = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Saved = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAutoSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nmDelay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.LinkLabel();
            this.emi_Label1 = new EASkins.Emi_Label();
            this.openFileRead = new System.Windows.Forms.OpenFileDialog();
            this.saveFileInit = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.MS_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Select = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Input = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgCMD)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCMD
            // 
            this.dgCMD.AllowUserToAddRows = false;
            this.dgCMD.AllowUserToDeleteRows = false;
            this.dgCMD.AllowUserToResizeColumns = false;
            this.dgCMD.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgCMD, "dgCMD");
            this.dgCMD.BackgroundColor = System.Drawing.Color.White;
            this.dgCMD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgCMD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCMD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCMD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsAutoSend,
            this.CType,
            this.CMDText,
            this.CMDTips,
            this.btnSend});
            this.dgCMD.ContextMenuStrip = this.contextMenuStrip1;
            this.dgCMD.MultiSelect = false;
            this.dgCMD.Name = "dgCMD";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgCMD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCMD.RowHeadersVisible = false;
            this.dgCMD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgCMD.RowTemplate.Height = 23;
            this.dgCMD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCMD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCMD_CellContentClick);
            this.dgCMD.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dgCMD_CellToolTipTextNeeded);
            this.dgCMD.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgCMD_RowsAdded);
            // 
            // IsAutoSend
            // 
            resources.ApplyResources(this.IsAutoSend, "IsAutoSend");
            this.IsAutoSend.Name = "IsAutoSend";
            this.IsAutoSend.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CType
            // 
            this.CType.DataPropertyName = "ContentTypeName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CType.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.CType, "CType");
            this.CType.Name = "CType";
            this.CType.ReadOnly = true;
            this.CType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CMDText
            // 
            this.CMDText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CMDText.DataPropertyName = "Text";
            resources.ApplyResources(this.CMDText, "CMDText");
            this.CMDText.Name = "CMDText";
            this.CMDText.ReadOnly = true;
            this.CMDText.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CMDTips
            // 
            this.CMDTips.DataPropertyName = "Tips";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CMDTips.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.CMDTips, "CMDTips");
            this.CMDTips.Name = "CMDTips";
            this.CMDTips.ReadOnly = true;
            this.CMDTips.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CMDTips.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.ReadOnly = true;
            this.btnSend.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnSend.Text = "send";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Add,
            this.MS_Edit,
            this.MS_Delete,
            this.MS_Select,
            this.MS_Saved,
            this.MS_Input,
            this.MS_SaveAs});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // MS_Saved
            // 
            this.MS_Saved.Name = "MS_Saved";
            resources.ApplyResources(this.MS_Saved, "MS_Saved");
            this.MS_Saved.Click += new System.EventHandler(this.MS_Saved_Click);
            // 
            // MS_SaveAs
            // 
            this.MS_SaveAs.Image = global::LeafSoft.Properties.Resources.export;
            this.MS_SaveAs.Name = "MS_SaveAs";
            resources.ApplyResources(this.MS_SaveAs, "MS_SaveAs");
            this.MS_SaveAs.Click += new System.EventHandler(this.MS_SaveAs_Click);
            // 
            // btnAutoSend
            // 
            resources.ApplyResources(this.btnAutoSend, "btnAutoSend");
            this.btnAutoSend.Name = "btnAutoSend";
            this.btnAutoSend.UseVisualStyleBackColor = true;
            this.btnAutoSend.Click += new System.EventHandler(this.btnAutoSend_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.AutoEllipsis = true;
            this.label1.Name = "label1";
            // 
            // nmDelay
            // 
            resources.ApplyResources(this.nmDelay, "nmDelay");
            this.nmDelay.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmDelay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmDelay.Name = "nmDelay";
            this.nmDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmDelay_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblCount
            // 
            resources.ApplyResources(this.lblCount, "lblCount");
            this.lblCount.Name = "lblCount";
            this.lblCount.TabStop = true;
            this.lblCount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCount_LinkClicked);
            // 
            // emi_Label1
            // 
            resources.ApplyResources(this.emi_Label1, "emi_Label1");
            this.emi_Label1.BackColor = System.Drawing.Color.Transparent;
            this.emi_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emi_Label1.Name = "emi_Label1";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.ShowAlways = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Name = "label3";
            // 
            // MS_Add
            // 
            this.MS_Add.Image = global::LeafSoft.Properties.Resources.add;
            this.MS_Add.Name = "MS_Add";
            resources.ApplyResources(this.MS_Add, "MS_Add");
            this.MS_Add.Click += new System.EventHandler(this.MS_Add_Click);
            // 
            // MS_Edit
            // 
            this.MS_Edit.Image = global::LeafSoft.Properties.Resources.edit;
            this.MS_Edit.Name = "MS_Edit";
            resources.ApplyResources(this.MS_Edit, "MS_Edit");
            this.MS_Edit.Click += new System.EventHandler(this.MS_Edit_Click);
            // 
            // MS_Delete
            // 
            this.MS_Delete.Image = global::LeafSoft.Properties.Resources.delete;
            this.MS_Delete.Name = "MS_Delete";
            resources.ApplyResources(this.MS_Delete, "MS_Delete");
            this.MS_Delete.Click += new System.EventHandler(this.MS_Delete_Click);
            // 
            // MS_Select
            // 
            this.MS_Select.Image = global::LeafSoft.Properties.Resources.select;
            this.MS_Select.Name = "MS_Select";
            resources.ApplyResources(this.MS_Select, "MS_Select");
            this.MS_Select.Click += new System.EventHandler(this.MS_Select_Click);
            // 
            // MS_Input
            // 
            this.MS_Input.Image = global::LeafSoft.Properties.Resources.import;
            this.MS_Input.Name = "MS_Input";
            resources.ApplyResources(this.MS_Input, "MS_Input");
            this.MS_Input.Click += new System.EventHandler(this.MS_Input_Click);
            // 
            // DataSend
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emi_Label1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmDelay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAutoSend);
            this.Controls.Add(this.dgCMD);
            this.Name = "DataSend";
            this.Load += new System.EventHandler(this.DataSend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCMD)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCMD;
        private System.Windows.Forms.Button btnAutoSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_Add;
        private System.Windows.Forms.ToolStripMenuItem MS_Edit;
        private System.Windows.Forms.ToolStripMenuItem MS_Delete;
        private System.Windows.Forms.LinkLabel lblCount;
        private EASkins.Emi_Label emi_Label1;
        private System.Windows.Forms.OpenFileDialog openFileRead;
        private System.Windows.Forms.SaveFileDialog saveFileInit;
        private System.Windows.Forms.ToolStripMenuItem MS_Saved;
        private System.Windows.Forms.ToolStripMenuItem MS_Input;
        private System.Windows.Forms.ToolStripMenuItem MS_SaveAs;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem MS_Select;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAutoSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn CType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMDText;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMDTips;
        private System.Windows.Forms.DataGridViewButtonColumn btnSend;
    }
}
