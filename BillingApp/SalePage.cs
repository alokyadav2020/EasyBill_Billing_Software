using BillingApp.connection_class;
using BillingApp.main_class;
using BillingSystem;
using BillingSystem.main_class;
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

namespace BillingApp
{
    public partial class SalePage : Form
    {
        Decimal aa, bb, cc, ee, ff, hh, gg, ngg,xx, yy, zz, sp, sd, sg, spa,nmrp;
        int tpq = 0;
        
        bool pcheck;
        retrievedata r = new retrievedata();
        PrintSaleReciept psr = new PrintSaleReciept();
        Viewalldata vd = new Viewalldata();
        CustomerDetails cd = new CustomerDetails();
        public SalePage()
        {
            InitializeComponent();
        }        
        private void ritembtn_Click(object sender, EventArgs e)
        {
            if (saledgv.Rows.Count > 0)
            {
                int ri = saledgv.CurrentCell.RowIndex;
                saledgv.Rows.RemoveAt(ri);
                totalvalue();
                statuslbl.Text = "Selected item has been removed from cart            ----  Success  ----                                              Remaning Item  =  " + saledgv.Rows.Count.ToString();
                statusStrip1.BackColor = Color.ForestGreen;
            }
            else
            {
                statuslbl.Text = "There is no Item in Cart    !!!";                
                statusStrip1.BackColor = Color.OrangeRed;
            }
        }
        private void mobilectxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char ch = e.KeyChar;
            if (char.IsDigit(ch)) { e.Handled = false; } else if (ch == 8) { e.Handled = false; } else { e.Handled = true; }
        }
        private void mobilectxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mobilectxt.Text.Trim()))
            {
                statusStrip1.BackColor = Color.OrangeRed;
                statuslbl.Text = "Please Enter 10 Digit Mobile Number   !!!!!";
                cnlbl.Text = "--------------";
                ca1lbl.Text = "--------------";
                ca2lbl.Text = "--------------";
                cid.Text = "";
            }
            else
            {
                if (mobilectxt.Text.Length == 10)
                {                    
                      statusStrip1.BackColor = Color.ForestGreen;
                      statuslbl.Text = "----------Done----------         Press 'Tab' to check customer details    !!!!!";
                }
                else
                {
                    statusStrip1.BackColor = Color.Orange;
                    statuslbl.Text = "Please Enter 10 Digit Mobile Number   !!!!!";
                    cnlbl.Text = "--------------";
                    ca1lbl.Text = "--------------";
                    ca2lbl.Text = "--------------";
                    cid.Text = "";
                }
            }
        }
        saleinsertion s = new saleinsertion();
        private void paybtn_Click(object sender, EventArgs e)
        {
            if (saledgv.Rows.Count > 0)
            {
                if (backgroundWorker2.IsBusy != true)
                {
                    // Start the asynchronous operation.
                    backgroundWorker2.RunWorkerAsync();
                }
            }
            else
            {
                statusStrip1.BackColor = Color.Red;
                statuslbl.Text = "yor 'Cart' is Epmety , Please select product and 'ADD' to cart then proceed for payment  ";
                salecombo.Focus();
                salecombo.SelectedItem = -1;
            }
        }       
        private void newinvoicebtn_Click(object sender, EventArgs e)
        {
            SalePage sp = new SalePage();
            sp.Show();
        }
        private void mobiletxt_Leave(object sender, EventArgs e)
        {
            if (mobilectxt.Text.Length == 10)
            {
               
                r.gcd(mobilectxt.Text, cid, cnlbl, ca1lbl, ca2lbl);
                statuslbl.Text = "----------------Please Check Customer Details Like          'Name'        'Addess'----------------";
                statusStrip1.BackColor = Color.Green;
            }
            else
            {
                statuslbl.Text = "Mobile Number should be '10' Digit not less then '10'  !!!!!!";
                statusStrip1.BackColor = Color.Red;
            }
            mobilectxt.BackColor = Color.WhiteSmoke;
        }
        private void cpaytxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch)) { e.Handled = false; } else if (ch == 8) { e.Handled = false; } else { e.Handled = true; }
        }
        private void cpaytxt_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cpaytxt.Text.Trim()))
            {
                balancelbl.Text = "0.00";
                balanreturlblb.Text = "Balance ";
                balancelbl.ForeColor = Color.Black;            
            }
            else
            {
                Decimal s = Convert.ToDecimal(sumpaylbl.Text);
                Decimal c = Convert.ToDecimal(cpaytxt.Text.Trim());
                if (s <= c)
                {
                    Decimal bp = c - s;
                    balancelbl.Text = bp.ToString("N");
                    balanreturlblb.Text = "Return :";
                    balancelbl.ForeColor = Color.Red;
                }
                else
                {
                    Decimal bp = c - s;
                    balancelbl.Text = bp.ToString("N");
                    balanreturlblb.Text = "Balance :";
                    balancelbl.ForeColor = Color.RoyalBlue;
                }
            }
        }
        private void cpaytxt_Enter(object sender, EventArgs e)
        {
            cpaytxt.BackColor = Color.Yellow;
            cpaytxt.Text = "";
        }
        private void cpaytxt_Leave(object sender, EventArgs e)
        {
            if (cpaytxt.Text == "")
            {
                cpaytxt.Text = "0.00";
                balancelbl.Text = "0.00";
                Decimal s = Convert.ToDecimal(sumpaylbl.Text);
                Decimal c = Convert.ToDecimal(cpaytxt.Text.Trim());                
                Decimal bp = c - s;
                balancelbl.Text = bp.ToString("N");
                balanreturlblb.Text = "Balance :";
                balancelbl.ForeColor = Color.RoyalBlue;             
            }
            cpaytxt.BackColor = Color.WhiteSmoke;
            paybtn.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (PageSize.A4 == true)
            {
                SaleReportA4 sr = new SaleReportA4(getinvoiceno());
                sr.Show();
            }
            else if (PageSize.A4s == true)
            {
                SaleReportA4 sr = new SaleReportA4(getinvoiceno());
                sr.Show();
            }
            else if (PageSize.A5V == true)
            {
                SalepageA5V spa5 = new SalepageA5V(getinvoiceno());
                spa5.Show();
            }
            else if (PageSize.A5H == true)
            {
                SalepageA5V spa5 = new SalepageA5V(getinvoiceno());
                spa5.Show();
            }
            else if (PageSize.Ther == true)
            {
                Roll3Inch rl = new Roll3Inch(getinvoiceno());
                rl.Show();
            }
            else if (PageSize.roll5 == true)
            {
                MessageBox.Show("Page Size is not setup yet");
            }
            //SaleReportA4 sr = new SaleReportA4(getinvoiceno());
            // sr.Show();
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

        private void saledgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
            //saledgv.Rows[e.RowIndex].Selected = true;// saledgv.Rows[e.RowIndex].Selected = false;
        }

        private void salecombo_Leave(object sender, EventArgs e)
        {
            salecombo.BackColor = Color.WhiteSmoke;
        }

        private void salecombo_Enter(object sender, EventArgs e)
        {
            salecombo.BackColor = Color.Yellow;
        }

        private void QuaTXT_Enter(object sender, EventArgs e)
        {
            QuaTXT.BackColor = Color.Yellow;
        }

        private void QuaTXT_Leave(object sender, EventArgs e)
        {
            QuaTXT.BackColor = Color.WhiteSmoke;
        }

        private void DisTXT_Enter(object sender, EventArgs e)
        {
            DisTXT.BackColor = Color.Yellow;
        }

        private void DisTXT_Leave(object sender, EventArgs e)
        {
            DisTXT.BackColor = Color.WhiteSmoke;
            serilanotxt.Focus();
        }

        private void mobilectxt_Enter(object sender, EventArgs e)
        {
            mobilectxt.BackColor = Color.Yellow;
        }

        private void addcartbtn_Enter(object sender, EventArgs e)
        {
            addcartbtn.BackColor = Color.Yellow;
            addcartbtn.ForeColor = Color.Black;
        }

        private void addcartbtn_Leave(object sender, EventArgs e)
        {
            addcartbtn.BackColor = Color.Navy;
            addcartbtn.ForeColor = Color.White;
        }

        private void prviewlbbtn_Enter(object sender, EventArgs e)
        {
            prviewlbbtn.BackColor = Color.Yellow;
            prviewlbbtn.ForeColor = Color.Black;
        }

        private void prviewlbbtn_Leave(object sender, EventArgs e)
        {
            prviewlbbtn.BackColor = Color.DarkMagenta;
            prviewlbbtn.ForeColor = Color.White;
        }

        private void ritembtn_Enter(object sender, EventArgs e)
        {
            ritembtn.BackColor = Color.Yellow;
            ritembtn.ForeColor = Color.Black;
        }

        private void ritembtn_Leave(object sender, EventArgs e)
        {
            ritembtn.BackColor = Color.Crimson;
            ritembtn.ForeColor = Color.White;
        }

        private void SalePage_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control == true && e.KeyCode == Keys.F1)
                {
                    salecombo.Focus();
                    salecombo.SelectedItem = null;
                }
                else if (e.Control == true && e.KeyCode == Keys.F2)
                {
                    mobilectxt.Focus();
                }
                else if (e.Control == true && e.KeyCode == Keys.Down)
                {
                    e.SuppressKeyPress = true;
                    SendKeys.Send("{tab}");
                }
                else if (e.Control == true && e.KeyCode == Keys.N)
                {
                    salecombo.Focus();
                    salecombo.SelectedItem = null;
                    Rbtnbyname.Checked = true;
                }
                else if (e.Control == true && e.KeyCode == Keys.C)
                {
                    salecombo.Focus();
                    salecombo.SelectedItem = null;
                    Rbtnbycode.Checked = true;
                }
                else if (e.KeyCode == Keys.Up)
                {
                    e.SuppressKeyPress = false;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rbtnbyname_CheckedChanged(object sender, EventArgs e)
        {
            salecombo.Focus();
            salecombo.SelectedItem = null;
            r.loadprocombo(salecombo, Rbtnbyname, Rbtnbycode);
            
        }

        private void Rbtnbycode_CheckedChanged(object sender, EventArgs e)
        {
            salecombo.Focus();
            salecombo.SelectedItem = null;
            r.loadprocombo(salecombo, Rbtnbyname, Rbtnbycode);
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tlbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

          /*  for (int i = 1; i <= 10; i++)
            {
                // Perform a time consuming operation and report progress.
                //  System.Threading.Thread.Sleep(500);
                worker.ReportProgress(i * 10);

            }*/

            this.Invoke(new MethodInvoker(delegate ()
            {
                if (saledgv.Rows.Count > 0)
                {
                    if (cid.Text == "")
                    {

                        DialogResult dr = MessageBox.Show("Are you sure to proceed without customer detail.....?", "customer details missing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            if (saledgv.Rows.Count > 0)
                            {
                                s.sale(Convert.ToInt64(invoicelbl.Text), Convert.ToDecimal(sumdislbl.Text), Convert.ToDecimal(sumgstamntlblb.Text), Convert.ToInt32(tpqlbl.Text), Convert.ToDecimal(sumplbl.Text), Convert.ToDecimal(cpaytxt.Text.Trim()), Convert.ToDecimal(balancelbl.Text), Convert.ToDecimal(sumpaylbl.Text),1, balanreturlblb.Text, saleuserlbl.Text, Convert.ToDecimal(cgstsalelbl.Text), Convert.ToDecimal(sgstsalelbl.Text), Convert.ToDecimal(tsavinglbl.Text), saledgv, "pr_id", "salepn", "PartNo", "saleq", "salepp", "salep", "saledis", "saleamount", "salegst", "salegstamount", "saleta", "tspdgv", saledt.Value);
                                DialogResult pdr = MessageBox.Show(" Sale Record With Invoice No. '" + invoicelbl.Text + "',\n\n Total Payament Amount '" + sumpaylbl.Text + "',  has been saved successfully.\n ..........................................................................................\n ...........................................................................................\n\n DO YOU WANT TO PRINT THIS RECORD ?", "Invoice Print...?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (pdr == DialogResult.Yes)
                                {

                                    psr.PrintREcieptAfourAsync(getinvoiceno());

                                }
                                saledgv.Rows.Clear();
                                totalvalue();
                                mobilectxt.Text = "";
                                //statusStrip1.BackColor = Color.ForestGreen;
                                // statuslbl.Text = "-------------------------Payment -----------------  success--------------------------";
                                cpaytxt.Text = "";
                                salecombo.SelectedItem = null;
                                // salecombo.Focus();
                            }
                            else
                            {
                                statusStrip1.BackColor = Color.Red;
                                statuslbl.Text = "your 'Cart' is Empety , Please select product and 'ADD' to cart then proceed for payment  ";
                                salecombo.Focus();
                                salecombo.SelectedItem = null;
                            }
                        }
                        else
                        {
                            mobilectxt.Focus();
                        }
                    }
                    else
                    {
                        if (saledgv.Rows.Count > 0)
                        {
                            s.sale(Convert.ToInt64(invoicelbl.Text), Convert.ToDecimal(sumdislbl.Text), Convert.ToDecimal(sumgstamntlblb.Text), Convert.ToInt32(tpqlbl.Text), Convert.ToDecimal(sumplbl.Text), Convert.ToDecimal(cpaytxt.Text.Trim()), Convert.ToDecimal(balancelbl.Text), Convert.ToDecimal(sumpaylbl.Text), Convert.ToInt32(cid.Text), balanreturlblb.Text, saleuserlbl.Text, Convert.ToDecimal(cgstsalelbl.Text), Convert.ToDecimal(sgstsalelbl.Text), Convert.ToDecimal(tsavinglbl.Text), saledgv, "pr_id", "salepn", "PartNo", "saleq", "salepp", "salep", "saledis", "saleamount", "salegst", "salegstamount", "saleta", "tspdgv", saledt.Value);
                            DialogResult pdr = MessageBox.Show(" Sale Record With Invoice No. '" + invoicelbl.Text + "',\n\n Total Payament Amount '" + sumpaylbl.Text + "',  has been saved successfull.\n ...........................................................................................\n ...........................................................................................\n\n DO YOU WANT TO PRINT THIS RECORD ?", "Invoice Print...?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (pdr == DialogResult.Yes)
                            {

                                psr.PrintREcieptAfourAsync(getinvoiceno());

                            }
                            saledgv.Rows.Clear();
                            totalvalue();
                            mobilectxt.Text = "";
                            //statusStrip1.BackColor = Color.ForestGreen;
                            //statuslbl.Text = "-------------------------Payment -----------------  success--------------------------";
                            cpaytxt.Text = "";
                            //salecombo.Focus();
                            salecombo.SelectedItem = null;
                        }
                        else
                        {
                            statusStrip1.BackColor = Color.Red;
                            statuslbl.Text = "yor 'Cart' is Epmety , Please select product and 'ADD' to cart then proceed for payment  ";
                            salecombo.Focus();
                            salecombo.SelectedItem = null;
                        }
                    }

                }
                else
                {
                    statusStrip1.BackColor = Color.Red;
                    statuslbl.Text = "yor 'Cart' is Epmety , Please select product and 'ADD' to cart then proceed for payment  ";
                    salecombo.Focus();
                    salecombo.SelectedItem = null;
                }
            }));               
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            salecombo.Focus();
            saleProgressBar1.Visible = true;
            statusStrip1.BackColor = Color.MidnightBlue;
            statuslbl.Text = "-----------Processing -----------Saving Data-----------------";
            saleProgressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusStrip1.BackColor = Color.ForestGreen;
            statuslbl.Text = "-------------------------Payment -----------------  success--------------------------";
            saleProgressBar1.Visible =false;
            salecombo.Focus();
            tsavinglbl.Text = "0.00";
        }

        private void paybtn_Enter(object sender, EventArgs e)
        {
            paybtn.BackColor = Color.Yellow;
            paybtn.ForeColor = Color.Black;
        }

        private void paybtn_Leave(object sender, EventArgs e)
        {
            paybtn.BackColor = Color.ForestGreen;
            paybtn.ForeColor = Color.White;
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button1.ForeColor = Color.Black;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.ForestGreen;
            button1.ForeColor = Color.White;
        }

        private void salecombo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (salecombo.Text == "")
                {
                    mobilectxt.Focus();
                }
            }
        }

        private void QuaTXT_KeyDown(object sender, KeyEventArgs e)
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

        private void DisTXT_KeyDown(object sender, KeyEventArgs e)
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

        private void cpaytxt_KeyDown(object sender, KeyEventArgs e)
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

       /* private void serilanotxt_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void serilanotxt_Enter(object sender, EventArgs e)
        {
            
        }

        private void serilanotxt_Leave(object sender, EventArgs e)
        {
            
        }*/

        private void serilanotxt_Leave_1(object sender, EventArgs e)
        {
            serilanotxt.BackColor = Color.WhiteSmoke;
            addcartbtn.Focus();
        }

        private void serilanotxt_Enter_1(object sender, EventArgs e)
        {
            serilanotxt.BackColor = Color.Yellow;
        }

        private void serilanotxt_KeyDown_1(object sender, KeyEventArgs e)
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

        private void mobilectxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                cpaytxt.Focus();
            }
        }
        //string pname = 
        private void addcartbtn_Click(object sender, EventArgs e)
        {
            if (Currenttime.withserial == true)
            {
                addcartwithserial();
                serilanotxt.Text = "";
                
            }
            else { addtocard();  }
        }
        void addcartwithserial()
        {
            if (salecombo.Text != "" && pronametxt.Text != "N")
            {
                saledgv.Rows.Add(prid.Text, pronametxt.Text + "\n"+Currenttime.serialtype+" " + serilanotxt.Text, partnolbl.Text, QuaTXT.Text, unitpricelbl.Text, ratelbl.Text, disamntlbl.Text, salepricelbl.Text, gstlbl.Text, gstamountlbl.Text, totalamontlbl.Text, tmrplbl.Text,tsplbl.Text);
                totalvalue();
                clearcontrol();
                statuslbl.Text = "Item has been added in cart          ------  Success -----                                                            Total Item  =  " + saledgv.Rows.Count.ToString();
                statusStrip1.BackColor = Color.ForestGreen;
                prid.Text = "";
                cpaytxt.Enabled = true;
                cpaytxt.Text = "0.00";
                cpaytxt.SelectAll();
                balancelbl.Text = "0.00";
                saledgv.ClearSelection();
                saledgv.FirstDisplayedScrollingRowIndex = saledgv.RowCount - 1;
                Decimal mrr = Convert.ToDecimal(nmrplbl.Text) - Convert.ToDecimal(sumpaylbl.Text);
                tsavinglbl.Text = mrr.ToString("N");
            }
        }
        void addtocard()
        {
            if (salecombo.Text != "" && pronametxt.Text != "N")
            {
                if (saledgv.RowCount == 0)
                {
                    saledgv.Rows.Add(prid.Text, pronametxt.Text , partnolbl.Text, QuaTXT.Text, unitpricelbl.Text, ratelbl.Text, disamntlbl.Text, salepricelbl.Text, gstlbl.Text, gstamountlbl.Text, totalamontlbl.Text, tmrplbl.Text,tsplbl.Text);
                    totalvalue();
                    clearcontrol();
                    statuslbl.Text = "Item has been added in cart          ------  Success -----                                                            Total Item  =  " + saledgv.Rows.Count.ToString();
                    statusStrip1.BackColor = Color.ForestGreen;
                    prid.Text = "";
                    cpaytxt.Enabled = true;
                    cpaytxt.Text = "0.00";
                    cpaytxt.SelectAll();
                    balancelbl.Text = "0.00";
                    saledgv.ClearSelection();
                    saledgv.FirstDisplayedScrollingRowIndex = saledgv.RowCount - 1;
                    Decimal mrr = Convert.ToDecimal(nmrplbl.Text) - Convert.ToDecimal(sumpaylbl.Text);
                    tsavinglbl.Text = mrr.ToString("N");
                }
                else
                {
                    foreach (DataGridViewRow row in saledgv.Rows)
                    {
                        if (row.Cells["pr_id"].Value.ToString() == prid.Text)
                        {
                            pcheck = true;
                            break;
                        }
                        else
                        {
                            pcheck = false;
                        }
                    }
                    if (pcheck == true)
                    {
                        foreach (DataGridViewRow row in saledgv.Rows)
                        {
                            if (row.Cells["pr_id"].Value.ToString() == prid.Text)
                            {
                                row.Cells["saleq"].Value = Convert.ToInt32(row.Cells["saleq"].Value) + Convert.ToInt32(QuaTXT.Text);
                                row.Cells["salep"].Value = Convert.ToDecimal(row.Cells["salep"].Value) + Convert.ToDecimal(ratelbl.Text);
                                row.Cells["saledis"].Value = Convert.ToDecimal(row.Cells["saledis"].Value) + Convert.ToDecimal(disamntlbl.Text);
                                row.Cells["salegstamount"].Value = Convert.ToDecimal(row.Cells["salegstamount"].Value) + Convert.ToDecimal(gstamountlbl.Text);
                                row.Cells["saleta"].Value = Convert.ToDecimal(row.Cells["saleta"].Value) + Convert.ToDecimal(totalamontlbl.Text);
                                row.Cells["mrpt"].Value = Convert.ToDecimal(row.Cells["mrpt"].Value) + Convert.ToDecimal(tmrplbl.Text);
                                totalvalue();
                                clearcontrol();
                                statuslbl.Text = "Same Item added in cart          ------  Success -----                                                            Total Quantity for this perticular item is    " + row.Cells["saleq"].Value.ToString();
                                statusStrip1.BackColor = Color.ForestGreen;
                                prid.Text = "";
                                saledgv.ClearSelection();
                                saledgv.FirstDisplayedScrollingRowIndex = saledgv.RowCount - 1;
                                Decimal mrr = Convert.ToDecimal(nmrplbl.Text) - Convert.ToDecimal(sumpaylbl.Text);
                                tsavinglbl.Text = mrr.ToString("N");
                            }
                        }
                    }
                    else
                    {
                        saledgv.Rows.Add(prid.Text, pronametxt.Text, partnolbl.Text, QuaTXT.Text, unitpricelbl.Text, ratelbl.Text, disamntlbl.Text, salepricelbl.Text, gstlbl.Text, gstamountlbl.Text, totalamontlbl.Text, tmrplbl.Text,tsplbl.Text);
                        totalvalue();
                        clearcontrol();
                        statuslbl.Text = "Item has been added in cart          ------  Success -----                                                            Total Item  =  " + saledgv.Rows.Count.ToString();
                        statusStrip1.BackColor = Color.ForestGreen;
                        prid.Text = "";
                        cpaytxt.Enabled = true;
                        cpaytxt.Text = "0.00";
                        cpaytxt.SelectAll();
                        balancelbl.Text = "0.00";
                        saledgv.ClearSelection();
                        saledgv.FirstDisplayedScrollingRowIndex = saledgv.RowCount - 1;
                        Decimal mrr = Convert.ToDecimal(nmrplbl.Text) - Convert.ToDecimal(sumpaylbl.Text);
                        tsavinglbl.Text = mrr.ToString("N");
                    }
                }
            }
            else
            {
                statuslbl.Text = "Please Select Item from ' Select Item ' then add to cart  !!!!!!";
                statusStrip1.BackColor = Color.Red;
            }
        }

        private void costtxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(costtxt.Text.Trim()))
            {
                disamntlbl.Text = "0.00";
            }
            disamntlbl.Text = "0.00";
        }

        ComboSelectChange csc = new ComboSelectChange();

        private void costtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void costtxt_Leave(object sender, EventArgs e)
        {
            costtxt.BackColor = Color.WhiteSmoke;
            if (costtxt.Text == "")
            {

                salecombo.SelectedIndex = -1;
                salecombo.Focus();
            }
            else
            {
                cost();
                if ( Convert.ToDecimal(tsplbl.Text) <= Convert.ToDecimal(costtxt.Text))
                {
                    DisTXT.Enabled = true;
                    DisTXT.Focus();
                }
                else { DisTXT.Enabled = false; }
            }
            
        }

        private void costtxt_Enter(object sender, EventArgs e)
        {
            costtxt.BackColor = Color.Yellow;
        }

        private void costtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch)) { e.Handled = false; } else if (ch == 8) { e.Handled = false; } else { e.Handled = true; }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paybtn_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void SalePage_Load(object sender, EventArgs e)
        {
            // vd.selectpagesize();
            saledt.Value = DateTime.Today;
            Rbtnbycode.Checked = true;
            saleuserlbl.Text = loggedInUser.UserName;
            statuslbl2.Text = DateTime.Now.ToLongDateString();
            salecombo.Focus();
            cid.Text = "";
            this.KeyPreview = true;
            //saleProgressBar1.Visible = false;
            r.getserial();
            salesetting();
        }
        void salesetting()
        {
            if (Currenttime.withserial == true)
            {
                serialnolbl.Visible = true;
                serilanotxt.Visible = true;
                serialnolbl.Text = Currenttime.serialtype;
            }
            if (Currenttime.discount == true) { dislbl.Text = "Give Discount In % ."; } else { dislbl.Text = "Give Discount In % ."; dislbl.Visible = false;DisTXT.Visible = false; }
        }
        private void SalePage_Activated(object sender, EventArgs e)
        {
          
               vd.selectpagesize(loggedInUser.UserName);
               r.loadprocombo(salecombo, Rbtnbyname, Rbtnbycode);
               s.Invoice(invoicelbl);
             
            timer2.Start();

        }
       
        private void salecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
           // salecombo.AutoCompleteSource = AutoCompleteSource.None;
            statuslbl.Text = "Ready to add in cart........!!!!";
            statusStrip1.BackColor = Color.ForestGreen;
            if (salecombo.SelectedItem != null)
            {
                csc.procomboxselectedindex(salecombo, prid, pronametxt, partnolbl, unitpricelbl, gstlbl,mrplbl,tsplbl,costtxt);             
                    QuaTXT.Text = "1";
                    DisTXT.Text = "0";
                    quant();
                    disNew();
                    QuaTXT.Enabled = true;
                //DisTXT.Enabled = true;
                costtxt.Enabled = true;
                QuaTXT.SelectAll();
                    QuaTXT.Focus();
                //costtxt.Text = tsplbl.Text.ToString();
                
            }
            else
            {
                unitpricelbl.Text = "0.00";
                QuaTXT.Text = "0.00";
                DisTXT.Text = "0.00";
                pronametxt.Text = "N";
                gstlbl.Text = "0.00 %";
                salecombo.Focus();
                QuaTXT.Enabled = false;
                DisTXT.Enabled = false;
                costtxt.Enabled = false;
                costtxt.Text = "0.00";
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch)) { e.Handled = false; } else if (ch == 8) { e.Handled = false; } else { e.Handled = true; }

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch)) { e.Handled = false; } else if (ch == 8) { e.Handled = false; } else { e.Handled = true; }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(QuaTXT.Text.Trim()))
            {
                QuaTXT.Text = "1";
                QuaTXT.SelectAll();
                if (Currenttime.discount == true) { dispercent(); } else { disNew(); }
            }
            else
            {
                quant();
                DisTXT.Text = "0";              
                if (Currenttime.discount == true) { dispercent(); } else { disNew(); }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DisTXT.Text.Trim()))
            {
                DisTXT.Text = "0";
                DisTXT.SelectAll();
            }
            else
            {
                if (Currenttime.discount == true) { dispercent(); } else { disNew(); }                
            }
        }
        void cost()
        {
            try
            {
                Decimal tt = Convert.ToDecimal(gstlbl.Text);// gst in %
                hh = tt / 100; //gst value
                Decimal ttt = hh + 1;
                Decimal bb = Convert.ToDecimal(QuaTXT.Text.Trim());
                Decimal dd = Convert.ToDecimal(costtxt.Text.Trim());//saleamount with gst with unit qauntity
                Decimal ddd = dd / ttt;// cost price with unit price without gst  //discounted sale price with unit qauntity
                                       // Decimal ddd = Convert.ToDecimal(tsplbl.Text.Trim());
                Decimal aa = Convert.ToDecimal(unitpricelbl.Text);// unit price without tax
                
                if (ddd > aa)
                {
                    ee = 0;
                    //discount amount without qauntity
                    yy = ee * bb;//discount amount with qauntity
                    disamntlbl.Text = yy.ToString("N");
                    //ff = (aa - ee); //discounted sale price with unit qauntity
                    ratelbl.Text = (bb*ddd).ToString("N");
                    gg = hh * ddd; //gst amount 
                    ngg = gg * bb;// gst amount with qauntity
                    gstamountlbl.Text = ngg.ToString("N");
                    //xx = ddd + gg; // saleamount with gst with unit qauntity
                    salepricelbl.Text = dd.ToString("N");
                    //yy = Convert.ToDecimal(salepricelbl.Text);
                    zz = dd * bb;// sale price with gst with quantity
                    totalamontlbl.Text = zz.ToString("N");
                    tsplbl.Text = zz.ToString("N");
                    Decimal mr = bb * Convert.ToDecimal(costtxt.Text.Trim());
                    tmrplbl.Text = mr.ToString("N");
                }
                else
                {
                    ee = aa - ddd;
                    //discount amount without qauntity
                    yy = ee * bb;//discount amount with qauntity
                    disamntlbl.Text = yy.ToString("N");
                    //ff = (aa - ee); //discounted sale price with unit qauntity

                    gg = hh * ddd; //gst amount 
                    ngg = gg * bb;// gst amount with qauntity
                    gstamountlbl.Text = ngg.ToString("N");
                    //xx = ddd + gg; // saleamount with gst with unit qauntity
                    salepricelbl.Text = dd.ToString("N");
                    //yy = Convert.ToDecimal(salepricelbl.Text);
                    zz = dd * bb;// sale price with gst with quantity
                    totalamontlbl.Text = zz.ToString("N");
                    Decimal mr = bb * Convert.ToDecimal(mrplbl.Text);
                    tmrplbl.Text = mr.ToString("N");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        void dispercent()
        {
            Decimal tt = Convert.ToDecimal(gstlbl.Text);// gst in %
            hh = tt / 100; //gst value
            Decimal ttt = hh + 1;
            Decimal bb = Convert.ToDecimal(QuaTXT.Text.Trim());
            Decimal dd = Convert.ToDecimal(costtxt.Text.Trim());//saleamount with gst with unit qauntity
            Decimal ddd = dd / ttt;// cost price with unit price without gst  //discounted sale price with unit qauntity                                             
            Decimal dds = Convert.ToDecimal(DisTXT.Text.Trim())/100;          
            ee = dds *ddd; //discount amount without qauntity
            yy= ee * bb;//discount amount with qauntity
            disamntlbl.Text = yy.ToString("N");           
            ff = (ddd - ee); //discounted sale price with unit qauntity                        
            gg = hh * ff; //gst amount 
            ngg = gg * bb;// gst amount with qauntity
            gstamountlbl.Text = ngg.ToString("N");
            xx = ff + gg; // saleamount with gst with unit qauntity
            salepricelbl.Text = xx.ToString("N");
            //yy = Convert.ToDecimal(salepricelbl.Text);
            zz = xx * bb;// sale price with gst with quantity
            totalamontlbl.Text = zz.ToString("N");
            Decimal aa = Convert.ToDecimal(unitpricelbl.Text);// unit price without tax
            if (ddd > aa)
            {
                Decimal mr = bb * Convert.ToDecimal(costtxt.Text);
                tmrplbl.Text = mr.ToString("N");
            }
            else
            {
                Decimal mr = bb * Convert.ToDecimal(mrplbl.Text);
                tmrplbl.Text = mr.ToString("N");
            }
           
        }
        void disc()
        {
            Decimal bb = Convert.ToDecimal(QuaTXT.Text.Trim());
            Decimal dd = Convert.ToDecimal(costtxt.Text.Trim());
            Decimal ddd = Convert.ToDecimal(tsplbl.Text.Trim());
            ee = dd * bb;
            disamntlbl.Text = ee.ToString("N");
            Decimal aa = Convert.ToDecimal(unitpricelbl.Text);
            ff = (aa - dd) * bb;// taxable price with quantity            
           // ff=(aa-dd); // taxable price with unit quantity
            salepricelbl.Text = ff.ToString("N");//
            Decimal tt = Convert.ToDecimal(gstlbl.Text);
            hh = tt / 100;
            gg = hh * ff; //tax amount
            // ugg=gg*bb; //tax amount 
            gstamountlbl.Text = gg.ToString("N");
            xx = Convert.ToDecimal(gstamountlbl.Text);
            yy = Convert.ToDecimal(salepricelbl.Text);
            zz = xx + yy;
            totalamontlbl.Text = zz.ToString("N");
        }
        void disNew()
        {
            Decimal bb = Convert.ToDecimal(QuaTXT.Text.Trim());
            Decimal dd = Convert.ToDecimal(DisTXT.Text.Trim());
            ee = dd * bb;
            disamntlbl.Text = ee.ToString("N");
            Decimal aa = Convert.ToDecimal(unitpricelbl.Text);
            ff = (aa - dd);
            Decimal tt = Convert.ToDecimal(gstlbl.Text);
            hh = tt / 100;
            gg = hh * ff;
            ngg = gg * bb;
            gstamountlbl.Text = ngg.ToString("N");
            xx=ff + gg;
            salepricelbl.Text = xx.ToString("N");
            yy= Convert.ToDecimal(salepricelbl.Text);
            zz = yy * bb;
            totalamontlbl.Text = zz.ToString("N");
            Decimal mr = bb * Convert.ToDecimal(mrplbl.Text);
            tmrplbl.Text = mr.ToString("N");
        }
        void quant()
        {
            aa = Convert.ToDecimal(unitpricelbl.Text);
            bb = Convert.ToDecimal(QuaTXT.Text.Trim());
            cc = aa * bb;
            ratelbl.Text = cc.ToString("N");
        }
        void totalvalue()
        {
            tpq = 0;
            sp = 0;
            sd = 0;
            sg = 0;
            spa = 0;
            nmrp = 0;
            for (int i = 0; i < saledgv.Rows.Count; i++)
            {
                tpq = tpq + Convert.ToInt32(saledgv.Rows[i].Cells[3].Value);
                sp = sp + Convert.ToDecimal(saledgv.Rows[i].Cells[5].Value);
                sd = sd + Convert.ToDecimal(saledgv.Rows[i].Cells[6].Value);
                sg = sg + Convert.ToDecimal(saledgv.Rows[i].Cells[9].Value);
                spa = spa + Convert.ToDecimal(saledgv.Rows[i].Cells[10].Value);
                nmrp = nmrp + Convert.ToDecimal(saledgv.Rows[i].Cells[11].Value);
            }
            tpqlbl.Text = tpq.ToString();
            sumplbl.Text = sp.ToString("N");
            sumdislbl.Text = sd.ToString("N");
            sumgstamntlblb.Text = sg.ToString("N");            
            sumpaylbl.Text = Math.Ceiling(Convert.ToDecimal(spa)).ToString("N");
            nmrplbl.Text = nmrp.ToString("N");
            tilbl.Text = saledgv.Rows.Count.ToString();            
            Decimal cgasta = sg / 2;
            cgstsalelbl.Text = cgasta.ToString("N");
            sgstsalelbl.Text = cgasta.ToString("N");
        }
        void clearcontrol()
        {
            salecombo.SelectedItem = null;
            
        }        
    }
}
