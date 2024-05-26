using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Windows.Forms;

namespace DriverCarLicences
{
    public partial class frm_Add_UpdateUser : Form
    {

        public delegate void DataBackEventHandler(object sender, int personID);
        public event DataBackEventHandler DataBack;

        enum enMode { Add = 0, Update = 1 }
        enMode _Mode = enMode.Update;

        int _userID = -1;
        clsUser _user = null;
        public frm_Add_UpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public frm_Add_UpdateUser(int id)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _userID = id;
        }

        private void btnNext_Click(object sender, EventArgs e)

        {
            // ! Nessacry
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                Login.Enabled = true;
                TablInfo.SelectedTab = TablInfo.TabPages["Login"];
                return;
            }

            if (cntrlPersonalInfoWithfilter1.PersonID != -1)
            {

                if (clsUser.isPersonHasAUser(cntrlPersonalInfoWithfilter1.PersonID))
                {
                   // e.Cancel = true;
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cntrlPersonalInfoWithfilter1.FilterFocus();
                }

                else
                {

                    btnSave.Enabled = true;
                    Login.Enabled = true;
                    TablInfo.SelectedIndex = 1;
                    tbUserName.Focus();
                }
            }
            else

            {
               // e.Cancel = true;

                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cntrlPersonalInfoWithfilter1.FilterFocus();

            }
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbUserName.Text))
            {
                e.Cancel = true;
                tbUserName.Focus();
                errorProvider1.SetError(tbUserName, "UserName is Required");
            }
            else if (tbUserName.Text.Length < 3)
            {
                e.Cancel = true;
                tbUserName.Focus();
                errorProvider1.SetError(tbUserName, "UserName is not valid");

            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(tbUserName, "");
            }

            if (tbUserName.Text != _user.UserName && clsUser.isUserExist(tbUserName.Text.Trim()))
            {
                e.Cancel = true;
                tbUserName.Focus();
                errorProvider1.SetError(tbUserName, "UserName is Exist ");

            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(tbUserName, "");
            }
        }

        private void tbPWD_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbPWD.Text))
            {
                e.Cancel = true;
                tbPWD.Focus();
                errorProvider1.SetError(tbPWD, "Password is Required");
            }
            else if (tbPWD.Text.Length < 3)
            {
                e.Cancel = true;
                tbPWD.Focus();
                errorProvider1.SetError(tbPWD, "Password is not valid");

            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(tbPWD, "");
            }
        }

        private void tbConfirmPwd_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbConfirmPwd.Text))
            {
                e.Cancel = true;
                tbConfirmPwd.Focus();
                errorProvider1.SetError(tbConfirmPwd, "Confirm Password is Required");
            }
            else if (tbPWD.Text != tbConfirmPwd.Text)
            {
                e.Cancel = true;
                tbConfirmPwd.Focus();
                errorProvider1.SetError(tbConfirmPwd, "Confirm Password is not valid");

            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(tbConfirmPwd, "");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check validations      - fill object     -- chckSave + open updateMode
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid: ", "Put the mouse over the red icon.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            _user.UserName = tbUserName.Text;
            _user.Password = tbPWD.Text;
            _user.ISActive = isActive.Checked;

            if(_user.Save())
            {

                lblPersonIDValue.Text = _user.UserID.ToString();
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                _Mode = enMode.Update;

                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Trigger the event to send 
                DataBack?.Invoke(this, _user.UserID);

            }
             else
                MessageBox.Show("Error: Data is not Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }   

        private void _LoadData()
        {
            _user = clsUser.find(_userID);
            cntrlPersonalInfoWithfilter1.EnableFilter = false;


            if (_user == null)
            {
                MessageBox.Show("No User with ID: " + _userID , "USER Not Founded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblPersonIDValue.Text = _userID.ToString();
            tbUserName.Text = _user.UserName;
            tbConfirmPwd.Text = _user.Password;
            tbPWD.Text = _user.Password;
            isActive.Checked = _user.ISActive;

            cntrlPersonalInfoWithfilter1.loadPersonInfo(_user.personID);


        }  

        private void _ResetDefaultValues()
        {
            

            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _user = new clsUser();

                Login.Enabled = false;

                cntrlPersonalInfoWithfilter1.Focus();
                cntrlPersonalInfoWithfilter1.FilterFocus();

            }
            else
            {

                lblTitle.Text = "Update User";
                
                this.Text = "Update User";

                Login.Enabled = true;
                btnSave.Enabled = true;

            }
            

            tbUserName.Text = "";
            tbPWD.Text     = "";
            tbConfirmPwd  .Text = "";
            isActive.Checked = false;
            lblPersonIDValue.Text = "N/A";


        }

        private void frm_Add_UpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)  
                _LoadData();
   
        }   

        private void frm_Add_UpdateUser_Activated(object sender, EventArgs e)
        {
            cntrlPersonalInfoWithfilter1.FilterFocus();
        }

        private void TablInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cntrlPersonalInfoWithfilter1_onPersonSelected(int obj)
        {
            // ! Nessacry
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                Login.Enabled = true;
                TablInfo.SelectedTab = TablInfo.TabPages["Login"];
                return;
            }

            if (cntrlPersonalInfoWithfilter1.PersonID != -1)
            {

                if (clsUser.isPersonHasAUser(cntrlPersonalInfoWithfilter1.PersonID))
                {
                    // e.Cancel = true;
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cntrlPersonalInfoWithfilter1.FilterFocus();
                }

                else if (clsPerson.isPersonExist(cntrlPersonalInfoWithfilter1.PersonID) && !clsUser.isPersonHasAUser(cntrlPersonalInfoWithfilter1.PersonID))
                {
                    _user.personID = cntrlPersonalInfoWithfilter1.PersonID;
                    DialogResult res =  MessageBox.Show("Press on Tab \'Logion\' To Enter User Information.\nIf You want move to \'Login \' Now Press \"OK\"",
                        "Seccess", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    btnSave.Enabled = true;
                    Login.Enabled = true;

                    if (DialogResult.OK == res)
                    {
                        TablInfo.SelectedIndex = 1;
                        tbUserName.Focus();
                    }
                    //TablInfo.SelectedIndex = 1;
                    //
                }
            }
            else

            {
                // e.Cancel = true;

                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cntrlPersonalInfoWithfilter1.FilterFocus();

            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
