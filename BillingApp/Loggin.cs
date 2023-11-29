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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Resources;
using System.IO;


namespace BillingApp
{
    public partial class Loggin : Form
    {
        public Loggin()
        {
            InitializeComponent();
            retrievrpass();
        }
        double dd;
        int bb;
        retrievedata rt = new retrievedata();
        private void logginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("logging", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usern", untxt.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", passtxt.Text.Trim());
                // cmd.Parameters.AddWithValue("@pass", SecureData.EncryptData(passtxt.Text.Trim()));
                DataTable dtuser = new DataTable();
                cs.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    dtuser.Load(sdr);
                    DataRow userrow = dtuser.Rows[0];
                    loggedInUser.UserName = userrow["UserName"].ToString();
                    loggedInUser.RoleId = Convert.ToInt32(userrow["RoleId"].ToString());
                    rt.getuserroll(Convert.ToInt32(userrow["RoleId"].ToString()));
                    passremeber();
                    cs.Close();
                    this.Hide();
                    if (bb > 0)
                    {
                        homefrm h = new homefrm();
                        h.ShowDialog();
                    }
                    else
                    {
                        Trialsubscription tr = new Trialsubscription();
                        tr.Show();
                    }
                  
                }
                else
                {
                    MessageBox.Show("User Name Or Password Are incorrect");
                }
                
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        
        private void Loggin_Load(object sender, EventArgs e)
        {
            trial();
            untxt.Focus();
        }
        private void newuserlogbtn_Click(object sender, EventArgs e)
        {
          
        }
        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgetpassword fr = new Forgetpassword();
            fr.ShowDialog();
        }

        
        void attachDB()
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                string query = @"CREATE DATABASE [BillingSystem] ON 
                           ( FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BillingSystem.mdf' ),
                           ( FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BillingSystem_log.ldf' )
                            FOR ATTACH";
                SqlCommand cmd = new SqlCommand(query,cs);
                cs.Open();
                cmd.ExecuteNonQuery();
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            csfile csf = new csfile();
            csf.ShowDialog();
        }

        private void untxt_KeyDown(object sender, KeyEventArgs e)
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

        private void passtxt_KeyDown(object sender, KeyEventArgs e)
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

        void passremeber()
        {
            if(remeberpasscb.Checked== true)
            {
                BillingSystem.Properties.Settings.Default.username = untxt.Text;
                BillingSystem.Properties.Settings.Default.password = passtxt.Text;
                BillingSystem.Properties.Settings.Default.Save();
            }
            else
            {
                BillingSystem.Properties.Settings.Default.username = "";
                BillingSystem.Properties.Settings.Default.password ="";
                BillingSystem.Properties.Settings.Default.Save();
            }
        }

        void retrievrpass()
        {
            if (BillingSystem.Properties.Settings.Default.username != string.Empty)
            {
                untxt.Text = BillingSystem.Properties.Settings.Default.username;
                passtxt.Text = BillingSystem.Properties.Settings.Default.password;
                remeberpasscb.Checked = true;
            }
        }

        private void remeberpasscb_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Loggin_KeyDown(object sender, KeyEventArgs e)
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
               else if (e.KeyCode == Keys.R)
                {
                    remeberpasscb.Checked = true;
                }
                else if (e.KeyCode == Keys.U)
                {
                    remeberpasscb.Checked = false;
                }
            }
            catch
            {
            }                        
        }

        private void Loggin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        void trial()
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("getvaliddate", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        int ab = dr.GetInt32(0);
                        DateTime datevalue = (dr.GetDateTime(1));
                        DateTime d1 = DateTime.Now;
                        TimeSpan t = datevalue - d1;
                        double d = t.TotalDays;
                        dd = Convert.ToDouble(d.ToString());
                        bb = Convert.ToInt32(ab.ToString());
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

        private void remeberpasscb_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
