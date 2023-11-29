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
using System.Globalization;
namespace BillingApp
{
    public partial class ProductRegistration : Form
    {
        public ProductRegistration()
        {
            InitializeComponent();
        }
        retrievedata rtd = new retrievedata();
        ComboSelectChange csevent = new ComboSelectChange();
        SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
        Insertion addpro = new Insertion();
        Deleteall d = new Deleteall();
        EditAll ed = new EditAll();
        public int productid { get; set; }
        public bool Isupdatepro { get; set; }
        int gatcatid;       
        public string gatcid { get; set; }       
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ProductRegistration_Load(object sender, EventArgs e)
        {           
            if (Isupdatepro == true)
            {
                savebtn.Text = "Update Data";
                viewbtn.Text = "Delete Data";
                openingsgb.Visible = false;
            }
            else
            {
                openingstocktxt.Text = "0";
                openingstocktxt.SelectAll();
            }
           
        }
        private void ProductRegistration_Activated(object sender, EventArgs e)
        {
            rtd.loadCATcombo(catcombobox);
            rtd.llodGSTcombo(gstcombobox);
        }
        private void gstcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gstcombobox.SelectedItem == null)
            {

            }
            else
            {
                csevent.gstcomboxselectedindex(gstcombobox, cgstproduct, sgstproduct);
                if (string.IsNullOrEmpty(prosalepircetxt.Text.Trim()))
                {

                }
                else
                {
                    //Double gstcombotxt = Convert.ToDouble(gstcombobox.SelectedItem);
                   /* double gsttax = Convert.ToDouble(gstcombobox.SelectedItem) / 100;
                    Double sp = Convert.ToDouble(prosalepircetxt.Text);
                    Double txgstamnt = gsttax * sp;
                    Double sa = sp + txgstamnt;
                    protsalepricetxt.Text = sa.ToString();
                    float txhalf = Convert.ToSingle(txgstamnt) / 2;
                    cgstamntlbl.Text = txhalf.ToString();
                    sgstamntlbl.Text = txhalf.ToString();
                    gstamntlbl.Text = txgstamnt.ToString();*/
                }                
            }
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (procodetxt.Text == "" || pronametxt.Text == "" || procodetxt.Text == "" || prosalepircetxt.Text == "" || gstcombobox.Text == "" || cgstproduct.Text == "" || sgstproduct.Text == "" || protsalepricetxt.Text == "" || mrptxt.Text == "" || catcombobox.Text=="")
            {
                MessageBox.Show("All Fields are madatory", "Fields with * are required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Isupdatepro == true)
            {
                ed.Editproduct(productid, procodetxt.Text, pronametxt.Text, propartnotxt.Text, prosalepircetxt.Text, Convert.ToDouble(gstcombobox.SelectedItem), cgstproduct.Text, sgstproduct.Text, protsalepricetxt.Text, mrptxt.Text, propurchagepricetxt.Text, gstamntlbl.Text, cgstamntlbl.Text, sgstamntlbl.Text);
                resetcontrols();
            }
            else if (Isupdatepro == false)
            {
                addpro.insertproduct(procodetxt.Text, pronametxt.Text, propartnotxt.Text, prosalepircetxt.Text, Convert.ToDouble(gstcombobox.SelectedItem), cgstproduct.Text, sgstproduct.Text, protsalepricetxt.Text, mrptxt.Text, propurchagepricetxt.Text, gstamntlbl.Text, cgstamntlbl.Text, sgstamntlbl.Text, gatcatid.ToString(), openingstocktxt.Text);
                // addpro.insertstock(openingstocktxt.Text);
                statuspnl.Visible = true;
                resetcontrols();
            }            
        }
        private void catcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (catcombobox.SelectedItem == null)
            {

            }
            else
            {                
                try
                {
                    int getcid;
                    SqlCommand cmd = new SqlCommand("catcomboselectchange", cs);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                    sdr.SelectCommand.Parameters.AddWithValue("@catname", catcombobox.SelectedItem.ToString());
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
                    statuspnl.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void prosalepircetxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(prosalepircetxt.Text) == true)
            {
                protsalepricetxt.Text = "";
                cgstamntlbl.Text = "0.00";
                sgstamntlbl.Text = "0.00";
                gstamntlbl.Text = "0.00";
                gstcombobox.SelectedItem = null;
                cgstproduct.Text = "";
                sgstproduct.Text = "";
            }
           
            else
            {
               /* Double gstcombotxt = Convert.ToDouble(gstcombobox.SelectedItem);
                Double gsttax = gstcombotxt / 100;
                Double sp = Convert.ToDouble(prosalepircetxt.Text);
                Double txgstamnt = gsttax * sp;
                Double sa = sp + txgstamnt;
                protsalepricetxt.Text = sa.ToString();
                float txhalf = Convert.ToSingle(txgstamnt) / 2;
                cgstamntlbl.Text = txhalf.ToString();
                sgstamntlbl.Text = txhalf.ToString();
                gstamntlbl.Text = txgstamnt.ToString();*/
            }

        }        
        private void cgstproduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void sgstproduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void propurchagepricetxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void propurchagepricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }
        private void prosalepircetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch)) { e.Handled = false; } else if (ch == 8) { e.Handled = false; } else { e.Handled = true; }
        }
        private void mrptxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch)) { e.Handled = false; } else if (ch == 8) { e.Handled = false; } else { e.Handled = true; }

        }
        private void protsalepricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch)) { e.Handled = false; } else if (ch == 8) { e.Handled = false; } else { e.Handled = true; }

        }
        private void gstcombobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void openingstocktxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch)) { e.Handled = false; } else if (ch == 8) { e.Handled = false; } else { e.Handled = true; }

        }
        void resetcontrols()
        {
           // catcombobox.SelectedItem = null;
            procodetxt.Text = "";
            pronametxt.Text = "";
            propartnotxt.Text = "";
            gstcombobox.SelectedItem = null;
            cgstproduct.Text = "";
            sgstproduct.Text = "";
            gstamntlbl.Text = "0.00";
            sgstamntlbl.Text = "0.00";
            cgstamntlbl.Text = "0.00";
            propurchagepricetxt.Text = "";
            prosalepircetxt.Text = "";
            mrptxt.Text = "";
            protsalepricetxt.Text = "";
            openingstocktxt.Text = "";
            procodetxt.Focus();
            if (Isupdatepro == true)
            {
                Isupdatepro = false;
            }
        }
        private void viewbtn_Click(object sender, EventArgs e)
        {
            if (Isupdatepro == true)
            {
                d.deletestock(productid);
                d.deleteproductdetails(productid);
                resetcontrols();
            }
            else
            {
                resetcontrols();
            }
        }
        private void catnewbtn_Click(object sender, EventArgs e)
        {
            NewCatagory nw = new NewCatagory();
            nw.ShowDialog();
        }
        private void gstnewbtn_Click(object sender, EventArgs e)
        {
            GST txt = new GST();
            txt.ShowDialog();
        }
        
        private void protsalepricetxt_TextChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(protsalepricetxt.Text) == true)
            {
                prosalepircetxt.Text = "";
                cgstamntlbl.Text = "0.00";
                sgstamntlbl.Text = "0.00";
                gstamntlbl.Text = "0.00";
                gstcombobox.SelectedItem = null;
                cgstproduct.Text = "";
                sgstproduct.Text = "";
            }
            

        }

        private void prosalepircetxt_Leave(object sender, EventArgs e)
        {
           
           
        }
        double y;
        private void protsalepricetxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(protsalepricetxt.Text) == true)
            {
           
            }
            else
            {
              
                double gsta = Convert.ToDouble(gstcombobox.SelectedItem) / 100;
                y = gsta + 1;
                double salep = Convert.ToDouble(protsalepricetxt.Text )/ y;
                prosalepircetxt.Text = salep.ToString("F");
                double gstvalue = salep * gsta;
                gstamntlbl.Text = gstvalue.ToString("F");
                float txhalf = Convert.ToSingle(gstvalue) / 2;
                cgstamntlbl.Text = txhalf.ToString("F");
                sgstamntlbl.Text = txhalf.ToString("F");
            }

        }

        private void procodetxt_Leave(object sender, EventArgs e)
        {
            
                SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
                try
                {
                    SqlCommand cmd = new SqlCommand("matchpcode", cs);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pcode", procodetxt.Text);
                    cs.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                    MessageBox.Show("The Product Code '"+procodetxt.Text+"' Already Exists, \n\n Try another PRODUCT CODE","Same Product Code !!!!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   // procodetxt.Focus();
                    }                   
                    cs.Close();
                }
                catch (Exception ex)
                {
                    cs.Close();
                    MessageBox.Show(ex.Message);
                }           
        }

        private void openingstocktxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(openingstocktxt.Text))
            {
                openingstocktxt.Text = "0";
                openingstocktxt.SelectAll();
            }
            else { }
        }

        private void openingstocktxt_Enter(object sender, EventArgs e)
        {
            openingstocktxt.SelectAll();
        }

        private void catcombobox_KeyDown(object sender, KeyEventArgs e)
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

        private void procodetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void pronametxt_KeyDown(object sender, KeyEventArgs e)
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

        private void propartnotxt_KeyDown(object sender, KeyEventArgs e)
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

        private void gstcombobox_KeyDown(object sender, KeyEventArgs e)
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

        private void protsalepricetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void mrptxt_KeyDown(object sender, KeyEventArgs e)
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

        private void prosalepircetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void propurchagepricetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void openingstocktxt_KeyDown(object sender, KeyEventArgs e)
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

        private void cgstproduct_KeyDown(object sender, KeyEventArgs e)
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

        private void sgstproduct_KeyDown(object sender, KeyEventArgs e)
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

        private void ProductRegistration_KeyDown(object sender, KeyEventArgs e)
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

        private void procodetxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(procodetxt.Text))
            {

            }
            else { statuspnl.Visible = false; }
            //
        }
    }
}
