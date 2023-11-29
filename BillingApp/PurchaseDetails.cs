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
    public partial class PurchaseDetails : Form
    {
        public PurchaseDetails()
        {
            InitializeComponent();
        }
        public Int64 PBNO { get; set; }
        Viewalldata vd = new Viewalldata();
        private void PurchaseDetails_Load(object sender, EventArgs e)
        {
            vd.purchasedetailsview(pddgv, PBNO, p1, p2, P3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
            pddgv.ClearSelection();
        }
    }
}
