using BillingApp.connection_class;
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

namespace BillingSystem
{
    public partial class PackageValidity : Form
    {
        public PackageValidity()
        {
            InitializeComponent();
        }
       
        private void PackageValidity_Load(object sender, EventArgs e)
        {          
            getexpdate();
            vrlbl.Text = Application.ProductVersion;
            
        }
        void getexpdate()
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("getvaliddate", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        int eid = dr.GetInt32(0);
                        DateTime expd = (dr.GetDateTime(1));
                        DateTime regd = (dr.GetDateTime(2));
                        double dy = dr.GetDouble(3);
                        string ty = dr.GetString(4);
                        DateTime d1 = DateTime.Now;
                        TimeSpan t = expd - d1;
                        double d = Convert.ToInt32(t.TotalDays);                                                                   
                        rdlbl.Text = "Renewable Date : " + Convert.ToDateTime(regd.ToString());
                        edlbl.Text = "Expiry Date    : " + Convert.ToDateTime(expd.ToString());
                        cp1.Text = dy.ToString();
                        cp2.Text = d.ToString();
                        ptlbl.Text = "Package Type : " + ty.ToString();
                        cp1.Minimum = 0;
                        cp1.Maximum = Convert.ToInt32(dy);
                        cp1.Value= Convert.ToInt32(dy);
                        cp2.Minimum= 0;
                        cp2.Maximum = Convert.ToInt32(dy);
                        cp2.Value = Convert.ToInt32(d);
                        if (Convert.ToInt32(d) < 10)
                        {
                            cp2.ProgressColor = Color.Red;
                            cp2.ForeColor = Color.IndianRed;
                            panel1.BackColor = Color.IndianRed;
                            alertlbl.Visible = true;
                            blink();
                        }
                        
                    }
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void PackageValidity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        public async void blink()
        {
            while (true)
            {
                await Task.Delay(500);
                alertlbl.BackColor = alertlbl.BackColor == Color.IndianRed ? Color.DarkSeaGreen : Color.IndianRed;
            }
        }
    }
}
