namespace BillingSystem
{
    partial class SalepageA5V
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalepageA5V));
            this.salereportA5viwer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salereportA5viwer
            // 
            this.salereportA5viwer.AutoSize = true;
            this.salereportA5viwer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SRD";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "SD";
            reportDataSource2.Value = null;
            reportDataSource3.Name = "TC";
            reportDataSource3.Value = null;
            this.salereportA5viwer.LocalReport.DataSources.Add(reportDataSource1);
            this.salereportA5viwer.LocalReport.DataSources.Add(reportDataSource2);
            this.salereportA5viwer.LocalReport.DataSources.Add(reportDataSource3);
            this.salereportA5viwer.LocalReport.ReportEmbeddedResource = "BillingSystem.SaleRecieptA5V.rdlc";
            this.salereportA5viwer.Location = new System.Drawing.Point(0, 24);
            this.salereportA5viwer.Name = "salereportA5viwer";
            this.salereportA5viwer.ServerReport.BearerToken = null;
            this.salereportA5viwer.Size = new System.Drawing.Size(1127, 649);
            this.salereportA5viwer.TabIndex = 0;
            this.salereportA5viwer.Load += new System.EventHandler(this.salereportA5viwer_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.refrshToolStripMenuItem,
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
            // refrshToolStripMenuItem
            // 
            this.refrshToolStripMenuItem.Name = "refrshToolStripMenuItem";
            this.refrshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refrshToolStripMenuItem.Text = "&Refresh";
            this.refrshToolStripMenuItem.Click += new System.EventHandler(this.refrshToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // SalepageA5V
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 673);
            this.Controls.Add(this.salereportA5viwer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalepageA5V";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyBill - Sale page A5 ";
            this.Load += new System.EventHandler(this.SalepageA5V_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SalepageA5V_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer salereportA5viwer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refrshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}