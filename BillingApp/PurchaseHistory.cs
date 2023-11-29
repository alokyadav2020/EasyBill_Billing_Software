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
    public partial class PurchaseHistory : Form
    {
        public PurchaseHistory()
        {
            InitializeComponent();
        }
        Viewalldata v = new Viewalldata();
        retrievedata r = new retrievedata();
        private void Loadbtwbtn_Click(object sender, EventArgs e)
        {
            v.viewpurchsae(date1.Value, date2.Value, purchasedeataildgv, pbn, sin, sfn, gns, gnp, gngsta, gncgsta, gnsgsta, pdatetime);
            purchasedeataildgv.ClearSelection();
            countp();
            pb1.BackColor = Color.GreenYellow;
            pb2.BackColor = Color.YellowGreen;
            pb3.BackColor = Color.AliceBlue;
            pb4.BackColor = Color.LightSteelBlue;
            suppliernameforpurchagetxt.Text = "";           
            date3.Value = DateTime.Today;
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            v.viewpurchsaebydate(date3.Value, purchasedeataildgv, pbn, sin, sfn, gns, gnp, gngsta, gncgsta, gnsgsta, pdatetime);
            purchasedeataildgv.ClearSelection();
            countp();
            pb3.BackColor = Color.GreenYellow;
            pb4.BackColor = Color.YellowGreen;
            pb1.BackColor = Color.AliceBlue;
            pb2.BackColor = Color.LightSteelBlue;
            suppliernameforpurchagetxt.Text = "";
            date1.Value = DateTime.Today;
            date2.Value = DateTime.Today;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void suppliernameforpurchagetxt_Leave(object sender, EventArgs e)
        {
           
        }

        private void PurchaseHistory_Activated(object sender, EventArgs e)
        {
            r.loadpartysup(suppliernameforpurchagetxt);
        }

        private void loadbysupplierbtn_Click(object sender, EventArgs e)
        {
            if (suppliernameforpurchagetxt.Text != "")
            {
                r.gsdp(suppliernameforpurchagetxt.Text);
                v.viewpurchsaebysid(purchasedeataildgv, pbn, sin, sfn, gns, gnp, gngsta, gncgsta, gnsgsta, pdatetime);
                purchasedeataildgv.ClearSelection();
                countp();
                pb1.BackColor = Color.AliceBlue;
                pb2.BackColor = Color.LightSteelBlue;
                pb3.BackColor = Color.AliceBlue;
                pb4.BackColor = Color.LightSteelBlue;
            }
            else { MessageBox.Show("Please type supplier name in  textbox","Supplier Name ?",MessageBoxButtons.OK,MessageBoxIcon.Information);}
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
        void countp()
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < purchasedeataildgv.Rows.Count; i++)
            {
                a = a + Convert.ToInt32(purchasedeataildgv.Rows[i].Cells[4].Value);
                b = b + Convert.ToInt32(purchasedeataildgv.Rows[i].Cells[5].Value);
            }
            tnslbl.Text = a.ToString("N");
            tnplbl.Text = b.ToString("N");
            siclbl.Text = purchasedeataildgv.Rows.Count.ToString();
        }

        private void PurchaseHistory_Load(object sender, EventArgs e)
        {
            date1.Value = DateTime.Today;
            date2.Value = DateTime.Today;
            date3.Value = DateTime.Today;
        }

        private void purchasedeataildgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex!=-1 && e.RowIndex != -1)
            {
                if (purchasedeataildgv.Columns[e.ColumnIndex].Name == "viewpurchsae")
                {

                    PurchaseDetails pd = new PurchaseDetails();
                    pd.PBNO = Convert.ToInt64(purchasedeataildgv.SelectedRows[0].Cells[1].Value);
                    pd.ShowDialog();
                }
            }
           
        }

        private void PurchaseHistory_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    e.SuppressKeyPress = true;
                    SendKeys.Send("{tab}");
                }
                else if (e.KeyCode == Keys.Up)
                {
                    e.SuppressKeyPress = true;
                    SendKeys.Send("+{tab}");
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }

            }
            catch
            {
            }
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            if (purchasedeataildgv.Rows.Count > 0)
            {
                bool dgvindex = purchasedeataildgv.CurrentRow.Selected;
                if (dgvindex)
                {
                    PurchaseDetails pd = new PurchaseDetails();
                    pd.PBNO = Convert.ToInt64(purchasedeataildgv.SelectedRows[0].Cells[1].Value);
                    pd.ShowDialog();
                }
                else { MessageBox.Show("Please select purchage invoice to view bill","Row Not Selected",MessageBoxButtons.OK,MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Please select date to view purchage details","Select Date ",MessageBoxButtons.OK,MessageBoxIcon.Information);}
        }

        private void excelbtn_Click(object sender, EventArgs e)
        {
            if (purchasedeataildgv.Rows.Count > 0)
            {
                try
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
                    sfd.FileName = "PurchageHistory.xlsx";
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
                        for (int i = 1; i < purchasedeataildgv.Columns.Count + 1; i++)
                        {
                            worksheet.Cells[1, i] = purchasedeataildgv.Columns[i - 1].HeaderText;
                        }
                        // storing Each row and column value to excel sheet  
                        for (int i = 0; i < purchasedeataildgv.Rows.Count + 1; i++)
                        {
                            for (int j = 0; j < purchasedeataildgv.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1] = purchasedeataildgv.Rows[i].Cells[j].Value.ToString();
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
                    //MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
