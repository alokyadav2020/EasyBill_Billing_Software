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
using System.IO;

namespace BillingSystem
{
    public partial class InvoicePageheader : Form
    {
        public InvoicePageheader()
        {
            InitializeComponent();
        }
        Viewalldata v = new Viewalldata();
        EditAll ea = new EditAll();
        Insertion i = new Insertion();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InvoicePageheader_Load(object sender, EventArgs e)
        {
            v.getshopheader(fntxt,cdtxt,addtxt,gstintxt,logopb);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Currenttime.fnid>0)
            {
                Image img = logopb.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                if (logopb.Image != null)
                {
                    ea.updateshopD(Currenttime.fnid, fntxt.Text, cdtxt.Text, addtxt.Text, gstintxt.Text, arr);
                }
                else
                {
                   

                    ea.updateshopD(Currenttime.fnid, fntxt.Text, cdtxt.Text, addtxt.Text, gstintxt.Text,arr);
                }
                v.getshopheader(fntxt, cdtxt, addtxt, gstintxt,logopb);
            }
            else
            {
                Image img = logopb.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                i.insertSHOPD(fntxt.Text, cdtxt.Text, addtxt.Text, gstintxt.Text,arr);
                v.getshopheader(fntxt, cdtxt, addtxt, gstintxt,logopb);
            }
        }

        private void fntxt_KeyDown(object sender, KeyEventArgs e)
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

        private void cdtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void addtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void gstintxt_KeyDown(object sender, KeyEventArgs e)
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

        private void InvoicePageheader_KeyDown(object sender, KeyEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "image files|*.jpg;*.png;*.gif;*.icon;.*;";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    
                    logopb.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            logopb.Image.Dispose();
            logopb.Image = null;
            logopb.ImageLocation = null;
        }
    }
}
