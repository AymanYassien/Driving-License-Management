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
    public partial class frmChangePassword : Form
    {
        clsUser _user;
        int id = -1;
        public frmChangePassword(int id)
        {
            InitializeComponent();
            this.id = id;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _user = clsUser.find(id);
            ctrlUser1.loadUserInfo(id);
            

        }

        private void tbPWD_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbPWD.Text))
            {
                e.Cancel = true;
                tbPWD.Focus();
                errorProvider1.SetError(tbPWD, "Current Password is Required");
            }
            else if (tbPWD.Text != _user.Password)
            {
                e.Cancel = true;
                tbPWD.Focus();
                errorProvider1.SetError(tbPWD, "Current Password is not valid");

            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(tbPWD, "");
            }
        }

        private void tbNew_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbNew.Text))
            {
                e.Cancel = true;
                tbNew.Focus();
                errorProvider1.SetError(tbNew, "Password is Required");
            }
            else if (tbNew.Text.Length < 3)
            {
                e.Cancel = true;
                tbNew.Focus();
                errorProvider1.SetError(tbNew, "Password is not valid");

            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(tbNew, "");
            }
        }

        private void tbConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbConfirm.Text))
            {
                e.Cancel = true;
                tbConfirm.Focus();
                errorProvider1.SetError(tbConfirm, "Password is Required");
            }
            else if (tbConfirm.Text != tbNew.Text)
            {
                e.Cancel = true;
                tbConfirm.Focus();
                errorProvider1.SetError(tbConfirm, "Password is not valid");

            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(tbConfirm, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid: ", "Put the mouse over the red icon.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
             _user.Password = tbConfirm.Text;
            if (_user.Save())
            {

                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
   

                //this.Close();

            }
            else
                MessageBox.Show("Error: Data is not Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
