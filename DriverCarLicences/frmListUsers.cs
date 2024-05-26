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
    public partial class frmListUsers : Form
    {
        static DataTable _dtUsers = clsUser.getAllUsers();

        private void _RefreshDataGridView()
        {

            _dtUsers = clsUser.getAllUsers();
            // false = no repeated rows including !
            


            //_dtSubPople.Rows.Updat
            dataGridView1.DataSource = _dtUsers;

            lblCounter.Text = dataGridView1.Rows.Count.ToString();

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "User ID";
                dataGridView1.Columns[0].Width = 80;

                dataGridView1.Columns[1].HeaderText = "Person ID";
                dataGridView1.Columns[1].Width = 80;

                dataGridView1.Columns[2].HeaderText = "Full Name";
                dataGridView1.Columns[2].Width = 300;

                dataGridView1.Columns[3].HeaderText = "UserName";
                dataGridView1.Columns[3].Width = 110;

                

                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Is Active";

                //dataGridView1.Columns[4].HeaderText = "Is Active";
                dataGridView1.Columns[4].Width = 110;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string isActiveValue = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    if (isActiveValue.ToUpper() == "YES") 
                    
                        dataGridView1.Rows[i].Cells[4].Value = true; 
                    
                }




            }

            comboBox1.SelectedIndex = 0;

        }
        public frmListUsers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_Add_UpdateUser Fadd = new frm_Add_UpdateUser();
            Fadd.ShowDialog();

            _RefreshDataGridView();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
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

        private void showDetail_Click(object sender, EventArgs e)
        {
            frmUserDetails details = new frmUserDetails((int)dataGridView1.CurrentRow.Cells[0].Value);
            details.ShowDialog();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            frm_Add_UpdateUser Fadd =
                new frm_Add_UpdateUser();
            Fadd.ShowDialog();

            _RefreshDataGridView();

        }

        private void Updagte_Click(object sender, EventArgs e)
        {
            frm_Add_UpdateUser Fadd =
                        new frm_Add_UpdateUser((int)dataGridView1.CurrentRow.Cells[0].Value);
            Fadd.ShowDialog();

            _RefreshDataGridView();
        }

        private void chPwd_Click(object sender, EventArgs e)
        {
            frmChangePassword details = new frmChangePassword((int)dataGridView1.CurrentRow.Cells[0].Value);
            details.ShowDialog();
        }

        private void email_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will apply Sooon", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void phone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will apply Sooon", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User  with ID: " + dataGridView1.CurrentRow.Cells[0].Value,
                "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (clsUser.DeleteUser((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully", "Success");
                }
                else
                    MessageBox.Show("User was not Deleted, Beacuse its have an integrity ", "Error");
            }


            _RefreshDataGridView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0 )
            {
                tbFilter.Visible = false;
                _RefreshDataGridView();

            }
            else 
            
                tbFilter.Visible = true;
                

        }
    }
}
