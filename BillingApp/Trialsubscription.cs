using BillingApp;
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
    public partial class Trialsubscription : Form
    {
        public Trialsubscription()
        {
            InitializeComponent();
        }
        Insertion inn = new Insertion();
        private void button1_Click(object sender, EventArgs e)
        {
            {
                DateTime d1 = DateTime.Now;
                DateTime d2 = d1.AddMonths(1);
                TimeSpan t = d2 - d1;
                double d = t.TotalDays;
                inn.insertvaliddate(d1, d2, d, "ONE MONTH FREE TRIAL");
                this.Hide();
                Loggin l = new Loggin();
                l.Show();
            }
        }

        private void Trialsubscription_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
               
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch
            {
            }
        }

        private void Trialsubscription_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Trialsubscription_Load(object sender, EventArgs e)
        {
            vslbl.Text= "Version " + Application.ProductVersion;
            d1lbl.Text = "Registerd Date :" + DateTime.Now;
            d2lbl.Text = "Expired Date" + DateTime.Now.AddMonths(1);
            d3lbl.Text = "Trial Period ONE MONTH ONLY";
        }
    }
}
