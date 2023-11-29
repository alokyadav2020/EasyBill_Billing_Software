
using BillingApp.connection_class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillingSystem;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Windows.Forms;
using BillingSystem.main_class;
using System.Drawing.Printing;

namespace BillingApp.main_class
{
    class PrintSaleReciept
    {     
        SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
        LocalReport lr = new LocalReport();
        public async void PrintREcieptAfourAsync(Int64 invno)
        {
           await Task.Run(() => {
               
              if (PageSize.A4 == true) // A4 Page
              {
                
                try
                {
                    
                    SqlCommand cmd4 = new SqlCommand();
                    SqlDataAdapter sda = new SqlDataAdapter("getinvoicerecieptbyuser", cs);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("@invoiceno", invno);
                    sda.SelectCommand.Parameters.AddWithValue("@uname", loggedInUser.UserName);
                    DataSet dst = new DataSet();
                    sda.Fill(dst, "SaleRecieptData"); //DataSet
                    ReportDataSource rds = new ReportDataSource("Salerecieptdataset", dst.Tables[0]);
                    ReportDataSource rds1 = new ReportDataSource("SD", shopname());
                    ReportDataSource rds2 = new ReportDataSource("TC", termandcond());
                    lr.ReportPath = Application.StartupPath + @"\\SalerecieptA4.rdlc";
                    lr.EnableExternalImages = true;
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
                       SqlDataAdapter sda = new SqlDataAdapter("getinvoicerecieptbyuser", cs);
                       sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                       sda.SelectCommand.Parameters.AddWithValue("@invoiceno", invno);
                       sda.SelectCommand.Parameters.AddWithValue("@uname", loggedInUser.UserName);
                       DataSet dst = new DataSet();
                       sda.Fill(dst, "SaleRecieptData"); //DataSet
                       ReportDataSource rds = new ReportDataSource("A4sale", dst.Tables[0]);
                       ReportDataSource rds1 = new ReportDataSource("SD", shopname());
                       ReportDataSource rds2 = new ReportDataSource("TC", termandcond());
                       lr.ReportPath = Application.StartupPath + @"\\salereportA4Simple.rdlc";
                       lr.EnableExternalImages = true;
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
               else if (PageSize.A5V == true) // A5V Page
            {
                try
                {
                    SqlCommand cmd4 = new SqlCommand();
                    SqlDataAdapter sda = new SqlDataAdapter("getinvoicerecieptbyuser", cs);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("@invoiceno", invno);
                    sda.SelectCommand.Parameters.AddWithValue("@uname", loggedInUser.UserName);
                    DataSet dst = new DataSet();
                    sda.Fill(dst, "SaleRecieptData"); //DataSet
                    ReportDataSource rds = new ReportDataSource("SRD", dst.Tables[0]);
                    ReportDataSource rds1 = new ReportDataSource("SD", shopname());
                    ReportDataSource rds2 = new ReportDataSource("TC", termandcond());
                    lr.ReportPath = Application.StartupPath + @"\\SaleRecieptA5V.rdlc";
                    lr.EnableExternalImages = true;
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
                       SqlDataAdapter sda = new SqlDataAdapter("getinvoicerecieptbyuser", cs);
                       sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                       sda.SelectCommand.Parameters.AddWithValue("@invoiceno", invno);
                       sda.SelectCommand.Parameters.AddWithValue("@uname", loggedInUser.UserName);
                       DataSet dst = new DataSet();
                       sda.Fill(dst, "SaleRecieptData"); //DataSet
                       ReportDataSource rds = new ReportDataSource("A5H", dst.Tables[0]);
                       ReportDataSource rds1 = new ReportDataSource("SD", shopname());
                       ReportDataSource rds2 = new ReportDataSource("TC", termandcond());
                       lr.ReportPath = Application.StartupPath + @"\\A5land.rdlc";
                       lr.EnableExternalImages = true;
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
            else if (PageSize.Ther == true)
               {
                   try
                   {
                       SqlCommand cmd4 = new SqlCommand();
                       SqlDataAdapter sda = new SqlDataAdapter("getrollbillbyuser", cs);
                       sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                       sda.SelectCommand.Parameters.AddWithValue("@invoiceno", invno);
                       sda.SelectCommand.Parameters.AddWithValue("@uname", loggedInUser.UserName);
                       DataSet dst = new DataSet();
                       sda.Fill(dst, "SaleRollPaper"); //DataSet           
                       ReportDataSource rds = new ReportDataSource("roll3inch", dst.Tables[0]);
                       ReportDataSource rds1 = new ReportDataSource("rollshop", shopname());
                       ReportDataSource rds2 = new ReportDataSource("rollTandC", termandcond());
                       lr.ReportPath = Application.StartupPath + @"\\Roll3inchrdlc.rdlc";
                       lr.EnableExternalImages = true;
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
               else if (PageSize.roll5 == true)
               {
                   PrintDoc pdoc = new PrintDoc();
                   pdoc.inv = invno;
                   pdoc.print4page();
               }
               else
               {
                  
               }
                
            });
        }
        private   DataTable shopname()
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select ShopName,ShopAddress,ShopContact,GSTIN,Logo from ShopDetails", cs);
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
            SqlCommand cmd = new SqlCommand("select Line1,Line2,Line3,Line4 from Termsandcondtion", cs);
            cs.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            cs.Close();
            return dt;
        }
        void printoprinter()
        {
            System.Drawing.Printing.PageSettings pg = new PageSettings();
            pg.PaperSize = new PaperSize("A5", 583, 827);
            pg.PaperSize.RawKind = (int)PaperKind.A5;
            pg.Margins = new System.Drawing.Printing.Margins(15, 15, 15, 15);
            PrintDocument pd = new PrintDocument();
                      
            //salereportA5viwer.SetPageSettings(pg);
        }

        void printsale(Int64 invno)
        {

           
        }
        /*  ReportDocument rd = new ReportDocument();
          SalereceiptA4 sr = new SalereceiptA4(); // Sale Page designe   
          Reciept r = new Reciept();
          public void PrintRecieptA4()
          {
              SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
              SqlCommand cmd = new SqlCommand();
              SqlDataAdapter sda = new SqlDataAdapter("getinvoicerecieptbyuser", cs);
              sda.SelectCommand.CommandType = CommandType.StoredProcedure;
              sda.SelectCommand.Parameters.AddWithValue("@invoiceno", getinvoiceno());
              sda.SelectCommand.Parameters.AddWithValue("@uname", loggedInUser.UserName);
              DataSet dst = new DataSet();
              sda.Fill(dst, "SaleRecieptData"); //DataSet
              sr.Load("SalereceiptA4.rpt");           
              sr.SetDataSource(dst);           
              sr.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
              sr.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
              sr.PrintToPrinter(1, false, 0, 0);
          }
          int getinvoiceno()
          {
              SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
              SqlCommand cmd = new SqlCommand("getinvoice", cs);
              cmd.CommandType = CommandType.StoredProcedure;
              cs.Open();
              int maxinvoice = Convert.ToInt32(cmd.ExecuteScalar());
              cs.Close();
              return maxinvoice;
          }
        /*  public void viewrecieptA4()
          {
              SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
              SqlCommand cmd = new SqlCommand();
              SqlDataAdapter sda = new SqlDataAdapter("getinvoicerecieptbyuser", cs);
              sda.SelectCommand.CommandType = CommandType.StoredProcedure;
              sda.SelectCommand.Parameters.AddWithValue("@invoiceno", getinvoiceno());
              sda.SelectCommand.Parameters.AddWithValue("@uname", loggedInUser.UserName);
              DataSet dst = new DataSet();
              sda.Fill(dst, "SaleRecieptData"); // DataSet Load
              sr.Load("RecieptReportViewerA4");
              sr.SetDataSource(dst);
              r.RecieptReportViewerA4.ReportSource = sr;
              r.RecieptReportViewerA4.Refresh();            
          }*/
        /* public void selectpagesize()
         {
             try
             {
                 SqlCommand cmd = new SqlCommand("getsalepagesize", cs);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cs.Open();
                 SqlDataReader sdr = cmd.ExecuteReader();
                 while (sdr.Read())
                 {

                     psa4 = Convert.ToBoolean(sdr.GetBoolean(1));
                     psa5v = Convert.ToBoolean(sdr.GetBoolean(2));
                     psba5h = Convert.ToBoolean(sdr.GetBoolean(3));
                     psth = Convert.ToBoolean(sdr.GetBoolean(4));


                     // sdr.GetBoolean(1) = psa4.ToString();
                 }
                 cs.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }*/
    }
}
