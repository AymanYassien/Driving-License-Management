using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverCarLicences
{
    public partial class frmUpdateApplicationTypes : Form
    {

        int appTypeID = -1;
        clsApplicationTypes _app = null;
        public frmUpdateApplicationTypes(int id)
        {
            InitializeComponent();
            appTypeID = id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid: ", "Put the mouse over the red icon.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            _app.ApplicationTypeID = this.appTypeID;

            decimal fee = 0;
            if (decimal.TryParse(textBox1.Text, out fee))
                _app.ApplicationTypeFee = fee;

            if (_app.Save())
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            else
                MessageBox.Show("Error: Data is not Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _ResetDefaultValues()
        {

            // for fun :)
            _app = clsApplicationTypes.find(appTypeID);

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            blID.Text = "???";

        }

        private void _LoadData()
        {
            _app = clsApplicationTypes.find(appTypeID);

            // more check
            if (_app == null)
            {
                MessageBox.Show("No App Type with ID: " + appTypeID, "App Type Not Founded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            blID.Text = appTypeID.ToString();
            textBox2.Text = _app.ApplicationTypeName.ToString();
            textBox1.Text = _app.ApplicationTypeFee.ToString();

        } 


        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            decimal fee = 0;
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Fee is Required");
            }
            else if (decimal.TryParse(textBox1.Text, out fee) && fee < 0)
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Invalid Fee,  Must number and > 0");

            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(textBox1, "");
            }
        }

        private void frmUpdateApplicationTypes_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
                _LoadData();
   
        }
    }
}
