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
    public partial class frmUserDetails : Form
    {
        int _id;
        public frmUserDetails(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            ctrlUser1.loadUserInfo(_id);
        }
    }
}
