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
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }
        retrievedata r = new retrievedata();
        Insertion i = new Insertion();
        public String Username { get; set; }
        public bool isupdate { get; set; }
        public string userdes { get; set; }
        private void UserInfo_Load(object sender, EventArgs e)
        {
            r.loadrole(userrolecombo);
            usernametxt.Focus();
            if (isupdate == true)
            {
                loduser();
                if (userdesctxt.Text == "Administrator" && userrolecombo.Text== "Administrator")
                {
                    userdesctxt.Enabled = false;
                    userrolecombo.Enabled = false;
                    isadmincb.Enabled = false;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userdesctxt.Text.Trim() == "" && passwordtxt.Text.Trim() == "" && userrolecombo.SelectedIndex == -1)
            {

            }
            else if (isupdate == false)
            {
                insertuser();
                reset();
            }
            else if (isupdate == true)
            {
                updateusers();
                reset();
                this.isupdate = false;
            }
            //  i.insertusers(usernametxt.Text.Trim(), passwordtxt.Text.Trim(), userrolecombo.SelectedText.Trim(), usercheck.Checked, userdesctxt.Text.Trim());
        }

        void insertuser()
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("insertuser", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@un", usernametxt.Text.Trim());
                cmd.Parameters.AddWithValue("@up", passwordtxt.Text.Trim());
                //cmd.Parameters.AddWithValue("@up", SecureData.EncryptData(passwordtxt.Text.Trim()));
                cmd.Parameters.AddWithValue("@roleid", userrolecombo.SelectedValue);
                cmd.Parameters.AddWithValue("@isactive", usercheck.Checked);
                cmd.Parameters.AddWithValue("@mobile", mobiletxt.Text.Trim());
                cmd.Parameters.AddWithValue("@email", emailtxt.Text.Trim());
                cmd.Parameters.AddWithValue("@desc", userdesctxt.Text.Trim());
                cmd.Parameters.AddWithValue("@cb", loggedInUser.UserName);
                cmd.Parameters.AddWithValue("@sp", "True");
                cmd.Parameters.AddWithValue("@sh", "True");
                cmd.Parameters.AddWithValue("@pur", "True");
                cmd.Parameters.AddWithValue("@purH", "True");
                cmd.Parameters.AddWithValue("@pr", "True");
                cmd.Parameters.AddWithValue("@prD", "True");
                cmd.Parameters.AddWithValue("@cus", "True");
                cmd.Parameters.AddWithValue("@cusD", "True");
                cmd.Parameters.AddWithValue("@suplr", "True");
                cmd.Parameters.AddWithValue("@suplrD", "True");
                cmd.Parameters.AddWithValue("@backup", "True");
                cmd.Parameters.AddWithValue("@restore", "True");
                cmd.Parameters.AddWithValue("@slb", "True");
                cmd.Parameters.AddWithValue("@expen", "True");
                cmd.Parameters.AddWithValue("@addexpens", "True");
                cmd.Parameters.AddWithValue("@stk", "True");
                cmd.Parameters.AddWithValue("@stting", "True");
                cmd.Parameters.AddWithValue("@Isadmin", isadmincb.Checked);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                cs.Close();
                if (a > 0)
                {
                    SqlCommand cmd1 = new SqlCommand("insertpagesizebyuser", cs);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@a4", "True");
                    cmd1.Parameters.AddWithValue("@a4spm", "False");
                    cmd1.Parameters.AddWithValue("@a5v", "False");
                    cmd1.Parameters.AddWithValue("@a5h", "False");
                    cmd1.Parameters.AddWithValue("@thermai", "False");
                    cmd1.Parameters.AddWithValue("@roll5", "False");
                    cmd1.Parameters.AddWithValue("@un", usernametxt.Text.Trim());
                    cs.Open();
                    int aa = cmd1.ExecuteNonQuery();
                    if (aa > 0)
                    {
                        MessageBox.Show("Data Saved Successfull","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data saveing failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cs.Close();
                }
                
                
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }
      
        
        void reset()
        {
            usernametxt.Text = "";
            passwordtxt.Text = "";
            userrolecombo.SelectedIndex = 0;
            usercheck.Checked = true;
            userdesctxt.Text = "";
            mobiletxt.Text = "";
            emailtxt.Text="";
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loduser()
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            SqlCommand cmd = new SqlCommand("loadusercontrols", cs);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usern", this.Username);
            DataTable dt = new DataTable();
            cs.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            DataRow row = dt.Rows[0];
            usernametxt.Text = row["Username"].ToString();
            passwordtxt.Text = row["Password"].ToString();
            userrolecombo.SelectedValue = row["RoleId"];
            usercheck.Checked = Convert.ToBoolean(row["IsActive"]);
            mobiletxt.Text = row["Mobile"].ToString();
            emailtxt.Text = row["EMAIL"].ToString();
            userdesctxt.Text = row["Description"].ToString();
            isadmincb.Checked = Convert.ToBoolean(row["IsAdmin"]);
            cs.Close();
        }
        void updateusers()
        {
            SqlConnection cs = new SqlConnection(Connectionstringcs.Connect());
            try
            {
                SqlCommand cmd = new SqlCommand("updatetuser", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@oldun", this.Username);
                cmd.Parameters.AddWithValue("@un", usernametxt.Text.Trim());
                cmd.Parameters.AddWithValue("@up", passwordtxt.Text.Trim());
                //cmd.Parameters.AddWithValue("@up", SecureData.EncryptData(passwordtxt.Text.Trim()));
                cmd.Parameters.AddWithValue("@roleid", userrolecombo.SelectedValue);
                cmd.Parameters.AddWithValue("@isactive", usercheck.Checked);
                cmd.Parameters.AddWithValue("@mob", mobiletxt.Text.Trim());
                cmd.Parameters.AddWithValue("@email", emailtxt.Text.Trim());
                cmd.Parameters.AddWithValue("@desc", userdesctxt.Text.Trim());
                cmd.Parameters.AddWithValue("@cb", loggedInUser.UserName);
                cmd.Parameters.AddWithValue("@isadmin", isadmincb.Checked);
                cs.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated succesfully ......!!!!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data updated failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cs.Close();
            }
            catch (Exception ex)
            {
                cs.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userdesctxt.Text == "Administrator")
            {
                MessageBox.Show("You can't delete 'Administrator'", "Denied !!!!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                Deleteall d = new Deleteall();
                DialogResult dr = MessageBox.Show("Are you sure to delete.....", "Confermation to Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.Yes)
                {
                    if (loggedInUser.UserName != usernametxt.Text)
                    {
                        d.deleusers(usernametxt.Text);
                        deleteToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("You can't delete loging user", "Delete process denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                this.Close();
            }
           
        }

        private void newRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersRoles ur = new UsersRoles();
            ur.ShowDialog();
        }

        private void checksp_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void usernametxt_KeyDown(object sender, KeyEventArgs e)
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

        private void passwordtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void mobiletxt_KeyDown(object sender, KeyEventArgs e)
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

        private void emailtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void userrolecombo_KeyDown(object sender, KeyEventArgs e)
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

        private void userdesctxt_KeyDown(object sender, KeyEventArgs e)
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

        private void userdesctxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UserInfo_KeyDown(object sender, KeyEventArgs e)
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
       
    }
}


