namespace BillingApp
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.changeclosebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.oldpasstxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newpasstxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confpasstxt = new System.Windows.Forms.TextBox();
            this.changepassbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeclosebtn
            // 
            this.changeclosebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeclosebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.changeclosebtn.Location = new System.Drawing.Point(14, 277);
            this.changeclosebtn.Margin = new System.Windows.Forms.Padding(4);
            this.changeclosebtn.Name = "changeclosebtn";
            this.changeclosebtn.Size = new System.Drawing.Size(305, 35);
            this.changeclosebtn.TabIndex = 4;
            this.changeclosebtn.Text = "&Close";
            this.changeclosebtn.UseVisualStyleBackColor = true;
            this.changeclosebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Old Password";
            // 
            // oldpasstxt
            // 
            this.oldpasstxt.Location = new System.Drawing.Point(14, 46);
            this.oldpasstxt.Margin = new System.Windows.Forms.Padding(4);
            this.oldpasstxt.Name = "oldpasstxt";
            this.oldpasstxt.PasswordChar = '*';
            this.oldpasstxt.Size = new System.Drawing.Size(304, 25);
            this.oldpasstxt.TabIndex = 0;
            this.oldpasstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldpasstxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.oldpasstxt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // newpasstxt
            // 
            this.newpasstxt.Location = new System.Drawing.Point(14, 105);
            this.newpasstxt.Margin = new System.Windows.Forms.Padding(4);
            this.newpasstxt.Name = "newpasstxt";
            this.newpasstxt.PasswordChar = '*';
            this.newpasstxt.Size = new System.Drawing.Size(304, 25);
            this.newpasstxt.TabIndex = 1;
            this.newpasstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newpasstxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newpasstxt_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Confirm Password";
            // 
            // confpasstxt
            // 
            this.confpasstxt.Location = new System.Drawing.Point(13, 169);
            this.confpasstxt.Margin = new System.Windows.Forms.Padding(4);
            this.confpasstxt.Name = "confpasstxt";
            this.confpasstxt.PasswordChar = '*';
            this.confpasstxt.Size = new System.Drawing.Size(304, 25);
            this.confpasstxt.TabIndex = 2;
            this.confpasstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confpasstxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confpasstxt_KeyDown);
            // 
            // changepassbtn
            // 
            this.changepassbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changepassbtn.Location = new System.Drawing.Point(14, 226);
            this.changepassbtn.Margin = new System.Windows.Forms.Padding(4);
            this.changepassbtn.Name = "changepassbtn";
            this.changepassbtn.Size = new System.Drawing.Size(305, 35);
            this.changepassbtn.TabIndex = 3;
            this.changepassbtn.Text = "Change Pssword";
            this.changepassbtn.UseVisualStyleBackColor = true;
            this.changepassbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(101, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(105, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(125, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "*";
            // 
            // ChangePassword
            // 
            this.AcceptButton = this.changepassbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.changeclosebtn;
            this.ClientSize = new System.Drawing.Size(332, 325);
            this.Controls.Add(this.confpasstxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newpasstxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldpasstxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changepassbtn);
            this.Controls.Add(this.changeclosebtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyBill - Change Password";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangePassword_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeclosebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldpasstxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newpasstxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confpasstxt;
        private System.Windows.Forms.Button changepassbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}