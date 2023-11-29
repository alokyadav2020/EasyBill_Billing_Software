using BillingApp;
using BillingApp.connection_class;
using BillingApp.main_class;
using BillingSystem.main_class;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BillingSystem
{
    public partial class SaleReportA4 : Form
    {
        Int64 invc;        
        public SaleReportA4(Int64 invno)
        {
            invc = invno;
            InitializeComponent();
        }
        SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
        LocalReport lr = new LocalReport();
        private  void SaleReportA4_Load(object sender, EventArgs e)
        {
          
            if (PageSize.A4 == true)
            {
                salereportA4classic();
            }
            else if (PageSize.A4s == true)
            {
                salereportA4V();
            }
        }
        private DataTable shopname()
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            DataTable dt = new DataTable();
           
            SqlCommand cmd = new SqlCommand("select * from ShopDetails", cs);
            cs.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            cs.Close();
            return dt;
        }
        private DataTable termandcond()
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            DataTable dt = new DataTable();
           
            SqlCommand cmd = new SqlCommand("select * from Termsandcondtion", cs);
            cs.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            cs.Close();
            return dt;
        }
        public async void salereportA4V() // A4 White paper
        {
            await Task.Run(() => {

                SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
                SqlCommand cmd4 = new SqlCommand();
                SqlDataAdapter sda = new SqlDataAdapter("getinvoicereciept", cs);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@invoiceno", invc);
                DataSet dst = new DataSet();
                sda.Fill(dst, "SaleRecieptData"); //DataSet           
                ReportDataSource rds = new ReportDataSource("A4sale", dst.Tables[0]);
                ReportDataSource rds1 = new ReportDataSource("SD", shopname());
                ReportDataSource rds2 = new ReportDataSource("TC", termandcond());
                this.SaleReportA4Viewer.LocalReport.DataSources.Add(rds);
                this.SaleReportA4Viewer.LocalReport.DataSources.Add(rds1);
                this.SaleReportA4Viewer.LocalReport.DataSources.Add(rds2);
                this.SaleReportA4Viewer.LocalReport.ReportPath = Application.StartupPath + @"\\salereportA4Simple.rdlc";   
                this.SaleReportA4Viewer.LocalReport.EnableExternalImages = true;
                System.Drawing.Printing.PageSettings pg = new PageSettings();
                pg.PaperSize = new PaperSize("A4", 827, 1169);
                pg.PaperSize.RawKind = (int)PaperKind.A4;
                pg.Margins = new System.Drawing.Printing.Margins(20,20,30,30);
                this.SaleReportA4Viewer.SetPageSettings(pg);                 
            });        
            this.SaleReportA4Viewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.SaleReportA4Viewer.ZoomMode = ZoomMode.Percent;
            this.SaleReportA4Viewer.RefreshReport();
        }
        public async  void salereportA4classic()
        {
            await Task.Run(() => {
               
                SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
                SqlCommand cmd4 = new SqlCommand();
                SqlDataAdapter sda = new SqlDataAdapter("getinvoicereciept", cs);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@invoiceno", invc);
                DataSet dst = new DataSet();
                sda.Fill(dst, "SaleRecieptData"); //DataSet           
                ReportDataSource rds = new ReportDataSource("Salerecieptdataset", dst.Tables[0]);
                ReportDataSource rds1 = new ReportDataSource("SD", shopname());
                ReportDataSource rds2 = new ReportDataSource("TC", termandcond());
                this.SaleReportA4Viewer.LocalReport.DataSources.Add(rds);
                this.SaleReportA4Viewer.LocalReport.DataSources.Add(rds1);
                this.SaleReportA4Viewer.LocalReport.DataSources.Add(rds2);
                this.SaleReportA4Viewer.LocalReport.ReportPath = Application.StartupPath + @"\\SalerecieptA4.rdlc";
                this.SaleReportA4Viewer.LocalReport.EnableExternalImages = true;
                System.Drawing.Printing.PageSettings pg = new PageSettings();
                pg.PaperSize = new PaperSize("A4", 827, 1169);
                pg.PaperSize.RawKind = (int)PaperKind.A4;
                pg.Margins = new System.Drawing.Printing.Margins(20,20,30,30);
                this.SaleReportA4Viewer.SetPageSettings(pg);               
            });            
            this.SaleReportA4Viewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.SaleReportA4Viewer.ZoomMode = ZoomMode.Percent;
            this.SaleReportA4Viewer.RefreshReport();
           
        }

        private  void salebw_DoWork(object sender, DoWorkEventArgs e)
        {
            // salereportA4();

           
        }

        private void salebw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Waiting w = new Waiting();
            w.Show();
        }

        private void salebw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Waiting w = new Waiting();
            w.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaleReportA4Viewer.RefreshReport();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Task.Run(() => { 
            if (PageSize.A4 == true)
            {
                    try
                    {
                        SqlCommand cmd4 = new SqlCommand();
                        SqlDataAdapter sda = new SqlDataAdapter("getinvoicereciept", cs);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.AddWithValue("@invoiceno", invc);                        
                        DataSet dst = new DataSet();
                        sda.Fill(dst, "SaleRecieptData"); //DataSet
                        ReportDataSource rds = new ReportDataSource("Salerecieptdataset", dst.Tables[0]);
                        ReportDataSource rds1 = new ReportDataSource("SD", shopname());
                        ReportDataSource rds2 = new ReportDataSource("TC", termandcond());
                        lr.ReportPath = Application.StartupPath + @"\\SalerecieptA4.rdlc";
                        lr.DataSources.Add(rds);
                        lr.DataSources.Add(rds1);
                        lr.DataSources.Add(rds2);
                        LocalReportExtensions.PrintToPrinter(lr);
                        lr.DataSources.Clear();
                        lr.Refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            else if (PageSize.A4s == true)
                {
                    try
                    {

                        SqlCommand cmd4 = new SqlCommand();
                        SqlDataAdapter sda = new SqlDataAdapter("getinvoicereciept", cs);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.AddWithValue("@invoiceno", invc);                       
                        DataSet dst = new DataSet();
                        sda.Fill(dst, "SaleRecieptData"); //DataSet
                        ReportDataSource rds = new ReportDataSource("A4sale", dst.Tables[0]);
                        ReportDataSource rds1 = new ReportDataSource("SD", shopname());
                        ReportDataSource rds2 = new ReportDataSource("TC", termandcond());
                        lr.ReportPath = Application.StartupPath + @"\\salereportA4Simple.rdlc";
                        lr.DataSources.Add(rds);
                        lr.DataSources.Add(rds1);
                        lr.DataSources.Add(rds2);
                        LocalReportExtensions.PrintToPrinter(lr);
                        lr.DataSources.Clear();
                        lr.Refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            });
        }
    }
}
