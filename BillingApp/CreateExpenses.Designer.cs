namespace BillingSystem
{
    partial class CreateExpenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateExpenses));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.desexptxt = new System.Windows.Forms.TextBox();
            this.priceexptxt = new System.Windows.Forms.TextBox();
            this.typetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvexp = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esdes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.closeexpbtn = new System.Windows.Forms.Button();
            this.viewexpbtn = new System.Windows.Forms.Button();
            this.deleteexpbtn = new System.Windows.Forms.Button();
            this.updateexpbtn = new System.Windows.Forms.Button();
            this.addexpbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexp)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.desexptxt);
            this.panel1.Controls.Add(this.priceexptxt);
            this.panel1.Controls.Add(this.typetxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 387);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expenses Type";
            // 
            // desexptxt
            // 
            this.desexptxt.Location = new System.Drawing.Point(3, 145);
            this.desexptxt.Multiline = true;
            this.desexptxt.Name = "desexptxt";
            this.desexptxt.Size = new System.Drawing.Size(203, 79);
            this.desexptxt.TabIndex = 2;
            this.desexptxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.desexptxt_KeyDown);
            // 
            // priceexptxt
            // 
            this.priceexptxt.Location = new System.Drawing.Point(3, 99);
            this.priceexptxt.Name = "priceexptxt";
            this.priceexptxt.Size = new System.Drawing.Size(203, 21);
            this.priceexptxt.TabIndex = 1;
            this.priceexptxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.priceexptxt_KeyDown);
            // 
            // typetxt
            // 
            this.typetxt.Location = new System.Drawing.Point(3, 50);
            this.typetxt.Name = "typetxt";
            this.typetxt.Size = new System.Drawing.Size(203, 21);
            this.typetxt.TabIndex = 0;
            this.typetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.typetxt_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(95, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(40, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "*";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(212, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 387);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.dgvexp);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(599, 307);
            this.panel4.TabIndex = 1;
            // 
            // dgvexp
            // 
            this.dgvexp.AllowUserToAddRows = false;
            this.dgvexp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvexp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvexp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvexp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvexp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvexp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvexp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvexp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvexp.ColumnHeadersHeight = 35;
            this.dgvexp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.extype,
            this.exprice,
            this.esdes});
            this.dgvexp.EnableHeadersVisualStyles = false;
            this.dgvexp.Location = new System.Drawing.Point(12, 32);
            this.dgvexp.Name = "dgvexp";
            this.dgvexp.ReadOnly = true;
            this.dgvexp.RowHeadersVisible = false;
            this.dgvexp.RowTemplate.Height = 50;
            this.dgvexp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvexp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvexp.Size = new System.Drawing.Size(578, 263);
            this.dgvexp.TabIndex = 0;
            this.dgvexp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvexp_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // extype
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.extype.DefaultCellStyle = dataGridViewCellStyle3;
            this.extype.HeaderText = "Expenses Type";
            this.extype.Name = "extype";
            this.extype.ReadOnly = true;
            // 
            // exprice
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exprice.DefaultCellStyle = dataGridViewCellStyle4;
            this.exprice.HeaderText = "Price";
            this.exprice.Name = "exprice";
            this.exprice.ReadOnly = true;
            // 
            // esdes
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.esdes.DefaultCellStyle = dataGridViewCellStyle5;
            this.esdes.HeaderText = "Description";
            this.esdes.Name = "esdes";
            this.esdes.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 289);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Expenses";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.closeexpbtn);
            this.panel3.Controls.Add(this.viewexpbtn);
            this.panel3.Controls.Add(this.deleteexpbtn);
            this.panel3.Controls.Add(this.updateexpbtn);
            this.panel3.Controls.Add(this.addexpbtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(599, 80);
            this.panel3.TabIndex = 0;
            // 
            // closeexpbtn
            // 
            this.closeexpbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.closeexpbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeexpbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeexpbtn.Location = new System.Drawing.Point(457, 21);
            this.closeexpbtn.Name = "closeexpbtn";
            this.closeexpbtn.Size = new System.Drawing.Size(95, 43);
            this.closeexpbtn.TabIndex = 4;
            this.closeexpbtn.Text = "&CLOSE";
            this.closeexpbtn.UseVisualStyleBackColor = false;
            this.closeexpbtn.Click += new System.EventHandler(this.closeexpbtn_Click);
            // 
            // viewexpbtn
            // 
            this.viewexpbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewexpbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewexpbtn.Location = new System.Drawing.Point(356, 21);
            this.viewexpbtn.Name = "viewexpbtn";
            this.viewexpbtn.Size = new System.Drawing.Size(95, 43);
            this.viewexpbtn.TabIndex = 3;
            this.viewexpbtn.Text = "&REFRESH";
            this.viewexpbtn.UseVisualStyleBackColor = false;
            this.viewexpbtn.Click += new System.EventHandler(this.viewexpbtn_Click);
            // 
            // deleteexpbtn
            // 
            this.deleteexpbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteexpbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteexpbtn.Location = new System.Drawing.Point(255, 21);
            this.deleteexpbtn.Name = "deleteexpbtn";
            this.deleteexpbtn.Size = new System.Drawing.Size(95, 43);
            this.deleteexpbtn.TabIndex = 2;
            this.deleteexpbtn.Text = "&DELETE";
            this.deleteexpbtn.UseVisualStyleBackColor = false;
            this.deleteexpbtn.Click += new System.EventHandler(this.deleteexpbtn_Click);
            // 
            // updateexpbtn
            // 
            this.updateexpbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateexpbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateexpbtn.Location = new System.Drawing.Point(154, 21);
            this.updateexpbtn.Name = "updateexpbtn";
            this.updateexpbtn.Size = new System.Drawing.Size(95, 43);
            this.updateexpbtn.TabIndex = 1;
            this.updateexpbtn.Text = "&UPDATE";
            this.updateexpbtn.UseVisualStyleBackColor = false;
            this.updateexpbtn.Click += new System.EventHandler(this.updateexpbtn_Click);
            // 
            // addexpbtn
            // 
            this.addexpbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addexpbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addexpbtn.Location = new System.Drawing.Point(53, 21);
            this.addexpbtn.Name = "addexpbtn";
            this.addexpbtn.Size = new System.Drawing.Size(95, 43);
            this.addexpbtn.TabIndex = 0;
            this.addexpbtn.Text = "&ADD";
            this.addexpbtn.UseVisualStyleBackColor = false;
            this.addexpbtn.Click += new System.EventHandler(this.addexpbtn_Click);
            // 
            // CreateExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 387);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateExpenses";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyBill - Create Expenses";
            this.Load += new System.EventHandler(this.CreateExpenses_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateExpenses_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvexp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox desexptxt;
        private System.Windows.Forms.TextBox priceexptxt;
        private System.Windows.Forms.TextBox typetxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvexp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button closeexpbtn;
        private System.Windows.Forms.Button viewexpbtn;
        private System.Windows.Forms.Button deleteexpbtn;
        private System.Windows.Forms.Button updateexpbtn;
        private System.Windows.Forms.Button addexpbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn extype;
        private System.Windows.Forms.DataGridViewTextBoxColumn exprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn esdes;
    }
}