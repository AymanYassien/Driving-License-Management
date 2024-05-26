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
    public partial class frmListApplicationTypes : Form
    {

        static DataTable _dtATypes = clsApplicationTypes.getAllAppTypes();

        private void _RefreshDataGridView()
        {

            _dtATypes = clsApplicationTypes.getAllAppTypes();

            //_dtSubPople.Rows.Updat
            dataGridView1.DataSource = _dtATypes;

            lblCounter.Text = dataGridView1.Rows.Count.ToString();

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[0].Width = 120;

                dataGridView1.Columns[1].HeaderText = "Title";
                dataGridView1.Columns[1].Width = 300;

                dataGridView1.Columns[2].HeaderText = "Fees";
                dataGridView1.Columns[2].Width = 120;

            }  

        }
        public frmListApplicationTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshDataGridView();
        }

        private void frmListApplicationTypes_MouseDown(object sender, MouseEventArgs e)
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

        private void updateApplicationTypeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmUpdateApplicationTypes update =new frmUpdateApplicationTypes((int)dataGridView1.CurrentRow.Cells[0].Value);
            update.ShowDialog();

            _RefreshDataGridView();
        }
    }
}
