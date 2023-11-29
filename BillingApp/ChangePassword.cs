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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                if (IsPasswordVarified())
                {
                    SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Changepassword", cs);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", loggedInUser.UserName);
                        cmd.Parameters.AddWithValue("@newpass", SecureData.EncryptData(newpasstxt.Text.Trim()));
                        cmd.Parameters.AddWithValue("@cb", loggedInUser.UserName);
                        cs.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("Password succesfully changed......!!!!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetcontrols();
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
                else
                {
                    MessageBox.Show("Your Old password is not correct, please enter the correct password", "Correct Old Password is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool IsPasswordVarified()
        {
            bool Iscorrect = false;
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("loggingVariefied", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", loggedInUser.UserName);
                cmd.Parameters.AddWithValue("@password", SecureData.EncryptData(oldpasstxt.Text.Trim()));
                cs.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    Iscorrect = true;
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Iscorrect;
        }
        private bool IsFormValid()
        {
            if (oldpasstxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Old Password Required", "Fill Old Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oldpasstxt.Focus();
                return false;
            }
            if (newpasstxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("New Password Required", "Fill New Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newpasstxt.Focus();
                return false;
            }
            if (confpasstxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Confirm Password Required", "Fill Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                confpasstxt.Focus();
                return false;
            }
            if (newpasstxt.Text.Trim() != confpasstxt.Text.Trim())
            {
                MessageBox.Show("New and Confirm Password is not matched", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                confpasstxt.Focus();
                return false;
            }
            return true;
        }
        void resetcontrols()
        {
            oldpasstxt.Text = "";
            newpasstxt.Text = "";
            confpasstxt.Text = "";
            oldpasstxt.Focus();
        }

        private void oldpasstxt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    SelectNextControl(ActiveControl, true, true, true, true);
                }
            }
            catch
            {
            }
        }

        private void newpasstxt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    SelectNextControl(ActiveControl, true, true, true, true);
                }
            }
            catch
            {
            }
        }

        private void confpasstxt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    SelectNextControl(ActiveControl, true, true, true, true);
                }
            }
            catch
            {
            }
        }

        private void ChangePassword_KeyDown(object sender, KeyEventArgs e)
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
