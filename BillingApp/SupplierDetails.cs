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
    public partial class SupplierDetails : Form
    {
        public SupplierDetails()
        {
            InitializeComponent();
        }
        Supplier s = new Supplier();
        Viewalldata vad = new Viewalldata();
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.ShowDialog();
        }

        private void SupplierDetails_Load(object sender, EventArgs e)
        {
            vad.suppleiropview(supplierdgv, sid, Sfirm, sname, smobile, sadd1, sadd2, sgstin, semail);
            supplierdgv.ClearSelection();
        }
        
        private void supplierdgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            s.sid = Convert.ToInt32(supplierdgv.SelectedRows[0].Cells[0].Value);
            s.firmtxt.Text = supplierdgv.SelectedRows[0].Cells[1].Value.ToString();
            s.snametxt.Text = supplierdgv.SelectedRows[0].Cells[2].Value.ToString();
            s.smobiletxt.Text = supplierdgv.SelectedRows[0].Cells[3].Value.ToString();
            s.sadd1txt.Text = supplierdgv.SelectedRows[0].Cells[4].Value.ToString();
            s.sadd2txt.Text = supplierdgv.SelectedRows[0].Cells[5].Value.ToString();
            s.sgstintxt.Text = supplierdgv.SelectedRows[0].Cells[6].Value.ToString();
            s.semailtxt.Text = supplierdgv.SelectedRows[0].Cells[7].Value.ToString();
            s.isupdates = true;
            s.ShowDialog();
            s.Refresh();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vad.suppleiropview(supplierdgv, sid, Sfirm, sname, smobile, sadd1, sadd2, sgstin, semail);
            supplierdgv.ClearSelection();
        }

        private void searchsupliertxt_TextChanged(object sender, EventArgs e)
        {
            vad.suppleisearrch(searchsupliertxt.Text, supplierdgv, sid, Sfirm, sname, smobile, sadd1, sadd2, sgstin, semail);
            supplierdgv.ClearSelection();
        }

        private void exportExcelToolStripMenuItem_Click(object sender, EventArgs e)
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
                    for (int i = 1; i < supplierdgv.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = supplierdgv.Columns[i - 1].HeaderText;
                    }
                    // storing Each row and column value to excel sheet  
                    for (int i = 0; i < supplierdgv.Rows.Count + 1; i++)
                    {
                        for (int j = 0; j < supplierdgv.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = supplierdgv.Rows[i].Cells[j].Value.ToString();
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
