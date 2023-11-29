namespace BillingSystem
{
    partial class SalePageSetting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.serialbtn = new System.Windows.Forms.Button();
            this.serialcb = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serialtypetxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.discb = new System.Windows.Forms.CheckBox();
            this.distxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale Page Setting";
            // 
            // serialbtn
            // 
            this.serialbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serialbtn.Location = new System.Drawing.Point(480, 24);
            this.serialbtn.Name = "serialbtn";
            this.serialbtn.Size = new System.Drawing.Size(103, 31);
            this.serialbtn.TabIndex = 1;
            this.serialbtn.Text = "&Save";
            this.serialbtn.UseVisualStyleBackColor = true;
            this.serialbtn.Click += new System.EventHandler(this.serialbtn_Click);
            // 
            // serialcb
            // 
            this.serialcb.AutoSize = true;
            this.serialcb.Location = new System.Drawing.Point(32, 154);
            this.serialcb.Name = "serialcb";
            this.serialcb.Size = new System.Drawing.Size(145, 21);
            this.serialcb.TabIndex = 2;
            this.serialcb.Text = "Sale with serial no.";
            this.serialcb.UseVisualStyleBackColor = true;
            this.serialcb.CheckedChanged += new System.EventHandler(this.serialcb_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serial No. Type";
            this.label2.Visible = false;
            // 
            // serialtypetxt
            // 
            this.serialtypetxt.Location = new System.Drawing.Point(32, 225);
            this.serialtypetxt.Name = "serialtypetxt";
            this.serialtypetxt.Size = new System.Drawing.Size(238, 23);
            this.serialtypetxt.TabIndex = 4;
            this.serialtypetxt.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.serialbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 68);
            this.panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 276);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale With serial Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.discb);
            this.groupBox2.Controls.Add(this.distxt);
            this.groupBox2.Location = new System.Drawing.Point(296, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 276);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Discount setting";
            // 
            // discb
            // 
            this.discb.AutoSize = true;
            this.discb.Location = new System.Drawing.Point(25, 74);
            this.discb.Name = "discb";
            this.discb.Size = new System.Drawing.Size(82, 21);
            this.discb.TabIndex = 2;
            this.discb.Text = "Discount";
            this.discb.UseVisualStyleBackColor = true;
            this.discb.CheckedChanged += new System.EventHandler(this.discb_CheckedChanged);
            // 
            // distxt
            // 
            this.distxt.Enabled = false;
            this.distxt.Location = new System.Drawing.Point(25, 125);
            this.distxt.Multiline = true;
            this.distxt.Name = "distxt";
            this.distxt.Size = new System.Drawing.Size(240, 125);
            this.distxt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(351, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalePageSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 448);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.serialtypetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serialcb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalePageSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Page Setting";
            this.Load += new System.EventHandler(this.salewithserial_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.salewithserial_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button serialbtn;
        private System.Windows.Forms.CheckBox serialcb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serialtypetxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox distxt;
        private System.Windows.Forms.CheckBox discb;
        private System.Windows.Forms.Button button1;
    }
}