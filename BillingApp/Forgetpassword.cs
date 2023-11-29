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
    public partial class Forgetpassword : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);

        public Forgetpassword()
        {
            InitializeComponent();
        }
        int a=0;
        string RandomNumber;
        retrievedata rt = new retrievedata();
        ComboSelectChange csc = new ComboSelectChange();
        Viewalldata vd = new Viewalldata();
        private void Forgetpassword_Activated(object sender, EventArgs e)
        {
            // rt.loaduseraccess(fpcombo);
            vd.getsystemcon();
            int Out;
            if (InternetGetConnectedState(out Out, 0) == true)
            {
                inerlbl.Text = "Internet Connected !! OK";
                inerlbl.ForeColor = Color.Green;
            }
            else
            {
                inerlbl.Text = "Internet Not Connected !!...Please Connect Internet !!";
                inerlbl.ForeColor = Color.Red;
            }
        }

        private  void fpsavebtn_Click(object sender, EventArgs e)
        {
            int Out;
            if (InternetGetConnectedState(out Out, 0) == true)
            {
                if (a == 0)
                {
                    if (frusernametxt.Text!="")
                    {                       
                        frusernametxt.Enabled = false;
                        label2.Visible = true;
                        label3.Visible = true;
                        otptxt.Visible = true;
                        newPtxt.Visible = true;
                        fpsavebtn.Text = "Save";                        
                        sendmail();
                        otptxt.Focus();
                    }
                    else { MessageBox.Show("Please Searcch User to change password", "Select User", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }


                else if (a == 1)
                {
                    if (otptxt.Text == RandomNumber )
                    {
                        updatepassword();
                        this.Close();
                    }
                    else { MessageBox.Show("Please Check OTP", "Wrogn OTP", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else { MessageBox.Show("Please Connect Internet First !!","Internet Not available",MessageBoxButtons.OK,MessageBoxIcon.Information);}
        }
       public async void  sendmail()
        {
            await Task.Run(() => {
                try
                {

                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Port = 587;
                    SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(Currenttime.sysemail,Currenttime.syspass);
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(Currenttime.sysemail);
                    mail.To.Add(fpemailtxt.Text);
                    Random rnd = new Random();
                    RandomNumber = (rnd.Next(100000, 999999)).ToString();
                    mail.Subject = "OTP for reset password is " + RandomNumber;
                    mail.Body = "One Time Password for reset password is " + RandomNumber;
                    SmtpServer.Send(mail);
                    a = 1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            });
            
        }
        void updatepassword()
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("Changepassword", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", frusernametxt.Text);
                //cmd.Parameters.AddWithValue("@newpass", SecureData.EncryptData(newPtxt.Text.Trim()));
                cmd.Parameters.AddWithValue("@newpass", newPtxt.Text.Trim());
                cmd.Parameters.AddWithValue("@cb", frusernametxt.Text);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Password succesfully changed......!!!!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //resetcontrols();
                }
                else
                {
                    MessageBox.Show("Password failed to change", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Forgetpassword_Load(object sender, EventArgs e)
        {
            
        }

        private void frusernametxt_Leave(object sender, EventArgs e)
        {
            rt.getusername(frusernametxt.Text, fpmobiletxt, fpemailtxt);
             a = 0;
             fpsavebtn.Text = "Send OTP";
        }

        private void Forgetpassword_KeyDown(object sender, KeyEventArgs e)
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
            }
            catch
            {
            }
        }
    }
}
