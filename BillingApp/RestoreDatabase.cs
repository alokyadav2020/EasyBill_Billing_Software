using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using BillingApp.connection_class;
namespace BillingSystem
{
    public partial class RestoreDatabase : Form
    {
        SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
        public RestoreDatabase()
        {
            InitializeComponent();
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {

        }

        private void restorebtn_Click(object sender, EventArgs e)
        {
            if (m1rb.Checked == true)
            {
                savedatadb();
                restore1();
            }
            else if(m2rb.Checked==true)
            {
                savedatadb();
                restore3();
               // restore2();
            }
            
        }
        void restore1()
        {
            if (textBox1.Text != "" && loadtxt.Text!="")
            {
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;database=master.mdf;Integrated Security=True");
                //string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\master.mdf;Integrated Security=True";
                String database = cs.Database.ToString();
                try
                {
                    string sql2 = $@"USE [MASTER] RESTORE DATABASE [" + loadtxt.Text + "] FROM DISK=N'" + textBox1.Text + "' WITH FILE = 1,  NOUNLOAD,  STATS = 5";
                    //string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + loadtxt.Text + "] FROM DISK='" + textBox1.Text + "' WITH FILE = 1,  NOUNLOAD,  STATS = 5");
                    SqlCommand cmd2 = new SqlCommand(sql2, cs);
                    cs.Open();
                    cmd2.ExecuteNonQuery();
                    cs.Close();
                   
                    MessageBox.Show("Database Restored successfully", "Restore Database successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadtxt.Text = "";

                }
                catch (Exception ex)

                {
                    cs.Close();
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please Select Backup File With Extension (.bak)", ".bak File not selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void restore2()
        {
            if (loadtxt.Text != "")
            {

                String database = cs.Database.ToString();
                try
                {


                    string sql1 = string.Format("USE MASTER ALTER DATABASE '" + loadtxt.Text + "' SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand cmd1 = new SqlCommand(sql1, cs);
                    cs.Open();
                    cmd1.ExecuteNonQuery();
                    cs.Close();
                    string sql2 = string.Format("USE MASTER RESTORE DATABASE '" + loadtxt.Text + "' FROM DISK='" + loadtxt.Text + "' WITH REPLACE");
                    SqlCommand cmd2 = new SqlCommand(sql2, cs);
                    cs.Open();
                    cmd2.ExecuteNonQuery();
                    cs.Close();
                    
                    MessageBox.Show("Database Restored successfully", "Restore Database successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadtxt.Text = "";

                }
                catch (Exception ex)

                {
                    cs.Close();
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please Select Backup File With Extension (.bak)", ".bak File not selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void  restore3()
        {
            if (loadtxt.Text != "")
            {                
                try
                {
                    string sql1 = "USE MASTER; ALTER DATABASE '" + loadtxt.Text + "' SET Single_User with RollBack Immediate; ";
                    sql1 += "RESTORE DATABASE '" + loadtxt.Text + "' FROM DISK= '" + textBox1.Text + "' WITH Replace; ";

                    SqlCommand cmd1 = new SqlCommand(sql1, cs);
                    //cmd1.CommandTimeout = 100;
                    cs.Open();
                    cmd1.ExecuteNonQuery();
                    cs.Close();                  
                    MessageBox.Show("Database Restored successfully", "Restore Database successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadtxt.Text = "";

                }
                catch (Exception ex)

                {
                    cs.Close();
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please Select Backup File With Extension (.bak)", ".bak File not selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Backup File(*.bak) | *.bak";
            ofd.Title = "Select backup file";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void browsebtn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
           // ofd.Filter = "Backup File(*.bak) | *.bak";
            ofd.Title = "Select backup file";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                loadtxt.Text = ofd.FileName;
            }

            
        }
        void savedatadb()
        {
            if (remembercb.Checked == true)
            {
                BillingSystem.Properties.Settings.Default.RNAME = loadtxt.Text;
                BillingSystem.Properties.Settings.Default.RPATH = textBox1.Text;
                BillingSystem.Properties.Settings.Default.Save();
            }
            else
            {
                BillingSystem.Properties.Settings.Default.RNAME = "";
                BillingSystem.Properties.Settings.Default.RPATH = "";
                BillingSystem.Properties.Settings.Default.Save();
            }
        }

        void loaddbname()
        {
            loadtxt.Text = BillingSystem.Properties.Settings.Default.RNAME;
            textBox1.Text = BillingSystem.Properties.Settings.Default.RPATH;
            remembercb.Checked = true;
        }

        private void RestoreDatabase_Load(object sender, EventArgs e)
        {
            loaddbname();
            m1rb.Checked = true;
        }
    }
}
