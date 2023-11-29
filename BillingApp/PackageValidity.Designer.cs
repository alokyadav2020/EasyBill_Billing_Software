namespace BillingSystem
{
    partial class PackageValidity
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
            this.label4 = new System.Windows.Forms.Label();
            this.vrlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cp1 = new CircularProgressBar.CircularProgressBar();
            this.cp2 = new CircularProgressBar.CircularProgressBar();
            this.rdlbl = new System.Windows.Forms.Label();
            this.edlbl = new System.Windows.Forms.Label();
            this.ptlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.alertlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.vrlbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 100);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Version";
            // 
            // vrlbl
            // 
            this.vrlbl.AutoSize = true;
            this.vrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vrlbl.Location = new System.Drawing.Point(475, 58);
            this.vrlbl.Name = "vrlbl";
            this.vrlbl.Size = new System.Drawing.Size(56, 17);
            this.vrlbl.TabIndex = 0;
            this.vrlbl.Text = "Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(79, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "EasyBill Standard version";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.cp1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cp2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(363, 116);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 150);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cp1
            // 
            this.cp1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cp1.AnimationSpeed = 500;
            this.cp1.BackColor = System.Drawing.Color.Transparent;
            this.cp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.cp1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cp1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cp1.InnerMargin = 2;
            this.cp1.InnerWidth = -1;
            this.cp1.Location = new System.Drawing.Point(3, 3);
            this.cp1.MarqueeAnimationSpeed = 2000;
            this.cp1.Name = "cp1";
            this.cp1.OuterColor = System.Drawing.Color.Gray;
            this.cp1.OuterMargin = -25;
            this.cp1.OuterWidth = 26;
            this.cp1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cp1.ProgressWidth = 5;
            this.cp1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cp1.Size = new System.Drawing.Size(144, 144);
            this.cp1.StartAngle = 270;
            this.cp1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cp1.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cp1.SubscriptText = "Days";
            this.cp1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cp1.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cp1.SuperscriptText = "";
            this.cp1.TabIndex = 0;
            this.cp1.Text = "0";
            this.cp1.TextMargin = new System.Windows.Forms.Padding(0);
            this.cp1.Value = 68;
            // 
            // cp2
            // 
            this.cp2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cp2.AnimationSpeed = 500;
            this.cp2.BackColor = System.Drawing.Color.Transparent;
            this.cp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.cp2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cp2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cp2.InnerMargin = 2;
            this.cp2.InnerWidth = -1;
            this.cp2.Location = new System.Drawing.Point(153, 3);
            this.cp2.MarqueeAnimationSpeed = 2000;
            this.cp2.Name = "cp2";
            this.cp2.OuterColor = System.Drawing.Color.Gray;
            this.cp2.OuterMargin = -25;
            this.cp2.OuterWidth = 26;
            this.cp2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cp2.ProgressWidth = 5;
            this.cp2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cp2.Size = new System.Drawing.Size(144, 144);
            this.cp2.StartAngle = 270;
            this.cp2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cp2.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cp2.SubscriptText = "Days";
            this.cp2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cp2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cp2.SuperscriptText = "";
            this.cp2.TabIndex = 0;
            this.cp2.Text = "0";
            this.cp2.TextMargin = new System.Windows.Forms.Padding(0);
            this.cp2.Value = 68;
            // 
            // rdlbl
            // 
            this.rdlbl.AutoSize = true;
            this.rdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdlbl.Location = new System.Drawing.Point(45, 149);
            this.rdlbl.Name = "rdlbl";
            this.rdlbl.Size = new System.Drawing.Size(46, 17);
            this.rdlbl.TabIndex = 2;
            this.rdlbl.Text = "label2";
            // 
            // edlbl
            // 
            this.edlbl.AutoSize = true;
            this.edlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edlbl.Location = new System.Drawing.Point(45, 186);
            this.edlbl.Name = "edlbl";
            this.edlbl.Size = new System.Drawing.Size(46, 17);
            this.edlbl.TabIndex = 2;
            this.edlbl.Text = "label2";
            // 
            // ptlbl
            // 
            this.ptlbl.AutoSize = true;
            this.ptlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ptlbl.Location = new System.Drawing.Point(45, 227);
            this.ptlbl.Name = "ptlbl";
            this.ptlbl.Size = new System.Drawing.Size(46, 17);
            this.ptlbl.TabIndex = 2;
            this.ptlbl.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(419, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(553, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Remaining";
            // 
            // alertlbl
            // 
            this.alertlbl.AutoSize = true;
            this.alertlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertlbl.ForeColor = System.Drawing.Color.DarkRed;
            this.alertlbl.Location = new System.Drawing.Point(45, 266);
            this.alertlbl.Name = "alertlbl";
            this.alertlbl.Size = new System.Drawing.Size(255, 20);
            this.alertlbl.TabIndex = 2;
            this.alertlbl.Text = "Your Package is going to expire !!!! ";
            this.alertlbl.Visible = false;
            // 
            // PackageValidity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(691, 310);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alertlbl);
            this.Controls.Add(this.ptlbl);
            this.Controls.Add(this.edlbl);
            this.Controls.Add(this.rdlbl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackageValidity";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyBil - Package Validity";
            this.Load += new System.EventHandler(this.PackageValidity_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PackageValidity_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label vrlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CircularProgressBar.CircularProgressBar cp1;
        private CircularProgressBar.CircularProgressBar cp2;
        private System.Windows.Forms.Label rdlbl;
        private System.Windows.Forms.Label edlbl;
        private System.Windows.Forms.Label ptlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label alertlbl;
    }
}