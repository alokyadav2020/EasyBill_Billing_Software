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
using BillingSystem.main_class;
using BillingSystem;

namespace BillingApp.main_class
{
    class retrievedata
    {
        public void loadCATcombo(ComboBox cb)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                cb.Items.Clear();
                SqlCommand cmd = new SqlCommand("catloadcombo", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string catname = dr.GetString(2);
                    cb.Items.Add(catname);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void loadprocombo(ComboBox cb, RadioButton rbn, RadioButton rbc)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                if (rbc.Checked)
                {
                    cb.Items.Clear();
                    SqlCommand cmd = new SqlCommand("proloadcombo", cs);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cs.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                       
                            string prc = dr.GetString(1);
                            cb.Items.Add(prc);
                       
                    }
                    cs.Close();
                }
                else if (rbn.Checked)
                {
                    cb.Items.Clear();
                    SqlCommand cmd = new SqlCommand("proloadcombo", cs);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cs.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                       
                       
                            string proname = dr.GetString(2);
                            cb.Items.Add(proname);
                       
                    }
                    cs.Close();
                }
               
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void loadpuchasetxt(TextBox txt)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                txt.Clear();
                SqlCommand cmd = new SqlCommand("proloadcombo", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                AutoCompleteStringCollection collec = new AutoCompleteStringCollection();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    collec.Add(dr.GetString(1));
                }
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteCustomSource = collec;
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void loadpartycus(TextBox txt)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                //txt.Clear();
                SqlCommand cmd = new SqlCommand("retriviewcus", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                AutoCompleteStringCollection collec = new AutoCompleteStringCollection();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    collec.Add(dr.GetString(0));
                }
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteCustomSource = collec;
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void loadpartysup(TextBox txt)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                //txt.Clear();
                SqlCommand cmd = new SqlCommand("retriviewcust", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                AutoCompleteStringCollection collec = new AutoCompleteStringCollection();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    collec.Add(dr.GetString(0));
                }
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteCustomSource = collec;
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void loadrole(ComboBox cb) //for combobox load

        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                cb.Items.Clear();
                SqlCommand cmd = new SqlCommand("loadroleincombo", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                cb.DataSource = dt;
                dt.Load(dr);
                cb.DisplayMember = "RoleTitle";
                cb.ValueMember = "RoleId";
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }


