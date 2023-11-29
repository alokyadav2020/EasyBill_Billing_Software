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
using BillingApp.connection_class;
using BillingSystem.main_class;

namespace BillingApp
{
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }
        public int cid { get; set; }
        public bool isupdatec { get; set; }
        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            if (isupdatec == true)
            {
                CusSaveBtn.Text = "Update";
                CMTXT.Enabled = false;
            }
            CNTXT.Focus();
        }
        private void CusSaveBtn_Click(object sender, EventArgs e)
        {
            if (isupdatec == false)
            {
                Insertion i = new Insertion();
                i.insertcustomer(CNTXT.Text.Trim(), CA1TXT.Text.Trim(), CA2TXT.Text.Trim(), CA3TXT.Text.Trim(), CMTXT.Text.Trim(), CEMAILTXT.Text.Trim());
                cleardata();
                this.Close();
            }
            else if (isupdatec == true)
            {
                
                EditAll ed = new EditAll();
                ed.updatcostemer(cid, CNTXT.Text, CA1TXT.Text, CA2TXT.Text, CA3TXT.Text, CEMAILTXT.Text);
                cleardata();
                this.Close();

            }
            
        }
        void cleardata()
        {
            CNTXT.Text = "";
            CA1TXT.Text = "";
            CA2TXT.Text = "";
            CA3TXT.Text = "";
            CMTXT.Text = "";
            CEMAILTXT.Text = "";
        }

        private void CNTXT_KeyDown(object sender, KeyEventArgs e)
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

        private void CA1TXT_KeyDown(object sender, KeyEventArgs e)
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

        private void CA2TXT_KeyDown(object sender, KeyEventArgs e)
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

        private void CA3TXT_KeyDown(object sender, KeyEventArgs e)
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

        private void CMTXT_KeyDown(object sender, KeyEventArgs e)
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

        private void CEMAILTXT_KeyDown(object sender, KeyEventArgs e)
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

        private void CustomerDetails_KeyDown(object sender, KeyEventArgs e)
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
