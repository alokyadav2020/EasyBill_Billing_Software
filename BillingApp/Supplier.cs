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

namespace BillingSystem
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }
        public int sid { get; set; }
        public bool isupdates { get; set; }
        Insertion i = new Insertion();
        EditAll ed = new EditAll();
        private void button1_Click(object sender, EventArgs e)
        {
            if (smobiletxt.Text != "" && firmtxt.Text!="")
            {
                if (isupdates == false)
                {
                    i.insertsupplier(firmtxt.Text, snametxt.Text, smobiletxt.Text, sadd1txt.Text, sadd2txt.Text, sgstintxt.Text, semailtxt.Text);
                    resetcontrol();
                }
                else if(isupdates==true)
                {
                    ed.updatsuppleir(sid, firmtxt.Text, snametxt.Text, smobiletxt.Text, sadd1txt.Text, sadd2txt.Text, sgstintxt.Text, semailtxt.Text);
                    resetcontrol();
                }                                
            }
            else
            {
                MessageBox.Show("Please provide requared information","Supplier Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }
        void resetcontrol()
        {
            firmtxt.Text = "";
            snametxt.Text = "";
            smobiletxt.Text = "";
            sadd1txt.Text = "";
            sadd2txt.Text = "";
            sgstintxt.Text = "";
            semailtxt.Text = "";
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            if (isupdates == true)
            {
                button1.Text = "Update";
            }
        }

        private void firmtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void snametxt_KeyDown(object sender, KeyEventArgs e)
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

        private void smobiletxt_KeyDown(object sender, KeyEventArgs e)
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

        private void sadd1txt_KeyDown(object sender, KeyEventArgs e)
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

        private void sadd2txt_KeyDown(object sender, KeyEventArgs e)
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

        private void sgstintxt_KeyDown(object sender, KeyEventArgs e)
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

        private void semailtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void Supplier_KeyDown(object sender, KeyEventArgs e)
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
