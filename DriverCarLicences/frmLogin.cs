using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverCarLicences
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.findUserByUNAndPwd(tbUserName.Text, tbPWD.Text);
            if (user!= null)
            {
                if (chkRemember.Checked)
                    clsGlobal.RememberUsernameAndPassword(tbUserName.Text, tbPWD.Text);
                else
                    clsGlobal.RememberUsernameAndPassword("", "");

                if (!user.ISActive)
                {
                    tbUserName.Text = "";
                    tbPWD.Text = "";

                    tbUserName.Focus();
                    MessageBox.Show("Your Account is not Active, contact Admin", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobal.CurrentUser = user;


                tbUserName.Text = "";
                tbPWD.Text = "";


                this.Hide();
                frmMain f = new frmMain(this);
                f.ShowDialog();
            }
            else
            {
                tbUserName.Text = "";
                tbPWD.Text = "";

                tbUserName.Focus();
                MessageBox.Show("Invalid UserName/Password", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string username = " ";
            string password = "";

            foreach (Form form in Application.OpenForms)
                if (form != this)
                {
                    form.Icon = this.Icon;
                    form.ShowIcon = true;
                }

            if (clsGlobal.GetStoredCredential(ref username, ref password))
            {
                tbUserName.Text = username;
                tbPWD.Text = password;
                chkRemember.Checked = true;

            }
            else
                chkRemember.Checked = false;

        }
    }
}
