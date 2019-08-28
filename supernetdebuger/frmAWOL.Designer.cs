namespace LeafSoft
{
    partial class frmAWOL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAWOL));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TextName = new EASkins.Ami_TextBox();
            this.ami_Label1 = new EASkins.Ami_Label();
            this.ami_Label2 = new EASkins.Ami_Label();
            this.TextMac = new IpBoxControl.MACTextBox();
            this.TextIp = new IpBoxControl.IpTextBox();
            this.SuspendLayout();
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextName
            // 
            resources.ApplyResources(this.TextName, "TextName");
            this.TextName.BackColor = System.Drawing.Color.Transparent;
            this.TextName.ForeColor = System.Drawing.Color.DimGray;
            this.TextName.MaxLength = 32767;
            this.TextName.Multiline = false;
            this.TextName.Name = "TextName";
            this.TextName.ReadOnly = false;
            this.TextName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextName.UseSystemPasswordChar = false;
            // 
            // ami_Label1
            // 
            resources.ApplyResources(this.ami_Label1, "ami_Label1");
            this.ami_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ami_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ami_Label1.Name = "ami_Label1";
            // 
            // ami_Label2
            // 
            resources.ApplyResources(this.ami_Label2, "ami_Label2");
            this.ami_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ami_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ami_Label2.Name = "ami_Label2";
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
            // frmAWOL
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextIp);
            this.Controls.Add(this.TextMac);
            this.Controls.Add(this.ami_Label2);
            this.Controls.Add(this.ami_Label1);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAWOL";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private EASkins.Ami_TextBox TextName;
        private EASkins.Ami_Label ami_Label1;
        private EASkins.Ami_Label ami_Label2;
        private IpBoxControl.MACTextBox TextMac;
        private IpBoxControl.IpTextBox TextIp;
    }
}