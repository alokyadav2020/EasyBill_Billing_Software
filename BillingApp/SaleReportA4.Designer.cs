namespace BillingSystem
{
    partial class SaleReportA4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleReportA4));
            this.SaleReportA4Viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salebw = new System.ComponentModel.BackgroundWorker();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaleReportA4Viewer
            // 
            this.SaleReportA4Viewer.AutoSize = true;
            this.SaleReportA4Viewer.BackColor = System.Drawing.Color.Gainsboro;
            this.SaleReportA4Viewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SaleReportA4Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleReportA4Viewer.DocumentMapWidth = 1;
            this.SaleReportA4Viewer.IsDocumentMapWidthFixed = true;
            this.SaleReportA4Viewer.LocalReport.ReportEmbeddedResource = "BillingSystem.SalerecieptA4.rdlc";
            this.SaleReportA4Viewer.Location = new System.Drawing.Point(0, 24);
            this.SaleReportA4Viewer.Name = "SaleReportA4Viewer";
            this.SaleReportA4Viewer.ServerReport.BearerToken = null;
            this.SaleReportA4Viewer.Size = new System.Drawing.Size(1127, 649);
            this.SaleReportA4Viewer.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SaleReportA4Viewer);
            this.panel5.Controls.Add(this.menuStrip1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1127, 673);
            this.panel5.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1127, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // salebw
            // 
            this.salebw.WorkerReportsProgress = true;
            this.salebw.WorkerSupportsCancellation = true;
            this.salebw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.salebw_DoWork);
            this.salebw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.salebw_ProgressChanged);
            this.salebw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.salebw_RunWorkerCompleted);
            // 
            // SaleReportA4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 673);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SaleReportA4";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyBill - Sale Invoice A4 Page";
            this.Load += new System.EventHandler(this.SaleReportA4_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Microsoft.Reporting.WinForms.ReportViewer SaleReportA4Viewer;
        private System.Windows.Forms.Panel panel5;
        private System.ComponentModel.BackgroundWorker salebw;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}