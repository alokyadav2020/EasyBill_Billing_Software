namespace BillingSystem
{
    partial class Forgetpassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgetpassword));
            this.fpmobiletxt = new System.Windows.Forms.TextBox();
            this.fpemailtxt = new System.Windows.Forms.TextBox();
            this.otptxt = new System.Windows.Forms.TextBox();
            this.newPtxt = new System.Windows.Forms.TextBox();
            this.fpsavebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inerlbl = new System.Windows.Forms.Label();
            this.frusernametxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpmobiletxt
            // 
            this.fpmobiletxt.BackColor = System.Drawing.SystemColors.Control;
            this.fpmobiletxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fpmobiletxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpmobiletxt.Enabled = false;
            this.fpmobiletxt.Location = new System.Drawing.Point(3, 135);
            this.fpmobiletxt.Multiline = true;
            this.fpmobiletxt.Name = "fpmobiletxt";
            this.fpmobiletxt.Size = new System.Drawing.Size(310, 38);
            this.fpmobiletxt.TabIndex = 1;
            this.fpmobiletxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fpemailtxt
            // 
            this.fpemailtxt.BackColor = System.Drawing.SystemColors.Control;
            this.fpemailtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fpemailtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpemailtxt.Enabled = false;
            this.fpemailtxt.Location = new System.Drawing.Point(3, 179);
            this.fpemailtxt.Multiline = true;
            this.fpemailtxt.Name = "fpemailtxt";
            this.fpemailtxt.Size = new System.Drawing.Size(310, 38);
            this.fpemailtxt.TabIndex = 1;
            this.fpemailtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // otptxt
            // 
            this.otptxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otptxt.Location = new System.Drawing.Point(3, 267);
            this.otptxt.Multiline = true;
            this.otptxt.Name = "otptxt";
            this.otptxt.Size = new System.Drawing.Size(310, 38);
            this.otptxt.TabIndex = 1;
            this.otptxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.otptxt.Visible = false;
            // 
            // newPtxt
            // 
            this.newPtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newPtxt.Location = new System.Drawing.Point(3, 355);
            this.newPtxt.Multiline = true;
            this.newPtxt.Name = "newPtxt";
            this.newPtxt.PasswordChar = '*';
            this.newPtxt.Size = new System.Drawing.Size(310, 38);
            this.newPtxt.TabIndex = 2;
            this.newPtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPtxt.Visible = false;
            // 
            // fpsavebtn
            // 
            this.fpsavebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpsavebtn.Location = new System.Drawing.Point(3, 399);
            this.fpsavebtn.Name = "fpsavebtn";
            this.fpsavebtn.Size = new System.Drawing.Size(310, 42);
            this.fpsavebtn.TabIndex = 3;
            this.fpsavebtn.Text = "Send OTP";
            this.fpsavebtn.UseVisualStyleBackColor = true;
            this.fpsavebtn.Click += new System.EventHandler(this.fpsavebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = " Enter Your Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter OTP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // inerlbl
            // 
            this.inerlbl.AutoSize = true;
            this.inerlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inerlbl.Location = new System.Drawing.Point(3, 0);
            this.inerlbl.Name = "inerlbl";
            this.inerlbl.Size = new System.Drawing.Size(310, 44);
            this.inerlbl.TabIndex = 4;
            this.inerlbl.Text = "internet";
            this.inerlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frusernametxt
            // 
            this.frusernametxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frusernametxt.Location = new System.Drawing.Point(3, 91);
            this.frusernametxt.Multiline = true;
            this.frusernametxt.Name = "frusernametxt";
            this.frusernametxt.Size = new System.Drawing.Size(310, 38);
            this.frusernametxt.TabIndex = 0;
            this.frusernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.frusernametxt.Leave += new System.EventHandler(this.frusernametxt_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.inerlbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fpsavebtn, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.newPtxt, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.frusernametxt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.otptxt, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.fpmobiletxt, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.fpemailtxt, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(316, 444);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Forgetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Forgetpassword";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyBill - Forgetpassword";
            this.Activated += new System.EventHandler(this.Forgetpassword_Activated);
            this.Load += new System.EventHandler(this.Forgetpassword_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Forgetpassword_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox fpmobiletxt;
        private System.Windows.Forms.TextBox fpemailtxt;
        private System.Windows.Forms.TextBox otptxt;
        private System.Windows.Forms.TextBox newPtxt;
        private System.Windows.Forms.Button fpsavebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label inerlbl;
        private System.Windows.Forms.TextBox frusernametxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}