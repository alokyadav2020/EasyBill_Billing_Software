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
    public partial class paytosuppiler : Form
    {
        public paytosuppiler()
        {
            InitializeComponent();
        }

        public Int64 sbill { get; set; }
        EditAll ed = new EditAll();
        private void spaymentbtn_Click(object sender, EventArgs e)
        {
            if (spaytxt.Enabled == true)
            {
                if (spaytxt.Text.Trim() != "")
                {
                    ed.updatesuupaccount(sbill, Convert.ToDecimal(palbl.Text), Convert.ToDecimal(unpalbl.Text), paydate.Value);
                    spaytxt.Enabled = false;
                }
            }
            else
            {
                noticlbl.Text="You have already try for this payment";
                noticlbl.Visible = true;
            }
        }
        decimal a, b;

        private void spaytxt_KeyDown(object sender, KeyEventArgs e)
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

        private void paytosuppiler_Load(object sender, EventArgs e)
        {
            spaytxt.Enabled = true;
        }

        private void spaytxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(spaytxt.Text.Trim()))
            {
                palbl.Text="0.00";
                unpalbl.Text = npalbl.Text.ToString();
            }
            else
            {
                try
                {
                    if (Convert.ToDecimal(spaytxt.Text) <= Convert.ToDecimal(npalbl.Text))
                    {
                        a = Convert.ToDecimal(spaytxt.Text);
                        palbl.Text = a.ToString();
                        b = Convert.ToDecimal(npalbl.Text) - a;
                        unpalbl.Text = b.ToString();
                        noticlbl.Visible = false;
                    }
                    else
                    {
                        noticlbl.Visible = true;
                        noticlbl.Text = "You can't pay more than net payable amount";
                        noticlbl.ForeColor = Color.Red;
                        noticlbl.BackColor = Color.White;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
