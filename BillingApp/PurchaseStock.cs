using BillingApp.connection_class;
using BillingApp.main_class;
using BillingSystem.main_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class PurchaseStock : Form
    {
        public PurchaseStock()
        {
            InitializeComponent();
        }
        purcgaseinsertiondata p = new purcgaseinsertiondata();
        retrievedata r = new retrievedata();
        Viewalldata vd = new Viewalldata();
        bool picheck;
        
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        private void PurchaseStock_Activated(object sender, EventArgs e)
        {
            p.purBillNo(pbnolbl);
            r.loadpuchasetxt(purchprotxt);            
            r.loadpartysup(parttxt);
        }
        String[] prradd = new string[4];
        private void button1_Click(object sender, EventArgs e)
        {
            if (purchprotxt.Text != "")
            {
                prradd = vd.addproductdgv(purchprotxt.Text);
              int   pidadd = Convert.ToInt32(prradd[0]);
                if (pidadd > 0)
                {
                    if (purchasedgv.Rows.Count != 0)
                    {
                        foreach (DataGridViewRow row in purchasedgv.Rows)
                        {
                            if (row.Cells["pidgvtxt"].Value.ToString() == pidadd.ToString())
                            {
                                picheck = true;
                                break;
                            }
                            else
                            {
                                picheck = false;
                            }
                        }
                        if (picheck == true)
                        {
                            foreach (DataGridViewRow row in purchasedgv.Rows)
                            {
                                if (row.Cells["pidgvtxt"].Value.ToString() == pidadd.ToString())
                                {
                                    MessageBox.Show("This Product " + prradd[2] + " Allready Added , Please Add Next Product", "Same Product Not Be Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    purchprotxt.Text = "";
                                }
                            }
                        }
                        else
                        {
                            purchasedgv.Rows.Add(Convert.ToInt32(prradd[0]), prradd[1], prradd[2], Convert.ToInt32(prradd[3]));
                            enablecontrols();
                            purchprotxt.Text = "";
                            purchasedgv.FirstDisplayedScrollingRowIndex = purchasedgv.RowCount - 1;
                        }
                    }
                    else
                    {
                        purchasedgv.Rows.Add(Convert.ToInt32(prradd[0]), prradd[1], prradd[2], Convert.ToInt32(prradd[3]));
                        enablecontrols();
                        purchprotxt.Text = "";
                        purchasedgv.FirstDisplayedScrollingRowIndex = purchasedgv.RowCount - 1;
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Product ", "Product Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    purchprotxt.Focus();
                    purchprotxt.Text = "";
                }
                Array.Clear(prradd, 0, prradd.Length);
            }
        }
                
        void enablecontrols()
        {
            adstbtn.Enabled = true;
            adstbtn.Focus();
            tpbtn.Enabled = true;
            gstbtn.Enabled = true;
        }

        private void PurchaseStock_Load(object sender, EventArgs e)
        {
            purchprotxt.Focus();
            Buserlbl.Text = loggedInUser.UserName;
            purcgaedatetime.Value = DateTime.Today;
        }

        private void purchasedgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            totalcount();
        }

        private void adstbtn_Leave(object sender, EventArgs e)
        {
            if (adstbtn.Text=="")
            {
                adstbtn.BackColor = Color.Red;
               // MessageBox.Show("Give Quantity", "Quantity Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //adstbtn.Focus();
            }
            else
            {
                if (rg.Match(adstbtn.Text).Success)
                {
                    int a = Convert.ToInt32(purchasedgv.SelectedRows[0].Cells[3].Value.ToString());
                    int b = Convert.ToInt32(adstbtn.Text);
                    int c = a + b;
                    purchasedgv.SelectedRows[0].Cells[5].Value = c.ToString();
                    purchasedgv.SelectedRows[0].Cells[4].Value = b.ToString();
                    adstbtn.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void purchprotxt_TextChanged(object sender, EventArgs e)
        {
            adstbtn.Text = "";
            tpbtn.Text = "";
            gstbtn.Text = "";
        }

        private void purchasedgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            purchasedgv.Rows[e.RowIndex].Selected = true;            
        }

        private void tpbtn_Leave(object sender, EventArgs e)
        {
            if (tpbtn.Text=="")
            {
                tpbtn.BackColor = Color.Red;
                //MessageBox.Show("Give Price", "Price Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // tpbtn.Focus();
            }
            else
            {
                if (rg.Match(tpbtn.Text).Success)
                {
                    Decimal TP = Convert.ToDecimal(tpbtn.Text);                   
                    purchasedgv.SelectedRows[0].Cells[6].Value = TP.ToString();
                    adstbtn.BackColor = Color.WhiteSmoke;
                }
            }
        }
        decimal txv;
        private void gstbtn_Leave(object sender, EventArgs e)
        {
            if (gstbtn.Text=="")
            {
                gstbtn.BackColor = Color.Red;
                purchprotxt.Focus();
                //MessageBox.Show("Give GST In %","GST Input Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //gstbtn.Focus();
            }
            else
            {
                if (rg.Match(gstbtn.Text).Success)
                {                    
                    Decimal TX = Convert.ToDecimal(gstbtn.Text);
                    txv = (TX / 100);
                    Decimal txx = txv + 1;
                    purchasedgv.SelectedRows[0].Cells[7].Value = TX.ToString();
                    Decimal pp = Convert.ToDecimal(purchasedgv.SelectedRows[0].Cells[6].Value.ToString());
                    
                    Decimal txblea = pp/txx;
                    Decimal txa = (TX / 100)*txblea;
                    purchasedgv.SelectedRows[0].Cells[8].Value = txa.ToString("N");
                    Decimal haltx = Convert.ToDecimal(purchasedgv.SelectedRows[0].Cells[8].Value) / 2;
                    purchasedgv.SelectedRows[0].Cells[9].Value = haltx.ToString("N");
                    purchasedgv.SelectedRows[0].Cells[10].Value = haltx.ToString("N");
                    totalcount();
                    purchprotxt.Focus();
                    txtcontols();
                    gstbtn.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (purchasedgv.Rows.Count > 0)
            {
                int ri = Convert.ToInt32(purchasedgv.SelectedRows[0].Index);
                purchasedgv.Rows.RemoveAt(ri);
                purchasedgv.Refresh();
                totalcount();
                purchprotxt.Focus();
                adstbtn.BackColor = Color.White;
                tpbtn.BackColor = Color.White;
                gstbtn.BackColor = Color.White;
                if (purchasedgv.Rows.Count > 1)
                {
                    purchasedgv.CurrentRow.Selected = true;
                }
                else
                {
                   
                }                
            }
            else
            {
                MessageBox.Show("Your Cart Is Emety","No Item",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void parttxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parttxt.Text))
            {
               
                partynlbl.Text = "Party information isrequired !!";
                paddlbl.Text = "Party information isrequired !!";
                parttxt.BackColor = Color.Red;
                
               
            }
            else
            {
                
                r.gsd(parttxt.Text,partynlbl, paddlbl);
                parttxt.BackColor = Color.WhiteSmoke;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        void totalcount()
        {
            int aa = 0;
            Decimal bb = 0;
            Decimal cc = 0;
            Decimal dd = 0;
            Decimal ee = 0;
            for (int i = 0; i < purchasedgv.Rows.Count; i++)
            {
                aa = aa + Convert.ToInt32(purchasedgv.Rows[i].Cells[4].Value); // total purchased stock
                bb = bb + Convert.ToDecimal(purchasedgv.Rows[i].Cells[6].Value);  //Total price
                cc = cc + Convert.ToDecimal(purchasedgv.Rows[i].Cells[8].Value); // total gst amount
                dd = dd + Convert.ToDecimal(purchasedgv.Rows[i].Cells[9].Value); //total cgst amount
                ee = ee + Convert.ToDecimal(purchasedgv.Rows[i].Cells[10].Value); // total sgst amount               
            }
            taddedstocklbl.Text = aa.ToString();
            totalpricetxt.Text = bb.ToString("N");
            tgstalbl.Text = cc.ToString("N");
            tcgstalbl.Text = dd.ToString("N");
            tsgcgalbl.Text = ee.ToString("N");
            totalitemlbl.Text = purchasedgv.Rows.Count.ToString();
        }
        void txtcontols()
        {
            adstbtn.Text = "";
            tpbtn.Text = "";
            gstbtn.Text = "";
            adstbtn.Enabled = false;
            tpbtn.Enabled = false;
            gstbtn.Enabled = false;
            paidtxt.Text = "";
            balancetxt.Text = "";
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            
            if(purchasedgv.Rows.Count>0 )
            {
                if (Isvalid())
                {
                    if (supplierinvoicetxt.Text == "")
                    {
                        DialogResult dr = MessageBox.Show("Supplier Invoice No not Entered !!!!!\n\nDo you want to proceed without Supplier Invoice no ?","Supplier Invoice No  ?",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            
                            p.insertpurchasedetails(Convert.ToInt64(pbnolbl.Text), Convert.ToInt32(taddedstocklbl.Text), Convert.ToDecimal(totalpricetxt.Text), Convert.ToDecimal(tgstalbl.Text), Convert.ToDecimal(tcgstalbl.Text), Convert.ToDecimal(tsgcgalbl.Text),Convert.ToDecimal(paidtxt.Text),Convert.ToDecimal(balancetxt.Text), supplierinvoicetxt.Text, Buserlbl.Text, Currenttime.sid, purcgaedatetime.Value, purchasedgv, "pidgvtxt", "pndgvtxt", "istockdgvtxt", "addstockdgvtxt", "updstockdgvtxt", "prcidgvtxt", "gstdgvtxt", "gstamondgvtxt", "cgstamoundgvtxt", "sgstamoundgvtxt");
                            purchasedgv.Rows.Clear();
                            totalcount();
                            parttxt.Text = "";
                            supplierinvoicetxt.Text = "";
                            txtcontols();
                            purchprotxt.Focus();
                        }
                        else { supplierinvoicetxt.Focus(); }
                    }
                    else
                    {
                        
                        p.insertpurchasedetails(Convert.ToInt64(pbnolbl.Text), Convert.ToInt32(taddedstocklbl.Text), Convert.ToDecimal(totalpricetxt.Text), Convert.ToDecimal(tgstalbl.Text), Convert.ToDecimal(tcgstalbl.Text), Convert.ToDecimal(tsgcgalbl.Text), Convert.ToDecimal(paidtxt.Text), Convert.ToDecimal(balancetxt.Text), supplierinvoicetxt.Text, Buserlbl.Text, Currenttime.sid, purcgaedatetime.Value, purchasedgv, "pidgvtxt", "pndgvtxt", "istockdgvtxt", "addstockdgvtxt", "updstockdgvtxt", "prcidgvtxt", "gstdgvtxt", "gstamondgvtxt", "cgstamoundgvtxt", "sgstamoundgvtxt");
                        purchasedgv.Rows.Clear();
                        totalcount();
                        parttxt.Text = "";
                        supplierinvoicetxt.Text = "";
                        txtcontols();
                        purchprotxt.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Supplier details must be entered","Supplier Details Missing",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    parttxt.Focus();
                }
            }
            else
            {
                //MessageBox.Show("Please Select Product And Party Details","Check Party OR Product",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }  
           
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            //
        }

        private void parttxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parttxt.Text))
            {
              
                partynlbl.Text = "";
                paddlbl.Text = "";
                //parttxt.BackColor = Color.WhiteSmoke;
            }
            else
            {
                //parttxt.BackColor = Color.WhiteSmoke;
            }
        }

        private void purchasedgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (purchasedgv.Rows.Count >0 && tpbtn.Text!="" && gstbtn.Text!="")
            {
                adstbtn.Text = purchasedgv.SelectedRows[0].Cells[4].Value.ToString();
                tpbtn.Text= purchasedgv.SelectedRows[0].Cells[6].Value.ToString();
                gstbtn.Text= purchasedgv.SelectedRows[0].Cells[7].Value.ToString();
                adstbtn.Enabled = true;
                tpbtn.Enabled = true;
                gstbtn.Enabled = true;
                adstbtn.Focus();
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tpbtn_TextChanged(object sender, EventArgs e)
        {
            tpbtn.BackColor = Color.White;
        }

        private void gstbtn_TextChanged(object sender, EventArgs e)
        {
            gstbtn.BackColor = Color.White;
        }

        private void PurchaseStock_KeyDown(object sender, KeyEventArgs e)
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
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                purchprotxt.Focus();
            }
            if (e.Control == true && e.KeyCode == Keys.A)
            {
               adstbtn.Focus();
            }
            if (e.Control == true && e.KeyCode == Keys.T)
            {
                tpbtn.Focus();
            }
            if (e.Control == true && e.KeyCode == Keys.G)
            {
                gstbtn.Focus();
            }
            if (e.Control == true && e.KeyCode == Keys.P)
            {
                parttxt.Focus();
            }
        }

        private void adstbtn_TextChanged(object sender, EventArgs e)
        {
            adstbtn.BackColor = Color.White;
        }

        private void purchprotxt_KeyDown(object sender, KeyEventArgs e)
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

        private void adstbtn_KeyDown(object sender, KeyEventArgs e)
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

        private void tpbtn_KeyDown(object sender, KeyEventArgs e)
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

        private void gstbtn_KeyDown(object sender, KeyEventArgs e)
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

        private void supplierinvoicetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void purcgaedatetime_KeyDown(object sender, KeyEventArgs e)
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

        private void parttxt_KeyDown(object sender, KeyEventArgs e)
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
        
        private void purchprotxt_Leave(object sender, EventArgs e)
        {
            purchprotxt.BackColor = Color.WhiteSmoke;
        }

        private void paidtxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(paidtxt.Text.Trim()))
            {
                balancetxt.Text = "";
            }
            else
            {
                if (totalpricetxt.Text.Trim() != "")
                {
                    decimal balance = Convert.ToDecimal(totalpricetxt.Text) - Convert.ToDecimal(paidtxt.Text);
                    balancetxt.Text = balance.ToString("N");
                }
            }
            
            
        }

        private void totalpricetxt_Enter(object sender, EventArgs e)
        {
            totalcount();
            totalpricetxt.BackColor = Color.Yellow;
        }

        private bool Isvalid()
        {
            if (Currenttime.sid<0 || parttxt.Text=="")
            {
                MessageBox.Show("Supplier Information is required !!!","Supplier Information ?",MessageBoxButtons.OK,MessageBoxIcon.Information);
                parttxt.Focus();
                parttxt.BackColor = Color.Red;
                return false;
            }
            return true;
        }

        private void parttxt_Enter(object sender, EventArgs e)
        {
            parttxt.BackColor = Color.Yellow;
        }

        private void totalpricetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void paidtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void balancetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void paidtxt_Leave(object sender, EventArgs e)
        {
            if (paidtxt.Text.Trim() == "")
            {
                MessageBox.Show("Paid 0 if you donot pay right now ","Field can not be empety",MessageBoxButtons.OK,MessageBoxIcon.Information);
                paidtxt.BackColor = Color.Red;
            }
            else { paidtxt.BackColor = Color.WhiteSmoke; }
        }

        private void purchprotxt_Enter(object sender, EventArgs e)
        {
            purchprotxt.BackColor = Color.Yellow;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.RoyalBlue;
            button1.ForeColor = Color.White;
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button1.ForeColor = Color.Black;
        }

        private void adstbtn_Enter(object sender, EventArgs e)
        {
            adstbtn.BackColor = Color.Yellow;
        }

        private void tpbtn_Enter(object sender, EventArgs e)
        {
            tpbtn.BackColor = Color.Yellow;
        }

        private void gstbtn_Enter(object sender, EventArgs e)
        {
            gstbtn.BackColor = Color.Yellow;
        }

        private void supplierinvoicetxt_Enter(object sender, EventArgs e)
        {
            supplierinvoicetxt.BackColor = Color.Yellow;
        }

        private void supplierinvoicetxt_Leave(object sender, EventArgs e)
        {
            supplierinvoicetxt.BackColor = Color.WhiteSmoke;
        }

        private void purcgaedatetime_Enter(object sender, EventArgs e)
        {
            purcgaedatetime.BackColor = Color.Yellow;
        }

        private void purcgaedatetime_Leave(object sender, EventArgs e)
        {
            purcgaedatetime.BackColor = Color.WhiteSmoke;
        }

        private void totalpricetxt_Leave(object sender, EventArgs e)
        {
            totalpricetxt.BackColor = Color.WhiteSmoke;
        }

        private void paidtxt_Enter(object sender, EventArgs e)
        {
            paidtxt.BackColor = Color.Yellow;
        }

        private void balancetxt_Enter(object sender, EventArgs e)
        {
            balancetxt.BackColor = Color.Yellow;
        }

        private void balancetxt_Leave(object sender, EventArgs e)
        {
            balancetxt.BackColor = Color.WhiteSmoke;
            savebtn.Focus();
        }

        private void savebtn_Enter(object sender, EventArgs e)
        {
            savebtn.BackColor = Color.Yellow;
            savebtn.ForeColor = Color.Black;
        }

        private void savebtn_Leave(object sender, EventArgs e)
        {
            savebtn.BackColor = Color.ForestGreen;
            savebtn.ForeColor = Color.White;
        }
    }
}
