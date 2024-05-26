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
    
    
    public partial class frmAddNewLocalDrivingLicenseApplication : Form
    {
        // validating     |  buttons         | data (load, Reset, send) 
        

        DataTable _LicenseClasses = clsManageLicenseClasses.getAllLisenseClasses();

        
        enum enMode { Add = 0, Update = 1 }
        enMode _Mode = enMode.Update;

        int _localDrivingLicenseID = -1;
        clsLocalDrivingLicenseApplication  _localDrivingLicenseApplication = null;

        public frmAddNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }

        public frmAddNewLocalDrivingLicenseApplication(int id)
        {
            InitializeComponent();

            _localDrivingLicenseID = id;
            _Mode = enMode.Update;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if( clsPerson.isPersonExist(cntrlPersonalInfoWithfilter1.PersonID))
                {
                    DialogResult res = MessageBox.Show("Press on Tab \'Appication\' To Take an Appointment.\nIf You want move to \'Appication \' Now Press \"OK\"",
                        "Seccess", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    btnSave.Enabled = true;
                    Login.Enabled = true;

                    if (DialogResult.OK == res)
                    {
                        TablInfo.SelectedIndex = 1;
                        dateTimePicker1.Focus();
                    }
                    //TablInfo.SelectedIndex = 1;
                }

            }
            else

            {

                MessageBox.Show("Please Select a Person!", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cntrlPersonalInfoWithfilter1.FilterFocus();

            }
        }

        private void frmAddNewLocalDrivingLicenseApplication_Activated(object sender, EventArgs e)
        {
            cntrlPersonalInfoWithfilter1.FilterFocus();
        }

        private void _ResetDefaultValues()
        {
            lblappID.Text = "N/A";
            lblDate.Text = DateTime.Now.ToShortDateString();
            comboBox1.SelectedIndex = 2;
            lblAppFees.Text = clsApplicationTypes.find(1).ApplicationTypeFee.ToString() ;
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;

            dateTimePicker1.Visible = false;
            


            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "New Local Driving License Application";
                this.Text = "New Local Driving License Application";
                _localDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();

                Login.Enabled = false;

                cntrlPersonalInfoWithfilter1.Focus();
                cntrlPersonalInfoWithfilter1.FilterFocus();

                // for first time set it, else do not otuch it!
                _localDrivingLicenseApplication.createdByUserID = clsGlobal.CurrentUser.UserID;

            }
            else
            {

                lblTitle.Text = "Update Local Driving License Application";

                this.Text = "Update Local Driving License Application";

                dateTimePicker1.Visible = true;
                lblDate.Visible = false;
                

                Login.Enabled = true;
                btnSave.Enabled = true;

            }


        }

        private void _LoadData()
        {
            _localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.findLocalDrivingLicenseApplication(_localDrivingLicenseApplication.LocalDrivingLicenseApplicationID);
            cntrlPersonalInfoWithfilter1.EnableFilter = false;


            if (_localDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Local Driving License Application with ID: " + _localDrivingLicenseID, "Local Driving License Application Not Founded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblappID.Text = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblDate.Text = _localDrivingLicenseApplication.ApplicationDate.ToShortDateString();
            comboBox1.SelectedIndex = _localDrivingLicenseApplication.LicenseClassID;
            lblAppFees.Text = _localDrivingLicenseApplication.paidFees.ToString();
            lblCreatedBy.Text = _localDrivingLicenseApplication.UserInfo.UserName.ToString();

            cntrlPersonalInfoWithfilter1.loadPersonInfo(_localDrivingLicenseApplication.UserInfo.personID);


        }

        private void frmAddNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(1);

            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check validations      - fill object     -- chckSave + open updateMode
            /*if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid: ", "Put the mouse over the red icon.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }*/  // Not need here 


            _localDrivingLicenseApplication.ApplicationDate = dateTimePicker1.Value;
            _localDrivingLicenseApplication.LicenseClassID = comboBox1.SelectedIndex + 1;
            _localDrivingLicenseApplication.PersonID = cntrlPersonalInfoWithfilter1.PersonID;

            _localDrivingLicenseApplication.AppTypeID = 1;
            _localDrivingLicenseApplication.AppStatus = 1;
            _localDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _localDrivingLicenseApplication.paidFees  = _localDrivingLicenseApplication.ApplicationTypeInfo.ApplicationTypeFee;





            if (!clsLocalDrivingLicenseApplication.isPersonHasANewAppointmentFromSameLicenseClass(
                _localDrivingLicenseApplication.PersonInfo.NationalNumber,
                comboBox1.Items[_localDrivingLicenseApplication.LicenseClassID-1].ToString()))
            {
                if (_localDrivingLicenseApplication.Save())
                {


                    _Mode = enMode.Update;
                    
                    MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _localDrivingLicenseID = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID;

                    //lblappID.Text = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                    lblTitle.Text = "Update Local Driving License Application";
                    this.Text = "Update Local Driving License Application";

                    
                    Login.Enabled = false;
                    btnSave.Enabled = false;

                    _LoadData();
                    
                }
                else
                    MessageBox.Show("Error: Data is not Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Error: Person Has A New Local Driving License For " + _localDrivingLicenseApplication.ApplicationTypeInfo.ApplicationTypeName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblAppFees.Text = _LicenseClasses.Rows[comboBox1.SelectedIndex][5].ToString();
        }
    }
}
