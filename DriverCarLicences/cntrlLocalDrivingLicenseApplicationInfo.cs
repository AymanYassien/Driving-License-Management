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
    public partial class cntrlLocalDrivingLicenseApplicationInfo : UserControl
    {
        public int LocalDrivingLicenseID = -1;
        clsLocalDrivingLicenseApplication _localLicenseInfo;
        public cntrlLocalDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
            
        }

        public void LoadApplicationInfoByID(int LocalDrivingLicenseApplicationID)
        {
            LocalDrivingLicenseID = LocalDrivingLicenseApplicationID;
            _localLicenseInfo = clsLocalDrivingLicenseApplication.findLocalDrivingLicenseApplication(LocalDrivingLicenseID);
            if (_localLicenseInfo == null )
            {
                resetDefaultValues();
                MessageBox.Show("Not Found Application", "Error");

                linkLabel1.Enabled = false;
                return;
            }
            FillInfo();
        }

       
        private void FillInfo()
        {

           
            DrivingLicenseInfoID.Text = _localLicenseInfo.LocalDrivingLicenseApplicationID.ToString();
            AppliedForLicenseClass.Text = clsManageLicenseClasses.getLicenseClassInfoByID(_localLicenseInfo.LicenseClassID).ToString();
            PassedTests.Text = "Soon";
            ApplicationID.Text = _localLicenseInfo.ApplicationID.ToString();
            Status.Text = _localLicenseInfo.statusText.ToString();
            Fees.Text = _localLicenseInfo.paidFees.ToString();
            ApplicationType.Text = "Local Driving License Application Info ";
            Applicant.Text = _localLicenseInfo.PersonInfo.FullName.ToString();
            StatusDate.Text = _localLicenseInfo.LastStatusDate.ToString();
            Date.Text = _localLicenseInfo.ApplicationDate.ToString();
            UserCreated.Text = _localLicenseInfo.UserInfo.UserName;
        }

        private void resetDefaultValues()
        {
            
            DrivingLicenseInfoID.Text ="[???]";
            AppliedForLicenseClass.Text = "[???]";
            PassedTests.Text = "Soon";
            ApplicationID.Text = "[???]";
            Status.Text = "[???]";
            Fees.Text = "[???]";
            ApplicationType.Text = "[???]";
            Applicant.Text = "[???]";
            StatusDate.Text = "[???]";
            Date.Text = "[???]";
            UserCreated.Text = "[???]";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Stub");
        }

        private void llEditPersonalInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails personDetails = new frmPersonDetails(_localLicenseInfo.PersonID);
            personDetails.ShowDialog();
        }
    }
}
