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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }
        retrievedata rt = new retrievedata();
        ComboSelectChange csc = new ComboSelectChange();
        Insertion i = new Insertion();
        Viewalldata vd = new Viewalldata();
        EditAll ed = new EditAll();
        Deleteall da= new Deleteall();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Expenses_Activated(object sender, EventArgs e)
        {
            rt.loadexpensetype(expcombo);
        }

        private void expcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            csc.expensecomboxselectedindex(expcombo, expricetxt);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if(tptxt.Text!="" && expcombo.SelectedItem != null)
            {
                i.insertexpense(expcombo.Text, Convert.ToDecimal(expricetxt.Text), qauntitytxt.Text, Convert.ToDecimal(tptxt.Text), expensedestxt.Text, loggedInUser.UserName, dateTimePicker1.Value);
                vd.expenseview(dgvexpense, id, et, price, Quantity, tp, des, cb, d);
                dgvexpense.ClearSelection();
                reset();
            }
            else
            {
                MessageBox.Show("Please select expense type and fill its total price","Items are missing",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            
        }
        void reset()
        {
            expcombo.SelectedText ="";
            expricetxt.Text = "";
            expensedestxt.Text = "";
            qauntitytxt.Text = "";
            tptxt.Text = "";
            expcombo.Focus();
        }

        private void tptxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void expricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            vd.expenseview(dgvexpense, id, et, price, Quantity, tp, des, cb, d);
            dgvexpense.ClearSelection();
            reset();
            eid = 0;
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            vd.expenseview(dgvexpense,id,et,price,Quantity,tp,des,cb,d);
            dgvexpense.ClearSelection();
            dateTimePicker1.Value = DateTime.Today;
            expensedate.Value = DateTime.Today;
        }
        int eid = 0;
        private void dgvexpense_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvexpense.Rows.Count > 0)
            {
                eid = Convert.ToInt32(dgvexpense.SelectedRows[0].Cells[0].Value);
                expcombo.Text = dgvexpense.SelectedRows[0].Cells[1].Value.ToString();
                expricetxt.Text= dgvexpense.SelectedRows[0].Cells[2].Value.ToString();
                qauntitytxt.Text= dgvexpense.SelectedRows[0].Cells[3].Value.ToString();
                tptxt.Text= dgvexpense.SelectedRows[0].Cells[4].Value.ToString(); 
                expensedestxt.Text= dgvexpense.SelectedRows[0].Cells[5].Value.ToString();
               dateTimePicker1.Value= Convert.ToDateTime(dgvexpense.SelectedRows[0].Cells[7].Value.ToString());
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (eid != 0)
            {
                ed.updateexpense(eid, expcombo.Text, Convert.ToDecimal(expricetxt.Text), qauntitytxt.Text, Convert.ToDecimal(tptxt.Text), expensedestxt.Text,dateTimePicker1.Value);
                reset();
                vd.expenseview(dgvexpense, id, et, price, Quantity, tp, des, cb, d);
                dgvexpense.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please select expenses to update","Items missing",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            eid = 0;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (eid != 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to delete this perticular item","Delete Confermation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(dr==DialogResult.Yes)
                {
                    da.deleteexpens(eid);
                    reset();
                    vd.expenseview(dgvexpense, id, et, price, Quantity, tp, des, cb, d);
                    dgvexpense.ClearSelection();
                }
                else if (dr == DialogResult.No)
                {
                    reset();
                    vd.expenseview(dgvexpense, id, et, price, Quantity, tp, des, cb, d);
                    dgvexpense.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Please select expenses to datele", "Items missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            eid = 0;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            vd.expenseviewbydate(expensedate.Value, dgvexpense, id, et, price, Quantity, tp, des, cb, d);            
            dgvexpense.ClearSelection();
        }

        private void expcombo_KeyDown(object sender, KeyEventArgs e)
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

        private void expricetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void qauntitytxt_KeyDown(object sender, KeyEventArgs e)
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

        private void tptxt_KeyDown(object sender, KeyEventArgs e)
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

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
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

        private void expensedestxt_KeyDown(object sender, KeyEventArgs e)
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

        private void Expenses_KeyDown(object sender, KeyEventArgs e)
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
