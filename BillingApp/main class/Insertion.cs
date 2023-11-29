using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BillingApp.connection_class;
using System.Transactions;
namespace BillingApp.main_class
{
    public class Insertion
    {
        SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
        public void insertnewcatagogy(string code, string name, string discription)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertcat", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catcode", code);
                cmd.Parameters.AddWithValue("@catname", name);
                cmd.Parameters.AddWithValue("@catdes", discription);
                cs.Open();
                cmd.ExecuteNonQuery();
                
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void insertroles(string rt, string rd, string cb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertrole", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@roletilte", rt);
                cmd.Parameters.AddWithValue("@dec", rd);
                cmd.Parameters.AddWithValue("@createdby", loggedInUser.UserName);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Saved succesfully ......!!!!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data saveing failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void insertgst(string gst, string cgst, string sgst)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("gstinsertion", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@gst", gst);
                cmd.Parameters.AddWithValue("@cgst", cgst);
                cmd.Parameters.AddWithValue("@sgst", sgst);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("GST inserted successfully", "!!Insertion Success!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GST 'NOT' inserted successfully", "!!Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        int maxproid;
        public void insertproduct(string prcode, string prname, string prpartno, string prsaleprice, Double prgst, string prcgst, string prsgst, string prtsaleprice, string prmrp, string prpurprice, string prgstamnt, string prcgstamnt, string prsgstamnt, string prcatid, string stockQ)
        {
            using(TransactionScope ts= new TransactionScope())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("addproduct", cs);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pcode", prcode);
                    cmd.Parameters.AddWithValue("@pname", prname);
                    cmd.Parameters.AddWithValue("@ppartno", prpartno);
                    cmd.Parameters.AddWithValue("@psaleprice", prsaleprice);
                    cmd.Parameters.AddWithValue("@pgsttax", prgst);
                    cmd.Parameters.AddWithValue("@pcgsttax", prcgst);
                    cmd.Parameters.AddWithValue("@psgsttax", prsgst);
                    cmd.Parameters.AddWithValue("@ptotalsaleprice", prtsaleprice);
                    cmd.Parameters.AddWithValue("@pmrp", prmrp);
                    cmd.Parameters.AddWithValue("@ppurchageprice", prpurprice);
                    cmd.Parameters.AddWithValue("@pgsttaxamount", prgstamnt);
                    cmd.Parameters.AddWithValue("@pcgsttaxamount", prcgstamnt);
                    cmd.Parameters.AddWithValue("@psgsttaxamount", prsgstamnt);
                    cmd.Parameters.AddWithValue("@catid", prcatid);
                    cs.Open();
                    int a = cmd.ExecuteNonQuery();
                    cs.Close();
                    if (a > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("getlatestproid", cs);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cs.Open();
                        maxproid = Convert.ToInt32(cmd2.ExecuteScalar());
                        cs.Close();
                        SqlCommand cmd1 = new SqlCommand("insertstocttbl", cs);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@proid", maxproid);
                        cmd1.Parameters.AddWithValue("@stock", stockQ);
                        cs.Open();
                        cmd1.ExecuteNonQuery();
                        
                        cs.Close();

                    }

                }
                catch (Exception ex)
                {
                    cs.Close();
                    MessageBox.Show(ex.Message);
                }
                ts.Complete();
            }
            
        }
        int getproductid()
        {
            SqlCommand cmd = new SqlCommand("getlatestproid", cs);
            cmd.CommandType = CommandType.StoredProcedure;
            cs.Open();
            int maxproid = Convert.ToInt32(cmd.ExecuteScalar());
            cs.Close();
            return maxproid;
        }
        public void insertstock(string stockQ)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertstocttbl", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proid", getproductid());
                cmd.Parameters.AddWithValue("@stock", stockQ);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Product Details Saved Successfully", "!!Insertion Success!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Product Details 'NOT' Saved Successfully", "!!Insertion Fialed!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void insertcustomer(string cusname, string cusadd1, string cusadd2, string cusadd3, string cusmobile, string cusemail)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insertcustomer", cs);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cname", cusname);
                    cmd.Parameters.AddWithValue("@caddress1", cusadd1);
                    cmd.Parameters.AddWithValue("@caddress2", cusadd2);
                    cmd.Parameters.AddWithValue("@caddress3", cusadd3);
                    cmd.Parameters.AddWithValue("@cmobile", cusmobile);
                    cmd.Parameters.AddWithValue("@cemail", cusemail);
                    cs.Open();
                    cmd.ExecuteNonQuery();
                    
                    cs.Close();
                }
                catch (Exception ex)
                {
                    cs.Close();
                    MessageBox.Show(ex.Message);
                }
                ts.Complete();
            }
               
        }
        public void insertsupplier(string sfirm, string sname, string smobile, string sadd1, string sadd2, string sgstin,string semail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertsupplier", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sfirm", sfirm);
                cmd.Parameters.AddWithValue("@sname", sname);
                cmd.Parameters.AddWithValue("@smobile", smobile);
                cmd.Parameters.AddWithValue("@sadd1", sadd1);
                cmd.Parameters.AddWithValue("@sadd2", sadd2);
                cmd.Parameters.AddWithValue("@sgstin", sgstin);
                cmd.Parameters.AddWithValue("@semail", semail);
                cs.Open();
                cmd.ExecuteNonQuery();
                
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void insertusers(string un, string up, ComboBox urcb, CheckBox ucb, String userdesc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertuser", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@un", un);
                cmd.Parameters.AddWithValue("@up", up);
                cmd.Parameters.AddWithValue("@roleid", urcb);
                cmd.Parameters.AddWithValue("@isactive", ucb);
                cmd.Parameters.AddWithValue("@desc", userdesc);
                //cmd.Parameters.AddWithValue("@cb", db);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Saved succesfully ......!!!!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data saveing failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void insertSHOPD(string name, string add, string cont, string sgstin,byte[] image)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertshopD", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sn", name);
                cmd.Parameters.AddWithValue("@sadd", add);
                cmd.Parameters.AddWithValue("@scon", cont);
                cmd.Parameters.AddWithValue("@sghtin", sgstin);
                cmd.Parameters.AddWithValue("@log", image);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Saved succesfully ......!!!!!!", "Data Insertion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data insertion failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void insertterms(string name, string add, string cont, string sgstin)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("inserterms", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@l1", name);
                cmd.Parameters.AddWithValue("@l2", add);
                cmd.Parameters.AddWithValue("@l3", cont);
                cmd.Parameters.AddWithValue("@l4", sgstin);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Saved succesfully ......!!!!!!", "Data Insertion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data insertion failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void insertexpencetypr(string type, string price, string discription)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertexpensetype", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@des", discription);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Saved succesfully ......!!!!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Not Saved failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void insertexpense(string t, Decimal p, string q, Decimal tp, string des, string cb, DateTime d)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertexpense", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@type", t);
                cmd.Parameters.AddWithValue("@price", p);
                cmd.Parameters.AddWithValue("@qua", q);
                cmd.Parameters.AddWithValue("@tp", tp);
                cmd.Parameters.AddWithValue("@des", des);
                cmd.Parameters.AddWithValue("@creaby", cb);
                cmd.Parameters.AddWithValue("@date", d);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data inserted succesfully ......!!!!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data insertion failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void insertsyscon(string code, string name, string discription)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertsyscon", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", code);
                cmd.Parameters.AddWithValue("@pass", name);
                cmd.Parameters.AddWithValue("@mob", discription);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data inserted succesfully ......!!!!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data insertion failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void insertvaliddate(DateTime d11,  DateTime d22, double d, string comm)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertexpiredate", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@d1", d11);
                cmd.Parameters.AddWithValue("@d2", d22);
                cmd.Parameters.AddWithValue("@day",d);
                cmd.Parameters.AddWithValue("@comm",comm);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Activation Successfull", "Activated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Activation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void dipositcustomermoney(Decimal dm, DateTime dt,int cid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("cusdiposit", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dipos", dm);
                cmd.Parameters.AddWithValue("@date", dt);
                cmd.Parameters.AddWithValue("@cusid", cid);
                cmd.Parameters.AddWithValue("@user", loggedInUser.UserName);
                cs.Open();
                
                int a= cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Money Diposited Successfully", "Diposit Amount Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Money Diposited NOT Successfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
