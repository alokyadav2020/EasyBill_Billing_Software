using BillingApp.connection_class;
using BillingApp.main_class;
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
using BillingSystem.main_class;

namespace BillingSystem
{
    public partial class Roll3Inch : Form
    {
        Int64 bill;
        public Roll3Inch(Int64 billno)
        {
            bill = billno;
            InitializeComponent();
        }
        SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
        LocalReport lr = new LocalReport();
        public async void salereportroll3Inch()
        {
            await Task.Run(() => {

                SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
                SqlCommand cmd4 = new SqlCommand();
                SqlDataAdapter sda = new SqlDataAdapter("getrollinvoce", cs);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@invoiceno", bill);
                DataSet dst = new DataSet();
                sda.Fill(dst, "SaleRollPaper"); //DataSet           
                ReportDataSource rds = new ReportDataSource("roll3inch", dst.Tables[0]);
                ReportDataSource rds1 = new ReportDataSource("rollshop", shopname());
                ReportDataSource rds2 = new ReportDataSource("rollTandC", termandcond());
                this.roll3ichreport.LocalReport.DataSources.Add(rds);
                this.roll3ichreport.LocalReport.DataSources.Add(rds1);
                this.roll3ichreport.LocalReport.DataSources.Add(rds2);
                this.roll3ichreport.LocalReport.ReportPath = Application.StartupPath + @"\\Roll3inchrdlc.rdlc";
                System.Drawing.Printing.PageSettings pg = new PageSettings();
                pg.PaperSize = new PaperSize("Custom", 300, 700);
                pg.PaperSize.RawKind = (int)PaperKind.Custom;
                pg.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
                this.roll3ichreport.SetPageSettings(pg);
                
            });
            
            this.roll3ichreport.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.roll3ichreport.ZoomMode = ZoomMode.Percent;
            
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

        private void Roll3Inch_Load(object sender, EventArgs e)
        {
            this.roll3ichreport.RefreshReport();
           // this.roll3ichreport.Clear();
            salereportroll3Inch();
            
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.roll3ichreport.RefreshReport();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                print3roll();
            } 
        }

      private async void  print3roll()
        {
            await Task.Run(() =>

            {
                if (PageSize.Ther == true)
                {
                    try
                    {
                        SqlCommand cmd4 = new SqlCommand();
                        SqlDataAdapter sda = new SqlDataAdapter("getrollinvoce", cs);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.AddWithValue("@invoiceno", bill);
                        DataSet dst = new DataSet();
                        sda.Fill(dst, "SaleRollPaper"); //DataSet           
                        ReportDataSource rds = new ReportDataSource("roll3inch", dst.Tables[0]);
                        ReportDataSource rds1 = new ReportDataSource("rollshop", shopname());
                        ReportDataSource rds2 = new ReportDataSource("rollTandC", termandcond());
                        lr.ReportPath = Application.StartupPath + @"\\Roll3inchrdlc.rdlc";
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
                        MessageBox.Show(ex.Message);
                    }
                }


            });
        }
    }
}
