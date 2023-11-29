using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using BillingApp.connection_class;

namespace BillingApp.main_class
{
    class ComboSelectChange
    {        
        SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());        
        public void gstcomboxselectedindex(ComboBox cb, TextBox cgsttxtt, TextBox sgsttxtt)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("gstcomboselectchange", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                sdr.SelectCommand.Parameters.AddWithValue("@gstcolum", Convert.ToDecimal(cb.SelectedItem.ToString()));
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Decimal cgstvalue = Convert.ToDecimal((dt.Rows[0]["CGST"]).ToString());
                    Decimal sgstvalue = Convert.ToDecimal((dt.Rows[0]["SGST"]).ToString());
                    cgsttxtt.Text = cgstvalue.ToString();
                    sgsttxtt.Text = sgstvalue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void procomboxselectedindex(ComboBox cb, Label pid, TextBox pn, Label partn,Label pp, Label ptax,Label mrpp, Label tspp,TextBox tb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("procomboselectchange", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                sdr.SelectCommand.Parameters.AddWithValue("@pc", cb.SelectedItem.ToString());
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    int id = Convert.ToInt32((dt.Rows[0]["Product_Id"]).ToString());
                    string p = (dt.Rows[0]["Name"]).ToString();
                    string pno = (dt.Rows[0]["Part_No"]).ToString();
                    Decimal price = Convert.ToDecimal((dt.Rows[0]["Sale_Price"]).ToString());
                    Decimal gsttax = Convert.ToDecimal((dt.Rows[0]["GST"]).ToString());
                    Decimal mrp = Convert.ToDecimal((dt.Rows[0]["MRP"]).ToString());
                    Decimal tsp = Convert.ToDecimal((dt.Rows[0]["Total_Sale_Price"]).ToString());
                   // Decimal ctsp = Convert.ToDecimal((dt.Rows[0]["Total_Sale_Price"]).ToString());
                    pid.Text = id.ToString();
                    pn.Text = p.ToString();
                    partn.Text = pno.ToString();
                    pp.Text = price.ToString("N");
                    ptax.Text = gsttax.ToString();
                    mrpp.Text = mrp.ToString("N");
                    tspp.Text = tsp.ToString();
                    tb.Text= tsp.ToString();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void procomboxselected(ComboBox cb, Label pid, Label pn, Label partn, Label pp, Label ptax)
        {
            try
            {

               /* SqlCommand cmd = new SqlCommand("procomboselectchange", cs);
                cmd.CommandType = CommandType.StoredProcedure;                
                cmd.Parameters.AddWithValue("@pc", cb.Text);
                cs.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if(sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        pid.Text = sdr.GetValue(0).ToString();
                        pn.Text = sdr.GetValue(1).ToString();
                        partn.Text = sdr.GetValue(2).ToString();
                        pp.Text = sdr.GetValue(3).ToString();
                        ptax.Text = sdr.GetValue(4).ToString();
                    }                                        
                }
                else
                {
                    MessageBox.Show("Product not available");
                }
                cs.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getcatagoryid(ComboBox cbc, string gatcid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("catcomboselectchange", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                sdr.SelectCommand.Parameters.AddWithValue("@catname", cbc.SelectedItem.ToString());
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    int getc_id = Convert.ToInt32((dt.Rows[0]["CatId"]).ToString());
                    gatcid = getc_id.ToString();                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void expensecomboxselectedindex(ComboBox cb, TextBox cgsttxtt)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("expensecomboselectchange", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                sdr.SelectCommand.Parameters.AddWithValue("@exptype", cb.SelectedItem.ToString());
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Decimal cgstvalue = Convert.ToDecimal((dt.Rows[0]["Price"]).ToString());
                    
                    cgsttxtt.Text = cgstvalue.ToString();
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void usercomboxselectedindex(ComboBox cb, Label l1, Label l2,CheckBox c1, CheckBox c2, CheckBox c3, CheckBox c4, CheckBox c5, CheckBox c6, CheckBox c7, CheckBox c8, CheckBox c9, CheckBox c10, CheckBox c11,CheckBox c12, CheckBox c13, CheckBox c14, CheckBox c15, CheckBox c16, CheckBox c17)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("usercobmochange", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                sdr.SelectCommand.Parameters.AddWithValue("@username", cb.SelectedItem.ToString());
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                     l1.Text = (dt.Rows[0]["Mobile"]).ToString();
                    l2.Text = (dt.Rows[0]["EMAIL"]).ToString();
                    c1.Checked = Convert.ToBoolean(dt.Rows[0]["salepage"]);
                    c2.Checked = Convert.ToBoolean(dt.Rows[0]["salehistory"]);
                    c3.Checked = Convert.ToBoolean(dt.Rows[0]["purchase"]);
                    c4.Checked = Convert.ToBoolean(dt.Rows[0]["purchasehistory"]);
                    c5.Checked = Convert.ToBoolean(dt.Rows[0]["newproduct"]);
                    c6.Checked = Convert.ToBoolean(dt.Rows[0]["productdetails"]);
                    c7.Checked = Convert.ToBoolean(dt.Rows[0]["newcustomer"]);
                    c8.Checked = Convert.ToBoolean(dt.Rows[0]["customerdetail"]);
                    c9.Checked = Convert.ToBoolean(dt.Rows[0]["newsupplier"]);
                    c10.Checked = Convert.ToBoolean(dt.Rows[0]["supplierdetail"]);
                    c11.Checked = Convert.ToBoolean(dt.Rows[0]["backupdb"]);
                    c12.Checked = Convert.ToBoolean(dt.Rows[0]["restoredb"]);
                    c13.Checked = Convert.ToBoolean(dt.Rows[0]["saleledgerbook"]);
                    c14.Checked = Convert.ToBoolean(dt.Rows[0]["createexpenses"]);
                    c15.Checked = Convert.ToBoolean(dt.Rows[0]["addexpenses"]);
                    c16.Checked = Convert.ToBoolean(dt.Rows[0]["stock"]);
                    c17.Checked = Convert.ToBoolean(dt.Rows[0]["setting"]);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
    }
}
