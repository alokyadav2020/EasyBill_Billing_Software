using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.Diagnostics;
using System.IO;
using BillingApp.main_class;
using System.Data.SqlClient;
using BillingApp.connection_class;

namespace BillingSystem
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
            
        }
        int imp;
        int gatcatid = 0;
        int savedata=0;
        private DataSet ds;
        Insertion insrt = new Insertion();
        retrievedata rtd = new retrievedata();
        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importtypelbl.Text = "Import Customer Details";
            imp = 0;
            supplierDetailsToolStripMenuItem.Enabled = false;
            productDetailsToolStripMenuItem.Enabled = false;
            IMPOERPANEL.Visible = true;
            productCatagoryToolStripMenuItem.Enabled = false;
            column();
        }

        private void supplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importtypelbl.Text = "Import Supplier Details";
            imp = 1;
            customerDetailsToolStripMenuItem.Enabled = false;
            productDetailsToolStripMenuItem.Enabled = false;
            IMPOERPANEL.Visible = true;
            productCatagoryToolStripMenuItem.Enabled = false;
            column();
        }

        private void productDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importtypelbl.Text = "Import Product Details";
            imp = 3;
            customerDetailsToolStripMenuItem.Enabled = false;
            supplierDetailsToolStripMenuItem.Enabled = false;
            IMPOERPANEL.Visible = true;
            productCatagoryToolStripMenuItem.Enabled = false;
            catidcb.Visible = true;
            column();
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            savedata = 0;
            OpenFileDialog oflg = new OpenFileDialog();
            oflg.Title = "Select Excel File";
            oflg.FileName = imoprtxt.Text;
            oflg.Filter = "Excel Sheet (*.xls)|*.xlsx|All Files(*.*)|*.*";
            oflg.FilterIndex = 1;
            oflg.RestoreDirectory = true;
            if (oflg.ShowDialog() == DialogResult.OK)
            {
                imoprtxt.Text = oflg.FileName;
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
        private void importbtn_Click(object sender, EventArgs e)
        {
            if (imoprtxt.Text != "")
            {
                importexcel();
            }
            else { MessageBox.Show("Please select excel file to import","Excel File Not Selected",MessageBoxButtons.OK,MessageBoxIcon.Information);}

        }
        void importexcel()
        {
            try
            {
                FileStream stream = new FileStream(imoprtxt.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                var sw = new Stopwatch();
                sw.Start();

                IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

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

               
                timelbl.Text = "Elapsed: " + sw.ElapsedMilliseconds.ToString() + " ms (" + openTiming.ToString() + " ms to open)";
               
                var tablenames = GetTablenames(ds.Tables);
                importcb.DataSource = tablenames;

                if (tablenames.Count > 0)
                    importcb.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void column()
        {
            if (imp == 0)
            {
                headerdgv.ColumnCount = 6;
                headerdgv.Columns[0].Name = "Customer Name";
                headerdgv.Columns[1].Name = "Address1";
                headerdgv.Columns[2].Name = "Address2";
                headerdgv.Columns[3].Name = "GSTN";
                headerdgv.Columns[4].Name = "Mobile";
                headerdgv.Columns[5].Name = "Email";
            }
            else if (imp == 1)
            {
                headerdgv.ColumnCount = 7;
                headerdgv.Columns[0].Name = "Firm Name";
                headerdgv.Columns[1].Name = "Supplier Name";
                headerdgv.Columns[2].Name = "Contact";
                headerdgv.Columns[3].Name = "Address1";
                headerdgv.Columns[4].Name = "Address2";
                headerdgv.Columns[5].Name = "GSTIN";
                headerdgv.Columns[6].Name = "Email";
            }
            else if (imp == 2)
            {
                headerdgv.ColumnCount = 3;
                headerdgv.Columns[0].Name = "Catagory Code";
                headerdgv.Columns[1].Name = "Catagory Name";
                headerdgv.Columns[2].Name = "Description";
                
            }
            else if (imp == 3)
            {
                headerdgv.ColumnCount = 9;
                headerdgv.Columns[0].Name = "Product Code";
                headerdgv.Columns[1].Name = "Product Name";
                headerdgv.Columns[2].Name = "HSN Code";
                headerdgv.Columns[3].Name = "Sale Price";
                headerdgv.Columns[4].Name = "GST(%)";
                headerdgv.Columns[5].Name = "Total Sale Price";
                headerdgv.Columns[6].Name = "MRP";
                headerdgv.Columns[7].Name = "Location";
                headerdgv.Columns[8].Name = "Opening Stock";
            }
        }
        private void SelectTable()
        {
            var tablename = importcb.SelectedItem.ToString();

            dgvimport.AutoGenerateColumns = true;
            
            dgvimport.DataSource = ds; // dataset
            dgvimport.DataMember = tablename;
           // column();
            dgvimport.ClearSelection();
            rowcountlbl.Text = "Total Row : "+dgvimport.Rows.Count.ToString();
            // GetValues(ds, tablename);
        }

        private void importcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTable();
            
        }

        private void productCatagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importtypelbl.Text = "Import Product Catagory";
            imp = 2;
            supplierDetailsToolStripMenuItem.Enabled = false;
            productDetailsToolStripMenuItem.Enabled = false;
            customerDetailsToolStripMenuItem.Enabled = false;
            IMPOERPANEL.Visible = true;
            column();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (dgvimport.Rows.Count > 0)
            {
                if (savedata == 0)
                {


                    if (imp == 0)
                    {
                        if (dgvimport.Columns.Count == 6)
                        {
                            for (int i = 0; i < dgvimport.Rows.Count; i++)
                            {
                                insrt.insertcustomer(dgvimport.Rows[i].Cells[0].Value.ToString(), dgvimport.Rows[i].Cells[1].Value.ToString(), dgvimport.Rows[i].Cells[2].Value.ToString(), dgvimport.Rows[i].Cells[3].Value.ToString(), dgvimport.Rows[i].Cells[4].Value.ToString(), dgvimport.Rows[i].Cells[5].Value.ToString());
                                savedata = 1;
                            }

                            statuslbl.Visible = true;
                            blink();
                        }
                        else { MessageBox.Show("For Catagory [Column should be 6] ", "Invalid Catagory Coumn", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    else if (imp == 1)
                    {
                        if (dgvimport.Columns.Count == 7)
                        {
                            for (int i = 0; i < dgvimport.Rows.Count; i++)
                            {
                                insrt.insertsupplier(dgvimport.Rows[i].Cells[0].Value.ToString(), dgvimport.Rows[i].Cells[1].Value.ToString(), dgvimport.Rows[i].Cells[2].Value.ToString(), dgvimport.Rows[i].Cells[3].Value.ToString(), dgvimport.Rows[i].Cells[4].Value.ToString(), dgvimport.Rows[i].Cells[5].Value.ToString(), dgvimport.Rows[i].Cells[6].Value.ToString());
                                savedata = 1;
                            }

                            statuslbl.Visible = true;
                            blink();
                        }
                        else { MessageBox.Show("For Catagory [Column should be 7] ", "Invalid Catagory Coumn", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    else if (imp == 2)
                    {
                        if (dgvimport.Columns.Count == 3)
                        {
                            for (int i = 0; i < dgvimport.Rows.Count; i++)
                            {
                                insrt.insertnewcatagogy(dgvimport.Rows[i].Cells[0].Value.ToString(), dgvimport.Rows[i].Cells[1].Value.ToString(), dgvimport.Rows[i].Cells[2].Value.ToString());
                                savedata = 1;
                            }

                            statuslbl.Visible = true;
                            blink();
                        }
                        else { MessageBox.Show("For Catagory [Column should be 3] ", "Invalid Catagory Coumn", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    else if (imp == 3)
                    {
                        if (catidcb.SelectedIndex != -1)
                        {
                            if (dgvimport.Columns.Count == 9)
                            {
                                for (int i = 0; i < dgvimport.Rows.Count; i++)
                                {
                                    insrt.insertproduct(dgvimport.Rows[i].Cells[0].Value.ToString(), dgvimport.Rows[i].Cells[1].Value.ToString(), dgvimport.Rows[i].Cells[2].Value.ToString(), Convert.ToDecimal(dgvimport.Rows[i].Cells[3].Value).ToString(), Convert.ToDouble(dgvimport.Rows[i].Cells[4].Value.ToString()), "0.00", "0.00", Convert.ToDecimal(dgvimport.Rows[i].Cells[5].Value).ToString(), Convert.ToDecimal(dgvimport.Rows[i].Cells[6].Value).ToString(), dgvimport.Rows[i].Cells[7].Value.ToString(), "0.00", "0.00", "0.00", Convert.ToString(gatcatid), dgvimport.Rows[i].Cells[8].Value.ToString() == "" ? "0" : dgvimport.Rows[i].Cells[8].Value.ToString());
                                    savedata = 1;
                                }

                                statuslbl.Visible = true;
                                blink();
                            }
                            else { MessageBox.Show("For Catagory [Column should be 9] ", "Invalid Catagory Coumn", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        }
                        else { MessageBox.Show("Please select catagory ", "catagory  not selected", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                }
                else { MessageBox.Show("You have Saved data successfully","Data Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);}
            }
            else { MessageBox.Show("Please select excel file to import", "Excel File Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);}
        }

        private void removerowbtn_Click(object sender, EventArgs e)
        {
            if (dgvimport.Rows.Count > 0)
            {
                int ri = dgvimport.CurrentCell.RowIndex;
                dgvimport.Rows.RemoveAt(ri);
                rowcountlbl.Text = "Total Row : " + dgvimport.Rows.Count.ToString();

            }
            else
            {
                MessageBox.Show("Please imoprt excel file ","Excel File Missing",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public async void blink()
        {
            while (true)
            {
                await Task.Delay(500);
                statuslbl.BackColor =statuslbl.BackColor== Color.Black ? Color.ForestGreen : Color.Black;
            }
        }

        private void Import_Load(object sender, EventArgs e)
        {
            rtd.loadCATcombo(catidcb);
            savedata = 0;
        }

        private void catidcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (catidcb.SelectedItem == null)
            {

            }
            else
            {
                try
                {
                    SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
                    int getcid;
                    SqlCommand cmd = new SqlCommand("catcomboselectchange", cs);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                    sdr.SelectCommand.Parameters.AddWithValue("@catname", catidcb.SelectedItem.ToString());
                    DataTable dt = new DataTable();
                    sdr.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        getcid = Convert.ToInt32(dt.Rows[0]["CatId"]);

                        //procodetxt.Text = getcid.ToString();
                        gatcatid = Convert.ToInt32(getcid.ToString());
                        // Decimal sgstvalue = Convert.ToDecimal((dt.Rows[0]["SGST"]).ToString());
                        // getcid.Text = cgetcid.ToString();
                        //sgsttxtt.Text = sgstvalue.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Import_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
   
}
