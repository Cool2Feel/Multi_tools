namespace LeafSoft.PartPanel
{
    partial class WOLPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WOLPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btWake = new CCWin.SkinControl.SkinButton();
            this.MacTextBox = new IpBoxControl.MACTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Eidt = new System.Windows.Forms.Button();
            this.btMac = new System.Windows.Forms.Button();
            this.btAllsend = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgWOL = new System.Windows.Forms.DataGridView();
            this.IsAutoWake = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CMac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMDIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSend = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_add = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_eidt = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_wake = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_getMac = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_select = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWOL)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btWake);
            this.panel1.Controls.Add(this.MacTextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // btWake
            // 
            resources.ApplyResources(this.btWake, "btWake");
            this.btWake.BackColor = System.Drawing.Color.Transparent;
            this.btWake.BaseColor = System.Drawing.Color.Silver;
            this.btWake.BorderColor = System.Drawing.Color.Gray;
            this.btWake.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btWake.DownBack = null;
            this.btWake.DownBaseColor = System.Drawing.Color.Gray;
            this.btWake.MouseBack = null;
            this.btWake.MouseBaseColor = System.Drawing.Color.Silver;
            this.btWake.Name = "btWake";
            this.btWake.NormlBack = null;
            this.btWake.UseVisualStyleBackColor = false;
            this.btWake.Click += new System.EventHandler(this.button1_Click);
            // 
            // MacTextBox
            // 
            resources.ApplyResources(this.MacTextBox, "MacTextBox");
            this.MacTextBox.Name = "MacTextBox";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bt_Eidt);
            this.panel2.Controls.Add(this.btMac);
            this.panel2.Controls.Add(this.btAllsend);
            this.panel2.Controls.Add(this.btDelete);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Name = "panel2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Name = "label3";
            // 
            // bt_Eidt
            // 
            resources.ApplyResources(this.bt_Eidt, "bt_Eidt");
            this.bt_Eidt.Name = "bt_Eidt";
            this.bt_Eidt.UseVisualStyleBackColor = true;
            this.bt_Eidt.Click += new System.EventHandler(this.bt_Eidt_Click);
            // 
            // btMac
            // 
            resources.ApplyResources(this.btMac, "btMac");
            this.btMac.Name = "btMac";
            this.btMac.UseVisualStyleBackColor = true;
            this.btMac.Click += new System.EventHandler(this.btMac_Click);
            // 
            // btAllsend
            // 
            resources.ApplyResources(this.btAllsend, "btAllsend");
            this.btAllsend.Name = "btAllsend";
            this.btAllsend.UseVisualStyleBackColor = true;
            this.btAllsend.Click += new System.EventHandler(this.btAllsend_Click);
            // 
            // btDelete
            // 
            resources.ApplyResources(this.btDelete, "btDelete");
            this.btDelete.Name = "btDelete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            resources.ApplyResources(this.btAdd, "btAdd");
            this.btAdd.Name = "btAdd";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dgWOL
            // 
            resources.ApplyResources(this.dgWOL, "dgWOL");
            this.dgWOL.AllowUserToAddRows = false;
            this.dgWOL.AllowUserToDeleteRows = false;
            this.dgWOL.AllowUserToResizeColumns = false;
            this.dgWOL.AllowUserToResizeRows = false;
            this.dgWOL.BackgroundColor = System.Drawing.Color.White;
            this.dgWOL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgWOL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgWOL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWOL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsAutoWake,
            this.CMac,
            this.CMDName,
            this.CMDIp,
            this.btnSend});
            this.dgWOL.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgWOL.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgWOL.MultiSelect = false;
            this.dgWOL.Name = "dgWOL";
            this.dgWOL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgWOL.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgWOL.RowHeadersVisible = false;
            this.dgWOL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgWOL.RowTemplate.Height = 23;
            this.dgWOL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgWOL.TabStop = false;
            this.dgWOL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWOL_CellContentClick);
            this.dgWOL.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgWOL_CellMouseDoubleClick);
            this.dgWOL.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgWOL_RowsAdded);
            // 
            // IsAutoWake
            // 
            resources.ApplyResources(this.IsAutoWake, "IsAutoWake");
            this.IsAutoWake.Name = "IsAutoWake";
            this.IsAutoWake.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CMac
            // 
            this.CMac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CMac.DataPropertyName = "MAC";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CMac.DefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(this.CMac, "CMac");
            this.CMac.Name = "CMac";
            this.CMac.ReadOnly = true;
            this.CMac.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CMac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CMDName
            // 
            this.CMDName.DataPropertyName = "NAME";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CMDName.DefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(this.CMDName, "CMDName");
            this.CMDName.Name = "CMDName";
            this.CMDName.ReadOnly = true;
            this.CMDName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CMDIp
            // 
            this.CMDIp.DataPropertyName = "IP";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CMDIp.DefaultCellStyle = dataGridViewCellStyle11;
            resources.ApplyResources(this.CMDIp, "CMDIp");
            this.CMDIp.Name = "CMDIp";
            this.CMDIp.ReadOnly = true;
            this.CMDIp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CMDIp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnSend
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.DefaultCellStyle = dataGridViewCellStyle12;
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.ReadOnly = true;
            this.btnSend.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnSend.Text = "wake";
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_add,
            this.MS_eidt,
            this.MS_delete,
            this.MS_wake,
            this.MS_getMac,
            this.MS_select});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // MS_add
            // 
            resources.ApplyResources(this.MS_add, "MS_add");
            this.MS_add.Name = "MS_add";
            this.MS_add.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // MS_eidt
            // 
            resources.ApplyResources(this.MS_eidt, "MS_eidt");
            this.MS_eidt.Name = "MS_eidt";
            this.MS_eidt.Click += new System.EventHandler(this.bt_Eidt_Click);
            // 
            // MS_delete
            // 
            resources.ApplyResources(this.MS_delete, "MS_delete");
            this.MS_delete.Name = "MS_delete";
            this.MS_delete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // MS_wake
            // 
            resources.ApplyResources(this.MS_wake, "MS_wake");
            this.MS_wake.Name = "MS_wake";
            this.MS_wake.Click += new System.EventHandler(this.btAllsend_Click);
            // 
            // MS_getMac
            // 
            resources.ApplyResources(this.MS_getMac, "MS_getMac");
            this.MS_getMac.Name = "MS_getMac";
            this.MS_getMac.Click += new System.EventHandler(this.btMac_Click);
            // 
            // MS_select
            // 
            resources.ApplyResources(this.MS_select, "MS_select");
            this.MS_select.Name = "MS_select";
            this.MS_select.Click += new System.EventHandler(this.MS_select_Click);
            // 
            // WOLPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.dgWOL);
            this.Controls.Add(this.panel1);
            this.Name = "WOLPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWOL)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgWOL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btMac;
        private System.Windows.Forms.Button btAllsend;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private IpBoxControl.MACTextBox MacTextBox;
        private CCWin.SkinControl.SkinButton btWake;
        private System.Windows.Forms.Button bt_Eidt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_add;
        private System.Windows.Forms.ToolStripMenuItem MS_eidt;
        private System.Windows.Forms.ToolStripMenuItem MS_delete;
        private System.Windows.Forms.ToolStripMenuItem MS_wake;
        private System.Windows.Forms.ToolStripMenuItem MS_getMac;
        private System.Windows.Forms.ToolStripMenuItem MS_select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAutoWake;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMac;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMDName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMDIp;
        private System.Windows.Forms.DataGridViewButtonColumn btnSend;
    }
}