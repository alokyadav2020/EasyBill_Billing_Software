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
    public partial class CustomerDiposit : Form
    {
        public CustomerDiposit()
        {
            InitializeComponent();
        }
        retrievedata r = new retrievedata();
        Viewalldata vd = new Viewalldata();
        Insertion inser = new Insertion();
        public string cusm { get; set; }
        private void CustomerDiposit_Load(object sender, EventArgs e)
        {
            diposittxt.Focus();
            r.gcd(cusm, cidlbl, namelbl, mobilelbl, addresslbl);
            
        }

        private void diposittxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(diposittxt.Text))
            {
                dismoneylbl.Text = "0.00";
            }
            else
            {
                decimal a = Convert.ToDecimal(diposittxt.Text);
                dismoneylbl.Text = a.ToString("C");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dipsotbtn_Click(object sender, EventArgs e)
        {
            if (diposittxt.Text.Trim() != "")
            {
                inser.dipositcustomermoney(Convert.ToDecimal(diposittxt.Text), dipositdt.Value, Convert.ToInt32(cidlbl.Text));
                diposittxt.Text = "";
                diposittxt.Enabled = false;
            }
            else { MessageBox.Show("Please Diposit Money","Diposit Money ?",MessageBoxButtons.OK,MessageBoxIcon.Information);}
        }
    }
}
