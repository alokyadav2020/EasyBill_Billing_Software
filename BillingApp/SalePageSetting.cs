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
    public partial class SalePageSetting : Form
    {
        public SalePageSetting()
        {
            InitializeComponent();
        }
        retrievedata r = new retrievedata();
        int a = 0;
        EditAll ed = new EditAll();
        private void salewithserial_Load(object sender, EventArgs e)
        {
            r.getserial();
            a = Convert.ToInt32(Currenttime.serialid.ToString());
            serialcb.Checked = Currenttime.withserial;
            discb.Checked = Currenttime.discount;
            serialtypetxt.Text = Currenttime.serialtype.ToString();
        }

        private void serialbtn_Click(object sender, EventArgs e)
        {
            ed.updateserial(Currenttime.serialid, serialcb, serialtypetxt.Text,discb);
            this.Close();
        }

        private void serialcb_CheckedChanged(object sender, EventArgs e)
        {
            if (serialcb.Checked)
            {
                label2.Visible = true;
                serialtypetxt.Visible = true;
                serialcb.ForeColor = Color.Green;
            }
            else
            {
                label2.Visible = false;
                serialtypetxt.Visible = false;
                serialcb.ForeColor = Color.Black;
            }
        }

        private void salewithserial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void discb_CheckedChanged(object sender, EventArgs e)
        {
            if (discb.Checked == true)
            {
                discb.Text = "Discount in % .";
                distxt.Text = "You have to give discount in % . If you want hide discount option, you have to uncheck and save.";
            }
            else
            {
                discb.Text = "Discount has been hide.";
                distxt.Text = "Your discount option has been hide . If you want show discount option , you have to check and save.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