        public void llodGSTcombo(ComboBox cb)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                cb.Items.Clear();
                SqlCommand cmd = new SqlCommand("gstloadcombo", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Decimal gstvalue = dr.GetDecimal(1);
                    cb.Items.Add(gstvalue);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void searpro(DataGridView pdgv, string search, DataGridViewColumn c1, DataGridViewColumn c2, DataGridViewColumn c3, DataGridViewColumn c4, DataGridViewColumn c5, DataGridViewColumn c6, DataGridViewColumn c7, DataGridViewColumn c8, DataGridViewColumn c9, DataGridViewColumn c10, DataGridViewColumn c11, DataGridViewColumn c12, DataGridViewColumn c13, DataGridViewColumn c14, DataGridViewColumn c15)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("serchpdetails", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pname", search);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                c1.DataPropertyName = dt.Columns["id"].ToString();
                c2.DataPropertyName = dt.Columns["proCode"].ToString();
                c3.DataPropertyName = dt.Columns["proName"].ToString();
                c4.DataPropertyName = dt.Columns["propartno"].ToString();
                c5.DataPropertyName = dt.Columns["sp"].ToString();
                c6.DataPropertyName = dt.Columns["gst"].ToString();
                c7.DataPropertyName = dt.Columns["cgst"].ToString();
                c8.DataPropertyName = dt.Columns["sgcst"].ToString();
                c9.DataPropertyName = dt.Columns["tsp"].ToString();
                c10.DataPropertyName = dt.Columns["mrp"].ToString();
                c11.DataPropertyName = dt.Columns["pp"].ToString();
                c12.DataPropertyName = dt.Columns["gsta"].ToString();
                c13.DataPropertyName = dt.Columns["cgsta"].ToString();
                c14.DataPropertyName = dt.Columns["sgsta"].ToString();
                c15.DataPropertyName = dt.Columns["catid"].ToString();
                pdgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void searrole(DataGridView rdgv, string search)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("searRoles", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@roletitle", search);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                rdgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void searchusers(DataGridView udgv, string usearch)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("searchuserdetails", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@filter", usearch);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                udgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       // public object getcid;
        public void gcdsale(string cm)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("getcustidforsale", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cmobile", cm);
                cs.Open();
               SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Currenttime.cidforsael = Convert.ToInt32(sdr.GetValue(0).ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No Recorsd Found");
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
           // return getcid;
        }

        public void gcd(string cm, Label idl, Label cnl, Label ca1l, Label ca2l)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("getcustdetails", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cmobile", cm);
                cs.Open();
                SqlDataReader dr = cmd.ExecuteReader();                               
                    if (dr.HasRows == true)
                    {
                        while (dr.Read())
                        {
                            idl.Text = dr.GetValue(0).ToString();
                            cnl.Text = dr.GetValue(1).ToString();
                            ca1l.Text = dr.GetValue(2).ToString();
                            ca2l.Text = dr.GetValue(4).ToString();
                        }
                    }
                    else
                    {
                        CustomerDetails cd = new CustomerDetails();
                        cd.CMTXT.Text = cm.ToString();
                        cd.ShowDialog();
                    }
                    cs.Close();                                
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void gsd(string sm,  Label cnl,  Label ca2l)
        {
                SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("selectsuppdetails", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sfn", sm);
                cs.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        Currenttime.sid= Convert.ToInt32(dr.GetValue(0).ToString());
                        cnl.Text = dr.GetValue(1).ToString();                       
                        ca2l.Text = dr.GetValue(2).ToString();
                    }
                }
                else
                {
                    
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void gsdp(string sm)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("selectsuppid", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sfn", sm);
                cs.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        Currenttime.sidforp = Convert.ToInt32(dr.GetValue(0).ToString());                       
                    }
                }
                else
                {

                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public object getquantity;
        public object getprostockquant(int proID)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("getstockquan", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cs.Open();
                getquantity = cmd.ExecuteScalar();
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
            return getquantity;
        }
        public void searPQ(DataGridView rdgv,string s, DataGridViewColumn pc, DataGridViewColumn pn, DataGridViewColumn pq)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("searchproductQ", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pname", s);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                pc.DataPropertyName = dt.Columns["product_Code"].ToString();
                pn.DataPropertyName = dt.Columns["Name"].ToString();
                pq.DataPropertyName = dt.Columns["Quantity"].ToString();              
                rdgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void selectbycategory(DataGridView rdgv, ComboBox cb, DataGridViewColumn pc, DataGridViewColumn pn, DataGridViewColumn pq)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("selectstockbycategory", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catname", cb.SelectedItem.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                pc.DataPropertyName = dt.Columns["Product_Code"].ToString();
                pn.DataPropertyName = dt.Columns["Name"].ToString();
                pq.DataPropertyName = dt.Columns["Quantity"].ToString();
                rdgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void selectCombpro(DataGridView pdgv, ComboBox search, DataGridViewColumn c1, DataGridViewColumn c2, DataGridViewColumn c3, DataGridViewColumn c4, DataGridViewColumn c5, DataGridViewColumn c6, DataGridViewColumn c7, DataGridViewColumn c8, DataGridViewColumn c9, DataGridViewColumn c10, DataGridViewColumn c11, DataGridViewColumn c12, DataGridViewColumn c13, DataGridViewColumn c14, DataGridViewColumn c15)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("searchproduct", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pname", search.SelectedItem.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                c1.DataPropertyName = dt.Columns["id"].ToString();
                c2.DataPropertyName = dt.Columns["proCode"].ToString();
                c3.DataPropertyName = dt.Columns["proName"].ToString();
                c4.DataPropertyName = dt.Columns["propartno"].ToString();
                c5.DataPropertyName = dt.Columns["sp"].ToString();
                c6.DataPropertyName = dt.Columns["gst"].ToString();
                c7.DataPropertyName = dt.Columns["cgst"].ToString();
                c8.DataPropertyName = dt.Columns["sgcst"].ToString();
                c9.DataPropertyName = dt.Columns["tsp"].ToString();
                c10.DataPropertyName = dt.Columns["mrp"].ToString();
                c11.DataPropertyName = dt.Columns["pp"].ToString();
                c12.DataPropertyName = dt.Columns["gsta"].ToString();
                c13.DataPropertyName = dt.Columns["cgsta"].ToString();
                c14.DataPropertyName = dt.Columns["sgsta"].ToString();
                c15.DataPropertyName = dt.Columns["catid"].ToString();
                pdgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void refreshreport()
        {
            if (PageSize.A4 == true)
            {
               
            }
            else if (PageSize.A5V == true)
            {
               
            }
            else if (PageSize.A5H == true)
            {
                
            }
            else if (PageSize.Ther == true)
            {
               
            }
        }
        public void loadexpensetype(ComboBox cb)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                cb.Items.Clear();
                SqlCommand cmd = new SqlCommand("loadexpensecombo", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string catname = dr.GetString(1);
                    cb.Items.Add(catname);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void loaduseraccess(ComboBox cb)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                cb.Items.Clear();
                SqlCommand cmd = new SqlCommand("loaduser", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string catname = dr.GetString(0);
                    cb.Items.Add(catname);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void getusername(string un, TextBox l1, TextBox l2)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("getuser", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username",un);
                cs.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows==true)
                {
                    while (sdr.Read())
                    {
                        l1.Text = sdr.GetValue(0).ToString();
                        l2.Text = sdr.GetValue(1).ToString();
                    }
                }
                else { MessageBox.Show("Username '"+un+"' Not Found","Invalid Usename",MessageBoxButtons    .OK,MessageBoxIcon.Error);}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getuserroll(int  rid)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("loadrole", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rollid", rid);
                cs.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows == true)
                {
                    while (sdr.Read())
                    {
                        Currenttime.Isadmin = Convert.ToBoolean(sdr.GetValue(0).ToString());
                        Currenttime.rolltitle = sdr.GetValue(1).ToString();
                       
                    }
                }
                //else { MessageBox.Show("Username '" + un + "' Not Found", "Invalid Usename", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getserial()
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                
                SqlCommand cmd = new SqlCommand("getsalewithserial", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Currenttime.serialid= dr.GetInt32(0);
                    Currenttime.withserial = dr.GetBoolean(1);
                    Currenttime.serialtype = dr.GetString(2);
                    Currenttime.discount = dr.GetBoolean(3);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}

