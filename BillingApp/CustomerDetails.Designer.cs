namespace BillingApp
{
    partial class CustomerDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CusSaveBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CEMAILTXT = new System.Windows.Forms.TextBox();
            this.CMTXT = new System.Windows.Forms.TextBox();
            this.CA3TXT = new System.Windows.Forms.TextBox();
            this.CA2TXT = new System.Windows.Forms.TextBox();
            this.CA1TXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CNTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CusSaveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 63);
            this.panel1.TabIndex = 0;
            // 
            // CusSaveBtn
            // 
            this.CusSaveBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.CusSaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CusSaveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CusSaveBtn.Image = global::BillingSystem.Properties.Resources.floppy_disk__1_;
            this.CusSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CusSaveBtn.Location = new System.Drawing.Point(16, 4);
            this.CusSaveBtn.Name = "CusSaveBtn";
            this.CusSaveBtn.Size = new System.Drawing.Size(293, 45);
            this.CusSaveBtn.TabIndex = 0;
            this.CusSaveBtn.Text = "&Save";
            this.CusSaveBtn.UseVisualStyleBackColor = false;
            this.CusSaveBtn.Click += new System.EventHandler(this.CusSaveBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CEMAILTXT);
            this.panel2.Controls.Add(this.CMTXT);
            this.panel2.Controls.Add(this.CA3TXT);
            this.panel2.Controls.Add(this.CA2TXT);
            this.panel2.Controls.Add(this.CA1TXT);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.CNTXT);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 409);
            this.panel2.TabIndex = 1;
            // 
            // CEMAILTXT
            // 
            this.CEMAILTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CEMAILTXT.Location = new System.Drawing.Point(16, 365);
            this.CEMAILTXT.MaxLength = 50;
            this.CEMAILTXT.Name = "CEMAILTXT";
            this.CEMAILTXT.Size = new System.Drawing.Size(293, 23);
            this.CEMAILTXT.TabIndex = 5;
            this.CEMAILTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CEMAILTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CEMAILTXT_KeyDown);
            // 
            // CMTXT
            // 
            this.CMTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CMTXT.Location = new System.Drawing.Point(16, 300);
            this.CMTXT.MaxLength = 10;
            this.CMTXT.Name = "CMTXT";
            this.CMTXT.Size = new System.Drawing.Size(293, 23);
            this.CMTXT.TabIndex = 4;
            this.CMTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CMTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CMTXT_KeyDown);
            // 
            // CA3TXT
            // 
            this.CA3TXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CA3TXT.Location = new System.Drawing.Point(16, 236);
            this.CA3TXT.MaxLength = 100;
            this.CA3TXT.Name = "CA3TXT";
            this.CA3TXT.Size = new System.Drawing.Size(293, 23);
            this.CA3TXT.TabIndex = 3;
            this.CA3TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CA3TXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CA3TXT_KeyDown);
            // 
            // CA2TXT
            // 
            this.CA2TXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CA2TXT.Location = new System.Drawing.Point(16, 172);
            this.CA2TXT.MaxLength = 100;
            this.CA2TXT.Name = "CA2TXT";
            this.CA2TXT.Size = new System.Drawing.Size(293, 23);
            this.CA2TXT.TabIndex = 2;
            this.CA2TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CA2TXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CA2TXT_KeyDown);
            // 
            // CA1TXT
            // 
            this.CA1TXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CA1TXT.Location = new System.Drawing.Point(16, 107);
            this.CA1TXT.MaxLength = 100;
            this.CA1TXT.Name = "CA1TXT";
            this.CA1TXT.Size = new System.Drawing.Size(293, 23);
            this.CA1TXT.TabIndex = 1;
            this.CA1TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CA1TXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CA1TXT_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(13, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // CNTXT
            // 
            this.CNTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CNTXT.Location = new System.Drawing.Point(16, 42);
            this.CNTXT.MaxLength = 50;
            this.CNTXT.Name = "CNTXT";
            this.CNTXT.Size = new System.Drawing.Size(293, 23);
            this.CNTXT.TabIndex = 0;
            this.CNTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CNTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CNTXT_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(13, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mobile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(13, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "GSTN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(13, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyBill - New Customer";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerDetails_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CusSaveBtn;
        public System.Windows.Forms.TextBox CMTXT;
        public System.Windows.Forms.TextBox CEMAILTXT;
        public System.Windows.Forms.TextBox CA3TXT;
        public System.Windows.Forms.TextBox CA2TXT;
        public System.Windows.Forms.TextBox CA1TXT;
        public System.Windows.Forms.TextBox CNTXT;
    }
}