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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;


namespace BillingApp
{
    public partial class ProductDetailView : Form
    {
        ProductRegistration pr = new ProductRegistration();
        int getproid;
        public ProductDetailView()
        {
            InitializeComponent();
        }
        retrievedata sear = new retrievedata();
        private void rfbtn_Click(object sender, EventArgs e)
        {
             textBox1.Text = "";
             Viewalldata va = new Viewalldata();
             va.productview(prodgv, PID, procode, proname, prono, prosale, gst, cgst, sgst, tsp, mrp, pp, gstamnt, cgstamnt, sgctamnt, catid);
             netbalance();
             rowcountlbl.Text = prodgv.Rows.Count.ToString();
             pcombo.SelectedItem = null;
             prodgv.ClearSelection();
            prodgv.Refresh();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                Viewalldata va = new Viewalldata();
                va.productview(prodgv, PID, procode, proname, prono, prosale, gst, cgst, sgst, tsp, mrp, pp, gstamnt, cgstamnt, sgctamnt, catid);
                netbalance();
                rowcountlbl.Text = prodgv.Rows.Count.ToString();
            }
            else
            {
                sear.searpro(prodgv, textBox1.Text.Trim(), PID, procode, proname, prono, prosale, gst, cgst, sgst, tsp, mrp, pp, gstamnt, cgstamnt, sgctamnt, catid);
                pcombo.SelectedItem = null;
                netbalance();
                rowcountlbl.Text = prodgv.Rows.Count.ToString();
            }
            netbalance();
            rowcountlbl.Text = prodgv.Rows.Count.ToString("N");
        }
        private void prodgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (prodgv.Rows.Count > 0)
            {
                pr.Isupdatepro = true;
                getproid = Convert.ToInt32(prodgv.SelectedRows[0].Cells[0].Value.ToString());
                pr.productid = getproid;
                // pr.catcombobox.SelectedItem = prodgv.SelectedRows[0].Cells[14].Value.ToString();
                pr.procodetxt.Text = prodgv.SelectedRows[0].Cells[1].Value.ToString();
                pr.pronametxt.Text = prodgv.SelectedRows[0].Cells[2].Value.ToString();
                pr.propartnotxt.Text = prodgv.SelectedRows[0].Cells[3].Value.ToString();
                pr.prosalepircetxt.Text = prodgv.SelectedRows[0].Cells[4].Value.ToString();
                //  pr.prosalepircetxt.Text = prodgv.SelectedRows[0].Cells[5].Value.ToString();
                pr.cgstproduct.Text = prodgv.SelectedRows[0].Cells[6].Value.ToString();
                pr.sgstproduct.Text = prodgv.SelectedRows[0].Cells[7].Value.ToString();
                pr.protsalepricetxt.Text = prodgv.SelectedRows[0].Cells[8].Value.ToString();
                pr.mrptxt.Text = prodgv.SelectedRows[0].Cells[9].Value.ToString();
                pr.propurchagepricetxt.Text = prodgv.SelectedRows[0].Cells[10].Value.ToString();
                pr.gstamntlbl.Text = prodgv.SelectedRows[0].Cells[11].Value.ToString();
                pr.cgstamntlbl.Text = prodgv.SelectedRows[0].Cells[12].Value.ToString();
                pr.sgstamntlbl.Text = prodgv.SelectedRows[0].Cells[13].Value.ToString();
                pr.ShowDialog();
                prodgv.Refresh();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Stock stck = new Stock();
            stck.ShowDialog();
        }
        private void ProductDetailView_Load(object sender, EventArgs e)
        {
           /* Viewalldata va = new Viewalldata();
            va.productview(prodgv, PID, procode, proname, prono, prosale, gst, cgst, sgst, tsp, mrp, pp, gstamnt, cgstamnt, sgctamnt, catid);
            netbalance();
            rowcountlbl.Text = prodgv.Rows.Count.ToString();*/
        }
        void netbalance()
        {
            int nb = 0;
            for (int i = 0; i < prodgv.Rows.Count; i++)
            {
                nb = nb + Convert.ToInt32(prodgv.Rows[i].Cells[9].Value);
            }
            
        }

        private void ProductDetailView_Activated(object sender, EventArgs e)
        {
            sear.loadCATcombo(pcombo);
        }

        private void pcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pcombo.SelectedItem == null)
            {

            }
            else
            {
                sear.selectCombpro(prodgv, pcombo, PID, procode, proname, prono, prosale, gst, cgst, sgst, tsp, mrp, pp, gstamnt, cgstamnt, sgctamnt, catid);
                textBox1.Text = "";
                netbalance();
                rowcountlbl.Text = prodgv.Rows.Count.ToString();
                prodgv.ClearSelection();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
                sfd.FileName = "SupplierDetails.xlsx";
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
                    for (int i = 1; i < prodgv.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = prodgv.Columns[i - 1].HeaderText;
                    }
                    // storing Each row and column value to excel sheet  
                    for (int i = 0; i < prodgv.Rows.Count + 1; i++)
                    {
                        for (int j = 0; j < prodgv.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = prodgv.Rows[i].Cells[j].Value.ToString();
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
    }
}
