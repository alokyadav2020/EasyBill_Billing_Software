using BillingApp.connection_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Transactions;
using System.Drawing;
using BillingSystem;

namespace BillingApp.main_class
{
    class EditAll
    {
        SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
        public void Editcatagory(int id, string catcode, string catname, string catdis)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("catedit", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@catcode", catcode);
                cmd.Parameters.AddWithValue("@catname", catname);
                cmd.Parameters.AddWithValue("@catdes", catdis);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data 'NOT' Updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void updateroles(int id, string rt, string rd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updaterole", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rid", id);
                cmd.Parameters.AddWithValue("@RTitle", rt);
                cmd.Parameters.AddWithValue("@RD", rd);
                cmd.Parameters.AddWithValue("@cteartby", loggedInUser.UserName);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data 'NOT' Updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void Editgst(int idgst, string gstedit, string cgstedit, string sgstedit)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("gstedit", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idgst);
                cmd.Parameters.AddWithValue("@gst", gstedit);
                cmd.Parameters.AddWithValue("@cgst", cgstedit);
                cmd.Parameters.AddWithValue("@sgst", sgstedit);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data 'NOT' Updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void Editproduct(int upid, string prcode, string prname, string prpartno, string prsaleprice, Double prgst, string prcgst, string prsgst, string prtsaleprice, string prmrp, string prpurprice, string prgstamnt, string prcgstamnt, string prsgstamnt)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATEproduct", cs);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pid", upid);
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
                    cs.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Data Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data 'NOT' Updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
        public void updateSCT(int proID, int Quan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updatestock", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", Quan);
                cs.Open();
                cmd.ExecuteNonQuery();
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void updateshopD(int id, string sn, string sa, string sc, string sg,byte[] image)
        {
            try
            {
               // byte[] imagedata;
                SqlCommand cmd = new SqlCommand("updateshopdetails", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@sname", sn);
                cmd.Parameters.AddWithValue("@saddress",sa);
                cmd.Parameters.AddWithValue("@scontact", sc);
                cmd.Parameters.AddWithValue("@sgstin", sg);
                cmd.Parameters.AddWithValue("@log",image);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data 'NOT' Updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void updatterrmscond(int id, string l1, string l2, string l3, string l4)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updateterms", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@l1", l1);
                cmd.Parameters.AddWithValue("@l2", l2);
                cmd.Parameters.AddWithValue("@l3", l3);
                cmd.Parameters.AddWithValue("@l4", l4);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data 'NOT' Updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void uppagesize(string un, RadioButton rba4, RadioButton rba4s,RadioButton rba5v, RadioButton rba5h, RadioButton thr,RadioButton rol5    )
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updatesalepagesize", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@un", un);
                cmd.Parameters.AddWithValue("@A4", rba4.Checked);
                cmd.Parameters.AddWithValue("@A4sipmle", rba4s.Checked);
                cmd.Parameters.AddWithValue("@A5V", rba5v.Checked);
                cmd.Parameters.AddWithValue("@A5H", rba5h.Checked);
                cmd.Parameters.AddWithValue("@ther", thr.Checked);
                cmd.Parameters.AddWithValue("@roll5", rol5.Checked);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Page Size Setting Saved Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Page Size Setting 'NOT' Updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void updatcostemer(int id, string cn, string ad1, string ad2, string ad3,string cemail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updatecustomer", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@cname", cn);
                cmd.Parameters.AddWithValue("@cadd1", ad1);
                cmd.Parameters.AddWithValue("@cadd2", ad2);
                cmd.Parameters.AddWithValue("@cadd3", ad3);
                
                cmd.Parameters.AddWithValue("@cemail", cemail);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data 'NOT' Updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void updatsuppleir(int id,string sfirn ,string sn,string smb ,string ad1, string ad2, string sgs, string semail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updatesupplier", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@sf", sfirn);
                cmd.Parameters.AddWithValue("@sn", sn);
                cmd.Parameters.AddWithValue("@sm", smb);
                cmd.Parameters.AddWithValue("@sad1", ad1);
                cmd.Parameters.AddWithValue("@sad2", ad2);
                cmd.Parameters.AddWithValue("@sgs", sgs);
                cmd.Parameters.AddWithValue("@sem", semail);                
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data 'NOT' Updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void updateexpensetype(int id, string catcode, string catname, string catdis)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updateexpensestype", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@type", catcode);
                cmd.Parameters.AddWithValue("@price", catname);
                cmd.Parameters.AddWithValue("@des", catdis);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data 'NOT' Updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void updateexpense(int id,string t,Decimal p, string q, Decimal tp,string des, DateTime d)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updateexpense", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@type", t);
                cmd.Parameters.AddWithValue("@price", p);
                cmd.Parameters.AddWithValue("@qua", q);
                cmd.Parameters.AddWithValue("@tp", tp);
                cmd.Parameters.AddWithValue("@des", des);
                cmd.Parameters.AddWithValue("@date", d);
                

                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data 'NOT' Updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void updateuseraccess(string name,CheckBox c1, CheckBox c2, CheckBox c3, CheckBox c4, CheckBox c5, CheckBox c6, CheckBox c7, CheckBox c8, CheckBox c9, CheckBox c10, CheckBox c11, CheckBox c12, CheckBox c13, CheckBox c14, CheckBox c15, CheckBox c16, CheckBox c17 )
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updateaccess", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@un", name);
                cmd.Parameters.AddWithValue("@a1", c1.Checked);
                cmd.Parameters.AddWithValue("@a2", c2.Checked);
                cmd.Parameters.AddWithValue("@a3", c3.Checked);
                cmd.Parameters.AddWithValue("@a4", c4.Checked);
                cmd.Parameters.AddWithValue("@a5", c5.Checked);
                cmd.Parameters.AddWithValue("@a6", c6.Checked);
                cmd.Parameters.AddWithValue("@a7", c7.Checked);
                cmd.Parameters.AddWithValue("@a8", c8.Checked);
                cmd.Parameters.AddWithValue("@a9", c9.Checked);
                cmd.Parameters.AddWithValue("@a10", c10.Checked);
                cmd.Parameters.AddWithValue("@a11", c11.Checked);
                cmd.Parameters.AddWithValue("@a12", c12.Checked);
                cmd.Parameters.AddWithValue("@a13", c13.Checked);
                cmd.Parameters.AddWithValue("@a14", c14.Checked);
                cmd.Parameters.AddWithValue("@a15", c15.Checked);
                cmd.Parameters.AddWithValue("@a16", c16.Checked);
                cmd.Parameters.AddWithValue("@a17", c17.Checked);
             
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Setting Saved Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Setting 'NOT' Saved Successfully ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void updatsyscon(int id, string sn, string sa, string sc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updatesyscon", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@email", sn);
                cmd.Parameters.AddWithValue("@pass", sa);
                cmd.Parameters.AddWithValue("@mob", sc);
               
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data 'NOT' Updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void updateserial(int id, CheckBox ws, string st,CheckBox dis)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updateserial", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@serial", ws.Checked);
                cmd.Parameters.AddWithValue("@stue", st);
                cmd.Parameters.AddWithValue("@dis", dis.Checked);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Setting Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Setting 'NOT' Updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void updatesuupaccount(Int64 id, decimal p, decimal up,DateTime dt)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updatesuppacc", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pbid", id);
                cmd.Parameters.AddWithValue("@paid", p);
                cmd.Parameters.AddWithValue("@upaid", up);
                cmd.Parameters.AddWithValue("@update", dt);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Payment has been Updated ", "Successful Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Payment has  'NOT' Updated ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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