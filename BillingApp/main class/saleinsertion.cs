using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Transactions;
using BillingApp.connection_class;
using BillingSystem;
using Microsoft.Reporting.WinForms;
using BillingSystem.main_class;
using System.IO;

namespace BillingApp.main_class
{
    class saleinsertion
    {
        SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
        public void Invoice(Label inlbl)
        {            
            string query = "select Invoice from InvoiceNO";
            SqlDataAdapter sda = new SqlDataAdapter(query, cs);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count < 1)
            {
                inlbl.Text = "1";
            }
            else
            {
                SqlCommand cmd = new SqlCommand("getinvoice", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                Int64 a = Convert.ToInt64(cmd.ExecuteScalar());
                a = a + 1;
                inlbl.Text = a.ToString();
                cs.Close();
            }
        }
      
      Int64 invno;
        int scount = 0;     
        retrievedata r = new retrievedata();
        EditAll e = new EditAll();
       // SaleReportA4 sr = new SaleReportA4();
        public object SaleReportA4Viewer { get; private set; }
        PrintSaleReciept psr = new PrintSaleReciept();
        //SalereceiptA4 sr = new SalereceiptA4(); // Sale Page designe 
        public void sale(Int64 si, Decimal snd, Decimal snga, int snq, Decimal sntp, Decimal cpay, Decimal retrn, Decimal snpa, int csid, string balnc, string un,Decimal cgsttaxa,Decimal sgsttaxa,Decimal tsave, DataGridView gv, string sspid, string pdgv, string dgv, string qgv, string urgv, string pgv, string dagv, string spgv, string gstsgv, string gstagv, string nagv, string tspgv, DateTime dat)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insertsale", cs);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@in", si);
                    cmd.Parameters.AddWithValue("@nd", snd);
                    cmd.Parameters.AddWithValue("@nga", snga);
                    cmd.Parameters.AddWithValue("@nq", snq);
                    cmd.Parameters.AddWithValue("@ntp", sntp);
                    cmd.Parameters.AddWithValue("@cp", cpay);
                    cmd.Parameters.AddWithValue("@ret", retrn);
                    cmd.Parameters.AddWithValue("@npa", snpa);
                    cmd.Parameters.AddWithValue("@c_id", csid);
                    cmd.Parameters.AddWithValue("@balance", balnc);
                    cmd.Parameters.AddWithValue("@username", un);
                    cmd.Parameters.AddWithValue("@cgsta", cgsttaxa);
                    cmd.Parameters.AddWithValue("@sgsta", sgsttaxa);
                    cmd.Parameters.AddWithValue("@totalsav", tsave);
                    cmd.Parameters.AddWithValue("@dt", dat);
                    cs.Open();
                    scount = cmd.ExecuteNonQuery();
                    if (scount > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("getinvoice", cs);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        invno = Convert.ToInt64(cmd2.ExecuteScalar());                        
                        for (int i = 0; i < gv.Rows.Count; i++)
                        {
                            SqlCommand cmd3 = new SqlCommand("insetsaletbl", cs);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@sinv", invno);
                            cmd3.Parameters.AddWithValue("@spid", Convert.ToInt32(gv.Rows[i].Cells[sspid].Value));
                            cmd3.Parameters.AddWithValue("@spd", gv.Rows[i].Cells[pdgv].Value.ToString());
                            cmd3.Parameters.AddWithValue("@sd", gv.Rows[i].Cells[dgv].Value.ToString());
                            cmd3.Parameters.AddWithValue("@squn", Convert.ToInt32(gv.Rows[i].Cells[qgv].Value));
                            cmd3.Parameters.AddWithValue("@sur", Convert.ToDecimal(gv.Rows[i].Cells[urgv].Value));
                            cmd3.Parameters.AddWithValue("@sp", Convert.ToDecimal(gv.Rows[i].Cells[pgv].Value));
                            cmd3.Parameters.AddWithValue("@sda", Convert.ToDecimal(gv.Rows[i].Cells[dagv].Value));
                            cmd3.Parameters.AddWithValue("@ssp", Convert.ToDecimal(gv.Rows[i].Cells[spgv].Value));
                            cmd3.Parameters.AddWithValue("@sgsstsale", Convert.ToDecimal(gv.Rows[i].Cells[gstsgv].Value));
                            cmd3.Parameters.AddWithValue("@sgstamn", Convert.ToDecimal(gv.Rows[i].Cells[gstagv].Value));
                            cmd3.Parameters.AddWithValue("@sna", Convert.ToDecimal(gv.Rows[i].Cells[nagv].Value));                            
                            cmd3.Parameters.AddWithValue("@tsp", Convert.ToDecimal(gv.Rows[i].Cells[tspgv].Value));
                            cmd3.Parameters.AddWithValue("@dt1", dat);
                            cmd3.ExecuteNonQuery();
                            int stocfpro = Convert.ToInt32(r.getprostockquant(Convert.ToInt32(gv.Rows[i].Cells[sspid].Value.ToString())));
                            int cst = Convert.ToInt32(gv.Rows[i].Cells[qgv].Value.ToString());
                            int fq = stocfpro - cst;
                            e.updateSCT(Convert.ToInt32(gv.Rows[i].Cells[sspid].Value), fq);                            
                        }
                    }
                    cs.Close();                   
                    
                }
                catch (Exception ex)
                {
                    cs.Close();
                    MessageBox.Show(ex.Message);
                }
                ts.Complete();                
            }
        }
        
    }
}
