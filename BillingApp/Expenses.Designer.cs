namespace BillingSystem
{
    partial class Expenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.expensedestxt = new System.Windows.Forms.TextBox();
            this.tptxt = new System.Windows.Forms.TextBox();
            this.qauntitytxt = new System.Windows.Forms.TextBox();
            this.expricetxt = new System.Windows.Forms.TextBox();
            this.expcombo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.expensedate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvexpense = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.et = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexpense)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.expensedestxt);
            this.panel1.Controls.Add(this.tptxt);
            this.panel1.Controls.Add(this.qauntitytxt);
            this.panel1.Controls.Add(this.expricetxt);
            this.panel1.Controls.Add(this.expcombo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 391);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value/quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expense Type";
            // 
            // expensedestxt
            // 
            this.expensedestxt.Location = new System.Drawing.Point(6, 264);
            this.expensedestxt.Multiline = true;
            this.expensedestxt.Name = "expensedestxt";
            this.expensedestxt.Size = new System.Drawing.Size(182, 80);
            this.expensedestxt.TabIndex = 5;
            this.expensedestxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.expensedestxt_KeyDown);
            // 
            // tptxt
            // 
            this.tptxt.Location = new System.Drawing.Point(7, 176);
            this.tptxt.Name = "tptxt";
            this.tptxt.Size = new System.Drawing.Size(182, 22);
            this.tptxt.TabIndex = 3;
            this.tptxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tptxt_KeyDown);
            this.tptxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tptxt_KeyPress);
            // 
            // qauntitytxt
            // 
            this.qauntitytxt.Location = new System.Drawing.Point(7, 130);
            this.qauntitytxt.Name = "qauntitytxt";
            this.qauntitytxt.Size = new System.Drawing.Size(182, 22);
            this.qauntitytxt.TabIndex = 2;
            this.qauntitytxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qauntitytxt_KeyDown);
            // 
            // expricetxt
            // 
            this.expricetxt.Enabled = false;
            this.expricetxt.Location = new System.Drawing.Point(7, 87);
            this.expricetxt.Name = "expricetxt";
            this.expricetxt.Size = new System.Drawing.Size(182, 22);
            this.expricetxt.TabIndex = 1;
            this.expricetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.expricetxt_KeyDown);
            this.expricetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expricetxt_KeyPress);
            // 
            // expcombo
            // 
            this.expcombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.expcombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.expcombo.FormattingEnabled = true;
            this.expcombo.Location = new System.Drawing.Point(6, 35);
            this.expcombo.Name = "expcombo";
            this.expcombo.Size = new System.Drawing.Size(183, 25);
            this.expcombo.Sorted = true;
            this.expcombo.TabIndex = 0;
            this.expcombo.SelectedIndexChanged += new System.EventHandler(this.expcombo_SelectedIndexChanged);
            this.expcombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.expcombo_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.expensedate);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(192, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 60);
            this.panel2.TabIndex = 1;
            // 
            // expensedate
            // 
            this.expensedate.Location = new System.Drawing.Point(220, 14);
            this.expensedate.Name = "expensedate";
            this.expensedate.Size = new System.Drawing.Size(247, 22);
            this.expensedate.TabIndex = 3;
            this.expensedate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Search";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.addbtn);
            this.panel3.Controls.Add(this.updatebtn);
            this.panel3.Controls.Add(this.Refreshbtn);
            this.panel3.Controls.Add(this.Deletebtn);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(192, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 60);
            this.panel3.TabIndex = 2;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.Control;
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.Location = new System.Drawing.Point(60, 9);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(94, 42);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "&Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.SystemColors.Control;
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.Location = new System.Drawing.Point(160, 9);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(94, 42);
            this.updatebtn.TabIndex = 0;
            this.updatebtn.Text = "&Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refreshbtn.Location = new System.Drawing.Point(360, 9);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(94, 42);
            this.Refreshbtn.TabIndex = 0;
            this.Refreshbtn.Text = "&Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = false;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.SystemColors.Control;
            this.Deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebtn.Location = new System.Drawing.Point(260, 9);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(94, 42);
            this.Deletebtn.TabIndex = 0;
            this.Deletebtn.Text = "&Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(460, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 42);
            this.button1.TabIndex = 0;
            this.button1.Tag = "";
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(192, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(622, 271);
            this.panel4.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvexpense);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expenses";
            // 
            // dgvexpense
            // 
            this.dgvexpense.AllowUserToAddRows = false;
            this.dgvexpense.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvexpense.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvexpense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvexpense.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvexpense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvexpense.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvexpense.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvexpense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvexpense.ColumnHeadersHeight = 35;
            this.dgvexpense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.et,
            this.price,
            this.Quantity,
            this.tp,
            this.d,
            this.des,
            this.cb});
            this.dgvexpense.EnableHeadersVisualStyles = false;
            this.dgvexpense.Location = new System.Drawing.Point(6, 21);
            this.dgvexpense.Name = "dgvexpense";
            this.dgvexpense.ReadOnly = true;
            this.dgvexpense.RowHeadersVisible = false;
            this.dgvexpense.RowTemplate.Height = 50;
            this.dgvexpense.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvexpense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvexpense.Size = new System.Drawing.Size(601, 232);
            this.dgvexpense.TabIndex = 0;
            this.dgvexpense.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvexpense_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // et
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.et.DefaultCellStyle = dataGridViewCellStyle3;
            this.et.HeaderText = "Expense type";
            this.et.Name = "et";
            this.et.ReadOnly = true;
            // 
            // price
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.price.DefaultCellStyle = dataGridViewCellStyle4;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // Quantity
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // tp
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tp.DefaultCellStyle = dataGridViewCellStyle6;
            this.tp.HeaderText = "Total Price";
            this.tp.Name = "tp";
            this.tp.ReadOnly = true;
            // 
            // d
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "f";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.d.DefaultCellStyle = dataGridViewCellStyle7;
            this.d.HeaderText = "date";
            this.d.Name = "d";
            this.d.ReadOnly = true;
            // 
            // des
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.des.DefaultCellStyle = dataGridViewCellStyle8;
            this.des.HeaderText = "Description";
            this.des.Name = "des";
            this.des.ReadOnly = true;
            // 
            // cb
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cb.DefaultCellStyle = dataGridViewCellStyle9;
            this.cb.HeaderText = "User";
            this.cb.Name = "cb";
            this.cb.ReadOnly = true;
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 391);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Expenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyBill - Expenses";
            this.Activated += new System.EventHandler(this.Expenses_Activated);
            this.Load += new System.EventHandler(this.Expenses_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Expenses_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvexpense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox expensedestxt;
        private System.Windows.Forms.TextBox tptxt;
        private System.Windows.Forms.TextBox qauntitytxt;
        private System.Windows.Forms.TextBox expricetxt;
        private System.Windows.Forms.ComboBox expcombo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvexpense;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn et;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.DataGridViewTextBoxColumn des;
        private System.Windows.Forms.DataGridViewTextBoxColumn cb;
        private System.Windows.Forms.DateTimePicker expensedate;
        private System.Windows.Forms.Label label9;
    }
}