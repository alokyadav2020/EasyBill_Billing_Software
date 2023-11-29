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

namespace BillingSystem
{
    public partial class attachDB : Form
    {
        public attachDB()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Database File(*.mdf) | *.mdf";
            ofd.Title = "Select mdf  file";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                msffiletxt.Text = ofd.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (msffiletxt.Text.Trim() != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=" + servertxt.Text + ";Initial Catalog = master; Integrated Security=True; MultipleActiveResultSets=true;");
                string query = @"CREATE DATABASE ["+dbnametxt.Text+"] ON (FILENAME = N'" + msffiletxt.Text + "') FOR ATTACH";                
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Database Attached Successfully");
                    rest();
                }
                catch (SqlException ex)
                {
                    con.Close();
                    MessageBox.Show("Error Generated. Details: " + ex.ToString());
                   
                }
                finally
                {
                    con.Close();

                }
            }          
        }

        private void msffiletxt_KeyDown(object sender, KeyEventArgs e)
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

        private void servertxt_KeyDown(object sender, KeyEventArgs e)
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

        private void attachDB_KeyDown(object sender, KeyEventArgs e)
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
        void rest()
        {
            servertxt.Text = "";
            msffiletxt.Text = "";
            dbnametxt.Text = "";
        }

        private void attachDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
