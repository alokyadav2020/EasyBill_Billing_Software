using BillingApp.main_class;
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
    public partial class NewCatagory : Form
    {
        Insertion insert = new Insertion();
        EditAll edit = new EditAll();       
        public int catid { get; set; }
        public bool Isupdate { get; set; }
        public NewCatagory()
        {
            InitializeComponent();

        }
        private void NewCatagory_Load(object sender, EventArgs e)
        {
            if (Isupdate == true)
            {
                saveclosebtn.Hide();
                savecatagorybtn.Text = "Update";
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void resetcontrols()
        {
            catagorycodetxt.Text = "";
            catagorynametxt.Text = "";
            catagorydiscriptiontxt.Text = "";
        }
        private void savecatagorybtn_Click(object sender, EventArgs e)
        {
            if (catagorycodetxt.Text == "" || catagorynametxt.Text == "" || catagorydiscriptiontxt.Text == "")
            {
                MessageBox.Show("All fields are mendatory", "Fields can be empaty", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (Isupdate == true)
            {
                SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
                edit.Editcatagory(catid, catagorycodetxt.Text.Trim(), catagorynametxt.Text.Trim(), catagorydiscriptiontxt.Text.Trim());
                this.Close();
            }
            else if (Isupdate == false)
            {
                insert.insertnewcatagogy(catagorycodetxt.Text.Trim(), catagorynametxt.Text.Trim(), catagorydiscriptiontxt.Text.Trim());
                resetcontrols();
                catagorycodetxt.Focus();
            }
        }
        private void saveclosebtn_Click(object sender, EventArgs e)
        {
            if (catagorycodetxt.Text != "" && catagorynametxt.Text != "" && catagorydiscriptiontxt.Text != "")
            {
                insert.insertnewcatagogy(catagorycodetxt.Text.Trim(), catagorynametxt.Text.Trim(), catagorydiscriptiontxt.Text.Trim());
                resetcontrols();
                catagorycodetxt.Focus();
            }
            else
            {
                MessageBox.Show("All fields are mendatory", "Fields can be empaty", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            this.Close();
        }

        private void catagorycodetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void catagorynametxt_KeyDown(object sender, KeyEventArgs e)
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

        private void catagorydiscriptiontxt_KeyDown(object sender, KeyEventArgs e)
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

        private void NewCatagory_KeyDown(object sender, KeyEventArgs e)
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
    }
}
