using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
using BillingApp.connection_class;
using BillingApp.main_class;

namespace BillingSystem
{
    class purcgaseinsertiondata
    {
        SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
        EditAll e = new EditAll();
        public void purBillNo(Label pl)
        {
            string query = "select PurchaseBillNo from PurchaseBillNo";
            SqlDataAdapter sda = new SqlDataAdapter(query, cs);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count < 1)
            {
                pl.Text = "1";
            }
            else
            {
                SqlCommand cmd = new SqlCommand("getBillNo", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cs.Open();
                Int64 a = Convert.ToInt64(cmd.ExecuteScalar());
                a = a + 1;
                pl.Text = a.ToString();
                cs.Close();
            }
        }
        public void insertpurchasedetails(Int64 pbn, int ns, Decimal np, Decimal gsta, Decimal csgta, Decimal sgsta,Decimal paida,Decimal unp, string sinvoice, string un,int sid,DateTime dtime, DataGridView pgv, string pgvpc, string pgvpn, string pgvos, string pgvns, string pgvups, string pgvtp, string pgvgst, string pgvgsta, string pgvcgst, string pgvsgst)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("inserpurcgaseBill", cs);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ib", pbn);
                    cmd.Parameters.AddWithValue("@gs", ns);
                    cmd.Parameters.AddWithValue("@gnt", np);
                    cmd.Parameters.AddWithValue("@gngsta", gsta);
                    cmd.Parameters.AddWithValue("@gncgsta", csgta);
                    cmd.Parameters.AddWithValue("@gnsgsta", sgsta);
                    cmd.Parameters.AddWithValue("@si", sinvoice);
                    cmd.Parameters.AddWithValue("@users", un);
                    cmd.Parameters.AddWithValue("@sid", sid);
                    cmd.Parameters.AddWithValue("@pucgasedate", dtime);
                    cs.Open();
                    int b = cmd.ExecuteNonQuery();
                    if (b > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("getBillNo", cs);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        Int64 bill = Convert.ToInt64(cmd2.ExecuteScalar());
                        SqlCommand cmd4 = new SqlCommand("inssupacc", cs);
                        cmd4.CommandType = CommandType.StoredProcedure;
                        cmd4.Parameters.AddWithValue("@npa", np);
                        cmd4.Parameters.AddWithValue("@p", paida);
                        cmd4.Parameters.AddWithValue("@up", unp);
                        cmd4.Parameters.AddWithValue("@pb", bill);
                        cmd4.Parameters.AddWithValue("@si", sinvoice);
                        cmd4.Parameters.AddWithValue("@date", dtime);
                        cmd4.Parameters.AddWithValue("@sid", sid);
                        int c = cmd4.ExecuteNonQuery();
                        if (c > 0)
                        {
                            
                            for (int i = 0; i < pgv.Rows.Count; i++)
                            {
                                SqlCommand cmd3 = new SqlCommand("insertPurBillDetails", cs);
                                cmd3.CommandType = CommandType.StoredProcedure;
                                cmd3.Parameters.AddWithValue("@billid", bill);
                                cmd3.Parameters.AddWithValue("@pid", Convert.ToInt32(pgv.Rows[i].Cells[pgvpc].Value));
                                cmd3.Parameters.AddWithValue("@pn", pgv.Rows[i].Cells[pgvpn].Value.ToString());
                                cmd3.Parameters.AddWithValue("@os", Convert.ToInt32(pgv.Rows[i].Cells[pgvos].Value));
                                cmd3.Parameters.AddWithValue("@ns", Convert.ToInt32(pgv.Rows[i].Cells[pgvns].Value));
                                cmd3.Parameters.AddWithValue("@uds", Convert.ToInt32(pgv.Rows[i].Cells[pgvups].Value));
                                cmd3.Parameters.AddWithValue("@tp", Convert.ToDecimal(pgv.Rows[i].Cells[pgvtp].Value));
                                cmd3.Parameters.AddWithValue("@gstp", Convert.ToDecimal(pgv.Rows[i].Cells[pgvgst].Value));
                                cmd3.Parameters.AddWithValue("@gsta", Convert.ToDecimal(pgv.Rows[i].Cells[pgvgsta].Value));
                                cmd3.Parameters.AddWithValue("@cgsta", Convert.ToDecimal(pgv.Rows[i].Cells[pgvcgst].Value));
                                cmd3.Parameters.AddWithValue("@sgsta", Convert.ToDecimal(pgv.Rows[i].Cells[pgvsgst].Value));
                                cmd3.Parameters.AddWithValue("@date", dtime);
                                cmd3.ExecuteNonQuery();
                                int updatedStock = Convert.ToInt32(pgv.Rows[i].Cells[pgvups].Value);
                                e.updateSCT(Convert.ToInt32(pgv.Rows[i].Cells[pgvpc].Value), updatedStock);
                            }
                        }
                           
                    }                    
                    cs.Close();
                    MessageBox.Show("Purchased Item Saved Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
