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
    public partial class InvoicePageFooter : Form
    {
        public InvoicePageFooter()
        {
            InitializeComponent();
        }
        Viewalldata v = new Viewalldata();
        EditAll ea = new EditAll();
        Insertion i = new Insertion();

        public bool Currenrtime { get; private set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void InvoicePageFooter_Load(object sender, EventArgs e)
        {
            v.gettermsr(l1txt,l2txt,l3txt,l4txt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Currenttime.tcid > 0)
            {
                ea.updatterrmscond(Currenttime.tcid, l1txt.Text, l2txt.Text, l3txt.Text, l4txt.Text);
                v.gettermsr(l1txt, l2txt, l3txt, l4txt);
            }
            else
            {
                i.insertterms(l1txt.Text, l2txt.Text, l3txt.Text, l4txt.Text);
                v.gettermsr(l1txt, l2txt, l3txt, l4txt);
            }
        }

        private void l1txt_KeyDown(object sender, KeyEventArgs e)
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

        private void l2txt_KeyDown(object sender, KeyEventArgs e)
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

        private void l3txt_KeyDown(object sender, KeyEventArgs e)
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

        private void l4txt_KeyDown(object sender, KeyEventArgs e)
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

        private void InvoicePageFooter_KeyDown(object sender, KeyEventArgs e)
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
