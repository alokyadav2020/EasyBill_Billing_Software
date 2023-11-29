using BillingApp.main_class;
using BillingSystem.main_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class Systemcontact : Form
    {
        public Systemcontact()
        {
            InitializeComponent();
        }
        Viewalldata vd = new Viewalldata();
        Insertion i = new Insertion();
        EditAll ed = new EditAll();
        private void Systemcontact_Load(object sender, EventArgs e)
        {
            vd.getsystemcon();
            emailtxt.Text = Currenttime.sysemail;
            passtxt.Text = Currenttime.syspass;
            mobtxt.Text = Currenttime.sysmob;
            emailtxt.Focus();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (Currenttime.sysconid > 0)
            {
                //update
                ed.updatsyscon(Currenttime.sysconid, emailtxt.Text.Trim(), passtxt.Text.Trim(), mobtxt.Text.Trim());
                vd.getsystemcon();
                emailtxt.Text = Currenttime.sysemail;
                passtxt.Text = Currenttime.syspass;
                mobtxt.Text = Currenttime.sysmob;
                emailtxt.Focus();
            }
            else
            {
                //insert
                i.insertsyscon(emailtxt.Text.Trim(),passtxt.Text.Trim(),mobtxt.Text.Trim());
                vd.getsystemcon();
                emailtxt.Text = Currenttime.sysemail;
                passtxt.Text = Currenttime.syspass;
                mobtxt.Text = Currenttime.sysmob;
                emailtxt.Focus();
            }
        }

        private void emailtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void mobtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void Systemcontact_KeyDown(object sender, KeyEventArgs e)
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
