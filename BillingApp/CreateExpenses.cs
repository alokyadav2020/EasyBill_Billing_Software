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
    public partial class CreateExpenses : Form
    {
        public CreateExpenses()
        {
            InitializeComponent();
        }
        Insertion i = new Insertion();
        Viewalldata vd = new Viewalldata();
        EditAll ed = new EditAll();
        Deleteall da = new Deleteall();
        private void closeexpbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addexpbtn_Click(object sender, EventArgs e)
        {
            if(typetxt.Text!="" && priceexptxt.Text != "")
            {
                i.insertexpencetypr(typetxt.Text.Trim(), priceexptxt.Text.Trim(), desexptxt.Text.Trim());
                reset();
                vd.expensestypeview(dgvexp, Id,extype, exprice, esdes);
                dgvexp.ClearSelection();
            }
            else
            {
                MessageBox.Show("Fields with * are requared", "Fields Mandatory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        void reset()
        {
            typetxt.Text = "";
            priceexptxt.Text = "";
            desexptxt.Text = "";
            typetxt.Focus();
        }

        private void CreateExpenses_Load(object sender, EventArgs e)
        {
            vd.expensestypeview(dgvexp,Id, extype, exprice, esdes);
            dgvexp.ClearSelection();
        }

        private void viewexpbtn_Click(object sender, EventArgs e)
        {
            vd.expensestypeview(dgvexp, Id,extype, exprice, esdes);
            dgvexp.ClearSelection();
            reset();
        }
        int exid=0;
        private void dgvexp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            exid = Convert.ToInt32(dgvexp.SelectedRows[0].Cells[0].Value);
            typetxt.Text = dgvexp.SelectedRows[0].Cells[1].Value.ToString();
            priceexptxt.Text = dgvexp.SelectedRows[0].Cells[2].Value.ToString();
            desexptxt.Text = dgvexp.SelectedRows[0].Cells[3].Value.ToString();
            dgvexp.Refresh();
        }

        private void updateexpbtn_Click(object sender, EventArgs e)
        {
            if (exid != 0)
            {
                ed.updateexpensetype(exid, typetxt.Text.Trim(), priceexptxt.Text.Trim(), desexptxt.Text.Trim());
                reset();
                vd.expensestypeview(dgvexp, Id, extype, exprice, esdes);
                dgvexp.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please select expenses type to update", "Select expenses type",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            exid = 0;
        }

        private void deleteexpbtn_Click(object sender, EventArgs e)
        {
           
           
            if (exid != 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to detele Expenses Type ", "Confermation to delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    da.deleteexpensetype(exid);
                    reset();
                    vd.expensestypeview(dgvexp, Id, extype, exprice, esdes);
                    dgvexp.ClearSelection();
                }
                else if (dr == DialogResult.No)
                {
                    reset();
                    vd.expensestypeview(dgvexp, Id, extype, exprice, esdes);
                    dgvexp.ClearSelection();
                }
               
            }
            else
            {
                MessageBox.Show("Please select expenses type to DELETE", "Select expenses type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            exid = 0;
        }

        private void typetxt_KeyDown(object sender, KeyEventArgs e)
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

        private void priceexptxt_KeyDown(object sender, KeyEventArgs e)
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

        private void desexptxt_KeyDown(object sender, KeyEventArgs e)
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

        private void CreateExpenses_KeyDown(object sender, KeyEventArgs e)
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
