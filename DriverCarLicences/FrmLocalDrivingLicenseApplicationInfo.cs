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
    public partial class FrmLocalDrivingLicenseApplicationInfo : Form
    {
        int _applicationID = -1;
        public FrmLocalDrivingLicenseApplicationInfo(int applicationID)
        {
            InitializeComponent();
            _applicationID = applicationID;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            cntrlLocalDrivingLicenseApplicationInfo1.LoadApplicationInfoByID(_applicationID);
        }
    }
}
