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
    public partial class UserAccess : Form
    {
        public UserAccess()
        {
            InitializeComponent();
        }
        retrievedata rt = new retrievedata();
        ComboSelectChange csc = new ComboSelectChange();
        EditAll ea = new EditAll();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserAccess_Activated(object sender, EventArgs e)
        {
            rt.loaduseraccess(loadusercb);
        }

        private void loadusercb_SelectedIndexChanged(object sender, EventArgs e)
        {
            csc.usercomboxselectedindex(loadusercb, Mobilelbl, emaillbl,salecb,saleHcb,purchasecb,purchaseHcb,newproductcb,productDcb,newcustcb,customerDcb,newsulrcb,sulrDcb,backcb,rstorecb,saleLBcb,crexpenscb,addexpnscb,stockcb,settingcb);
            colortex();
        }

        private void UserAccess_Load(object sender, EventArgs e)
        {

        }

        private void salecb_CheckedChanged(object sender, EventArgs e)
        {
            if (salecb.Checked) { salecb.ForeColor = Color.Green; } else { salecb.ForeColor = Color.Red; }
        }

        private void settingcb_CheckedChanged(object sender, EventArgs e)
        {
            if (settingcb.Checked) { settingcb.ForeColor = Color.ForestGreen; } else { settingcb.ForeColor = Color.Red; }
        }
        void colortex()
        {
            if (salecb.Checked) { salecb.ForeColor = Color.Green; } else { salecb.ForeColor = Color.Red; }
            if (saleHcb.Checked) { saleHcb.ForeColor = Color.Green; } else { saleHcb.ForeColor = Color.Red; }
            if (purchasecb.Checked) { purchasecb.ForeColor = Color.Green; } else { purchasecb.ForeColor = Color.Red; }
            if (purchaseHcb.Checked) { purchaseHcb.ForeColor = Color.Green; } else { purchaseHcb.ForeColor = Color.Red; }
            if (newproductcb.Checked) { newproductcb.ForeColor = Color.Green; } else { newproductcb.ForeColor = Color.Red; }
            if (productDcb.Checked) { productDcb.ForeColor = Color.Green; } else { productDcb.ForeColor = Color.Red; }
            if (newcustcb.Checked) { newcustcb.ForeColor = Color.Green; } else { newcustcb.ForeColor = Color.Red; }
            if (customerDcb.Checked) { customerDcb.ForeColor = Color.Green; } else { customerDcb.ForeColor = Color.Red; }
            if (newsulrcb.Checked) { newsulrcb.ForeColor = Color.Green; } else { newsulrcb.ForeColor = Color.Red; }
            if (sulrDcb.Checked) { sulrDcb.ForeColor = Color.Green; } else { sulrDcb.ForeColor = Color.Red; }
            if (backcb.Checked) { backcb.ForeColor = Color.Green; } else { backcb.ForeColor = Color.Red; }
            if (rstorecb.Checked) { rstorecb.ForeColor = Color.Green; } else { rstorecb.ForeColor = Color.Red; }
            if (saleLBcb.Checked) { saleLBcb.ForeColor = Color.Green; } else { saleLBcb.ForeColor = Color.Red; }
            if (crexpenscb.Checked) { crexpenscb.ForeColor = Color.Green; } else { crexpenscb.ForeColor = Color.Red; }
            if (addexpnscb.Checked) { addexpnscb.ForeColor = Color.Green; } else { addexpnscb.ForeColor = Color.Red; }
            if (stockcb.Checked) { stockcb.ForeColor = Color.Green; } else { stockcb.ForeColor = Color.Red; }
            if (settingcb.Checked) { settingcb.ForeColor = Color.Green; } else { settingcb.ForeColor = Color.Red; }
           
        }

        private void saleHcb_CheckedChanged(object sender, EventArgs e)
        {
            if (saleHcb.Checked) { saleHcb.ForeColor = Color.Green; } else { saleHcb.ForeColor = Color.Red; }
        }

        private void purchasecb_CheckedChanged(object sender, EventArgs e)
        {
            if (purchasecb.Checked) { purchasecb.ForeColor = Color.Green; } else { purchasecb.ForeColor = Color.Red; }
        }

        private void purchaseHcb_CheckedChanged(object sender, EventArgs e)
        {
            if (purchaseHcb.Checked) { purchaseHcb.ForeColor = Color.Green; } else { purchaseHcb.ForeColor = Color.Red; }
        }

        private void newproductcb_CheckedChanged(object sender, EventArgs e)
        {
            if (newproductcb.Checked) { newproductcb.ForeColor = Color.Green; } else { newproductcb.ForeColor = Color.Red; }
        }

        private void productDcb_CheckedChanged(object sender, EventArgs e)
        {
            if (productDcb.Checked) { productDcb.ForeColor = Color.Green; } else { productDcb.ForeColor = Color.Red; }
        }

        private void newcustcb_CheckedChanged(object sender, EventArgs e)
        {
            if (newcustcb.Checked) { newcustcb.ForeColor = Color.Green; } else { newcustcb.ForeColor = Color.Red; }
        }

        private void customerDcb_CheckedChanged(object sender, EventArgs e)
        {
            if (customerDcb.Checked) { customerDcb.ForeColor = Color.Green; } else { customerDcb.ForeColor = Color.Red; }
        }

        private void newsulrcb_CheckedChanged(object sender, EventArgs e)
        {
            if (newsulrcb.Checked) { newsulrcb.ForeColor = Color.Green; } else { newsulrcb.ForeColor = Color.Red; }
        }

        private void sulrDcb_CheckedChanged(object sender, EventArgs e)
        {
            if (sulrDcb.Checked) { sulrDcb.ForeColor = Color.Green; } else { sulrDcb.ForeColor = Color.Red; }
        }

        private void backcb_CheckedChanged(object sender, EventArgs e)
        {
            if (backcb.Checked) { backcb.ForeColor = Color.Green; } else { backcb.ForeColor = Color.Red; }
        }

        private void rstorecb_CheckedChanged(object sender, EventArgs e)
        {
            if (rstorecb.Checked) { rstorecb.ForeColor = Color.Green; } else { rstorecb.ForeColor = Color.Red; }
        }

        private void saleLBcb_CheckedChanged(object sender, EventArgs e)
        {
            if (saleLBcb.Checked) { saleLBcb.ForeColor = Color.Green; } else { saleLBcb.ForeColor = Color.Red; }
        }

        private void crexpenscb_CheckedChanged(object sender, EventArgs e)
        {
            if (crexpenscb.Checked) { crexpenscb.ForeColor = Color.Green; } else { crexpenscb.ForeColor = Color.Red; }
        }

        private void addexpnscb_CheckedChanged(object sender, EventArgs e)
        {
            if (addexpnscb.Checked) { addexpnscb.ForeColor = Color.Green; } else { addexpnscb.ForeColor = Color.Red; }
        }

        private void stockcb_CheckedChanged(object sender, EventArgs e)
        {
            if (stockcb.Checked) { stockcb.ForeColor = Color.Green; } else { stockcb.ForeColor = Color.Red; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ea.updateuseraccess(loadusercb.Text,salecb,saleHcb,purchasecb,purchaseHcb,newproductcb,productDcb,newcustcb,customerDcb,newsulrcb,sulrDcb,backcb,rstorecb,saleLBcb,crexpenscb,addexpnscb,stockcb,settingcb);
        }

        private void loadusercb_KeyDown(object sender, KeyEventArgs e)
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

        private void UserAccess_KeyDown(object sender, KeyEventArgs e)
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
    }
}
