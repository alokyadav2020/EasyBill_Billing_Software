using BillingApp.main_class;
using BillingSystem.main_class;
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
    public partial class Supplieraccount : Form
    {
        public Supplieraccount()
        {
            InitializeComponent();
        }
        retrievedata r = new retrievedata();
        Viewalldata vd = new Viewalldata();
        private void Supplieraccount_Load(object sender, EventArgs e)
        {
            r.loadpartysup(suptxt);
        }

        private void supbtn_Click(object sender, EventArgs e)
        {
            if (suptxt.Text != "")
            {
                r.gsd(suptxt.Text, snamelbl, saddlblb);
                vd.getsupaccount(dgvsup, Currenttime.sid, pin, sin, pa, ca, unp, dt);
                dgvsup.ClearSelection();
                total();
            }                       
        }

        private void suptxt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    SelectNextControl(ActiveControl, true, true, true, true);
                }
            }
            catch
            {
            }
        }

        void total()
        {
            decimal a = 0;
            decimal b = 0;
            decimal c = 0;
            for (int i = 0; i < dgvsup.Rows.Count; i++)
            {
                int sum = Convert.ToInt32(dgvsup.Rows[i].Cells[4].Value);
                if (sum > 0)
                {                    
                    dgvsup.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                }
                a = a + Convert.ToDecimal(dgvsup.Rows[i].Cells[2].Value);
                b = b + Convert.ToDecimal(dgvsup.Rows[i].Cells[3].Value);
                c = c + Convert.ToDecimal(dgvsup.Rows[i].Cells[4].Value);
            }
            
            tnalbl.Text = a.ToString("C");
            tpalbl.Text = b.ToString("C");
            tuplbl.Text = c.ToString("C");
            //ticlbl.Text = dgvcusacc.Rows.Count.ToString();
        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            if (dgvsup.Rows.Count > 0)
            {
                bool dgvindex = dgvsup.CurrentRow.Selected;
                if (dgvindex)
                {
                    paytosuppiler pt = new paytosuppiler();
                    pt.snlbl.Text = snamelbl.Text.ToString();
                    pt.saddlbl.Text = saddlblb.Text.ToString();
                    pt.sbill = Convert.ToInt64(dgvsup.SelectedRows[0].Cells[0].Value);
                    pt.pbillnolbl.Text= dgvsup.SelectedRows[0].Cells[0].Value.ToString();
                    pt.sinlbl.Text = dgvsup.SelectedRows[0].Cells[1].Value.ToString();
                    pt.npalbl.Text= dgvsup.SelectedRows[0].Cells[2].Value.ToString();
                    pt.palbl.Text = dgvsup.SelectedRows[0].Cells[3].Value.ToString();
                    pt.unpalbl.Text =dgvsup.SelectedRows[0].Cells[4].Value.ToString();
                    pt.paydate.Value = Convert.ToDateTime(dgvsup.SelectedRows[0].Cells[5].Value.ToString());
                    pt.ShowDialog();
                    dgvsup.Refresh();
                }
                else { MessageBox.Show("Please select purchage invoice to view bill", "Row Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Please select date to view purchage details", "Select Date ", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void Exportbtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
                sfd.FileName = "SupplierPaidUnpaid.xlsx";
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
                    for (int i = 1; i < dgvsup.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dgvsup.Columns[i - 1].HeaderText;
                    }
                    // storing Each row and column value to excel sheet  
                    for (int i = 0; i < dgvsup.Rows.Count + 1; i++)
                    {
                        for (int j = 0; j < dgvsup.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgvsup.Rows[i].Cells[j].Value.ToString();
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

        private void viewbillbtn_Click(object sender, EventArgs e)
        {
            if (dgvsup.Rows.Count > 0)
            {
                bool dgvindex = dgvsup.CurrentRow.Selected;
                if (dgvindex)
                {
                    PurchaseDetails pd = new PurchaseDetails();
                    pd.PBNO = Convert.ToInt64(dgvsup.SelectedRows[0].Cells[0].Value);
                    pd.ShowDialog();
                }
                else { MessageBox.Show("Please select purchage invoice to view bill", "Row Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Please select date to view purchage details", "Select Date ", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Int64 Bvalue;
        private void dgvsup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Bvalue = Convert.ToInt64(dgvsup.SelectedRows[0].Cells[0].Value);
        }
    }
}
