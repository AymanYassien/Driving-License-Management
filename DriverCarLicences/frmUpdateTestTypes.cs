using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DriverCarLicences
{
    public partial class frmUpdateTestTypes : Form
    {
        int _TTypeID = -1;
        clsTestTypes _test = null;
        public frmUpdateTestTypes(int id )
        {
            InitializeComponent();
            _TTypeID = id;
        }

        private void frmUpdateTestTypes_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            _LoadData();

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

            _test.TestTypeID = this._TTypeID;
            _test.TestTypeDescription = tbDesc.Text.ToString() ;
            _test.TestTypeName = tbtitle.Text.ToString();

            bool isDef = short.TryParse(textBox1.Text.ToString(), out short def);
            _test.DefaultDegree = def;

            bool isDec = decimal.TryParse(tbFee.Text.ToString(), out decimal des);
            _test.TestTypeFee = des;


           // decimal fee = 0;
          //  if (decimal.TryParse(textBox1.Text, out fee))
               // _test.TestTypeFee = fee;

            if (_test.Save())
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error: Data is not Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _ResetDefaultValues()
        {

            // for fun :)
            _test = clsTestTypes.find(_TTypeID);

            tbDesc.Text = string.Empty;
            tbFee.Text = string.Empty;
            tbtitle.Text = string.Empty;
            textBox1.Text = string.Empty;
            blID.Text = "???";

        }  //-

        private void _LoadData()
        {
            _test = clsTestTypes.find(_TTypeID);

            // more check
            if (_test == null)
            {
                MessageBox.Show("No Test Type with ID: " + _TTypeID, "ATestpp Type Not Founded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            blID.Text = _test.TestTypeID.ToString();
            tbtitle.Text = _test.TestTypeName.ToString();
            tbDesc.Text = _test.TestTypeDescription.ToString();
            tbFee.Text  = _test.TestTypeFee.ToString();
            textBox1.Text = _test.DefaultDegree.ToString();

        } // -

        private void tbFee_Validating(object sender, CancelEventArgs e)
        {
            decimal fee = 0;
            if (String.IsNullOrWhiteSpace(tbFee.Text))
            {
                e.Cancel = true;
                tbFee.Focus();
                errorProvider1.SetError(tbFee, "Fee is Required");
            }
            else if (decimal.TryParse(tbFee.Text, out fee) && fee < 0)
            {
                e.Cancel = true;
                tbFee.Focus();
                errorProvider1.SetError(tbFee, "Invalid Fee,  Must number and > 0");

            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(tbFee, "");
            }
        }

       
    }
}
