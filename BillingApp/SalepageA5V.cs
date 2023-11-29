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
    public partial class SalepageA5V : Form
    {
        Int64 invc;
        public SalepageA5V(Int64 invno)
        {
            invc = invno;
            InitializeComponent();
        }
        SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
        LocalReport lr = new LocalReport();
        private  void SalepageA5V_Load(object sender, EventArgs e)
        {
            try
            {
                if (PageSize.A5V == true)
                {
                    A5v();
                }
                else if (PageSize.A5H == true)
                {
                    A5H();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
        public async void A5v()
        {
           
            await Task.Run(() =>
            {
                SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
                SqlCommand cmd4 = new SqlCommand();
                SqlDataAdapter sda = new SqlDataAdapter("getinvoicereciept", cs);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@invoiceno", invc);
                DataSet dst = new DataSet();
                sda.Fill(dst, "SaleRecieptData"); //DataSet           
                ReportDataSource rds = new ReportDataSource("SRD", dst.Tables[0]);
                ReportDataSource rds1 = new ReportDataSource("SD", shopname());
                ReportDataSource rds2 = new ReportDataSource("TC", termandcond());
                this.salereportA5viwer.LocalReport.DataSources.Add(rds);
                this.salereportA5viwer.LocalReport.DataSources.Add(rds1);
                this.salereportA5viwer.LocalReport.DataSources.Add(rds2);
                this.salereportA5viwer.LocalReport.ReportPath = Application.StartupPath + @"\\SaleRecieptA5V.rdlc";
                System.Drawing.Printing.PageSettings pg = new PageSettings();
                pg.PaperSize = new PaperSize("A5", 583, 827);
                pg.PaperSize.RawKind = (int)PaperKind.A5;
                pg.Margins = new System.Drawing.Printing.Margins(15, 15, 15, 15);
                this.salereportA5viwer.SetPageSettings(pg);
                //this.salereportA5viwer.RefreshReport();                      
               
            });
           // this.salereportA5viwer.Width = 583;
           // this.salereportA5viwer.Height = 827;
            this.salereportA5viwer.SetDisplayMode(DisplayMode.PrintLayout);
            this.salereportA5viwer.ZoomMode = ZoomMode.Percent;
            this.salereportA5viwer.RefreshReport();

        }
        public async void A5H()
        {
            await Task.Run(() =>
            {
                SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
                SqlCommand cmd4 = new SqlCommand();
                SqlDataAdapter sda = new SqlDataAdapter("getinvoicereciept", cs);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@invoiceno", invc);
                DataSet dst = new DataSet();
                sda.Fill(dst, "SaleRecieptData"); //DataSet           
                ReportDataSource rds = new ReportDataSource("A5H", dst.Tables[0]);
                ReportDataSource rds1 = new ReportDataSource("SD", shopname());
                ReportDataSource rds2 = new ReportDataSource("TC", termandcond());
                this.salereportA5viwer.LocalReport.DataSources.Add(rds);
                this.salereportA5viwer.LocalReport.DataSources.Add(rds1);
                this.salereportA5viwer.LocalReport.DataSources.Add(rds2);
                this.salereportA5viwer.LocalReport.ReportPath = Application.StartupPath + @"\\A5land.rdlc";
                System.Drawing.Printing.PageSettings pg = new PageSettings();
                pg.PaperSize = new PaperSize("A5",583, 827);
                pg.PaperSize.RawKind = (int)PaperKind.A5;
                pg.Landscape = true;
                pg.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
                this.salereportA5viwer.SetPageSettings(pg);
                //this.salereportA5viwer.RefreshReport();                      

            });
           // this.salereportA5viwer.Width = 827;
          //  this.salereportA5viwer.Height = 583;
            this.salereportA5viwer.SetDisplayMode(DisplayMode.PrintLayout);
            this.salereportA5viwer.ZoomMode = ZoomMode.Percent;            
            this.salereportA5viwer.RefreshReport();
            this.salereportA5viwer.Clear();

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

        private void salereportA5viwer_Load(object sender, EventArgs e)
        {

        }

        private void SalepageA5V_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void refrshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.salereportA5viwer.RefreshReport();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Task.Run(() => 
            
            {
                if (PageSize.A5V == true)
                {
                    try
                    {
                        SqlCommand cmd4 = new SqlCommand();
                        SqlDataAdapter sda = new SqlDataAdapter("getinvoicereciept", cs);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.AddWithValue("@invoiceno", invc);                       
                        DataSet dst = new DataSet();
                        sda.Fill(dst, "SaleRecieptData"); //DataSet
                        ReportDataSource rds = new ReportDataSource("SRD", dst.Tables[0]);
                        ReportDataSource rds1 = new ReportDataSource("SD", shopname());
                        ReportDataSource rds2 = new ReportDataSource("TC", termandcond());
                        lr.ReportPath = Application.StartupPath + @"\\SaleRecieptA5V.rdlc";
                        lr.DataSources.Add(rds);
                        lr.DataSources.Add(rds1);
                        lr.DataSources.Add(rds2);
                        //printoprinter();
                        LocalReportExtensions.PrintToPrinter(lr);
                        lr.DataSources.Clear();
                        lr.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else if (PageSize.A5H == true)
                {
                    try
                    {
                        SqlCommand cmd4 = new SqlCommand();
                        SqlDataAdapter sda = new SqlDataAdapter("getinvoicereciept", cs);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.AddWithValue("@invoiceno", invc);                        
                        DataSet dst = new DataSet();
                        sda.Fill(dst, "SaleRecieptData"); //DataSet
                        ReportDataSource rds = new ReportDataSource("A5H", dst.Tables[0]);
                        ReportDataSource rds1 = new ReportDataSource("SD", shopname());
                        ReportDataSource rds2 = new ReportDataSource("TC", termandcond());
                        lr.ReportPath = Application.StartupPath + @"\\A5land.rdlc";
                        lr.DataSources.Add(rds);
                        lr.DataSources.Add(rds1);
                        lr.DataSources.Add(rds2);
                        //printoprinter();
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
