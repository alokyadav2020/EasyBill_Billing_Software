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

namespace BillingApp
{
    public partial class Stock : Form
    {
        Viewalldata v = new Viewalldata();
        retrievedata r = new retrievedata();
        int pp=0;
        public Stock()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stckclosebtn_Click(object sender, EventArgs e)
        {

        }

        private void stckclosebtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            v.gettotalitem();
            stocksearchtxt.Focus();
            sdgv.Rows.Clear();
           // v.stockview(sdgv, spc, spn, spq);           
            netstock();
            sdgv.ClearSelection();
            cpsctock.ForeColor = Color.ForestGreen;
            cpsctock.ProgressColor = Color.YellowGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v.stockview(sdgv, spc, spn, spq);
            netstock();
            stocksearchtxt.Text = "";
            stockselectcombo.SelectedItem = null;
            sdgv.ClearSelection();
            cpsctock.ForeColor = Color.ForestGreen;
            cpsctock.ProgressColor = Color.YellowGreen;
        }

        void netstock()
        {
            int ns = 0;
            for (int i = 0; i < sdgv.Rows.Count; i++)
            {
                int sum= Convert.ToInt32(sdgv.Rows[i].Cells[2].Value);                
                if (sum > Convert.ToInt32(lowsttxt.Value))
                {
                    ns = ns + sum;
                   // ns = sdgv.Rows.Count;
                }
                else
                {
                    sdgv.Rows[i].DefaultCellStyle.BackColor = Color.Crimson;
                    sdgv.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
            tnslbl.Text = ns.ToString();
            dgvcountbycp();           
        }

        private void stocksearchtxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(stocksearchtxt.Text.Trim()))
            {
               // sdgv.Rows.Clear();
            }
            else
            {
               
                r.searPQ(sdgv, stocksearchtxt.Text, spc, spn, spq);
                netstock();
                stockselectcombo.SelectedItem = null;
                sdgv.ClearSelection();
                cpsctock.ForeColor = Color.ForestGreen;
                cpsctock.ProgressColor = Color.YellowGreen;
            }          
        }

        private void Stock_Activated(object sender, EventArgs e)
        {
            r.loadCATcombo(stockselectcombo);
        }

        private void stockselectcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stockselectcombo.SelectedItem == null)
            {

            }
            else
            {
                r.selectbycategory(sdgv, stockselectcombo, spc, spn, spq);
                netstock();
                stocksearchtxt.Text = "";
                sdgv.ClearSelection();
                cpsctock.ForeColor = Color.ForestGreen;
                cpsctock.ProgressColor = Color.YellowGreen;

            }           
        }
        void dgvcountbycp()
        {
            cpsctock.Value = 0;
            cpsctock.Minimum = 0;
            cpsctock.Maximum = Currenttime.totalSTCKitem;
            cpsctock.Value = sdgv.Rows.Count;
            cpsctock.Text = sdgv.Rows.Count.ToString();
            cpsctock.SubscriptText = Currenttime.totalSTCKitem.ToString();
            if (Currenttime.totalSTCKitem != 0) { pp = Convert.ToInt32(sdgv.Rows.Count) * 100 / Convert.ToInt32(Currenttime.totalSTCKitem); }            
            cpsctock.SuperscriptText = pp.ToString()+"%";

        }

        private void Stock_KeyDown(object sender, KeyEventArgs e)
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

        private void lwstbtn_Click(object sender, EventArgs e)
        {
            v.lowstockview(sdgv, spc, spn, spq,Convert.ToInt32(lowsttxt.Value));
            netstock();
            sdgv.ClearSelection();
            stocksearchtxt.Text = "";
            stockselectcombo.SelectedItem = null;
            cpsctock.ForeColor = Color.Red;
            cpsctock.ProgressColor = Color.Red;
        }
    }
}
