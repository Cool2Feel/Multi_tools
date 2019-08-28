namespace LeafSoft.PartPanel
{
    partial class AdbPanel
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdbPanel));
            this.txtListInfo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomIP = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_pull = new System.Windows.Forms.Button();
            this.txtCustomPath = new System.Windows.Forms.TextBox();
            this.bt_connect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClearCmd = new System.Windows.Forms.Button();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.btnStopADB = new System.Windows.Forms.Button();
            this.cboAllADBCmd = new System.Windows.Forms.ComboBox();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.txtCustomCmd = new System.Windows.Forms.TextBox();
            this.btnGetDevice = new System.Windows.Forms.Button();
            this.btnStartADB = new System.Windows.Forms.Button();
            this.btnADBVersion = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtListInfo
            // 
            resources.ApplyResources(this.txtListInfo, "txtListInfo");
            this.txtListInfo.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtListInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtListInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtListInfo.Name = "txtListInfo";
            this.txtListInfo.ReadOnly = true;
            this.toolTip1.SetToolTip(this.txtListInfo, resources.GetString("txtListInfo.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCustomIP);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bt_pull);
            this.panel1.Controls.Add(this.txtCustomPath);
            this.panel1.Controls.Add(this.bt_connect);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnClearCmd);
            this.panel1.Controls.Add(this.txtOS);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDeviceName);
            this.panel1.Controls.Add(this.cboDevice);
            this.panel1.Controls.Add(this.btnStopADB);
            this.panel1.Controls.Add(this.cboAllADBCmd);
            this.panel1.Controls.Add(this.btnSendCmd);
            this.panel1.Controls.Add(this.txtCustomCmd);
            this.panel1.Controls.Add(this.btnGetDevice);
            this.panel1.Controls.Add(this.btnStartADB);
            this.panel1.Controls.Add(this.btnADBVersion);
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // txtCustomIP
            // 
            resources.ApplyResources(this.txtCustomIP, "txtCustomIP");
            this.txtCustomIP.Name = "txtCustomIP";
            this.toolTip1.SetToolTip(this.txtCustomIP, resources.GetString("txtCustomIP.ToolTip"));
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.toolTip1.SetToolTip(this.linkLabel1, resources.GetString("linkLabel1.ToolTip"));
            this.linkLabel1.DoubleClick += new System.EventHandler(this.linkLabel1_DoubleClick);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // bt_pull
            // 
            resources.ApplyResources(this.bt_pull, "bt_pull");
            this.bt_pull.Name = "bt_pull";
            this.toolTip1.SetToolTip(this.bt_pull, resources.GetString("bt_pull.ToolTip"));
            this.bt_pull.UseVisualStyleBackColor = true;
            this.bt_pull.Click += new System.EventHandler(this.bt_pull_Click);
            // 
            // txtCustomPath
            // 
            resources.ApplyResources(this.txtCustomPath, "txtCustomPath");
            this.txtCustomPath.Name = "txtCustomPath";
            this.toolTip1.SetToolTip(this.txtCustomPath, resources.GetString("txtCustomPath.ToolTip"));
            // 
            // bt_connect
            // 
            resources.ApplyResources(this.bt_connect, "bt_connect");
            this.bt_connect.Name = "bt_connect";
            this.toolTip1.SetToolTip(this.bt_connect, resources.GetString("bt_connect.ToolTip"));
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // btnClearCmd
            // 
            resources.ApplyResources(this.btnClearCmd, "btnClearCmd");
            this.btnClearCmd.Name = "btnClearCmd";
            this.toolTip1.SetToolTip(this.btnClearCmd, resources.GetString("btnClearCmd.ToolTip"));
            this.btnClearCmd.UseVisualStyleBackColor = true;
            this.btnClearCmd.Click += new System.EventHandler(this.btnClearCmd_Click);
            // 
            // txtOS
            // 
            resources.ApplyResources(this.txtOS, "txtOS");
            this.txtOS.Name = "txtOS";
            this.toolTip1.SetToolTip(this.txtOS, resources.GetString("txtOS.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // txtDeviceName
            // 
            resources.ApplyResources(this.txtDeviceName, "txtDeviceName");
            this.txtDeviceName.Name = "txtDeviceName";
            this.toolTip1.SetToolTip(this.txtDeviceName, resources.GetString("txtDeviceName.ToolTip"));
            // 
            // cboDevice
            // 
            resources.ApplyResources(this.cboDevice, "cboDevice");
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Name = "cboDevice";
            this.toolTip1.SetToolTip(this.cboDevice, resources.GetString("cboDevice.ToolTip"));
            this.cboDevice.SelectedIndexChanged += new System.EventHandler(this.cboDevice_SelectedIndexChanged);
            // 
            // btnStopADB
            // 
            resources.ApplyResources(this.btnStopADB, "btnStopADB");
            this.btnStopADB.Name = "btnStopADB";
            this.toolTip1.SetToolTip(this.btnStopADB, resources.GetString("btnStopADB.ToolTip"));
            this.btnStopADB.UseVisualStyleBackColor = true;
            this.btnStopADB.Click += new System.EventHandler(this.btnStopADB_Click);
            // 
            // cboAllADBCmd
            // 
            resources.ApplyResources(this.cboAllADBCmd, "cboAllADBCmd");
            this.cboAllADBCmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAllADBCmd.FormattingEnabled = true;
            this.cboAllADBCmd.Name = "cboAllADBCmd";
            this.toolTip1.SetToolTip(this.cboAllADBCmd, resources.GetString("cboAllADBCmd.ToolTip"));
            this.cboAllADBCmd.SelectedIndexChanged += new System.EventHandler(this.cboAllADBCmd_SelectedIndexChanged);
            // 
            // btnSendCmd
            // 
            resources.ApplyResources(this.btnSendCmd, "btnSendCmd");
            this.btnSendCmd.Name = "btnSendCmd";
            this.toolTip1.SetToolTip(this.btnSendCmd, resources.GetString("btnSendCmd.ToolTip"));
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.btnSendCmd_Click);
            // 
            // txtCustomCmd
            // 
            resources.ApplyResources(this.txtCustomCmd, "txtCustomCmd");
            this.txtCustomCmd.Name = "txtCustomCmd";
            this.toolTip1.SetToolTip(this.txtCustomCmd, resources.GetString("txtCustomCmd.ToolTip"));
            this.txtCustomCmd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustomCmd_KeyUp);
            // 
            // btnGetDevice
            // 
            resources.ApplyResources(this.btnGetDevice, "btnGetDevice");
            this.btnGetDevice.Name = "btnGetDevice";
            this.toolTip1.SetToolTip(this.btnGetDevice, resources.GetString("btnGetDevice.ToolTip"));
            this.btnGetDevice.UseVisualStyleBackColor = true;
            this.btnGetDevice.Click += new System.EventHandler(this.btnGetDevice_Click);
            // 
            // btnStartADB
            // 
            resources.ApplyResources(this.btnStartADB, "btnStartADB");
            this.btnStartADB.Name = "btnStartADB";
            this.toolTip1.SetToolTip(this.btnStartADB, resources.GetString("btnStartADB.ToolTip"));
            this.btnStartADB.UseVisualStyleBackColor = true;
            this.btnStartADB.Click += new System.EventHandler(this.btnStartADB_Click);
            // 
            // btnADBVersion
            // 
            resources.ApplyResources(this.btnADBVersion, "btnADBVersion");
            this.btnADBVersion.Name = "btnADBVersion";
            this.toolTip1.SetToolTip(this.btnADBVersion, resources.GetString("btnADBVersion.ToolTip"));
            this.btnADBVersion.UseVisualStyleBackColor = true;
            this.btnADBVersion.Click += new System.EventHandler(this.btnADBVersion_Click);
            // 
            // AdbPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtListInfo);
            this.Name = "AdbPanel";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.AdbPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStopADB;
        private System.Windows.Forms.ComboBox cboAllADBCmd;
        private System.Windows.Forms.TextBox txtCustomCmd;
        private System.Windows.Forms.Button btnGetDevice;
        private System.Windows.Forms.Button btnStartADB;
        private System.Windows.Forms.Button btnADBVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Button btnClearCmd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSendCmd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_pull;
        private System.Windows.Forms.TextBox txtCustomPath;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomIP;
    }
}
