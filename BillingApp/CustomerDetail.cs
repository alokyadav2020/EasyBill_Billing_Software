using BillingApp.connection_class;
using BillingApp.main_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.OleDb;
using ExcelDataReader;
using System.Diagnostics;

namespace BillingApp
{
    public partial class CustomerDetail : Form
    {
        //private DataSet ds;
        public CustomerDetail()
        {
            InitializeComponent();
        }
        CustomerDetails cd = new CustomerDetails();
        Viewalldata v = new Viewalldata();
        private void CustomerDetail_Load(object sender, EventArgs e)
        {
            Viewalldata v = new Viewalldata();
            v.customertopview(dgvcustomer, cid, cname, ca1, ca2, ca3, cm, cem);
            dgvcustomer.ClearSelection();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

            v.customerpreview(dgvcustomer, cid, cname, ca1, ca2, ca3, cm, cem);
            dgvcustomer.ClearSelection();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvcustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvcustomer.SelectedRows[0].Cells[0].Value);
            cd.cid = id;
            cd.CNTXT.Text = dgvcustomer.SelectedRows[0].Cells[1].Value.ToString();
            cd.CA1TXT.Text = dgvcustomer.SelectedRows[0].Cells[2].Value.ToString();
            cd.CA2TXT.Text = dgvcustomer.SelectedRows[0].Cells[3].Value.ToString();
            cd.CA3TXT.Text = dgvcustomer.SelectedRows[0].Cells[4].Value.ToString();
            cd.CMTXT.Text = dgvcustomer.SelectedRows[0].Cells[5].Value.ToString();
            cd.CEMAILTXT.Text = dgvcustomer.SelectedRows[0].Cells[6].Value.ToString();
            cd.isupdatec = true;
            cd.ShowDialog();
            dgvcustomer.Refresh();


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
        }

        private void cussearchtxt_TextChanged(object sender, EventArgs e)
        {
            v.customertsearch(cussearchtxt.Text, dgvcustomer, cid, cname, ca1, ca2, ca3, cm, cem);
            dgvcustomer.ClearSelection();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private DataTable getdata()
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from SaleDetail", cs);
            cs.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            cs.Close();
            return dt;
        }

        private void exportExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
                sfd.FileName = "Customer.xlsx";
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
                    for (int i = 1; i < dgvcustomer.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dgvcustomer.Columns[i - 1].HeaderText;
                    }
                    // storing Each row and column value to excel sheet  
                    for (int i = 0; i < dgvcustomer.Rows.Count + 1; i++)
                    {
                        for (int j = 0; j < dgvcustomer.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgvcustomer.Rows[i].Cells[j].Value.ToString();
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

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void browbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog oflg = new OpenFileDialog();
            oflg.Title = "Select Excel File";
            //oflg.FileName = pathtxt.Text;
            oflg.Filter = "Excel Sheet (*.xls)|*.xls|All Files(*.*)|*.*";
            oflg.FilterIndex = 1;
            oflg.RestoreDirectory = true;
            if (oflg.ShowDialog() == DialogResult.OK)
            {
              //  pathtxt.Text = oflg.FileName;
            }
        }
        private static IList<string> GetTablenames(DataTableCollection tables)
        {
            var tableList = new List<string>();
            foreach (var table in tables)
            {
                tableList.Add(table.ToString());
            }

            return tableList;
        }
        private void loadbtn_Click(object sender, EventArgs e)
        {
         /*   try
            {
                //FileStream stream = new FileStream(pathtxt.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                var sw = new Stopwatch();
                sw.Start();

               // IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

                var openTiming = sw.ElapsedMilliseconds;
                // reader.IsFirstRowAsColumnNames = firstRowNamesCheckBox.Checked;
                ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    UseColumnDataType = false,
                    ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                    {
                       // UseHeaderRow = checkBox1.Checked
                    }
                });

                label2.Text = "Elapsed: " + sw.ElapsedMilliseconds.ToString() + " ms (" + openTiming.ToString() + " ms to open)";

                var tablenames = GetTablenames(ds.Tables);
                comboBox1.DataSource = tablenames;

                if (tablenames.Count > 0)
                    comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }
        private void SelectTable()
        {
            //var tablename = comboBox1.SelectedItem.ToString();

            //dgvcustomer.AutoGenerateColumns = true;
           // dgvcustomer.DataSource = ds; // dataset
           // dgvcustomer.DataMember = tablename;

            // GetValues(ds, tablename);
        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTable();
            dgvcustomer.ClearSelection();
        }
    }
} 

        
    

