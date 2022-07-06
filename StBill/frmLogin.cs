using System;
using System.Drawing;
using System.Windows.Forms;

namespace StBill
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var dr = Db.GetDataReader("SELECT * FROM TBL_EMPLOYEE WHERE ((EMP_USER_NAME='" + 
                                          textBoxUserName.Text.Trim() + "') " + "AND (EMP_PASSWORD='" + 
                                          textBoxPassword.Text.Trim() + "'))");
                if (dr.HasRows)
                {
                    labelLoginMessage.Text = "";
                    dr.Read();
                    GlobalSetting.EmpUserName = dr["EMP_USER_NAME"].ToString();
                    GlobalSetting.EmpName = dr["EMP_NAME"].ToString();
                    new frmHome().Show();
                    base.Hide();
                }
                else
                {
                    labelLoginMessage.Text = "Username or Password incorrect...";
                    labelLoginMessage.ForeColor = Color.Red;
                }
            }
            catch
            {
                labelLoginMessage.Text = "Username or Password incorrect...";
                labelLoginMessage.ForeColor = Color.Red;
            }
        }

        private void textBoxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBoxPassword.Focus();
                textBoxPassword.SelectAll();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buttonLogin.PerformClick();
            }
        }
    }
}
