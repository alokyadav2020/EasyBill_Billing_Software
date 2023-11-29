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

namespace BillingApp
{
    public partial class catagaryviews : Form
    {
        Viewalldata valld = new Viewalldata();
        Deleteall da = new Deleteall();
        NewCatagory nc = new NewCatagory();
        public int a;
        public catagaryviews()
        {
            InitializeComponent();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            valld.catagarview(catdgv, id, CatagoryCode, CatName, catDis);
            catdgv.ClearSelection();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCatagory nc = new NewCatagory();
            nc.ShowDialog();
        }
        private void catdgv_Click(object sender, EventArgs e)
        {
            if (catdgv.Rows.Count > 0)
            {
                a = Convert.ToInt32(catdgv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (a > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete ....?", "Delete Confermation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    da.deletecat(a);
                    valld.catagarview(catdgv, id, CatagoryCode, CatName, catDis);
                    catdgv.ClearSelection();
                }

            }
            else
            {
                MessageBox.Show("Please select ROW to delete", "ROW not selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void catagaryviews_Load(object sender, EventArgs e)
        {
            valld.catagarview(catdgv, id, CatagoryCode, CatName, catDis);
            catdgv.ClearSelection();
        }
        private void catdgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (catdgv.Rows.Count > 0)
            {
                nc.Isupdate = true;
                a = Convert.ToInt32(catdgv.SelectedRows[0].Cells[0].Value.ToString());
                nc.catid = a;
                nc.catagorycodetxt.Text = catdgv.SelectedRows[0].Cells[1].Value.ToString();
                nc.catagorynametxt.Text = catdgv.SelectedRows[0].Cells[2].Value.ToString();
                nc.catagorydiscriptiontxt.Text = catdgv.SelectedRows[0].Cells[3].Value.ToString();
                nc.ShowDialog();
                valld.catagarview(catdgv, id, CatagoryCode, CatName, catDis);
                catdgv.ClearSelection();
            }
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
                sfd.FileName = "Product_Catagory.xlsx";
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
                    for (int i = 1; i < catdgv.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = catdgv.Columns[i - 1].HeaderText;
                    }
                    // storing Each row and column value to excel sheet  
                    for (int i = 0; i < catdgv.Rows.Count + 1; i++)
                    {
                        for (int j = 0; j < catdgv.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = catdgv.Rows[i].Cells[j].Value.ToString();
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
    }
}
