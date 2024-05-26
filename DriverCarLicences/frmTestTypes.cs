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
    public partial class frmTestTypes : Form
    {
        public frmTestTypes()
        {
            InitializeComponent();
        }

        static DataTable _dtTTypes = clsTestTypes.getAllTestTypes();
        

        private void _RefreshDataGridView()
        {

            _dtTTypes = clsTestTypes.getAllTestTypes();

            //_dtSubPople.Rows.Updat
            dataGridView1.DataSource = _dtTTypes;

            lblCounter.Text = dataGridView1.Rows.Count.ToString();

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[0].Width = 70;

                dataGridView1.Columns[1].HeaderText = "Title";
                dataGridView1.Columns[1].Width = 80;

                dataGridView1.Columns[2].HeaderText = "Description";
                dataGridView1.Columns[2].Width = 200;

                dataGridView1.Columns[3].HeaderText = "Fees";
                dataGridView1.Columns[3].Width = 70;

                dataGridView1.Columns[4].HeaderText = "Default Pass";
                dataGridView1.Columns[4].Width = 70;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

     

        private void frmTestTypes2_Load(object sender, EventArgs e)
        {
            _RefreshDataGridView();
        }

        private void updateApplicationTypeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmUpdateTestTypes update = new frmUpdateTestTypes((int)dataGridView1.CurrentRow.Cells[0].Value);
            update.ShowDialog();

            _RefreshDataGridView();

        }

        private void frmTestTypes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dataGridView1.HitTest(e.X, e.Y);

                if (hitTest.Type == DataGridViewHitTestType.Cell && hitTest.RowIndex >= 0)
                {
                    // Right-click on a cell in a row (not on the header)
                    contextMenuStrip1.Show(dataGridView1, e.Location);
                }
                else
                {
                    // Right-click on the header or outside of the DataGridView
                    // Cancel the context menu strip from showing
                    dataGridView1.ContextMenuStrip = null;
                }
            }
        }
    }
}
