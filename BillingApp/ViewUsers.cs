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
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();
        }
        Viewalldata vd = new Viewalldata();
        retrievedata r = new retrievedata();
        private void ViewUsers_Load(object sender, EventArgs e)
        {
            vd.loadusers(userdgv);
            userdgv.ClearSelection();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vd.loadusers(userdgv);
            userdgv.ClearSelection();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo ui = new UserInfo();
            ui.ShowDialog();
        }

        private void usersearchtxt_TextChanged(object sender, EventArgs e)
        {
            r.searchusers(userdgv, usersearchtxt.Text.Trim());
        }

        private void userdgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UserInfo ui = new UserInfo();
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                if (userdgv.Rows.Count > 0)
                {
                    ui.isupdate = true;
                    String username = userdgv.SelectedRows[0].Cells[0].Value.ToString();
                    ui.Username = username;
                    ui.deleteToolStripMenuItem.Enabled = true;
                    ui.ShowDialog();
                    vd.loadusers(userdgv);
                    userdgv.ClearSelection();
                }
            }
           
        }
    }
}
