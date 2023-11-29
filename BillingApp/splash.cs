using BillingApp;
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
using System.IO;
using System.Data.SqlClient;
using BillingApp.connection_class;
using System.Configuration;

namespace BillingSystem
{
    public partial class splashpage : Form
    {
        public splashpage()
        {
            InitializeComponent();
        }
        retrievedata rt = new retrievedata();
        double dd;
        int aa;
        private void splashpage_Shown(object sender, EventArgs e)
        {
          
        }

        private void stimer_Tick(object sender, EventArgs e)
        {
            
            panel2.Width += 5;
            if (panel2.Width >= 700)
            {
                //ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString==""
                //!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ "\\db_connect")
                stimer.Stop();
                if(!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\db_connect"))
                {
                    csfile cs = new csfile();
                    cs.Show();
                    this.Hide();
                }
                else
                {
                    if (dd>0)
                    {
                        Loggin log = new Loggin();
                        log.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (aa > 0)
                        {
                            
                            this.Hide();
                            shopvalidation spd = new shopvalidation();
                            spd.Show();
                            
                        }
                        else
                        {
                            this.Hide();
                            Trialsubscription tr = new Trialsubscription();
                            tr.Show();
                        }
                        
                    }
                    
                }
               
            }
            
        }

        private void splashpage_Load(object sender, EventArgs e)
        {
            verslbl.Text= "Version " + Application.ProductVersion;
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\db_connect"))
            {
               
            }
            else { getexpdate(); }      
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
                        DateTime  datevalue = (dr.GetDateTime(1));
                        DateTime d1 = DateTime.Now;                      
                        TimeSpan t = datevalue - d1;
                        double d = t.TotalDays;
                        dd = Convert.ToDouble(d.ToString());
                        aa = Convert.ToInt32(eid.ToString());
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
    }
}
