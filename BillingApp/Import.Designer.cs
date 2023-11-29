namespace BillingSystem
{
    partial class Import
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IMPOERPANEL = new System.Windows.Forms.Panel();
            this.catidcb = new System.Windows.Forms.ComboBox();
            this.importcb = new System.Windows.Forms.ComboBox();
            this.removerowbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.importbtn = new System.Windows.Forms.Button();
            this.browsebtn = new System.Windows.Forms.Button();
            this.imoprtxt = new System.Windows.Forms.TextBox();
            this.importtypelbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productCatagoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statuslbl = new System.Windows.Forms.Label();
            this.rowcountlbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvimport = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.headerdgv = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.IMPOERPANEL.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvimport)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IMPOERPANEL);
            this.panel1.Controls.Add(this.importtypelbl);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 105);
            this.panel1.TabIndex = 0;
            // 
            // IMPOERPANEL
            // 
            this.IMPOERPANEL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IMPOERPANEL.Controls.Add(this.catidcb);
            this.IMPOERPANEL.Controls.Add(this.importcb);
            this.IMPOERPANEL.Controls.Add(this.removerowbtn);
            this.IMPOERPANEL.Controls.Add(this.savebtn);
            this.IMPOERPANEL.Controls.Add(this.importbtn);
            this.IMPOERPANEL.Controls.Add(this.browsebtn);
            this.IMPOERPANEL.Controls.Add(this.imoprtxt);
            this.IMPOERPANEL.Dock = System.Windows.Forms.DockStyle.Right;
            this.IMPOERPANEL.Location = new System.Drawing.Point(509, 24);
            this.IMPOERPANEL.Name = "IMPOERPANEL";
            this.IMPOERPANEL.Size = new System.Drawing.Size(687, 81);
            this.IMPOERPANEL.TabIndex = 2;
            this.IMPOERPANEL.Visible = false;
            // 
            // catidcb
            // 
            this.catidcb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.catidcb.FormattingEnabled = true;
            this.catidcb.Location = new System.Drawing.Point(266, 45);
            this.catidcb.Name = "catidcb";
            this.catidcb.Size = new System.Drawing.Size(208, 24);
            this.catidcb.TabIndex = 3;
            this.catidcb.Text = "Select Catagory....";
            this.catidcb.Visible = false;
            this.catidcb.SelectedIndexChanged += new System.EventHandler(this.catidcb_SelectedIndexChanged);
            // 
            // importcb
            // 
            this.importcb.FormattingEnabled = true;
            this.importcb.Location = new System.Drawing.Point(480, 15);
            this.importcb.Name = "importcb";
            this.importcb.Size = new System.Drawing.Size(189, 24);
            this.importcb.TabIndex = 2;
            this.importcb.SelectedIndexChanged += new System.EventHandler(this.importcb_SelectedIndexChanged);
            // 
            // removerowbtn
            // 
            this.removerowbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removerowbtn.Location = new System.Drawing.Point(480, 46);
            this.removerowbtn.Name = "removerowbtn";
            this.removerowbtn.Size = new System.Drawing.Size(189, 29);
            this.removerowbtn.TabIndex = 1;
            this.removerowbtn.Text = "&Remove Row";
            this.removerowbtn.UseVisualStyleBackColor = true;
            this.removerowbtn.Click += new System.EventHandler(this.removerowbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Location = new System.Drawing.Point(185, 45);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 29);
            this.savebtn.TabIndex = 1;
            this.savebtn.Text = "&Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // importbtn
            // 
            this.importbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importbtn.Location = new System.Drawing.Point(104, 45);
            this.importbtn.Name = "importbtn";
            this.importbtn.Size = new System.Drawing.Size(75, 29);
            this.importbtn.TabIndex = 1;
            this.importbtn.Text = "&Import";
            this.importbtn.UseVisualStyleBackColor = true;
            this.importbtn.Click += new System.EventHandler(this.importbtn_Click);
            // 
            // browsebtn
            // 
            this.browsebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browsebtn.Location = new System.Drawing.Point(23, 45);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(75, 29);
            this.browsebtn.TabIndex = 1;
            this.browsebtn.Text = "&Browse";
            this.browsebtn.UseVisualStyleBackColor = true;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // imoprtxt
            // 
            this.imoprtxt.Location = new System.Drawing.Point(23, 16);
            this.imoprtxt.Name = "imoprtxt";
            this.imoprtxt.Size = new System.Drawing.Size(451, 23);
            this.imoprtxt.TabIndex = 0;
            // 
            // importtypelbl
            // 
            this.importtypelbl.AutoSize = true;
            this.importtypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importtypelbl.Location = new System.Drawing.Point(12, 45);
            this.importtypelbl.Name = "importtypelbl";
            this.importtypelbl.Size = new System.Drawing.Size(91, 31);
            this.importtypelbl.TabIndex = 1;
            this.importtypelbl.Text = "Import";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerDetailsToolStripMenuItem,
            this.supplierDetailsToolStripMenuItem,
            this.productCatagoryToolStripMenuItem,
            this.productDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1196, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerDetailsToolStripMenuItem
            // 
            this.customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            this.customerDetailsToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.customerDetailsToolStripMenuItem.Text = "Customer Details";
            this.customerDetailsToolStripMenuItem.Click += new System.EventHandler(this.customerDetailsToolStripMenuItem_Click);
            // 
            // supplierDetailsToolStripMenuItem
            // 
            this.supplierDetailsToolStripMenuItem.Name = "supplierDetailsToolStripMenuItem";
            this.supplierDetailsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.supplierDetailsToolStripMenuItem.Text = "Supplier Details";
            this.supplierDetailsToolStripMenuItem.Click += new System.EventHandler(this.supplierDetailsToolStripMenuItem_Click);
            // 
            // productCatagoryToolStripMenuItem
            // 
            this.productCatagoryToolStripMenuItem.Name = "productCatagoryToolStripMenuItem";
            this.productCatagoryToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.productCatagoryToolStripMenuItem.Text = "Product Catagory";
            this.productCatagoryToolStripMenuItem.Click += new System.EventHandler(this.productCatagoryToolStripMenuItem_Click);
            // 
            // productDetailsToolStripMenuItem
            // 
            this.productDetailsToolStripMenuItem.Name = "productDetailsToolStripMenuItem";
            this.productDetailsToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.productDetailsToolStripMenuItem.Text = "Product Details";
            this.productDetailsToolStripMenuItem.Click += new System.EventHandler(this.productDetailsToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.statuslbl);
            this.panel2.Controls.Add(this.rowcountlbl);
            this.panel2.Controls.Add(this.timelbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 612);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 32);
            this.panel2.TabIndex = 1;
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statuslbl.Location = new System.Drawing.Point(422, 7);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(343, 15);
            this.statuslbl.TabIndex = 2;
            this.statuslbl.Text = "Customer Details Has Been Imorpted Successfully  !!";
            this.statuslbl.Visible = false;
            // 
            // rowcountlbl
            // 
            this.rowcountlbl.AutoSize = true;
            this.rowcountlbl.Location = new System.Drawing.Point(937, 7);
            this.rowcountlbl.Name = "rowcountlbl";
            this.rowcountlbl.Size = new System.Drawing.Size(36, 17);
            this.rowcountlbl.TabIndex = 1;
            this.rowcountlbl.Text = "0.00";
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Location = new System.Drawing.Point(15, 7);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(32, 17);
            this.timelbl.TabIndex = 0;
            this.timelbl.Text = "Sec";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvimport);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1196, 507);
            this.panel3.TabIndex = 2;
            // 
            // dgvimport
            // 
            this.dgvimport.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvimport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvimport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvimport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvimport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvimport.ColumnHeadersHeight = 30;
            this.dgvimport.ColumnHeadersVisible = false;
            this.dgvimport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvimport.EnableHeadersVisualStyles = false;
            this.dgvimport.Location = new System.Drawing.Point(15, 41);
            this.dgvimport.Name = "dgvimport";
            this.dgvimport.RowHeadersVisible = false;
            this.dgvimport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvimport.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvimport.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvimport.RowTemplate.Height = 50;
            this.dgvimport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvimport.Size = new System.Drawing.Size(1166, 466);
            this.dgvimport.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1181, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 466);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 466);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.headerdgv);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1196, 41);
            this.panel4.TabIndex = 1;
            // 
            // headerdgv
            // 
            this.headerdgv.AllowUserToAddRows = false;
            this.headerdgv.AllowUserToDeleteRows = false;
            this.headerdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.headerdgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.headerdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.headerdgv.ColumnHeadersHeight = 40;
            this.headerdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerdgv.Location = new System.Drawing.Point(15, 0);
            this.headerdgv.Name = "headerdgv";
            this.headerdgv.ReadOnly = true;
            this.headerdgv.RowHeadersVisible = false;
            this.headerdgv.Size = new System.Drawing.Size(1166, 41);
            this.headerdgv.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1181, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(15, 41);
            this.panel8.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(15, 41);
            this.panel7.TabIndex = 0;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 644);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Import";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import";
            this.Load += new System.EventHandler(this.Import_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Import_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.IMPOERPANEL.ResumeLayout(false);
            this.IMPOERPANEL.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvimport)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvimport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productDetailsToolStripMenuItem;
        private System.Windows.Forms.Label importtypelbl;
        private System.Windows.Forms.Panel IMPOERPANEL;
        private System.Windows.Forms.ComboBox importcb;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button importbtn;
        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.TextBox imoprtxt;
        private System.Windows.Forms.Button removerowbtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.ToolStripMenuItem productCatagoryToolStripMenuItem;
        private System.Windows.Forms.Label rowcountlbl;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.ComboBox catidcb;
        private System.Windows.Forms.DataGridView headerdgv;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
    }
}