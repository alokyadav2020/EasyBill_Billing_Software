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

namespace BillingApp
{
    public partial class GST : Form
    {
        Insertion insert = new Insertion();
        Viewalldata vad = new Viewalldata();
        Deleteall delete = new Deleteall();
        EditAll edit = new EditAll();
        int a;
        Waiting w = new Waiting();
        public GST()
        {
            InitializeComponent();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gsttxt.Text.Trim() == "")
            {
                MessageBox.Show("Please fill GST ", "GST confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                insert.insertgst(gsttxt.Text.Trim(), cgsttxt.Text.Trim(), sgsttxt.Text.Trim());
                vad.gstview(gstdgv, id, gstv, cgstv, sgstv);
                gsttxt.Text = "";
                cgsttxt.Text = "";
                sgsttxt.Text = "";
            }
        }
        private void gsttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {               
                e.Handled = true;
            }           
        }
        private void sgsttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void cgsttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void gsttxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gsttxt.Text) == true)
            {
                gsttxt.Text = "";
                cgsttxt.Text = "";
                sgsttxt.Text = "";
            }
            else if (gsttxt.Text == ".")
            {
                MessageBox.Show("Start with '0.', like 0.5 or 0.7 somethinng", "Should not start with '.'", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Double a = Convert.ToDouble(gsttxt.Text);
                Double b = (Double)a / (Double)2;
                cgsttxt.Text = b.ToString();
                sgsttxt.Text = b.ToString();
            }
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Waiting w = new Waiting();
            w.Show();
            vad.gstview(gstdgv, id, gstv, cgstv, sgstv);
            w.Hide();
        }
        private void gstdgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gstdgv.Rows.Count > 0)
            {
                a = Convert.ToInt32(gstdgv.SelectedRows[0].Cells[0].Value.ToString());
                gsttxt.Text = gstdgv.SelectedRows[0].Cells[1].Value.ToString();
                cgsttxt.Text = gstdgv.SelectedRows[0].Cells[2].Value.ToString();
                sgsttxt.Text = gstdgv.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (a > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete ....?", "Delete Confermation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    delete.deletegst(a);
                    vad.gstview(gstdgv, id, gstv, cgstv, sgstv);
                    gsttxt.Text = "";
                    cgsttxt.Text = "";
                    sgsttxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please select ROW to delete", "ROW not selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (a > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to Update....?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    edit.Editgst(a, gsttxt.Text, cgsttxt.Text, sgsttxt.Text);
                    vad.gstview(gstdgv, id, gstv, cgstv, sgstv);
                    gsttxt.Text = "";
                    cgsttxt.Text = "";
                    sgsttxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please select ROW to Upadate", "ROW not selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
