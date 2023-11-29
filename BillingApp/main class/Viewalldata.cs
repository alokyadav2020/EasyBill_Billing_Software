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
using BillingSystem;
using BillingSystem.main_class;
using System.IO;
using System.Drawing;

namespace BillingApp.main_class
{
    class Viewalldata
    {
        SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());


        public void catagarview(DataGridView dgv, DataGridViewColumn cid, DataGridViewColumn ccode, DataGridViewColumn cname, DataGridViewColumn cdis)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("catviewdata", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cid.DataPropertyName = dt.Columns["id"].ToString();
                ccode.DataPropertyName = dt.Columns["CatagoryCode"].ToString();
                cname.DataPropertyName = dt.Columns["CatName"].ToString();
                cdis.DataPropertyName = dt.Columns["catDis"].ToString();
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void gstview(DataGridView dgv, DataGridViewColumn gid, DataGridViewColumn gst, DataGridViewColumn cgst, DataGridViewColumn sgst)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("gstviewall", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gid.DataPropertyName = dt.Columns["gid"].ToString();
                gst.DataPropertyName = dt.Columns["gst"].ToString();
                cgst.DataPropertyName = dt.Columns["cgst"].ToString();
                sgst.DataPropertyName = dt.Columns["sgst"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void productview(DataGridView pdgv, DataGridViewColumn c1, DataGridViewColumn c2, DataGridViewColumn c3, DataGridViewColumn c4, DataGridViewColumn c5, DataGridViewColumn c6, DataGridViewColumn c7, DataGridViewColumn c8, DataGridViewColumn c9, DataGridViewColumn c10, DataGridViewColumn c11, DataGridViewColumn c12, DataGridViewColumn c13, DataGridViewColumn c14, DataGridViewColumn c15)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("proviewdata", cs);
                cmd.CommandType = CommandType.StoredProcedure;
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
        public void stockview(DataGridView dgv, DataGridViewColumn scode, DataGridViewColumn sname, DataGridViewColumn squantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("VIEWstock", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                scode.DataPropertyName = dt.Columns["Product_Code"].ToString();
                sname.DataPropertyName = dt.Columns["Name"].ToString();
                squantity.DataPropertyName = dt.Columns["Quantity"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void lowstockview(DataGridView dgv, DataGridViewColumn scode, DataGridViewColumn sname, DataGridViewColumn squantity, int q)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("lowstock", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@qua", q);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                scode.DataPropertyName = dt.Columns["Product_Code"].ToString();
                sname.DataPropertyName = dt.Columns["Name"].ToString();
                squantity.DataPropertyName = dt.Columns["Quantity"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void customertopview(DataGridView dgv, DataGridViewColumn cid, DataGridViewColumn cn, DataGridViewColumn cadd1, DataGridViewColumn cadd2, DataGridViewColumn cadd3, DataGridViewColumn cmbl, DataGridViewColumn cml)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("viewstopcustomer", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cid.DataPropertyName = dt.Columns["id"].ToString();
                cn.DataPropertyName = dt.Columns["cn"].ToString();
                cadd1.DataPropertyName = dt.Columns["cad1"].ToString();
                cadd2.DataPropertyName = dt.Columns["cad2"].ToString();
                cadd3.DataPropertyName = dt.Columns["cad3"].ToString();
                cmbl.DataPropertyName = dt.Columns["cmb"].ToString();
                cml.DataPropertyName = dt.Columns["cmail"].ToString();
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void customertsearch(string cname, DataGridView dgv, DataGridViewColumn cid, DataGridViewColumn cn, DataGridViewColumn cadd1, DataGridViewColumn cadd2, DataGridViewColumn cadd3, DataGridViewColumn cmbl, DataGridViewColumn cml)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("searchcustomer", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", cname);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cid.DataPropertyName = dt.Columns["id"].ToString();
                cn.DataPropertyName = dt.Columns["cn"].ToString();
                cadd1.DataPropertyName = dt.Columns["cad1"].ToString();
                cadd2.DataPropertyName = dt.Columns["cad2"].ToString();
                cadd3.DataPropertyName = dt.Columns["cad3"].ToString();
                cmbl.DataPropertyName = dt.Columns["cmb"].ToString();
                cml.DataPropertyName = dt.Columns["cmail"].ToString();
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void suppleiropview(DataGridView dgv, DataGridViewColumn sid, DataGridViewColumn sf, DataGridViewColumn sn, DataGridViewColumn sm, DataGridViewColumn sad1, DataGridViewColumn sad2, DataGridViewColumn sgstin, DataGridViewColumn semail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getsuppdetails", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sid.DataPropertyName = dt.Columns["sid"].ToString();
                sf.DataPropertyName = dt.Columns["sfirm"].ToString();
                sn.DataPropertyName = dt.Columns["sname"].ToString();
                sm.DataPropertyName = dt.Columns["mobile"].ToString();
                sad1.DataPropertyName = dt.Columns["add1"].ToString();
                sad2.DataPropertyName = dt.Columns["add2"].ToString();
                sgstin.DataPropertyName = dt.Columns["gstn"].ToString();
                semail.DataPropertyName = dt.Columns["email"].ToString();
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void suppleisearrch(string sfname, DataGridView dgv, DataGridViewColumn sid, DataGridViewColumn sf, DataGridViewColumn sn, DataGridViewColumn sm, DataGridViewColumn sad1, DataGridViewColumn sad2, DataGridViewColumn sgstin, DataGridViewColumn semail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("searchsuppdetails", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sfn", sfname);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sid.DataPropertyName = dt.Columns["sid"].ToString();
                sf.DataPropertyName = dt.Columns["sfirm"].ToString();
                sn.DataPropertyName = dt.Columns["sname"].ToString();
                sm.DataPropertyName = dt.Columns["mobile"].ToString();
                sad1.DataPropertyName = dt.Columns["add1"].ToString();
                sad2.DataPropertyName = dt.Columns["add2"].ToString();
                sgstin.DataPropertyName = dt.Columns["gstn"].ToString();
                semail.DataPropertyName = dt.Columns["email"].ToString();
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void customerpreview(DataGridView dgv, DataGridViewColumn cid, DataGridViewColumn cn, DataGridViewColumn cadd1, DataGridViewColumn cadd2, DataGridViewColumn cadd3, DataGridViewColumn cmbl, DataGridViewColumn cml)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("viewscustomer", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cid.DataPropertyName = dt.Columns["id"].ToString();
                cn.DataPropertyName = dt.Columns["cn"].ToString();
                cadd1.DataPropertyName = dt.Columns["cad1"].ToString();
                cadd2.DataPropertyName = dt.Columns["cad2"].ToString();
                cadd3.DataPropertyName = dt.Columns["cad3"].ToString();
                cmbl.DataPropertyName = dt.Columns["cmb"].ToString();
                cml.DataPropertyName = dt.Columns["cmail"].ToString();
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadusers(DataGridView dgv) //for datagridview load
        {
            // SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("getuserdetails", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadroles(DataGridView dgv) //for datagridview load
        {
            // SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("getroledetails", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void salehistory(DateTime d, DataGridView shdgv, DataGridViewColumn ingv, DataGridViewColumn cngv, DataGridViewColumn cmgv, DataGridViewColumn tqgv, DataGridViewColumn tpgv, DataGridViewColumn tgstagv, DataGridViewColumn pagv, DataGridViewColumn spgv, DataGridViewColumn dtime)

        {
            // SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("getsalehistory", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("@invoic", invoice);
                cmd.Parameters.AddWithValue("@date", d);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ingv.DataPropertyName = dt.Columns["InvoiceNo"].ToString();
                cngv.DataPropertyName = dt.Columns["cusomername"].ToString();
                cmgv.DataPropertyName = dt.Columns["mobile"].ToString();
                tqgv.DataPropertyName = dt.Columns["TotalQuantity"].ToString();
                tpgv.DataPropertyName = dt.Columns["TotalPrice"].ToString();
                tgstagv.DataPropertyName = dt.Columns["TotalGSTAmount"].ToString();
                pagv.DataPropertyName = dt.Columns["PaybleAmount"].ToString();
                spgv.DataPropertyName = dt.Columns["Salesperson"].ToString();
                dtime.DataPropertyName = dt.Columns["datetim"].ToString();
                shdgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void salehistorybtdate(DateTime d1, DateTime d2, DataGridView shdgv, DataGridViewColumn ingv, DataGridViewColumn cngv, DataGridViewColumn cmgv, DataGridViewColumn tqgv, DataGridViewColumn tpgv, DataGridViewColumn tgstagv, DataGridViewColumn pagv, DataGridViewColumn spgv, DataGridViewColumn dategv)
        {
            // SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("salehistorybtwdate", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", d1);
                cmd.Parameters.AddWithValue("@date2", d2);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ingv.DataPropertyName = dt.Columns["InvoiceNo"].ToString();
                cngv.DataPropertyName = dt.Columns["cusomername"].ToString();
                cmgv.DataPropertyName = dt.Columns["mobile"].ToString();
                tqgv.DataPropertyName = dt.Columns["TotalQuantity"].ToString();
                tpgv.DataPropertyName = dt.Columns["TotalPrice"].ToString();
                tgstagv.DataPropertyName = dt.Columns["TotalGSTAmount"].ToString();
                pagv.DataPropertyName = dt.Columns["PaybleAmount"].ToString();
                spgv.DataPropertyName = dt.Columns["Salesperson"].ToString();
                dategv.DataPropertyName = dt.Columns["createdate"].ToString();
                shdgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void salehistorybycust(DataGridView shdgv, DataGridViewColumn ingv, DataGridViewColumn cngv, DataGridViewColumn cmgv, DataGridViewColumn tqgv, DataGridViewColumn tpgv, DataGridViewColumn tgstagv, DataGridViewColumn pagv, DataGridViewColumn spgv, DataGridViewColumn dategv)
        {
            // SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("getsalehistorybycus", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cid", Currenttime.cidforsael);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ingv.DataPropertyName = dt.Columns["InvoiceNo"].ToString();
                cngv.DataPropertyName = dt.Columns["cusomername"].ToString();
                cmgv.DataPropertyName = dt.Columns["mobile"].ToString();
                tqgv.DataPropertyName = dt.Columns["TotalQuantity"].ToString();
                tpgv.DataPropertyName = dt.Columns["TotalPrice"].ToString();
                tgstagv.DataPropertyName = dt.Columns["TotalGSTAmount"].ToString();
                pagv.DataPropertyName = dt.Columns["PaybleAmount"].ToString();
                spgv.DataPropertyName = dt.Columns["Salesperson"].ToString();
                dategv.DataPropertyName = dt.Columns["datetim"].ToString();
                shdgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void customeraccount(int cid,DataGridView shdgv, DataGridViewColumn ingv, DataGridViewColumn cngv, DataGridViewColumn cmgv, DataGridViewColumn tqgv, DataGridViewColumn tpgv)
        {
            // SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("getcusacc", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cid", cid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ingv.DataPropertyName = dt.Columns[0].ToString();
                cngv.DataPropertyName = dt.Columns[1].ToString();
                cmgv.DataPropertyName = dt.Columns[2].ToString();
                tqgv.DataPropertyName = dt.Columns[3].ToString();
                tpgv.DataPropertyName = dt.Columns[4].ToString();               
                shdgv.DataSource = dt;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getdiposit(int cidd,DataGridView shdgv, DataGridViewColumn ingv, DataGridViewColumn cngv )
        {
            // SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("getdipositmoney", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", cidd);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ingv.DataPropertyName = dt.Columns[0].ToString();
                cngv.DataPropertyName = dt.Columns[1].ToString();
               
                shdgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void salehistorybyinvoice(Int64 invo, DataGridView shdgv, DataGridViewColumn ingv, DataGridViewColumn cngv, DataGridViewColumn cmgv, DataGridViewColumn tqgv, DataGridViewColumn tpgv, DataGridViewColumn tgstagv, DataGridViewColumn pagv, DataGridViewColumn spgv, DataGridViewColumn dtime)
        {
            //  SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("getsalehistorybyinvoce", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@invoice", invo);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ingv.DataPropertyName = dt.Columns["InvoiceNo"].ToString();
                cngv.DataPropertyName = dt.Columns["cusomername"].ToString();
                cmgv.DataPropertyName = dt.Columns["mobile"].ToString();
                tqgv.DataPropertyName = dt.Columns["TotalQuantity"].ToString();
                tpgv.DataPropertyName = dt.Columns["TotalPrice"].ToString();
                tgstagv.DataPropertyName = dt.Columns["TotalGSTAmount"].ToString();
                pagv.DataPropertyName = dt.Columns["PaybleAmount"].ToString();
                spgv.DataPropertyName = dt.Columns["Salesperson"].ToString();
                dtime.DataPropertyName = dt.Columns["datetim"].ToString();
                shdgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        String[] adspindgv = new String[4];
        public String[] addproductdgv(String prntxt)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("protxtselect", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pn", prntxt);
                cs.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        adspindgv[0] = sdr[0].ToString();
                        adspindgv[1] = sdr[1].ToString();
                        adspindgv[2] = sdr[2].ToString();
                        adspindgv[3] = sdr[3].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("There is NO product of this name....... Please try next product", "Wrong Product name", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
            return adspindgv;
        }
        public void getshopheader(TextBox t1, TextBox t2, TextBox t3, TextBox t4, PictureBox pb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("shopheader", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Currenttime.fnid = Convert.ToInt32(sdr["id"].ToString());
                        t1.Text = sdr["ShopName"].ToString();
                        t2.Text = sdr["ContactDetails"].ToString();
                        t3.Text = sdr["Address"].ToString();
                        t4.Text = sdr["GSTIN"].ToString();
                        byte[] imgg = sdr.IsDBNull(5) ? null : (byte[])sdr["log"];

                        if (imgg == null)
                        {
                            pb.Image = null;

                        }
                        else
                        {
                            MemoryStream mstream = new MemoryStream(imgg);
                            pb.Image = System.Drawing.Image.FromStream(mstream);
                        }
                    }
                }
                cs.Close();

            }
            catch (Exception )
            {
                cs.Close();
                //MessageBox.Show("Logo Not set yet", "Logo ?");
            }
        }
        public void shpdetails()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("shopheader", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Currenttime.fnid = Convert.ToInt32(sdr["id"].ToString());
                        Currenttime.fname = sdr["ShopName"].ToString();
                        Currenttime.fcontact = sdr["ContactDetails"].ToString();
                        Currenttime.faddress = sdr["Address"].ToString();
                        Currenttime.fgstin = sdr["GSTIN"].ToString();
                    }
                }
                cs.Close();

            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void getshop(TextBox t1, TextBox t2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("shopheader", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Currenttime.fnid = Convert.ToInt32(sdr["id"].ToString());
                        t1.Text = sdr["ShopName"].ToString();
                        t2.Text = sdr["ContactDetails"].ToString();

                    }
                }
                cs.Close();

            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void gettermsr(TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("gettermconditio", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Currenttime.tcid = Convert.ToInt32(sdr["ID"].ToString());
                        tb1.Text = sdr["LINE1"].ToString();
                        tb2.Text = sdr["LINE2"].ToString();
                        tb3.Text = sdr["LINE3"].ToString();
                        tb4.Text = sdr["LINE4"].ToString();
                    }
                }
                cs.Close();

            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void getsystemcon()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getsystemcontact", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Currenttime.sysconid = Convert.ToInt32(sdr["ID"].ToString());
                        Currenttime.sysemail = sdr["Email"].ToString();
                        Currenttime.syspass = sdr["pass"].ToString();
                        Currenttime.sysmob = sdr["mob"].ToString();

                    }
                }
                cs.Close();

            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void rbchecked(RadioButton rba4, RadioButton rba4s, RadioButton rba5v, RadioButton rba5h, RadioButton rbth, RadioButton rbroll5)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getsalepagesize", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@un", loggedInUser.UserName);
                cs.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    if (sdr["A4Page"].ToString() == "True") { rba4.Checked = true; }
                    else if (sdr["A4Pagesimple"].ToString() == "True") { rba4s.Checked = true; }
                    else if (sdr["A5VPage"].ToString() == "True") { rba5v.Checked = true; }
                    else if (sdr["A5HPage"].ToString() == "True") { rba5h.Checked = true; }
                    else if (sdr["Thermal"].ToString() == "True") { rbth.Checked = true; }
                    else if (sdr["roll5inch"].ToString() == "True") { rbroll5.Checked = true; }
                    // sdr["A4Page"].ToString() == "1" ? rba4.Checked = true : rba4.Checked = false;
                    // rba5v.Checked = sdr["A5VPage"].ToString() == "1" ? rba5v.Checked = true : rba5v.Checked = false;
                    //  rba5h.Checked = sdr["A5HPage"].ToString() == "1" ? rba5h.Checked = true : rba5h.Checked = false;
                    //  rbth.Checked = sdr["Thermal"].ToString() == "1" ? rbth.Checked = true : rbth.Checked = false;
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void selectpagesize(string un)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getsalepagesize", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@un", un);
                cs.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    PageSize.A4 = Convert.ToBoolean(sdr.GetBoolean(1));
                    PageSize.A4s = Convert.ToBoolean(sdr.GetBoolean(2));
                    PageSize.A5V = Convert.ToBoolean(sdr.GetBoolean(3));
                    PageSize.A5H = Convert.ToBoolean(sdr.GetBoolean(4));
                    PageSize.Ther = Convert.ToBoolean(sdr.GetBoolean(5));
                    PageSize.roll5 = Convert.ToBoolean(sdr.GetBoolean(6));
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void viewpurchsae(DateTime d1, DateTime d2, DataGridView pdgv, DataGridViewColumn c1, DataGridViewColumn c2, DataGridViewColumn c3, DataGridViewColumn c4, DataGridViewColumn c5, DataGridViewColumn c6, DataGridViewColumn c7, DataGridViewColumn c8, DataGridViewColumn c9)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getpurchasedetailsBTWDATE", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", d1);
                cmd.Parameters.AddWithValue("@date2", d2);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                c1.DataPropertyName = dt.Columns["purchasebill"].ToString();
                c2.DataPropertyName = dt.Columns["supplierinvoice"].ToString();
                c3.DataPropertyName = dt.Columns["firmname"].ToString();
                c4.DataPropertyName = dt.Columns["grossstock"].ToString();
                c5.DataPropertyName = dt.Columns["grossprise"].ToString();
                c6.DataPropertyName = dt.Columns["grossgstamn"].ToString();
                c7.DataPropertyName = dt.Columns["grosscgstamn"].ToString();
                c8.DataPropertyName = dt.Columns["grosssgstamn"].ToString();
                c9.DataPropertyName = dt.Columns["purchasedate"].ToString();
                pdgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void viewpurchsaebydate(DateTime d1, DataGridView pdgv, DataGridViewColumn c1, DataGridViewColumn c2, DataGridViewColumn c3, DataGridViewColumn c4, DataGridViewColumn c5, DataGridViewColumn c6, DataGridViewColumn c7, DataGridViewColumn c8, DataGridViewColumn c9)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getpurchasedetailbydate", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", d1);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                c1.DataPropertyName = dt.Columns["purchasebill"].ToString();
                c2.DataPropertyName = dt.Columns["supplierinvoice"].ToString();
                c3.DataPropertyName = dt.Columns["firmname"].ToString();
                c4.DataPropertyName = dt.Columns["grossstock"].ToString();
                c5.DataPropertyName = dt.Columns["grossprise"].ToString();
                c6.DataPropertyName = dt.Columns["grossgstamn"].ToString();
                c7.DataPropertyName = dt.Columns["grosscgstamn"].ToString();
                c8.DataPropertyName = dt.Columns["grosssgstamn"].ToString();
                c9.DataPropertyName = dt.Columns["purchasedate"].ToString();
                pdgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void viewpurchsaebysid(DataGridView pdgv, DataGridViewColumn c1, DataGridViewColumn c2, DataGridViewColumn c3, DataGridViewColumn c4, DataGridViewColumn c5, DataGridViewColumn c6, DataGridViewColumn c7, DataGridViewColumn c8, DataGridViewColumn c9)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getpurchasedetailbysid", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sid", Currenttime.sidforp);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                c1.DataPropertyName = dt.Columns["purchasebill"].ToString();
                c2.DataPropertyName = dt.Columns["supplierinvoice"].ToString();
                c3.DataPropertyName = dt.Columns["firmname"].ToString();
                c4.DataPropertyName = dt.Columns["grossstock"].ToString();
                c5.DataPropertyName = dt.Columns["grossprise"].ToString();
                c6.DataPropertyName = dt.Columns["grossgstamn"].ToString();
                c7.DataPropertyName = dt.Columns["grosscgstamn"].ToString();
                c8.DataPropertyName = dt.Columns["grosssgstamn"].ToString();
                c9.DataPropertyName = dt.Columns["purchasedate"].ToString();
                pdgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void sumqytsale(DateTime dt1, DateTime dt2, DataGridView dgv, DataGridViewColumn prd, DataGridViewColumn sq)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sumsalestockbtwdate", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", dt1);
                cmd.Parameters.AddWithValue("@date2", dt2);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                prd.DataPropertyName = dt.Columns["PD"].ToString();
                sq.DataPropertyName = dt.Columns["TQ"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void countqytsale(DateTime dt1, DateTime dt2, DataGridView dgv, DataGridViewColumn prd, DataGridViewColumn sq)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("countsalestockbtwdate", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", dt1);
                cmd.Parameters.AddWithValue("@date2", dt2);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                prd.DataPropertyName = dt.Columns["PD"].ToString();
                sq.DataPropertyName = dt.Columns["TQ"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void sumtqytsalebydate(DateTime dt1, DataGridView dgv, DataGridViewColumn prd, DataGridViewColumn sq)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sumsalestockBYdate", cs);  // Sum of all quantity by date for sale and purchase ledger book
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", dt1);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                prd.DataPropertyName = dt.Columns["PD"].ToString();
                sq.DataPropertyName = dt.Columns["TQ"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void counttqytsalebydate(DateTime dt1, DataGridView dgv, DataGridViewColumn prd, DataGridViewColumn sq)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("countsalestockBYdate", cs);  // Count of all quantity by date for sale and purchase ledger book
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", dt1);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                prd.DataPropertyName = dt.Columns["PD"].ToString();
                sq.DataPropertyName = dt.Columns["TQ"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void sumqytpurchase(DateTime dt1, DateTime dt2, DataGridView dgv, DataGridViewColumn prd, DataGridViewColumn sq)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sumpurchasetockbtwdate", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", dt1);
                cmd.Parameters.AddWithValue("@date2", dt2);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                prd.DataPropertyName = dt.Columns["PD"].ToString();
                sq.DataPropertyName = dt.Columns["TQ"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void sumtqytpurchasebydate(DateTime dt1, DataGridView dgv, DataGridViewColumn prd, DataGridViewColumn sq)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sumpurchasetockBYdate", cs);  // Sum of all quantity by date for sale and purchase ledger book
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", dt1);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                prd.DataPropertyName = dt.Columns["PD"].ToString();
                sq.DataPropertyName = dt.Columns["TQ"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getinvoicecount(DateTime d1, DateTime d2, Label l1, Label l2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("invoicecount_LB", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", d1);
                cmd.Parameters.AddWithValue("@date2", d2);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                l1.Text = dt.Rows[0]["inv"].ToString();
                // l2.Text = dt.Rows[0]["NPA"].ToString() == "" ? "0.00" : "₹ " + dt.Rows[0]["NPA"].ToString();
                if (dt.Rows[0]["NPA"].ToString() == "")
                {
                    l2.Text = "₹ 0.00";
                }
                else
                {
                    Int64 aa = Convert.ToInt64(dt.Rows[0]["NPA"]);
                    l2.Text = aa.ToString("C");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void getexpensscount(DateTime d1, DateTime d2, Label l1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("expensescount_LB", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", d1);
                cmd.Parameters.AddWithValue("@date2", d2);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // l1.Text = dt.Rows[0]["TP"].ToString() == "" ? "0.00" : "₹ " + dt.Rows[0]["TP"].ToString();
                if (dt.Rows[0]["TP"].ToString() == "")
                {
                    //int a = Convert.ToInt32(dt.Rows[0]["NPA"]);
                    l1.Text = "0.00";
                }
                else
                {
                    int a = Convert.ToInt32(dt.Rows[0]["TP"]);
                    l1.Text = a.ToString("C");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getpurchasecount(DateTime d1, DateTime d2, Label l1, Label l2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("purchagecount_LB", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", d1);
                cmd.Parameters.AddWithValue("@date2", d2);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                l1.Text = dt.Rows[0]["inv"].ToString();
                // l2.Text = dt.Rows[0]["NPA"].ToString() == "" ? "0.00" : "₹ " + dt.Rows[0]["NPA"].ToString();
                if (dt.Rows[0]["NPA"].ToString() == "")
                {
                    l2.Text = "₹ 0.00";
                }
                else
                {
                    int aa = Convert.ToInt32(dt.Rows[0]["NPA"]);
                    l2.Text = aa.ToString("C");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void getinvoicecountBYDATE(DateTime d1, Label l1, Label l2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("invoicecount_LB_BYDATE", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", d1);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                l1.Text = dt.Rows[0]["inv"].ToString();
                if (dt.Rows[0]["NPA"].ToString() == "")
                {
                    l2.Text = "₹ 0.00";
                }
                else
                {
                    int aa = Convert.ToInt32(dt.Rows[0]["NPA"]);
                    l2.Text = aa.ToString("C");
                }
                //l2.Text = dt.Rows[0]["NPA"].ToString() == "" ? "0.00" : "₹ " + dt.Rows[0]["NPA"].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getinvoicecountBYTime(DateTime d1, Label l1, Label l2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("invoicecount_LB_BYTIME", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", d1);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                l1.Text = dt.Rows[0]["inv"].ToString();
                if (dt.Rows[0]["NPA"].ToString() == "")
                {
                    l2.Text = "₹ 0.00";
                }
                else
                {
                    int aa = Convert.ToInt32(dt.Rows[0]["NPA"]);
                    l2.Text = aa.ToString("C");
                }
                //l2.Text = dt.Rows[0]["NPA"].ToString() == "" ? "0.00" : "₹ " + dt.Rows[0]["NPA"].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getexpenssBYDATE(DateTime d1, Label l2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Expenss_LB_BYDATE", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", d1);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows[0]["TPD"].ToString() == "")
                {
                    //int a = Convert.ToInt32(dt.Rows[0]["NPA"]);
                    l2.Text = "0.00";
                }
                else
                {
                    int a = Convert.ToInt32(dt.Rows[0]["TPD"]);
                    l2.Text = a.ToString("C");
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getpurchasecountBYDATE(DateTime d1, Label l1, Label l2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("purchagecount_LB_BYDATE", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", d1);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                l1.Text = dt.Rows[0]["inv"].ToString();
                // l2.Text = dt.Rows[0]["NPA"].ToString() =="" ? "0.00" : "₹ " + dt.Rows[0]["NPA"].ToString();
                if (dt.Rows[0]["NPA"].ToString() == "")
                {
                    l2.Text = "₹ 0.00";
                }
                else
                {
                    int aa = Convert.ToInt32(dt.Rows[0]["NPA"]);
                    l2.Text = aa.ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int gettotalitem()
        {
            SqlCommand cmd = new SqlCommand("totalstockitem", cs);
            cmd.CommandType = CommandType.StoredProcedure;
            cs.Open();
            Currenttime.totalSTCKitem = Convert.ToInt32(cmd.ExecuteScalar());
            cs.Close();
            return Currenttime.totalSTCKitem;
        }

        public async void getaccess()
        {
            await Task.Run(() =>
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("accesscontrols", cs);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("un", loggedInUser.UserName);
                    cs.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Currenttime.spage = Convert.ToBoolean(sdr.GetBoolean(9));
                        Currenttime.shistory = Convert.ToBoolean(sdr.GetBoolean(10));
                        Currenttime.purchase = Convert.ToBoolean(sdr.GetBoolean(11));
                        Currenttime.purchaseH = Convert.ToBoolean(sdr.GetBoolean(12));
                        Currenttime.newproduct = Convert.ToBoolean(sdr.GetBoolean(13));
                        Currenttime.productD = Convert.ToBoolean(sdr.GetBoolean(14));
                        Currenttime.newcustomer = Convert.ToBoolean(sdr.GetBoolean(15));
                        Currenttime.CustomerD = Convert.ToBoolean(sdr.GetBoolean(16));
                        Currenttime.newsuplr = Convert.ToBoolean(sdr.GetBoolean(17));
                        Currenttime.suplrD = Convert.ToBoolean(sdr.GetBoolean(18));
                        Currenttime.back = Convert.ToBoolean(sdr.GetBoolean(19));
                        Currenttime.restor = Convert.ToBoolean(sdr.GetBoolean(20));
                        Currenttime.saleLB = Convert.ToBoolean(sdr.GetBoolean(21));
                        Currenttime.creatEXP = Convert.ToBoolean(sdr.GetBoolean(22));
                        Currenttime.addEXP = Convert.ToBoolean(sdr.GetBoolean(23));
                        Currenttime.stock = Convert.ToBoolean(sdr.GetBoolean(24));
                        Currenttime.setting = Convert.ToBoolean(sdr.GetBoolean(25));
                        Currenttime.Isadmin = Convert.ToBoolean(sdr.GetBoolean(26));

                    }
                    cs.Close();
                }
                catch (Exception ex)
                {
                    cs.Close();
                    MessageBox.Show(ex.Message);
                }
            });
        }
        public void expensestypeview(DataGridView dgv, DataGridViewColumn id, DataGridViewColumn type, DataGridViewColumn price, DataGridViewColumn des)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getexpensestrype", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                id.DataPropertyName = dt.Columns["id"].ToString();
                type.DataPropertyName = dt.Columns["Type"].ToString();
                price.DataPropertyName = dt.Columns["Price"].ToString();
                des.DataPropertyName = dt.Columns["Description"].ToString();
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void expenseview(DataGridView dgv, DataGridViewColumn cid, DataGridViewColumn cn, DataGridViewColumn cadd1, DataGridViewColumn cadd2, DataGridViewColumn cadd3, DataGridViewColumn cmbl, DataGridViewColumn cml, DataGridViewColumn cm)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getexpense", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cid.DataPropertyName = dt.Columns["id"].ToString();
                cn.DataPropertyName = dt.Columns["type"].ToString();
                cadd1.DataPropertyName = dt.Columns["price"].ToString();
                cadd2.DataPropertyName = dt.Columns["Quantity"].ToString();
                cadd3.DataPropertyName = dt.Columns["ToptalPrice"].ToString();
                cmbl.DataPropertyName = dt.Columns["Description"].ToString();
                cml.DataPropertyName = dt.Columns["Createdby"].ToString();
                cm.DataPropertyName = dt.Columns["Date"].ToString();
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void expenseviewbydate(DateTime d, DataGridView dgv, DataGridViewColumn cid, DataGridViewColumn cn, DataGridViewColumn cadd1, DataGridViewColumn cadd2, DataGridViewColumn cadd3, DataGridViewColumn cmbl, DataGridViewColumn cml, DataGridViewColumn cm)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getexpensebydate", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", d);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cid.DataPropertyName = dt.Columns["id"].ToString();
                cn.DataPropertyName = dt.Columns["type"].ToString();
                cadd1.DataPropertyName = dt.Columns["price"].ToString();
                cadd2.DataPropertyName = dt.Columns["Quantity"].ToString();
                cadd3.DataPropertyName = dt.Columns["ToptalPrice"].ToString();
                cmbl.DataPropertyName = dt.Columns["Description"].ToString();
                cml.DataPropertyName = dt.Columns["Createdby"].ToString();
                cm.DataPropertyName = dt.Columns["Date"].ToString();
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void purchasedetailsview(DataGridView pdgv, Int64 pbno, DataGridViewColumn c1, DataGridViewColumn c2, DataGridViewColumn c3, DataGridViewColumn c4, DataGridViewColumn c5, DataGridViewColumn c6, DataGridViewColumn c7, DataGridViewColumn c8, DataGridViewColumn c9, DataGridViewColumn c10, DataGridViewColumn c11, DataGridViewColumn c12, DataGridViewColumn c13)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getpurchasedetails", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p1", pbno);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                c1.DataPropertyName = dt.Columns["pp"].ToString();
                c2.DataPropertyName = dt.Columns["p2"].ToString();
                c3.DataPropertyName = dt.Columns["p3"].ToString();
                c4.DataPropertyName = dt.Columns["p4"].ToString();
                c5.DataPropertyName = dt.Columns["p5"].ToString();
                c6.DataPropertyName = dt.Columns["p6"].ToString();
                c7.DataPropertyName = dt.Columns["p7"].ToString();
                c8.DataPropertyName = dt.Columns["p8"].ToString();
                c9.DataPropertyName = dt.Columns["p9"].ToString();
                c10.DataPropertyName = dt.Columns["p10"].ToString();
                c11.DataPropertyName = dt.Columns["p11"].ToString();
                c12.DataPropertyName = dt.Columns["p12"].ToString();
                c13.DataPropertyName = dt.Columns["p13"].ToString();

                pdgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void pltotal(string proc, DataGridView dgv, DataGridViewColumn ccode, DataGridViewColumn cname, DataGridViewColumn cdis)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ccode.DataPropertyName = dt.Columns[0].ToString();
                cname.DataPropertyName = dt.Columns[1].ToString();
                cdis.DataPropertyName = dt.Columns[2].ToString();
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void pltotalbtdate(string proc, DataGridView dgv, DataGridViewColumn ccode, DataGridViewColumn cname, DataGridViewColumn cdis, DateTime d1, DateTime d2)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date1", d1);
                cmd.Parameters.AddWithValue("@date2", d2);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ccode.DataPropertyName = dt.Columns[0].ToString();
                cname.DataPropertyName = dt.Columns[1].ToString();
                cdis.DataPropertyName = dt.Columns[2].ToString();
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getsupaccount(DataGridView pdgv, int pbno, DataGridViewColumn c1, DataGridViewColumn c2, DataGridViewColumn c3, DataGridViewColumn c4, DataGridViewColumn c5, DataGridViewColumn c6)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getsupacc", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pbno);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                c1.DataPropertyName = dt.Columns["pb"].ToString();
                c2.DataPropertyName = dt.Columns["sin"].ToString();
                c3.DataPropertyName = dt.Columns["npa"].ToString();
                c4.DataPropertyName = dt.Columns["paid"].ToString();
                c5.DataPropertyName = dt.Columns["unp"].ToString();
                c6.DataPropertyName = dt.Columns["date"].ToString();
               
                pdgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

