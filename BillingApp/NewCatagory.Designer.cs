namespace BillingApp
{
    partial class NewCatagory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCatagory));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.catagorycodetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.catagorynametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.catagorydiscriptiontxt = new System.Windows.Forms.TextBox();
            this.savecatagorybtn = new System.Windows.Forms.Button();
            this.saveclosebtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catagory Code :";
            // 
            // catagorycodetxt
            // 
            this.catagorycodetxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.catagorycodetxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.catagorycodetxt.Location = new System.Drawing.Point(157, 42);
            this.catagorycodetxt.MaxLength = 50;
            this.catagorycodetxt.Name = "catagorycodetxt";
            this.catagorycodetxt.Size = new System.Drawing.Size(275, 23);
            this.catagorycodetxt.TabIndex = 0;
            this.catagorycodetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.catagorycodetxt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Catagory Name :";
            // 
            // catagorynametxt
            // 
            this.catagorynametxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.catagorynametxt.Location = new System.Drawing.Point(157, 83);
            this.catagorynametxt.MaxLength = 50;
            this.catagorynametxt.Name = "catagorynametxt";
            this.catagorynametxt.Size = new System.Drawing.Size(275, 23);
            this.catagorynametxt.TabIndex = 1;
            this.catagorynametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.catagorynametxt_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Discription:";
            // 
            // catagorydiscriptiontxt
            // 
            this.catagorydiscriptiontxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.catagorydiscriptiontxt.Location = new System.Drawing.Point(157, 126);
            this.catagorydiscriptiontxt.MaxLength = 200;
            this.catagorydiscriptiontxt.Multiline = true;
            this.catagorydiscriptiontxt.Name = "catagorydiscriptiontxt";
            this.catagorydiscriptiontxt.Size = new System.Drawing.Size(275, 73);
            this.catagorydiscriptiontxt.TabIndex = 2;
            this.catagorydiscriptiontxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.catagorydiscriptiontxt_KeyDown);
            // 
            // savecatagorybtn
            // 
            this.savecatagorybtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.savecatagorybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savecatagorybtn.FlatAppearance.BorderSize = 2;
            this.savecatagorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savecatagorybtn.Location = new System.Drawing.Point(157, 223);
            this.savecatagorybtn.Name = "savecatagorybtn";
            this.savecatagorybtn.Size = new System.Drawing.Size(275, 31);
            this.savecatagorybtn.TabIndex = 3;
            this.savecatagorybtn.Text = "Save";
            this.savecatagorybtn.UseVisualStyleBackColor = false;
            this.savecatagorybtn.Click += new System.EventHandler(this.savecatagorybtn_Click);
            // 
            // saveclosebtn
            // 
            this.saveclosebtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveclosebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveclosebtn.FlatAppearance.BorderSize = 2;
            this.saveclosebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveclosebtn.Location = new System.Drawing.Point(157, 269);
            this.saveclosebtn.Name = "saveclosebtn";
            this.saveclosebtn.Size = new System.Drawing.Size(275, 31);
            this.saveclosebtn.TabIndex = 4;
            this.saveclosebtn.Text = "Save and Close";
            this.saveclosebtn.UseVisualStyleBackColor = false;
            this.saveclosebtn.Click += new System.EventHandler(this.saveclosebtn_Click);
            // 
            // NewCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(468, 312);
            this.Controls.Add(this.saveclosebtn);
            this.Controls.Add(this.savecatagorybtn);
            this.Controls.Add(this.catagorydiscriptiontxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.catagorynametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.catagorycodetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NewCatagory";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyBill - New Catagory";
            this.Load += new System.EventHandler(this.NewCatagory_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewCatagory_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button savecatagorybtn;
        private System.Windows.Forms.Button saveclosebtn;
        public System.Windows.Forms.TextBox catagorycodetxt;
        public System.Windows.Forms.TextBox catagorynametxt;
        public System.Windows.Forms.TextBox catagorydiscriptiontxt;
    }
}