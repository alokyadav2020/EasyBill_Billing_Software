using BillingApp;
using BillingApp.main_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class SalePurchaseLB : Form
    {
        public SalePurchaseLB()
        {
            InitializeComponent();
        }
        Viewalldata vd = new Viewalldata();
        private  void button1_Click(object sender, EventArgs e)
        {
           //     await Task.Run(() => vd.getinvoicecount(dateTime1.Value, dateTime2.Value, lbl1, lbl2));
                vd.getinvoicecount(dateTime1.Value, dateTime2.Value, lbl1, lbl2);
            vd.getexpensscount(dateTime1.Value, dateTime2.Value, lbl5);
            // await Task.Run(() => vd.getpurchasecount(dateTime1.Value, dateTime2.Value, lbl3, lbl4));
            vd.getpurchasecount(dateTime1.Value, dateTime2.Value, lbl3, lbl4);
                //  await Task.Run(() => vd.sumqytsale(dateTime1.Value, dateTime2.Value, dgv1, pd, SQ));
                vd.sumqytsale(dateTime1.Value, dateTime2.Value, dgv1, pd, SQ);
                //  await Task.Run(() => vd.countqytsale(dateTime1.Value, dateTime2.Value, dgv2, pdes, cq));
                vd.countqytsale(dateTime1.Value, dateTime2.Value, dgv2, pdes, cq);
                //  await Task.Run(() => vd.sumqytpurchase(dateTime1.Value, dateTime2.Value, dgv3, pd3, sumq));
                vd.sumqytpurchase(dateTime1.Value, dateTime2.Value, dgv3, pd3, sumq);
                dgv1.ClearSelection();
                dgv2.ClearSelection();
                dgv3.ClearSelection();
                panelcolor1();           
                dateTime3.Value = DateTime.Today;
        }

        private  void button2_Click(object sender, EventArgs e)
        {
            vd.getinvoicecountBYDATE(dateTime3.Value, lbl1, lbl2);
            vd.getexpenssBYDATE(dateTime3.Value, lbl5);
            vd.getpurchasecountBYDATE(dateTime3.Value, lbl3, lbl4);
            vd.sumtqytsalebydate(dateTime3.Value, dgv1, pd, SQ);
            vd.counttqytsalebydate(dateTime3.Value, dgv2, pdes, cq);
            vd.sumtqytpurchasebydate(dateTime3.Value, dgv3, pd3, sumq);
            dgv1.ClearSelection();
            dgv2.ClearSelection();
            dgv3.ClearSelection();
            panelcolor2();
            dateTime1.Value = DateTime.Today;
            dateTime2.Value = DateTime.Today;            
        }
        void panelcolor1()
        {
            panel4.BackColor = Color.GreenYellow;
            panel5.BackColor = Color.YellowGreen;
            panel7.BackColor = Color.WhiteSmoke;
            panel6.BackColor = Color.LightSteelBlue;
        }
        void panelcolor2()
        {
            panel4.BackColor = Color.LightSteelBlue;
            panel5.BackColor = Color.WhiteSmoke;
            panel7.BackColor = Color.YellowGreen;
            panel6.BackColor = Color.GreenYellow;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          
        }
        
        private  void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalePurchaseLB_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
               
                if (e.KeyCode == Keys.Up)
                {
                    e.SuppressKeyPress = true;
                    SendKeys.Send("+{tab}");
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                else if (e.Control == true && e.KeyCode == Keys.Down)
                {
                    e.SuppressKeyPress = true;
                    SendKeys.Send("{tab}");
                }
            }
            catch
            {
            }
        }

        private void SalePurchaseLB_Load(object sender, EventArgs e)
        {
            dateTime1.Value = DateTime.Today;
            dateTime2.Value = DateTime.Today;
            dateTime3.Value = DateTime.Today;
        }
    }
}
