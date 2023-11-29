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
using System.Net;
using System.Net.Mime;
using System.Net.Mail;
using System.Data.SqlClient;
using BillingApp.connection_class;
using System.Runtime.InteropServices;
using BillingSystem.main_class;

namespace BillingSystem
{
    public partial class shopvalidation : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);
        public shopvalidation()
        {
            InitializeComponent();
        }
        Insertion inn = new Insertion();
        Viewalldata v = new Viewalldata();
        int a=0;
        string RandomNumber;
        private void smtbtn_Click(object sender, EventArgs e)
        {
            int Out;
            if (InternetGetConnectedState(out Out, 0) == true)
            {
                if (a == 0)
                {
                    if (monthrb.Checked==true)
                    {
                        sereillbl.Visible = true;
                        serieltxt.Visible = true;
                        txidtxt.Enabled = false;
                        smtbtn.Text = "Activate";
                        groupBox2.Enabled = false;
                        sendmail();
                    }
                    else if (threemonthrb.Checked==true)
                    {
                        sereillbl.Visible = true;
                        serieltxt.Visible = true;
                        txidtxt.Enabled = false;
                        smtbtn.Text = "Activate";
                        groupBox2.Enabled = false;
                        sendmail();
                    }
                    else if (sixmonthrb.Checked==true)
                    {
                        sereillbl.Visible = true;
                        serieltxt.Visible = true;
                        txidtxt.Enabled = false;
                        smtbtn.Text = "Activate";
                        groupBox2.Enabled = false;
                        sendmail();
                    }
                    else if (oneyrrb.Checked==true)
                    {
                        sereillbl.Visible = true;
                        serieltxt.Visible = true;
                        txidtxt.Enabled = false;
                        smtbtn.Text = "Activate";
                        groupBox2.Enabled = false;
                        sendmail();
                    }
                    else
                    {
                        MessageBox.Show("Please Scan QR CODE and pay , Call To 8005086600 For Serial Key","Call 8005086600",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else if (a == 1)
                {
                    if (serieltxt.Text == RandomNumber)
                    {
                        if (monthrb.Checked == true) { setdate(DateTime.Now.AddMonths(1),"ONE MONTH"); }                      
                        else if (threemonthrb.Checked == true) { setdate(DateTime.Now.AddMonths(3), "THREE MONTH"); }
                        else if (sixmonthrb.Checked == true) { setdate(DateTime.Now.AddMonths(6), "SIX MONTH"); }
                        else if (oneyrrb.Checked == true) { setdate(DateTime.Now.AddYears(50), "Full Time Plan"); }                        
                        splashpage sp = new splashpage();
                        sp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Serial Key Incorrect !! Please Contact Servise Provider '8005086600'","ERROR!!!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    }
                }
                
            }
            else { MessageBox.Show("Please Connect Internet First !!", "Internet Not available", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
        void setdate(DateTime totald,string type)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = totald;
            TimeSpan t = d2 - d1;
            double d = t.TotalDays;
            inn.insertvaliddate(d1, d2, d,type);
        }
        public async void sendmail()
        {
            await Task.Run(() => {
                try
                {

                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Port = 587;
                    SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("aacademy2022@gmail.com", "8005086600");
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("aacademy2022@gmail.com");
                    mail.To.Add("alokranjan.ucer@gmail.com");
                    Random rnd = new Random();
                    RandomNumber = (rnd.Next(100000, 999999)).ToString();
                    if (monthrb.Checked)
                    {
                        mail.Subject = "Serial Key For ONE MONTH Renewal Softwate  | Shop name : " + Currenttime.fname;
                        mail.Body = "Serial Key for Renewal Softwate for 1 Month time Period\n\nTransaction Id : " + txidtxt.Text + "\n\n Current Date :" + DateTime.Now + "\n\n Valid Upto: " + DateTime.Now.AddMonths(1) + "\n\n\nSerial Key is " + RandomNumber + "\n\n\n" + Currenttime.fname + "\n" + Currenttime.fcontact + "\n" + Currenttime.faddress + "\n" + Currenttime.fgstin;
                        SmtpServer.Send(mail);
                        a = 1;
                        
                    }
                    else if (threemonthrb.Checked)
                    {
                        mail.Subject = "Serial Key For THREE MONTH Renewal Softwate  | Shop name : " + Currenttime.fname;
                        mail.Body = "Serial Key for Renewal Softwate for THREE MONTH time Period\n\nTransaction Id : " + txidtxt.Text + "\n\n Current Date :" + DateTime.Now + "\n\n Valid Upto: " + DateTime.Now.AddMonths(3) + "\n\n\nSerial Key is " + RandomNumber + "\n\n\n" + Currenttime.fname + "\n" + Currenttime.fcontact + "\n" + Currenttime.faddress + "\n" + Currenttime.fgstin;
                        SmtpServer.Send(mail);
                        a = 1;
                       
                    }
                    else if (sixmonthrb.Checked)
                    {
                        mail.Subject = "Serial Key For SIX MONTH Renewal Softwate  | Shop name : " + Currenttime.fname;
                        mail.Body = "Serial Key for Renewal Softwate for Six month time Period\n\nTransaction Id : " + txidtxt.Text + "\n\n Current Date :" + DateTime.Now + "\n\n Valid Upto: " + DateTime.Now.AddMonths(6) + "\n\n\nSerial Key is " + RandomNumber + "\n\n\n" + Currenttime.fname + "\n" + Currenttime.fcontact + "\n" + Currenttime.faddress + "\n" + Currenttime.fgstin;
                        SmtpServer.Send(mail);
                        a = 1;
                        
                    }
                    else if (oneyrrb.Checked)
                    {
                        mail.Subject = "Serial Key For Full Time Renewal Softwate  | Shop name : " + Currenttime.fname;
                        mail.Body = "Serial Key for Renewal Softwate for Full Time time Period\n\nTransaction Id : " + txidtxt.Text + "\n\n Current Date :" + DateTime.Now + "\n\n Valid Upto: " + DateTime.Now.AddYears(50) + "\n\n\nSerial Key is " + RandomNumber + "\n\n\n" + Currenttime.fname + "\n" + Currenttime.fcontact + "\n" + Currenttime.faddress + "\n" + Currenttime.fgstin;
                        SmtpServer.Send(mail);
                        a = 1;
                        
                    }
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            });

        }

        private void shopvalidation_Load(object sender, EventArgs e)
        {
            txidtxt.Focus();
            v.shpdetails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QR q = new QR();
            q.Show();
        }

        private void shopvalidation_KeyDown(object sender, KeyEventArgs e)
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
                else if (e.KeyCode == Keys.Q)
                {
                    QR q = new QR();
                    q.Show();
                }
            }
            catch
            {
            }
        }

        private void shopvalidation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void monthrb_CheckedChanged(object sender, EventArgs e)
        {
            txidtxt.Visible = true;
            tsxlbl.Visible = true;
            d1txt.Text = "Registerd Date : " + DateTime.Now;
            d2txt.Text = "Expired Date : " + DateTime.Now.AddMonths(1);
            d3txt.Text = "Trial Period ONE MONTH ONLY";
        }

        private void threemonthrb_CheckedChanged(object sender, EventArgs e)
        {
            txidtxt.Visible = true;
            tsxlbl.Visible = true;
            d1txt.Text = "Registerd Date : " + DateTime.Now;
            d2txt.Text = "Expired Date : " + DateTime.Now.AddMonths(3);
            d3txt.Text = "Trial Period THREE MONTH ONLY";
        }

        private void sixmonthrb_CheckedChanged(object sender, EventArgs e)
        {
            txidtxt.Visible = true;
            tsxlbl.Visible = true;
            d1txt.Text = "Registerd Date : " + DateTime.Now;
            d2txt.Text = "Expired Date : " + DateTime.Now.AddMonths(6);
            d3txt.Text = "Trial Period SIX MONTH ONLY";
        }

        private void oneyrrb_CheckedChanged(object sender, EventArgs e)
        {
            txidtxt.Visible = true;
            tsxlbl.Visible = true;
            d1txt.Text = "Registerd Date : " + DateTime.Now;
            d2txt.Text = "Expired Date : " + DateTime.Now.AddYears(1);
            d3txt.Text = "Trial Period ONE YEAR ONLY";
        }
    }
}
