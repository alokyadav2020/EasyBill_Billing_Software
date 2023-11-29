using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BillingApp.connection_class;

namespace BillingApp.main_class
{
    class Deleteall
    {
        SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
        public void deletecat(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("catdelete", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data deleted succesfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not deleted succesfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void deletrole(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("deleterole", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data deleted succesfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not deleted succesfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void deleusers(string name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("deleteusers", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", name);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data deleted succesfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not deleted succesfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void deletegst(int gstid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("gstdelete", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", gstid);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data deleted succesfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not deleted succesfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void deleteproductdetails(int producdlttid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("productdetaildelete", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", producdlttid);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data deleted succesfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not deleted succesfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void deletestock(int stockdelte)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("stockdq", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sid", stockdelte);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Stock Quantity deleted succesfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Stock Quantity Not deleted succesfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void deleteexpensetype(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("deletexpensetype", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data deleted succesfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not deleted succesfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void deleteexpens(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("deleteexpens", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data deleted succesfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not deleted succesfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
