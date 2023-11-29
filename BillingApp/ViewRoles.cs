using BillingApp.connection_class;
using BillingApp.main_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApp
{
    public partial class Rolesview : Form
    {
        retrievedata r = new retrievedata();
        UsersRoles ur = new UsersRoles();
        Viewalldata vd = new Viewalldata();
        public Rolesview()
        {
            InitializeComponent();
        }

        private void Rolesview_Load(object sender, EventArgs e)
        {
            vd.loadroles(roledgv);
            roledgv.ClearSelection();
            
        }

        private void searchroletxt_TextChanged(object sender, EventArgs e)
        {
            r.searrole(roledgv, searchroletxt.Text.Trim());
        }

        private void newRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ur.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refeshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //r.loadroles(roledgv);
            vd.loadroles(roledgv);
            roledgv.ClearSelection();
        }

        private void roledgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex !=-1 )
            {
                if (roledgv.Rows.Count > 0)
                {
                    int roleid = Convert.ToInt32(roledgv.SelectedRows[0].Cells[0].Value);
                    ur.roleid = roleid;
                    ur.titletxt.Text = roledgv.SelectedRows[0].Cells[1].Value.ToString();
                    ur.roledectxt.Text = roledgv.SelectedRows[0].Cells[2].Value.ToString();
                    ur.Isupdate = true;
                    ur.deleteToolStripMenuItem.Enabled = true; ;
                    ur.ShowDialog();
                    // r.loadroles(roledgv);
                    vd.loadroles(roledgv);
                    roledgv.ClearSelection();
                }
            }
           
        }
    }
}
