using BillingApp.connection_class;
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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        public int loadvalue { get; set; }
        private void Report_Load(object sender, EventArgs e)
        {
            if (loadvalue == 0)
            {
                namelbl.Text = "Sale Report Between Two Dates !!";
            }
            else if (loadvalue == 1) { namelbl.Text="Purchase Report Between Two Dates !!"; }
            this.salereport.RefreshReport();
            this.salereport.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loadvalue == 0)
            {
               
                salereportbydate();
            }
            else if (loadvalue == 1) { purchasereportbydate(); }
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
        public async void salereportbydate()
        {
            await Task.Run(() => {

                SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
                SqlCommand cmd4 = new SqlCommand();
                SqlDataAdapter sda = new SqlDataAdapter("getsalehistorybtwdate", cs);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@date1", d1.Value);
                sda.SelectCommand.Parameters.AddWithValue("@date2", d2.Value);
                DataSet dst = new DataSet();
                sda.Fill(dst, "SaleReportByDate"); //DataSet           
                ReportDataSource rds = new ReportDataSource("salereportbydate", dst.Tables[0]);
                ReportDataSource rds1 = new ReportDataSource("SD", shopname());                
                this.salereport.LocalReport.DataSources.Add(rds);
                this.salereport.LocalReport.DataSources.Add(rds1);                
                this.salereport.LocalReport.ReportPath = Application.StartupPath + @"\\salereportbydate.rdlc";
                this.salereport.LocalReport.EnableExternalImages = true;                
                ReportParameter[] parms = new ReportParameter[2];
                parms[0] = new ReportParameter("ReportParameter1", d1.Value.ToString());
                parms[1] = new ReportParameter("ReportParameter2", d2.Value.ToString());
                this.salereport.LocalReport.SetParameters(parms);                               
            });            
            this.salereport.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.salereport.ZoomMode = ZoomMode.Percent;
            this.salereport.RefreshReport();
           // this.salereport.Clear();
        }
        public async void purchasereportbydate()
        {
            await Task.Run(() => {

                SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
                SqlCommand cmd4 = new SqlCommand();
                SqlDataAdapter sda = new SqlDataAdapter("getpurchasedetailsBTWDATE", cs);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@date1", d1.Value);
                sda.SelectCommand.Parameters.AddWithValue("@date2", d2.Value);
                DataSet dst = new DataSet();
                sda.Fill(dst, "PurchaseReportbydate"); //DataSet           
                ReportDataSource rds = new ReportDataSource("purchasebydate", dst.Tables[0]);
                ReportDataSource rds1 = new ReportDataSource("SD", shopname());
                this.salereport.LocalReport.DataSources.Add(rds);
                this.salereport.LocalReport.DataSources.Add(rds1);
                this.salereport.LocalReport.ReportPath = Application.StartupPath + @"\\purchasereport.rdlc";
                this.salereport.LocalReport.EnableExternalImages = true;
                ReportParameter[] parms = new ReportParameter[2];
                parms[0] = new ReportParameter("ReportParameter1", d1.Value.ToString());
                parms[1] = new ReportParameter("ReportParameter2", d2.Value.ToString());
                this.salereport.LocalReport.SetParameters(parms);
            });
            this.salereport.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.salereport.ZoomMode = ZoomMode.Percent;
            this.salereport.RefreshReport();
            //this.salereport.Clear();
        }
    }
}
