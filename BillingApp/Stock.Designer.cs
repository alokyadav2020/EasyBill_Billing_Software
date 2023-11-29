namespace BillingApp
{
    partial class Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lowsttxt = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpsctock = new CircularProgressBar.CircularProgressBar();
            this.tnslbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lwstbtn = new System.Windows.Forms.Button();
            this.stockrefbtn = new System.Windows.Forms.Button();
            this.stckclosebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stockselectcombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stocksearchtxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sdgv = new System.Windows.Forms.DataGridView();
            this.spc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowsttxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lowsttxt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cpsctock);
            this.panel2.Controls.Add(this.tnslbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lwstbtn);
            this.panel2.Controls.Add(this.stockrefbtn);
            this.panel2.Controls.Add(this.stckclosebtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 632);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lowsttxt
            // 
            this.lowsttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowsttxt.Location = new System.Drawing.Point(5, 434);
            this.lowsttxt.Name = "lowsttxt";
            this.lowsttxt.Size = new System.Drawing.Size(189, 23);
            this.lowsttxt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Low Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Item In Stock";
            // 
            // cpsctock
            // 
            this.cpsctock.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.cpsctock.AnimationSpeed = 500;
            this.cpsctock.BackColor = System.Drawing.Color.Transparent;
            this.cpsctock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.cpsctock.ForeColor = System.Drawing.Color.ForestGreen;
            this.cpsctock.InnerColor = System.Drawing.SystemColors.ControlLightLight;
            this.cpsctock.InnerMargin = 2;
            this.cpsctock.InnerWidth = -1;
            this.cpsctock.Location = new System.Drawing.Point(5, 168);
            this.cpsctock.MarqueeAnimationSpeed = 2000;
            this.cpsctock.Name = "cpsctock";
            this.cpsctock.OuterColor = System.Drawing.SystemColors.Control;
            this.cpsctock.OuterMargin = -25;
            this.cpsctock.OuterWidth = 26;
            this.cpsctock.ProgressColor = System.Drawing.Color.YellowGreen;
            this.cpsctock.ProgressWidth = 7;
            this.cpsctock.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cpsctock.Size = new System.Drawing.Size(189, 178);
            this.cpsctock.StartAngle = 270;
            this.cpsctock.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpsctock.SubscriptColor = System.Drawing.Color.ForestGreen;
            this.cpsctock.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpsctock.SubscriptText = "";
            this.cpsctock.SuperscriptColor = System.Drawing.Color.ForestGreen;
            this.cpsctock.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpsctock.SuperscriptText = "";
            this.cpsctock.TabIndex = 9;
            this.cpsctock.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpsctock.Value = 68;
            // 
            // tnslbl
            // 
            this.tnslbl.AutoSize = true;
            this.tnslbl.BackColor = System.Drawing.SystemColors.Control;
            this.tnslbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tnslbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnslbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.tnslbl.Location = new System.Drawing.Point(69, 40);
            this.tnslbl.Name = "tnslbl";
            this.tnslbl.Size = new System.Drawing.Size(20, 28);
            this.tnslbl.TabIndex = 6;
            this.tnslbl.Text = "-";
            this.tnslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock";
            // 
            // lwstbtn
            // 
            this.lwstbtn.BackColor = System.Drawing.Color.LightCoral;
            this.lwstbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lwstbtn.FlatAppearance.BorderSize = 2;
            this.lwstbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.lwstbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lwstbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwstbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lwstbtn.Location = new System.Drawing.Point(5, 474);
            this.lwstbtn.Name = "lwstbtn";
            this.lwstbtn.Size = new System.Drawing.Size(191, 39);
            this.lwstbtn.TabIndex = 1;
            this.lwstbtn.Text = "&Low Stock";
            this.lwstbtn.UseVisualStyleBackColor = false;
            this.lwstbtn.Click += new System.EventHandler(this.lwstbtn_Click);
            // 
            // stockrefbtn
            // 
            this.stockrefbtn.BackColor = System.Drawing.Color.DarkBlue;
            this.stockrefbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockrefbtn.FlatAppearance.BorderSize = 2;
            this.stockrefbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.stockrefbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stockrefbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockrefbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stockrefbtn.Location = new System.Drawing.Point(5, 530);
            this.stockrefbtn.Name = "stockrefbtn";
            this.stockrefbtn.Size = new System.Drawing.Size(191, 39);
            this.stockrefbtn.TabIndex = 1;
            this.stockrefbtn.Text = "&Total Stock Item";
            this.stockrefbtn.UseVisualStyleBackColor = false;
            this.stockrefbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // stckclosebtn
            // 
            this.stckclosebtn.BackColor = System.Drawing.Color.Crimson;
            this.stckclosebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stckclosebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stckclosebtn.FlatAppearance.BorderSize = 0;
            this.stckclosebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.stckclosebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stckclosebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stckclosebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stckclosebtn.Location = new System.Drawing.Point(3, 585);
            this.stckclosebtn.Name = "stckclosebtn";
            this.stckclosebtn.Size = new System.Drawing.Size(194, 37);
            this.stckclosebtn.TabIndex = 0;
            this.stckclosebtn.Text = "&Close";
            this.stckclosebtn.UseVisualStyleBackColor = false;
            this.stckclosebtn.Click += new System.EventHandler(this.stckclosebtn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 93);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // stockselectcombo
            // 
            this.stockselectcombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stockselectcombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.stockselectcombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.stockselectcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockselectcombo.FormattingEnabled = true;
            this.stockselectcombo.Location = new System.Drawing.Point(22, 43);
            this.stockselectcombo.Name = "stockselectcombo";
            this.stockselectcombo.Size = new System.Drawing.Size(264, 24);
            this.stockselectcombo.TabIndex = 7;
            this.stockselectcombo.SelectedIndexChanged += new System.EventHandler(this.stockselectcombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Category";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(319, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search";
            // 
            // stocksearchtxt
            // 
            this.stocksearchtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stocksearchtxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stocksearchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocksearchtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stocksearchtxt.Location = new System.Drawing.Point(323, 43);
            this.stocksearchtxt.Name = "stocksearchtxt";
            this.stocksearchtxt.Size = new System.Drawing.Size(243, 23);
            this.stocksearchtxt.TabIndex = 4;
            this.stocksearchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stocksearchtxt.TextChanged += new System.EventHandler(this.stocksearchtxt_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sdgv);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(203, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 632);
            this.panel3.TabIndex = 2;
            // 
            // sdgv
            // 
            this.sdgv.AllowUserToAddRows = false;
            this.sdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sdgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sdgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sdgv.ColumnHeadersHeight = 35;
            this.sdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spc,
            this.spn,
            this.spq});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sdgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.sdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdgv.EnableHeadersVisualStyles = false;
            this.sdgv.Location = new System.Drawing.Point(0, 96);
            this.sdgv.Name = "sdgv";
            this.sdgv.ReadOnly = true;
            this.sdgv.RowHeadersVisible = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sdgv.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.sdgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sdgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdgv.RowTemplate.Height = 60;
            this.sdgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sdgv.Size = new System.Drawing.Size(836, 536);
            this.sdgv.TabIndex = 0;
            // 
            // spc
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spc.DefaultCellStyle = dataGridViewCellStyle3;
            this.spc.HeaderText = "Product Name";
            this.spc.Name = "spc";
            this.spc.ReadOnly = true;
            // 
            // spn
            // 
            this.spn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spn.DefaultCellStyle = dataGridViewCellStyle4;
            this.spn.FillWeight = 98.47716F;
            this.spn.HeaderText = "Print Name";
            this.spn.Name = "spn";
            this.spn.ReadOnly = true;
            // 
            // spq
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.spq.DefaultCellStyle = dataGridViewCellStyle5;
            this.spq.FillWeight = 101.5228F;
            this.spq.HeaderText = "Quantity";
            this.spq.Name = "spq";
            this.spq.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.stockselectcombo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.stocksearchtxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 96);
            this.panel1.TabIndex = 1;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1042, 638);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stock";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyBill - Stock";
            this.Activated += new System.EventHandler(this.Stock_Activated);
            this.Load += new System.EventHandler(this.Stock_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stock_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowsttxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sdgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView sdgv;
        private System.Windows.Forms.Button stckclosebtn;
        private System.Windows.Forms.Button stockrefbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stocksearchtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tnslbl;
        private System.Windows.Forms.ComboBox stockselectcombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularProgressBar.CircularProgressBar cpsctock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown lowsttxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button lwstbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn spc;
        private System.Windows.Forms.DataGridViewTextBoxColumn spn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spq;
    }
}