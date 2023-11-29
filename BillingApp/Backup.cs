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

namespace BillingApp
{
    public partial class Backup : Form
    {       
        SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
        public Backup()
        {
            InitializeComponent();
        }        
        private void browsebtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                backuptxt.Text = fbd.SelectedPath;
            }
        }
        private void backupbtn_Click(object sender, EventArgs e)
        {
            savedatadb();
            backup1();
        }

        private void backuptxt_KeyDown(object sender, KeyEventArgs e)
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

        void backup1()
        {
            if (backuptxt.Text.Trim() != "")
            {
                String database = cs.Database.ToString();
                try
                {
                    string q = "BACKUP DATABASE [" + loadtxt.Text + "] TO DISK='" + backuptxt.Text + "\\" + "EasyBillBackupFile" + ".bak'";
                    //string q = "BACKUP DATABASE EBDB TO DISK='" + backuptxt.Text + "\\" + "EBDB" + ".bak'";
                    SqlCommand cmd = new SqlCommand(q, cs);
                    cs.Open();
                    cmd.ExecuteNonQuery();
                    cs.Close();
                    MessageBox.Show("Backup Database Successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    backuptxt.Text = "";
                }
                catch (Exception ex)
                {
                    cs.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select path where you want to backup ", "Path Select....?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Backup File(*.bak) | *.bak";
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
                BillingSystem.Properties.Settings.Default.BNAME = loadtxt.Text;
                BillingSystem.Properties.Settings.Default.BPATH = backuptxt.Text;
                BillingSystem.Properties.Settings.Default.Save();
            }
            else
            {
                BillingSystem.Properties.Settings.Default.BNAME = "";
                BillingSystem.Properties.Settings.Default.BPATH = "";
                BillingSystem.Properties.Settings.Default.Save();
            }
        }

        void loaddbname()
        {
            loadtxt.Text = BillingSystem.Properties.Settings.Default.BNAME;
            backuptxt.Text = BillingSystem.Properties.Settings.Default.BPATH;
            remembercb.Checked = true;
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            loaddbname();
        }
    }
}
