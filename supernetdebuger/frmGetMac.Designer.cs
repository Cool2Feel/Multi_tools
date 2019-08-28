namespace LeafSoft
{
    partial class frmGetMac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetMac));
            this.TextName = new EASkins.Ami_TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ami_Label2 = new EASkins.Ami_Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextMac = new IpBoxControl.MACTextBox();
            this.TextIp = new IpBoxControl.IpTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextName
            // 
            resources.ApplyResources(this.TextName, "TextName");
            this.TextName.BackColor = System.Drawing.Color.Transparent;
            this.TextName.ForeColor = System.Drawing.Color.Silver;
            this.TextName.MaxLength = 32767;
            this.TextName.Multiline = false;
            this.TextName.Name = "TextName";
            this.TextName.ReadOnly = false;
            this.TextName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextName.UseSystemPasswordChar = false;
            // 
            // btGet
            // 
            resources.ApplyResources(this.btGet, "btGet");
            this.btGet.Name = "btGet";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // btAdd
            // 
            resources.ApplyResources(this.btAdd, "btAdd");
            this.btAdd.Name = "btAdd";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ami_Label2
            // 
            resources.ApplyResources(this.ami_Label2, "ami_Label2");
            this.ami_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ami_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ami_Label2.Name = "ami_Label2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextMac
            // 
            resources.ApplyResources(this.TextMac, "TextMac");
            this.TextMac.Name = "TextMac";
            // 
            // TextIp
            // 
            resources.ApplyResources(this.TextIp, "TextIp");
            this.TextIp.Name = "TextIp";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmGetMac
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextMac);
            this.Controls.Add(this.TextIp);
            this.Controls.Add(this.ami_Label2);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGetMac";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EASkins.Ami_TextBox TextName;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private EASkins.Ami_Label ami_Label2;
        private IpBoxControl.IpTextBox TextIp;
        private IpBoxControl.MACTextBox TextMac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}