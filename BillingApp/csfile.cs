using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using BillingApp;
using System.Data.SqlClient;
using BillingSystem.main_class;
using BillingApp.connection_class;
using System.IO;

namespace BillingSystem
{
    public partial class csfile : Form
    {
        public csfile()
        {
            InitializeComponent();
        }
        string connection;
       
        public void updateconfigfile(string dbcs)
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if(xElement.Name== "connectionStrings")
                {
                    xElement.FirstChild.Attributes[1].Value = dbcs;
                }
            }
            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
       void saveconnection()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\db_connect";
            File.WriteAllText(path, connection);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
             if (servernametxt.Text.Trim() != "" && dbnametxt.Text.Trim()!="")
             {
                if (checkb.Checked)
                {
                    connection = "Data Source=" + servernametxt.Text + ";Initial Catalog = " + dbnametxt.Text + ";Integrated Security=True ; MultipleActiveResultSets=true;Trusted_Connection=True";
                    saveconnection();
                    //updateconfigfile(connection); 
                    this.Hide();
                    Loggin lg = new Loggin();
                    lg.Show();
                    passwordpolicy();
                   
                }
                else if(!checkb.Checked)
                {
                    connection = "Data Source=" + servernametxt.Text + ";Initial Catalog = " + dbnametxt.Text + "; User ID = " + usertxt.Text + "; Password=" + passtxt.Text + "; MultipleActiveResultSets=true;Trusted_Connection=True";
                    saveconnection();
                     //updateconfigfile(connection);  
                    this.Hide();
                    Loggin lg = new Loggin();
                    lg.Show();
                    passwordpolicy();
                    
                }                            
             }
             else { MessageBox.Show("All Fields are mandatory", "Fileds Missing ..", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
 
        }

        private void createTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attachDB adb = new attachDB();
            adb.ShowDialog();
        }

        private void csfile_Load(object sender, EventArgs e)
        {
            servernametxt.Focus();
        }

        void passwordpolicy()
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                string query = @" USE [master]  ALTER LOGIN [easyapp] WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF ";
                SqlCommand cmd = new SqlCommand(query, cs);
                cs.Open();
                int a = cmd.ExecuteNonQuery();                
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void servernametxt_KeyDown(object sender, KeyEventArgs e)
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

        private void dbnametxt_KeyDown(object sender, KeyEventArgs e)
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

        private void usertxt_KeyDown(object sender, KeyEventArgs e)
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

        private void csfile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void checkb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkb.Checked)
            {
                usertxt.Text = "";
                passtxt.Text = "";
                usertxt.Enabled = false;
                passtxt.Enabled = false;
            }
            else if (!checkb.Checked)
            {
                usertxt.Text = "";
                passtxt.Text = "";
                usertxt.Enabled = true;
                passtxt.Enabled = true;
            }
        }

        private void csfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void csfile_Load_1(object sender, EventArgs e)
        {

        }
    }
}
