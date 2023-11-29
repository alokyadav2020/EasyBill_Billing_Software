namespace BillingSystem
{
    partial class CustomerDiposit
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
            this.dipositdt = new System.Windows.Forms.DateTimePicker();
            this.cidlbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.namelbl = new System.Windows.Forms.Label();
            this.mobilelbl = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.dipsotbtn = new System.Windows.Forms.Button();
            this.diposittxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dismoneylbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dipositdt);
            this.panel1.Controls.Add(this.cidlbl);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 100);
            this.panel1.TabIndex = 0;
            // 
            // dipositdt
            // 
            this.dipositdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dipositdt.Location = new System.Drawing.Point(28, 22);
            this.dipositdt.Name = "dipositdt";
            this.dipositdt.Size = new System.Drawing.Size(322, 38);
            this.dipositdt.TabIndex = 11;
            // 
            // cidlbl
            // 
            this.cidlbl.AutoSize = true;
            this.cidlbl.Location = new System.Drawing.Point(309, 63);
            this.cidlbl.Name = "cidlbl";
            this.cidlbl.Size = new System.Drawing.Size(41, 17);
            this.cidlbl.TabIndex = 10;
            this.cidlbl.Text = "cusid";
            this.cidlbl.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.Controls.Add(this.namelbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mobilelbl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.addresslbl, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(395, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(582, 57);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namelbl.Location = new System.Drawing.Point(3, 0);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(409, 28);
            this.namelbl.TabIndex = 4;
            this.namelbl.Text = "-";
            this.namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mobilelbl
            // 
            this.mobilelbl.AutoSize = true;
            this.mobilelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mobilelbl.Location = new System.Drawing.Point(3, 28);
            this.mobilelbl.Name = "mobilelbl";
            this.mobilelbl.Size = new System.Drawing.Size(409, 29);
            this.mobilelbl.TabIndex = 5;
            this.mobilelbl.Text = "-";
            this.mobilelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addresslbl.Location = new System.Drawing.Point(418, 0);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(161, 28);
            this.addresslbl.TabIndex = 6;
            this.addresslbl.Text = "-";
            this.addresslbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dipsotbtn
            // 
            this.dipsotbtn.BackColor = System.Drawing.Color.LightGreen;
            this.dipsotbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dipsotbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dipsotbtn.Location = new System.Drawing.Point(149, 243);
            this.dipsotbtn.Name = "dipsotbtn";
            this.dipsotbtn.Size = new System.Drawing.Size(201, 51);
            this.dipsotbtn.TabIndex = 1;
            this.dipsotbtn.Text = "Diposit";
            this.dipsotbtn.UseVisualStyleBackColor = false;
            this.dipsotbtn.Click += new System.EventHandler(this.dipsotbtn_Click);
            // 
            // diposittxt
            // 
            this.diposittxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diposittxt.Location = new System.Drawing.Point(23, 178);
            this.diposittxt.Name = "diposittxt";
            this.diposittxt.Size = new System.Drawing.Size(327, 53);
            this.diposittxt.TabIndex = 2;
            this.diposittxt.TextChanged += new System.EventHandler(this.diposittxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Diposit Money";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(395, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 289);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dismoneylbl, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(594, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dismoneylbl
            // 
            this.dismoneylbl.AutoSize = true;
            this.dismoneylbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dismoneylbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dismoneylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dismoneylbl.ForeColor = System.Drawing.Color.LawnGreen;
            this.dismoneylbl.Location = new System.Drawing.Point(3, 0);
            this.dismoneylbl.Name = "dismoneylbl";
            this.dismoneylbl.Size = new System.Drawing.Size(588, 100);
            this.dismoneylbl.TabIndex = 0;
            this.dismoneylbl.Text = "0.00";
            this.dismoneylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(149, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerDiposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 389);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diposittxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dipsotbtn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerDiposit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDiposit";
            this.Load += new System.EventHandler(this.CustomerDiposit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label mobilelbl;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.Label cidlbl;
        private System.Windows.Forms.Button dipsotbtn;
        private System.Windows.Forms.TextBox diposittxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label dismoneylbl;
        private System.Windows.Forms.DateTimePicker dipositdt;
        private System.Windows.Forms.Button button1;
    }
}