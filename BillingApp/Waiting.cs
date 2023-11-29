using BillingSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApp
{
    public partial class Waiting : Form
    {


        public Waiting()
        {
            InitializeComponent();
           
        }

        private void Waiting_Load(object sender, EventArgs e)
        {
            label1.Text = "Please wait......";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
