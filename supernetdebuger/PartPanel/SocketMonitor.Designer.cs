namespace LeafSoft.PartPanel
{
    partial class SocketMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocketMonitor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.dgPacket = new System.Windows.Forms.DataGridView();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourcePort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtData = new LeafSoft.LeafControl.BytesBox();
            this.cbxServerIP = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmSourcePort = new System.Windows.Forms.NumericUpDown();
            this.nmTargetPort = new System.Windows.Forms.NumericUpDown();
            this.cbxProtocol = new System.Windows.Forms.ComboBox();
            this.txtTargetIP = new System.Windows.Forms.TextBox();
            this.txtSourceIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacket)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSourcePort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTargetPort)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Clear});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // MS_Clear
            // 
            this.MS_Clear.Name = "MS_Clear";
            resources.ApplyResources(this.MS_Clear, "MS_Clear");
            this.MS_Clear.Click += new System.EventHandler(this.MS_Clear_Click);
            // 
            // dgPacket
            // 
            this.dgPacket.AllowUserToAddRows = false;
            this.dgPacket.AllowUserToDeleteRows = false;
            this.dgPacket.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgPacket, "dgPacket");
            this.dgPacket.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgPacket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPacket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Protocol,
            this.SourceIP,
            this.SourcePort,
            this.TargetIP,
            this.TargetPort});
            this.dgPacket.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPacket.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgPacket.MultiSelect = false;
            this.dgPacket.Name = "dgPacket";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgPacket.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgPacket.RowHeadersVisible = false;
            this.dgPacket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPacket.RowTemplate.Height = 23;
            this.dgPacket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPacket.SelectionChanged += new System.EventHandler(this.dgPacket_SelectionChanged);
            // 
            // Protocol
            // 
            this.Protocol.DataPropertyName = "Protocol";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Protocol.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.Protocol, "Protocol");
            this.Protocol.Name = "Protocol";
            this.Protocol.ReadOnly = true;
            this.Protocol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Protocol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SourceIP
            // 
            this.SourceIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SourceIP.DataPropertyName = "SourceIP";
            resources.ApplyResources(this.SourceIP, "SourceIP");
            this.SourceIP.Name = "SourceIP";
            this.SourceIP.ReadOnly = true;
            // 
            // SourcePort
            // 
            this.SourcePort.DataPropertyName = "SourcePort";
            resources.ApplyResources(this.SourcePort, "SourcePort");
            this.SourcePort.Name = "SourcePort";
            this.SourcePort.ReadOnly = true;
            // 
            // TargetIP
            // 
            this.TargetIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TargetIP.DataPropertyName = "TargetIP";
            resources.ApplyResources(this.TargetIP, "TargetIP");
            this.TargetIP.Name = "TargetIP";
            this.TargetIP.ReadOnly = true;
            // 
            // TargetPort
            // 
            this.TargetPort.DataPropertyName = "TargetPort";
            resources.ApplyResources(this.TargetPort, "TargetPort");
            this.TargetPort.Name = "TargetPort";
            this.TargetPort.ReadOnly = true;
            // 
            // txtData
            // 
            resources.ApplyResources(this.txtData, "txtData");
            this.txtData.EncodeType = LeafSoft.Lib.EnumType.DataEncode.Hex;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            // 
            // cbxServerIP
            // 
            this.cbxServerIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbxServerIP, "cbxServerIP");
            this.cbxServerIP.FormattingEnabled = true;
            this.cbxServerIP.Name = "cbxServerIP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmSourcePort);
            this.groupBox1.Controls.Add(this.nmTargetPort);
            this.groupBox1.Controls.Add(this.cbxProtocol);
            this.groupBox1.Controls.Add(this.txtTargetIP);
            this.groupBox1.Controls.Add(this.txtSourceIP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // nmSourcePort
            // 
            resources.ApplyResources(this.nmSourcePort, "nmSourcePort");
            this.nmSourcePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmSourcePort.Name = "nmSourcePort";
            this.nmSourcePort.ValueChanged += new System.EventHandler(this.nmSourcePort_ValueChanged);
            // 
            // nmTargetPort
            // 
            resources.ApplyResources(this.nmTargetPort, "nmTargetPort");
            this.nmTargetPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmTargetPort.Name = "nmTargetPort";
            this.nmTargetPort.ValueChanged += new System.EventHandler(this.nmTargetPort_ValueChanged);
            // 
            // cbxProtocol
            // 
            this.cbxProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProtocol.FormattingEnabled = true;
            this.cbxProtocol.Items.AddRange(new object[] {
            resources.GetString("cbxProtocol.Items"),
            resources.GetString("cbxProtocol.Items1"),
            resources.GetString("cbxProtocol.Items2"),
            resources.GetString("cbxProtocol.Items3"),
            resources.GetString("cbxProtocol.Items4")});
            resources.ApplyResources(this.cbxProtocol, "cbxProtocol");
            this.cbxProtocol.Name = "cbxProtocol";
            this.cbxProtocol.SelectedIndexChanged += new System.EventHandler(this.cbxProtocol_SelectedIndexChanged);
            // 
            // txtTargetIP
            // 
            resources.ApplyResources(this.txtTargetIP, "txtTargetIP");
            this.txtTargetIP.Name = "txtTargetIP";
            // 
            // txtSourceIP
            // 
            resources.ApplyResources(this.txtSourceIP, "txtSourceIP");
            this.txtSourceIP.Name = "txtSourceIP";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnMonitor
            // 
            resources.ApplyResources(this.btnMonitor, "btnMonitor");
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // SocketMonitor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.dgPacket);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cbxServerIP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMonitor);
            this.Name = "SocketMonitor";
            this.Load += new System.EventHandler(this.SocketMonitor_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPacket)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSourcePort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTargetPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxServerIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.TextBox txtSourceIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmTargetPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmSourcePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxProtocol;
        private System.Windows.Forms.Label label6;
        private LeafControl.BytesBox txtData;
        private System.Windows.Forms.TextBox txtTargetIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_Clear;
        private System.Windows.Forms.DataGridView dgPacket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourcePort;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetPort;
    }
}
