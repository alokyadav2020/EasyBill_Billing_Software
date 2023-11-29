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
using BillingSystem.Properties;
using System.Resources;
namespace BillingSystem
{
    public partial class InvoicePageSize : Form
    {
        public InvoicePageSize()
        {
            InitializeComponent();
        }
        Viewalldata v = new Viewalldata();
        EditAll ea = new EditAll();

        private void InvoicePageSize_Load(object sender, EventArgs e)
        {
            v.rbchecked(a4psclasic,a4pswhite,a5potrate,a5landscape,roll3inch,roll5inch);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            ea.uppagesize(loggedInUser.UserName, a4psclasic, a4pswhite, a5potrate, a5landscape, roll3inch, roll5inch);
            this.Close();
        }

        private void a4psclasic_CheckedChanged(object sender, EventArgs e)
        {
            sizepb.Image = Resources.A4C;
        }

        private void a5potrate_CheckedChanged(object sender, EventArgs e)
        {
            sizepb.Image = Resources.A5v;
        }

        private void a4pswhite_CheckedChanged(object sender, EventArgs e)
        {
            sizepb.Image = Resources.A4S;
        }

        private void a5landscape_CheckedChanged(object sender, EventArgs e)
        {
            sizepb.Image = Resources.A5H;
        }

        private void roll3inch_CheckedChanged(object sender, EventArgs e)
        {
            sizepb.Image = Resources.roll3;
        }

        private void InvoicePageSize_KeyDown(object sender, KeyEventArgs e)
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
