using BillingApp.main_class;
using BillingSystem;
using BillingSystem.main_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.Diagnostics;
using System.Drawing.Printing;

namespace BillingApp
{
    public partial class Salehistory : Form
    {
        public Salehistory()
        {
            InitializeComponent();
        }
       // SalepageA5V spa5 = new SalepageA5V(Bvalue);
        //Decimal b, c, d;
        Viewalldata vd = new Viewalldata();
        retrievedata r = new retrievedata();
      

        private void closesalehistorybtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shsearchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch)) { e.Handled = false; } else if (ch == 8) { e.Handled = false; } else { e.Handled = true; }
        }

        private void salehistorydvg_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           // salehistorydvg.Rows[e.RowIndex].Selected = true;
        }

        private void salehistorydvg_SelectionChanged(object sender, EventArgs e)
        {
            //salehistorydvg.ClearSelection();
        }

        private void Salehistory_Load(object sender, EventArgs e)
        {
            vd.selectpagesize(loggedInUser.UserName);
            todaydate();
        }

        private void Loaddatebtn_Click(object sender, EventArgs e)
        {                        
            vd.salehistorybtdate(date1.Value,date2.Value, salehistorydvg, insh, cnsh, cmsh, tqsh, tprsh, tghstash, pash, spsh,Date);
            totalcount();
            salehistorydvg.ClearSelection();
            custsalerecordtxt.Text = "";
            pb1.BackColor = Color.GreenYellow;
            pb2.BackColor = Color.YellowGreen;
            pb3.BackColor = Color.WhiteSmoke;
            pb4.BackColor = Color.LightSlateGray;
            if (rbname.Checked == true) { rbname.Checked = false; }
            else if (rbmobile.Checked == true) { rbmobile.Checked = false; }
            else if (invoicerb.Checked == true) { invoicerb.Checked = false; }
            date3.Value = DateTime.Today;            
        }

        private void date3_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Salehistory_Activated(object sender, EventArgs e)
        {
           // if (rbname.Checked==true) { r.loadpartytxt(custsalerecordtxt); }
            
        }

        private void rbname_CheckedChanged(object sender, EventArgs e)
        {
            if (rbname.Checked == true)
            {
                r.loadpartycus(custsalerecordtxt);
                custsalerecordtxt.Focus();
                custsalerecordtxt.Text = "";
                custsalerecordtxt.Enabled = true;
                pb3.BackColor = Color.WhiteSmoke;
                pb4.BackColor = Color.LightSlateGray;
                pb1.BackColor = Color.WhiteSmoke;
                pb2.BackColor = Color.LightSlateGray;
               
            }
           
        }

        private void rbmobile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbmobile.Checked == true)
            {
                custsalerecordtxt.Focus();
                custsalerecordtxt.Text = "";
                custsalerecordtxt.Enabled = true;
                pb3.BackColor = Color.WhiteSmoke;
                pb4.BackColor = Color.LightSlateGray;
                pb1.BackColor = Color.WhiteSmoke;
                pb2.BackColor = Color.LightSlateGray;

            }
        }

        private void custsalerecordtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbmobile.Checked == true || invoicerb.Checked==true)
            {
                char ch = e.KeyChar;
                if (char.IsDigit(ch)) { e.Handled = false; } else if (ch == 8) { e.Handled = false; } else { e.Handled = true; }
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (custsalerecordtxt.Text == "")
            {
                MessageBox.Show("Please type to search", "search Information ?", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
           else if (invoicerb.Checked == true)
            {

                vd.salehistorybyinvoice(Convert.ToInt64(custsalerecordtxt.Text.Trim()), salehistorydvg, insh, cnsh, cmsh, tqsh, tprsh, tghstash, pash, spsh, Date);
                totalcount();                
                salehistorydvg.ClearSelection();
                salehistorydvg.Refresh();
            }
            else if(rbmobile.Checked==true || rbname.Checked==true)
            {
                r.gcdsale(custsalerecordtxt.Text);
                vd.salehistorybycust(salehistorydvg, insh, cnsh, cmsh, tqsh, tprsh, tghstash, pash, spsh, Date);
                totalcount();
                salehistorydvg.ClearSelection();
            }
            else { MessageBox.Show("Please select Customer's name or Customer's mobile or invoice no","Not selected",MessageBoxButtons.OK,MessageBoxIcon.Information);}
          
        }

        private void invoicerb_CheckedChanged(object sender, EventArgs e)
        {
            if (invoicerb.Checked == true)
            {
                custsalerecordtxt.Enabled = true;
                custsalerecordtxt.Focus();
                custsalerecordtxt.Text = "";
                pb3.BackColor = Color.WhiteSmoke;
                pb4.BackColor = Color.LightSlateGray;
                pb1.BackColor = Color.WhiteSmoke;
                pb2.BackColor = Color.LightSlateGray;
            }
        }

        private void date1btn_Click(object sender, EventArgs e)
        {
            vd.salehistory(date3.Value, salehistorydvg, insh, cnsh, cmsh, tqsh, tprsh, tghstash, pash, spsh, Date);
            // shsearchtxt.Text = "";
            totalcount();
            salehistorydvg.ClearSelection();
            custsalerecordtxt.Text = "";
            pb3.BackColor = Color.GreenYellow;
            pb4.BackColor = Color.YellowGreen;
            pb1.BackColor = Color.WhiteSmoke;
            pb2.BackColor = Color.LightSlateGray;
            if (rbname.Checked == true) { rbname.Checked = false; }
            else if (rbmobile.Checked == true) { rbmobile.Checked = false; }
            else if (invoicerb.Checked == true) { invoicerb.Checked = false; }
            date1.Value = DateTime.Today;
            date2.Value = DateTime.Today;
        }

        private void salehistorydvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex!=-1 && e.ColumnIndex != -1)
            {
                if (salehistorydvg.Columns[e.ColumnIndex].Name == "printbtn")
                {
                    Int64 Bvalue = Convert.ToInt64(salehistorydvg.SelectedRows[0].Cells[1].Value);
                    if (PageSize.A4 == true)
                    {
                        SaleReportA4 sr = new SaleReportA4(Bvalue);
                        sr.Show();
                    }
                    else if (PageSize.A4s == true)
                    {
                        SaleReportA4 sr = new SaleReportA4(Bvalue);
                        sr.Show();
                    }
                    else if (PageSize.A5V == true)
                    {
                        SalepageA5V spa5 = new SalepageA5V(Bvalue);
                        spa5.Show();
                        //spa5.salereportA5viwer.RefreshReport();
                    }
                    else if (PageSize.A5H == true)
                    {
                        ; SalepageA5V spa5 = new SalepageA5V(Bvalue);
                        spa5.Show();
                    }
                    else if (PageSize.Ther == true)
                    {
                        Roll3Inch r3 = new Roll3Inch(Bvalue);
                        r3.Show();
                    }
                    else if (PageSize.roll5 == true)
                    {
                        MessageBox.Show("Page Size Under the process");
                    }
                }
            }
          
        }
       
        void totalcount()
        {
            Decimal b = 0;
            Decimal c = 0;
            Decimal d = 0;
            for (int i = 0; i < salehistorydvg.Rows.Count; i++)
            {
                
                b = b + Convert.ToDecimal(salehistorydvg.Rows[i].Cells[4].Value);
                c = c + Convert.ToDecimal(salehistorydvg.Rows[i].Cells[6].Value);
                d = d + Convert.ToDecimal(salehistorydvg.Rows[i].Cells[7].Value);
            }
            gtqlbl.Text = b.ToString("N");
            tgclbl.Text = c.ToString("C");
            gtsalbl.Text = d.ToString("C");
            tinclbl.Text = salehistorydvg.Rows.Count.ToString();
        }

        private void Salehistory_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Up)
                {
                    e.SuppressKeyPress = true;
                    SendKeys.Send("+{tab}");
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                else if (e.Control == true && e.KeyCode == Keys.Down)
                {
                    e.SuppressKeyPress = true;
                    SendKeys.Send("{tab}");
                }
            }
            catch
            {
            }
        }
        void todaydate()
        {           
            date1.Value = DateTime.Today;
            date2.Value = DateTime.Today;
            date3.Value = DateTime.Today;
        }

        private void pribtn_Click(object sender, EventArgs e)
        {
            if (salehistorydvg.Rows.Count > 0)
            {
                bool dgvindex = salehistorydvg.CurrentRow.Selected;
                if (dgvindex)
                {
                    Int64 Bvalue = Convert.ToInt64(salehistorydvg.SelectedRows[0].Cells[1].Value);
                    if (PageSize.A4 == true)
                    {
                        SaleReportA4 sr = new SaleReportA4(Bvalue);
                        sr.Show();
                    }
                    else if (PageSize.A4s == true)
                    {
                        SaleReportA4 sr = new SaleReportA4(Bvalue);
                        sr.Show();
                    }
                    else if (PageSize.A5V == true)
                    {
                        SalepageA5V spa5 = new SalepageA5V(Bvalue);
                        spa5.Show();
                        //spa5.salereportA5viwer.RefreshReport();
                    }
                    else if (PageSize.A5H == true)
                    {
                        ; SalepageA5V spa5 = new SalepageA5V(Bvalue);
                        spa5.Show();
                    }
                    else if (PageSize.Ther == true)
                    {
                        Roll3Inch r3 = new Roll3Inch(Bvalue);
                        r3.Show();
                    }
                    else if (PageSize.roll5 == true)
                    {
                        PrintDoc pdoc = new PrintDoc();
                        pdoc.inv = Convert.ToInt64(salehistorydvg.SelectedRows[0].Cells[1].Value);
                        pdoc.print4page();
                    }
                }
                else { MessageBox.Show("Please select INVOICE to view details", "Invoice not selected", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
           
        }

        private void exportbtn_Click(object sender, EventArgs e)
        {
            if (salehistorydvg.Rows.Count > 0)
            {
                try
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
                    sfd.FileName = "SaleHistory.xlsx";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        // creating Excel Application  
                        Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                        // creating new WorkBook within Excel application  
                        Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                        // creating new Excelsheet in workbook  
                        Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                        // see the excel sheet behind the program  
                        app.Visible = true;
                        // get the reference of first sheet. By default its name is Sheet1.  
                        // store its reference to worksheet  
                        worksheet = workbook.Sheets["Sheet1"];
                        worksheet = workbook.ActiveSheet;
                        // changing the name of active sheet  
                        worksheet.Name = "Exported from gridview";
                        // storing header part in Excel  
                        for (int i = 1; i < salehistorydvg.Columns.Count + 1; i++)
                        {
                            worksheet.Cells[1, i] = salehistorydvg.Columns[i - 1].HeaderText;
                        }
                        // storing Each row and column value to excel sheet  
                        for (int i = 0; i < salehistorydvg.Rows.Count + 1; i++)
                        {
                            for (int j = 0; j < salehistorydvg.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1] = salehistorydvg.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        // save the application  
                        workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        // Exit from the application  
                        app.Quit();
                    }
                }
                catch (Exception)
                {
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool dgvindex = salehistorydvg.CurrentRow.Selected;
            if (dgvindex)
            {
                PrintDoc pdoc = new PrintDoc();
                pdoc.inv= Convert.ToInt64(salehistorydvg.SelectedRows[0].Cells[1].Value);
                pdoc.print4page();
            }
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.WindowState = FormWindowState.Maximized;
            //printPreviewDialog1.ShowDialog();
        }

        private int itemprpage = 0;
        private int itemprinted = 0;

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            //PrintDocument pd = new PrintDocument();
            
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
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Far;
            int gap1 = 360;
           
                for (int i = 0; i < salehistorydvg.Rows.Count; i++)
                {
                itemprinted++;
                if (itemprinted <= salehistorydvg.Rows.Count)
                {
                    for (int j = 0; j <= 5; j++)
                    {
                        itemprpage++;
                        if (itemprpage <= 5)
                        {

                            try
                            {
                                e.Graphics.DrawString(salehistorydvg.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 9), new SolidBrush(Color.Black), 61, gap1);
                                e.Graphics.DrawString(salehistorydvg.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 9), new SolidBrush(Color.Black), 321, gap1);
                                e.Graphics.DrawString(salehistorydvg.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 9), new SolidBrush(Color.Black), 399, gap1);
                                e.Graphics.DrawString(salehistorydvg.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 9), new SolidBrush(Color.Black), 500, gap1, stringFormat);
                                e.Graphics.DrawString(salehistorydvg.Rows[i].Cells[6].Value.ToString(), new Font("Arial", 9), new SolidBrush(Color.Black), 810, gap1, stringFormat);
                                gap1 += 18;
                            }
                            catch (Exception)
                            {

                                throw;
                            }


                        }
                        else
                        {
                            itemprpage = 0;
                            e.HasMorePages = true;
                            //return;
                        }
                    }
                }
                else
                {
                    e.HasMorePages = false;
                }
                
                    
                    
                   
                }
                
                    
                

                    
            
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
           // PrinterSettings ps = new PrinterSettings();
          //  PrintDocument pd = new PrintDocument();
          //  pd.PrinterSettings = ps;
           // IEnumerable<PaperSize> paperSizes = ps.PaperSizes.Cast<PaperSize>();
           // PaperSize sizeA4 = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.A4); // setting paper size to A4 size
            //pd.DefaultPageSettings.PaperSize = sizeA4;

        }

        private void custsalerecordtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
