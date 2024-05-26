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
    public partial class frmListLocalDrivingApplication : Form
    {
        static DataTable _dtLocalLicenses = clsLocalDrivingLicenseApplication.getAllLocalDrivingLicenseApplication();

        private void _RefreshDataGridView()
        {

            _dtLocalLicenses = clsLocalDrivingLicenseApplication.getAllLocalDrivingLicenseApplication();
            // false = no repeated rows including !



            //_dtSubPople.Rows.Updat
            dataGridView1.DataSource = _dtLocalLicenses;

            lblCounter.Text = dataGridView1.Rows.Count.ToString();

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "L.D.L.AppID";
                dataGridView1.Columns[0].Name = dataGridView1.Columns[0].HeaderText;
                dataGridView1.Columns[0].Width = 80;

                dataGridView1.Columns[1].HeaderText = "Driving class";
                dataGridView1.Columns[1].Width = 200;

                dataGridView1.Columns[2].HeaderText = "National Number";
                dataGridView1.Columns[2].Width = 120;

                dataGridView1.Columns[3].HeaderText = "FullName";
                dataGridView1.Columns[3].Width = 200;

                dataGridView1.Columns[4].HeaderText = "Application Date";
                dataGridView1.Columns[4].Width = 110;

                dataGridView1.Columns[5].HeaderText = "Passed Tests";
                dataGridView1.Columns[5].Width = 110;

                dataGridView1.Columns[6].HeaderText = "Status";
                dataGridView1.Columns[6].Width = 110;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    dataGridView1.Columns[i].Name = dataGridView1.Columns[i].HeaderText;
            }

            comboBox1.SelectedIndex = 0;

        }
        public frmListLocalDrivingApplication()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewLocalDrivingLicenseApplication Fadd = new frmAddNewLocalDrivingLicenseApplication();
            Fadd.ShowDialog();

            _RefreshDataGridView();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dataGridView1.HitTest(e.X, e.Y);

                if (hitTest.Type == DataGridViewHitTestType.Cell && hitTest.RowIndex >= 0)
                {
                    // Right-click on a cell in a row (not on the header)
                    NotSetTitle.Show(dataGridView1, e.Location);
                }
                else
                {
                    // Right-click on the header or outside of the DataGridView
                    // Cancel the context menu strip from showing
                    dataGridView1.ContextMenuStrip = null;
                }
            }
        }

        private void frmListLocalDrivingApplication_Load(object sender, EventArgs e)
        {
            _RefreshDataGridView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Visible = comboBox1.Text != "None";

            if (tbFilter.Visible)
            {
                tbFilter.Text = "";
                tbFilter.Focus();
            }

            _dtLocalLicenses.DefaultView.RowFilter = "";
            lblCounter.Text = dataGridView1.Rows.Count.ToString();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (comboBox1.Text)
            {

                case "L.D.L.AppID":
                    FilterColumn = "LDLAppID";
                    break;

                case "National Number":
                    FilterColumn = "NationalNumber";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Status":
                    FilterColumn = "Status";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }

            if (tbFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtLocalLicenses.DefaultView.RowFilter = "";
                lblCounter.Text = dataGridView1.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "LDLAppID")
                //in this case we deal with integer not string.
                _dtLocalLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilter.Text.Trim());
            else
                _dtLocalLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilter.Text.Trim());

            lblCounter.Text = dataGridView1.Rows.Count.ToString();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.Text == "L.D.L.AppID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showDetail_Click(object sender, EventArgs e)
        {
                FrmLocalDrivingLicenseApplicationInfo frm = 
                    new FrmLocalDrivingLicenseApplicationInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
    
               // MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }  // 1

        private void Updagte_Click(object sender, EventArgs e)
        {
            frmAddNewLocalDrivingLicenseApplication fAdd = new
                frmAddNewLocalDrivingLicenseApplication((int)dataGridView1.CurrentRow.Cells[0].Value);

            fAdd.ShowDialog();
        }  // 2

        private void Delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.findLocalDrivingLicenseApplication((int)dataGridView1.CurrentRow.Cells[0].Value);

            if (LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.Cancel())
                {
                    MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the form again.
                    frmListLocalDrivingApplication_Load(null, null); // = refresh
                }
                else
                {
                    MessageBox.Show("Could not Cancel Applicatoin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }    // 3

        private void Issue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stub");
        }

        private void ShowLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stub");
        }

        private void LicensesHistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stub");
        }


        // menu logiv
    }
}
