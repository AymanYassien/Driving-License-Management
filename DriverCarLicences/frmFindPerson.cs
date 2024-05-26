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
    public partial class frmFindPerson : Form
    {
       //   never used in project


        public  delegate void DataBackEventHandler(object sender, int ID);
        public event DataBackEventHandler DataBack;
        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void FindPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBack?.Invoke(this, cntrlPersonalInfoWithfilter1.PersonID);
        }
    }
}
