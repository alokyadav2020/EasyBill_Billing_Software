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

namespace BillingApp
{
    public partial class UsersRoles : Form
    {
        Insertion i = new Insertion();
        EditAll E = new EditAll();
        Deleteall d = new Deleteall();
        public UsersRoles()
        {
            InitializeComponent();
        }
        public int roleid { get; set; }
        public bool Isupdate { get; set; }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (titletxt.Text.Trim() == "" && roledectxt.Text.Trim() == "")
            {

            }
            else if (Isupdate == true)
            {
                E.updateroles(roleid, titletxt.Text.Trim(), roledectxt.Text.Trim());
                titletxt.Text = "";
                roledectxt.Text = "";
            }
            else if (Isupdate == false)
            {
                i.insertroles(titletxt.Text.Trim(), roledectxt.Text.Trim(), "");
                titletxt.Text = "";
                roledectxt.Text = "";
            }
        }

        private void UsersRoles_Load(object sender, EventArgs e)
        {
            titletxt.Focus();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (titletxt.Text == "Administrator")
            {
                MessageBox.Show("You can't delete Administrator","Deletion denied !!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                d.deletrole(roleid);
                titletxt.Text = "";
                roledectxt.Text = "";
                deleteToolStripMenuItem.Enabled = false;
            }
            
        }

        private void titletxt_KeyDown(object sender, KeyEventArgs e)
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

        private void roledectxt_KeyDown(object sender, KeyEventArgs e)
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

        private void UsersRoles_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Up)
                {
                    e.SuppressKeyPress = true;
                    SendKeys.Send("+{tab}");
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                else if (e.Control == true && e.KeyCode == Keys.Down)
                {
                    e.SuppressKeyPress = true;
                    SendKeys.Send("{tab}");
                }
            }
            catch
            {
            }
        }
    }
}
