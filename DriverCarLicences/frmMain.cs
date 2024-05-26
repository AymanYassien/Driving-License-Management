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

    public partial class frmMain : Form
    {
        
        frmLogin _frmLogin;
        public frmMain(frmLogin frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPeople people = new frmListPeople();
            people.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented Yet!", "Stub");
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers users = new frmListUsers();
            users.ShowDialog();
        }




        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword changePassword = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            changePassword.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails showUser = new frmUserDetails(clsGlobal.CurrentUser.UserID);
            showUser.ShowDialog();
        }

        private void LocalLicense_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Stub");

            frmAddNewLocalDrivingLicenseApplication local = new frmAddNewLocalDrivingLicenseApplication();
            //local.DataBack += DataBackEvent;
            local.ShowDialog();
        }

        private void InternationalLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stub");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stub");
        }

        private void ReplacementForLostOrDamagedLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stub");
        }

        private void ReleaseDetainedDrivingLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stub");
        }

        private void RetakeTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stub");
        }

        private void LocalDrivingLicense_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Stub");
            frmListLocalDrivingApplication flApp = new frmListLocalDrivingApplication();
            flApp.ShowDialog();
        }

        private void InternationalLicenseApplications_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stub");
        }

        private void ManageDetainedLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stub");
        }

        private void DetainLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stub");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stub");
        }

        private void ManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmListApplicationTypes frm = new frmListApplicationTypes();
            frm.ShowDialog();
        }

        private void ManageTestTypes_Click(object sender, EventArgs e)
        {
            frmTestTypes frm__ = new frmTestTypes();
            frm__.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmLogin.Show(); 
        }
    }
}
