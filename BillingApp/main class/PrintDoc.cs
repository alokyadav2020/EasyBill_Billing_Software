using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BillingSystem.main_class
{
    class PrintDoc
    {
        public void print4page()
        {
            itemprinted = 0;
            itemprpage = 0;
            PrintDocument pd = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            pd.PrinterSettings = ps;
            IEnumerable<PaperSize> paperSizes = ps.PaperSizes.Cast<PaperSize>();
            PaperSize sizeA4 = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.A4); // setting paper size to A4 size
            pd.DefaultPageSettings.PaperSize = sizeA4;
            pd.PrintPage += new PrintPageEventHandler
            (this.pd_PrintPage);
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            (ppd as Form).WindowState = FormWindowState.Maximized;
            ppd.Document = pd;
            ppd.ShowDialog();
        }
       public Int64 inv;
        private int itemprpage = 0;
        private int itemprinted = 0;
        public void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            //PrintDocument pd = new PrintDocument();
            //PrinterSettings ps = new PrinterSettings();
            //  PrintDocument pd = new PrintDocument();
            // pd.PrinterSettings = ps;
            //printDocument1.PrinterSettings = ps;
            //IEnumerable<PaperSize> paperSizes = ps.PaperSizes.Cast<PaperSize>();
            //PaperSize sizeA4 = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.A4); // setting paper size to A4 size
            //printDocument1.DefaultPageSettings.PaperSize = sizeA4;
            // pd.DefaultPageSettings.PaperSize = pd.PrinterSettings.PaperSizes("A4",200,200);
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 1);
            // Create rectangle.
            Rectangle rect = new Rectangle(25, 35, 800, 1030);
            // Create coordinates of points that define line.
            //e.Graphics.DrawString("12345678\n912", new Font("Arial",9), new SolidBrush(Color.Black), 300,320);
            //e.Graphics.DrawString("14%", new Font("Arial", 9), new SolidBrush(Color.Black), 501, 351);
            // e.Graphics.DrawString("20,000", new Font("Arial", 9), new SolidBrush(Color.Black), 591, 351);
            e.Graphics.DrawString("TAX INVOICE", new Font("Arial", 25), new SolidBrush(Color.Black), 570, 70);
            e.Graphics.DrawString("Alok Ranjan Enterprises", new Font("Arial", 18), new SolidBrush(Color.Black), 30, 110);
            e.Graphics.DrawString("Tivenipuram, Jhunsi, 21019, Prayagraj", new Font("Arial", 10), new SolidBrush(Color.Black), 30, 140);
            e.Graphics.DrawString("Mob. 8005086600, 9953795346, Email ID : alokranjan.ucer@gmail.com", new Font("Arial", 10), new SolidBrush(Color.Black), 30, 160);
            e.Graphics.DrawString("GSTIN : 8005086600ABCDE", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, 180);
            e.Graphics.DrawString("BILL TO", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, 215);
            e.Graphics.DrawString("Name", new Font("Arial", 10), new SolidBrush(Color.Black), 30, 235);//fix
            e.Graphics.DrawString("Alok Ranjan", new Font("Arial", 10), new SolidBrush(Color.Black), 85, 235);//variabl name
            e.Graphics.DrawString("Mobile", new Font("Arial", 10), new SolidBrush(Color.Black), 30, 255);//fix
            e.Graphics.DrawString("8005086600", new Font("Arial", 10), new SolidBrush(Color.Black), 85, 255);//variabl mobile
            e.Graphics.DrawString("Address", new Font("Arial", 10), new SolidBrush(Color.Black), 30, 275);// fix
            e.Graphics.DrawString("Trivenipuram jhunsi", new Font("Arial", 10), new SolidBrush(Color.Black), 85, 275);// variabl
            e.Graphics.DrawString("GSTIN", new Font("Arial", 10), new SolidBrush(Color.Black), 30, 295);
            e.Graphics.DrawString("123456789alokij", new Font("Arial", 10), new SolidBrush(Color.Black), 85, 295);
            e.Graphics.DrawString("INVOICE NO : " + "001", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), 525, 235);
            e.Graphics.DrawString("DATE : " + DateTime.Now.ToLongDateString(), new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), 525, 255);
            e.Graphics.DrawString("TIME : " + DateTime.Now.ToLongTimeString(), new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), 525, 275);
            e.Graphics.DrawString("S.N.", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), 26, 325);
            e.Graphics.DrawString("Product Description", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), 61, 326);
            e.Graphics.DrawString("HSN/SAC", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), 321, 326);
            e.Graphics.DrawString("Qty.", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), 395, 326);
            e.Graphics.DrawString("Price", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), 440, 326);
            e.Graphics.DrawString("CGST", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), 500, 326);
            e.Graphics.DrawString("SGST", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), 540, 326);
            e.Graphics.DrawString("CGST V.", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), 581, 326);
            e.Graphics.DrawString("SGST V.", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), 651, 326);
            e.Graphics.DrawString("Total Amount", new Font("Arial", 9, FontStyle.Bold), new SolidBrush(Color.Black), 725, 326);
            Point p111 = new Point(25, 205);//First Line
            Point p222 = new Point(825, 205);//First Line
            Point p1 = new Point(25, 320);//Second Line
            Point p2 = new Point(825, 320);//Second Line
            Point p3 = new Point(425, 205);// vERTICAL  LINE
            Point p4 = new Point(425, 320);
            Point p5 = new Point(25, 350);//start item
            Point p6 = new Point(825, 350);//start item
            Point p7 = new Point(25, 820);
            Point p8 = new Point(825, 820);
            Point p9 = new Point(25, 960);
            Point p10 = new Point(825, 960);
            Point p11 = new Point(60, 320);//s.n.column
            Point p12 = new Point(60, 820);//s.n.column
            Point p13 = new Point(320, 320);//Product column
            Point p14 = new Point(320, 820);//Product column
            Point p15 = new Point(390, 320);//HSN
            Point p16 = new Point(390, 820);//HSN
            Point p17 = new Point(430, 320);//QUANTITY
            Point p18 = new Point(430, 820);//QUANTITY
            Point p19 = new Point(500, 320);//PRICE
            Point p20 = new Point(500, 820);//PRICE
            Point p21 = new Point(540, 320);//cgst
            Point p22 = new Point(540, 820);//cgst
            Point p23 = new Point(580, 320);//sgst
            Point p24 = new Point(580, 820);//sgst
            Point p25 = new Point(650, 320);//sgst v
            Point p26 = new Point(650, 820);//sgst  v
            Point p27 = new Point(720, 320);//sgst v
            Point p28 = new Point(720, 820);//sgst v

            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, rect);
            e.Graphics.DrawLine(blackPen, p111, p222);
            e.Graphics.DrawLine(blackPen, p1, p2);
            e.Graphics.DrawLine(blackPen, p3, p4);
            e.Graphics.DrawLine(blackPen, p5, p6);
            e.Graphics.DrawLine(blackPen, p7, p8);
            e.Graphics.DrawLine(blackPen, p9, p10);
            e.Graphics.DrawLine(blackPen, p11, p12);
            e.Graphics.DrawLine(blackPen, p13, p14);
            e.Graphics.DrawLine(blackPen, p15, p16);
            e.Graphics.DrawLine(blackPen, p17, p18);
            e.Graphics.DrawLine(blackPen, p19, p20);
            e.Graphics.DrawLine(blackPen, p21, p22);
            e.Graphics.DrawLine(blackPen, p23, p24);
            e.Graphics.DrawLine(blackPen, p25, p26);
            e.Graphics.DrawLine(blackPen, p27, p28);


            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Far;
            int gap1 = 360;
            

            //rowcount = dt.Rows.Count;
            for (int i = itemprpage; i < getdata(); i++)
            {
                itemprpage++;
                if (itemprpage <= getdata())
                {

                    itemprinted++;
                    if (itemprinted <= 20)
                    {

                        try
                        {

                            string query = "select ProductDetails,Quantity, Len(ProductDetails) as ln  from SaleDetail where Invoice=@no";
                            DataTable dt = new DataTable();
                            //DataSet ds = new DataSet();
                            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BillingSystem;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@no", inv);
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            sda.Fill(dt);
                            int lrnth = Convert.ToInt32(dt.Rows[i]["ProductDetails"].ToString().Length);
                            if (lrnth < 30)
                            {
                                e.Graphics.DrawString(Convert.ToString(itemprpage), new Font("Arial", 8), new SolidBrush(Color.Black), 35, gap1);
                                e.Graphics.DrawString(dt.Rows[i]["ProductDetails"].ToString(), new Font("Arial", 8), new SolidBrush(Color.Black), 61, gap1);
                                e.Graphics.DrawString(dt.Rows[i]["Quantity"].ToString().ToString(), new Font("Arial", 8), new SolidBrush(Color.Black), 400, gap1, stringFormat);

                                gap1 += 25;
                            }
                            else
                            {
                                e.Graphics.DrawString(Convert.ToString(itemprpage), new Font("Arial", 8), new SolidBrush(Color.Black), 35, gap1);
                                e.Graphics.DrawString(dt.Rows[i]["ProductDetails"].ToString(), new Font("Arial", 8), new SolidBrush(Color.Black), 61, gap1);
                                // e.Graphics.DrawString(dt.Rows[i]["ProductDetails"].ToString().Substring(0, 30), new Font("Arial", 8), new SolidBrush(Color.Black), 61, gap1);
                                //  e.Graphics.DrawString(dt.Rows[i]["ProductDetails"].ToString().Substring(31, lrnth), new Font("Arial", 8), new SolidBrush(Color.Black), 61, gap1 + 12);
                                e.Graphics.DrawString(dt.Rows[i]["Quantity"].ToString().ToString(), new Font("Arial", 8), new SolidBrush(Color.Black), 400, gap1);

                                gap1 += 30;
                            }


                        }
                        catch (Exception)
                        {

                            throw;
                        }


                    }
                    else
                    {
                        itemprinted = 0;
                        e.HasMorePages = true;
                        itemprpage = itemprpage - 1;
                        return;

                    }
                }


                else
                {
                    e.HasMorePages = false;

                }

            }

        }
        int rowcount = 0;
        public int getdata()
        {
            string query = "select Invoice from SaleDetail where Invoice=@no";
            DataTable dt = new DataTable();
            //DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BillingSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@no",inv);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            rowcount = dt.Rows.Count;
            return rowcount;
        }
    }
}
