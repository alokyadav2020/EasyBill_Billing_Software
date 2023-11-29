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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.OleDb;
using ExcelDataReader;

namespace BillingSystem
{
    public partial class CustomerAccount : Form
    {
        public CustomerAccount()
        {
            InitializeComponent();
        }
        retrievedata r = new retrievedata();
        Viewalldata vd = new Viewalldata();
        Int64 Bvalue;
        CustomerDiposit cd = new CustomerDiposit();
        decimal up = 0;
        decimal p= 0;
        //decimal b= 0;
        private void rbcname_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcname.Checked == true)
            {
                r.loadpartycus(custxt);               
                custxt.Text = "";
                custxt.Enabled = true;
                custxt.Focus();
                
            }
        }

        private void rbcmobile_CheckedChanged(object sender, EventArgs e)
        {
           
            custxt.Focus();
            custxt.Text = "";
            custxt.Enabled = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (custxt.Text == "")
            {
                MessageBox.Show("Please type to search", "search Information ?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbcname.Checked==true || rbcmobile.Checked == true)
            {
                //r.gcdsale(custxt.Text);
                r.gcd(custxt.Text, cidlbl, namelbl, mobilelbl, addresslbl);
                vd.customeraccount(Convert.ToInt32(cidlbl.Text),dgvcusacc,Invoice,PayableAmunt,cusp,borr,dt);
                vd.getdiposit(Convert.ToInt32(cidlbl.Text),dgvdiposit, da, ddt);
                dgvdiposit.ClearSelection();
                dgvcusacc.ClearSelection();
                total();
                dtotal();
                //balancelbl.Text = Convert.ToDecimal(upalbl.Text) - dipostamnlbl.Text;
                button2.Visible = true;

            }
            else {  MessageBox.Show("Please select Customer's name or Customer's mobile ", "Not selected", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        void total()
        {
            decimal a = 0;
            for (int i = 0; i < dgvcusacc.Rows.Count; i++)
            {
                int sum = Convert.ToInt32(dgvcusacc.Rows[i].Cells[3].Value);
                
                if (sum < 0)
                {
                    a = a + Convert.ToDecimal(dgvcusacc.Rows[i].Cells[3].Value);
                    
                    dgvcusacc.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                }
                else
                {
                  
                }
            }
            up = a;
            upalbl.Text = a.ToString("C");
            ticlbl.Text = dgvcusacc.Rows.Count.ToString();
        }

        void dtotal()
        {
            decimal b = 0;
            
                for (int i = 0; i < dgvdiposit.Rows.Count; i++)
                {
                    b= b+ Convert.ToDecimal(dgvdiposit.Rows[i].Cells[1].Value);
                }
                dipostamnlbl.Text = b.ToString("C");
                p = b;
                b = p + up;
                balancelbl.Text = b.ToString("C");

        }

        private void exportbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
                sfd.FileName = "CustomerPaidUnpaid.xlsx";
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
                    for (int i = 1; i < dgvcusacc.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dgvcusacc.Columns[i - 1].HeaderText;
                    }
                    // storing Each row and column value to excel sheet  
                    for (int i = 0; i < dgvcusacc.Rows.Count +1; i++)
                    {
                        for (int j = 0; j < dgvcusacc.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 1, j + 1] = dgvcusacc.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    // save the application  
                    workbook.SaveAs("c:\\output.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    // Exit from the application  
                    app.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifybtn_Click(object sender, EventArgs e)
        {
            if (dgvcusacc.Rows.Count > 0)
            {
                bool dgvindex = dgvcusacc.CurrentRow.Selected;
                if (dgvindex)
                {
                    
                    if (PageSize.A4 == true)
                    {
                        SaleReportA4 sr = new SaleReportA4(Bvalue);
                        sr.Show();
                    }
                    else if (PageSize.A4s == true)
                    {
                        SaleReportA4 sr = new SaleReportA4(Bvalue);
                        sr.Show();
                    }
                    else if (PageSize.A5V == true)
                    {
                        SalepageA5V spa5 = new SalepageA5V(Bvalue);
                        spa5.Show();
                        //spa5.salereportA5viwer.RefreshReport();
                    }
                    else if (PageSize.A5H == true)
                    {
                        ; SalepageA5V spa5 = new SalepageA5V(Bvalue);
                        spa5.Show();
                    }
                    else if (PageSize.Ther == true)
                    {
                        Roll3Inch r3 = new Roll3Inch(Bvalue);
                        r3.Show();
                    }
                    else if (PageSize.roll5 == true)
                    {
                        MessageBox.Show("Page Size Under the process");
                    }
                }
                else { MessageBox.Show("Please select INVOICE to view details", "Invoice not selected", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void CustomerAccount_Load(object sender, EventArgs e)
        {
            vd.selectpagesize(loggedInUser.UserName);
        }

        private void dgvcusacc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Bvalue = Convert.ToInt64(dgvcusacc.SelectedRows[0].Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            CustomerDiposit cd = new CustomerDiposit();
            r.gcd(custxt.Text, cidlbl, namelbl, mobilelbl, addresslbl);
            cd.cusm = custxt.Text;
            cd.ShowDialog();
        }

        private void custxt_KeyDown(object sender, KeyEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
                sfd.FileName = "CustomerDipositAccount.xlsx";
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
                    for (int i = 1; i < dgvdiposit.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dgvdiposit.Columns[i - 1].HeaderText;
                    }
                    // storing Each row and column value to excel sheet  
                    for (int i = 0; i < dgvdiposit.Rows.Count + 1; i++)
                    {
                        for (int j = 0; j < dgvdiposit.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgvdiposit.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    // save the application  
                    workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    // Exit from the application  
                    app.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
