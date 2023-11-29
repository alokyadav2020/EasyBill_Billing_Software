using BillingApp.main_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class Profit_Loss : Form
    {
        public Profit_Loss()
        {
            InitializeComponent();
        }
        Int64 a,b,c;
        Viewalldata vd = new Viewalldata();
        private void profitlossbtn_Click(object sender, EventArgs e)
        {
            vd.pltotal("plstock", dgvpl1, spn, sq, sprice);
            vd.pltotal("plsale", dgvpl2, salepn,saleQuntity,saleprice);
            vd.pltotal("plpurchase", dgvpl3, prname,prq,prprice);
            totalvalue1();
            totalvalue2();
            totalvalue3();
            pl();
            dgvpl1.ClearSelection();
            dgvpl2.ClearSelection();
            dgvpl3.ClearSelection();
            //plpercen();
        }
        void totalvalue1()
        {
            Int64 ts=0;
            for (int i = 0; i < dgvpl1.Rows.Count; i++)
            {
                ts = ts + Convert.ToInt64(dgvpl1.Rows[i].Cells[2].Value);
            }
            stamountlbl.Text = ts.ToString("C");
        }
        void totalvalue2()
        {
            Int64 tsale = 0;
            for (int i = 0; i < dgvpl2.Rows.Count; i++)
            {
                tsale = tsale + Convert.ToInt64(dgvpl2.Rows[i].Cells[2].Value);
            }
            sallbl.Text = tsale.ToString("C");
             a = Convert.ToInt64(tsale.ToString());
        }
        void totalvalue3()
        {
            Int64 tpr = 0;
            for (int i = 0; i < dgvpl3.Rows.Count; i++)
            {
                tpr = tpr + Convert.ToInt64(dgvpl3.Rows[i].Cells[2].Value);
            }
            prlbl.Text = tpr.ToString("C");
             b = Convert.ToInt64(tpr.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            vd.pltotal("plstock", dgvpl1, spn, sq, sprice);
            vd.pltotalbtdate("plsalebtdate", dgvpl2, salepn, saleQuntity, saleprice,dt1.Value,dt2.Value);
            vd.pltotalbtdate("plpurchasebtdate", dgvpl3, prname, prq, prprice, dt1.Value, dt2.Value);
            totalvalue1();
            totalvalue2();
            totalvalue3();
            pl();
            dgvpl1.ClearSelection();
            dgvpl2.ClearSelection();
            dgvpl3.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
                sfd.FileName = "SocktReportAmount.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // creating Excel Application  
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    // creating new WorkBook within Excel application  
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    // creating new Excelsheet in workbook  
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    // see the excel sheet behind the program  
                    app.Visible = true;
                    // get the reference of first sheet. By default its name is Sheet1.  
                    // store its reference to worksheet  
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;
                    // changing the name of active sheet  
                    worksheet.Name = "Exported from gridview";
                    // storing header part in Excel  
                    for (int i = 1; i < dgvpl1.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dgvpl1.Columns[i - 1].HeaderText;
                    }
                    // storing Each row and column value to excel sheet  
                    for (int i = 0; i < dgvpl1.Rows.Count + 1; i++)
                    {
                        for (int j = 0; j < dgvpl1.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgvpl1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    // save the application  
                    workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    // Exit from the application  
                    app.Quit();
                }
            }
            catch (Exception)
            {
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
                sfd.FileName = "SaleReportAmount.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // creating Excel Application  
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    // creating new WorkBook within Excel application  
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    // creating new Excelsheet in workbook  
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    // see the excel sheet behind the program  
                    app.Visible = true;
                    // get the reference of first sheet. By default its name is Sheet1.  
                    // store its reference to worksheet  
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;
                    // changing the name of active sheet  
                    worksheet.Name = "Exported from gridview";
                    // storing header part in Excel  
                    for (int i = 1; i < dgvpl1.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dgvpl1.Columns[i - 1].HeaderText;
                    }
                    // storing Each row and column value to excel sheet  
                    for (int i = 0; i < dgvpl1.Rows.Count + 1; i++)
                    {
                        for (int j = 0; j < dgvpl1.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgvpl1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    // save the application  
                    workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    // Exit from the application  
                    app.Quit();
                }
            }
            catch (Exception)
            {
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
                sfd.FileName = "PurchaseReportAmount.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // creating Excel Application  
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    // creating new WorkBook within Excel application  
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    // creating new Excelsheet in workbook  
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    // see the excel sheet behind the program  
                    app.Visible = true;
                    // get the reference of first sheet. By default its name is Sheet1.  
                    // store its reference to worksheet  
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;
                    // changing the name of active sheet  
                    worksheet.Name = "Exported from gridview";
                    // storing header part in Excel  
                    for (int i = 1; i < dgvpl1.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dgvpl1.Columns[i - 1].HeaderText;
                    }
                    // storing Each row and column value to excel sheet  
                    for (int i = 0; i < dgvpl1.Rows.Count + 1; i++)
                    {
                        for (int j = 0; j < dgvpl1.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgvpl1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    // save the application  
                    workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    // Exit from the application  
                    app.Quit();
                }
            }
            catch (Exception )
            {

            }
        }

        void pl()
        {
           c = a - b;
            if (c > 0)
            {
                pllbl.BackColor = Color.LightGreen;
                plpanel.BackColor = Color.LightGreen;
                pllbl.Text = c.ToString("C");
                pllable.Text = "Profit";
                
            }
            else
            {
                pllbl.BackColor = Color.LightCoral;
                plpanel.BackColor = Color.LightCoral;
                pllbl.Text = c.ToString("C");
                pllable.Text = "Loss";
            }
        }
        void plpercen()
        {
            //Int64 plp = (c / b) * 100;
            
        }
    }
}
