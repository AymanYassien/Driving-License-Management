using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DriverCarLicences
{
    public partial class frmListPeople : Form
    {
        //static public string ConnectionString = "Server=192.168.88.12,1433;Database=DriverCarLicense;User ID=sa;Password=Docker@123;";

        static DataTable _dtAllPeople = clsPerson.getAllPeople();
        // false = no repeated rows including !
        DataTable _dtSubPople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNumber", "FirstName",
            "SecondName", "ThirdName", "LastName", "Gender", "DateOfBirth", "CountryName", "Phone", "Email"
            );

        private void _RefreshDataGridView()
        {

            _dtAllPeople = clsPerson.getAllPeople();
            // false = no repeated rows including !
            DataTable _dtSubPople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNumber", "FirstName",
                "SecondName", "ThirdName", "LastName", "Gender", "DateOfBirth", "CountryName", "Phone", "Email"
                );


            //_dtSubPople.Rows.Updat
            dataGridView1.DataSource = _dtSubPople;

            lblCounter.Text =  dataGridView1.Rows.Count.ToString();

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "Person ID";
                dataGridView1.Columns[0].Width = 100;

                dataGridView1.Columns[1].HeaderText = "Nationality";
                dataGridView1.Columns[1].Width = 100;

                dataGridView1.Columns[2].HeaderText = "First Name";
                dataGridView1.Columns[2].Width = 110;

                dataGridView1.Columns[3].HeaderText = "Second Name";
                dataGridView1.Columns[3].Width = 110;

                dataGridView1.Columns[4].HeaderText = "Third Name";
                dataGridView1.Columns[4].Width = 110;

                dataGridView1.Columns[5].HeaderText = "Last Name";
                dataGridView1.Columns[5].Width = 110;

                dataGridView1.Columns[6].HeaderText = "Gendor";
                dataGridView1.Columns[6].Width = 80;

                dataGridView1.Columns[7].HeaderText = "Date of Birth";
                dataGridView1.Columns[7].Width = 130;

                dataGridView1.Columns[8].HeaderText = "Country Name";
                dataGridView1.Columns[8].Width = 100;

                dataGridView1.Columns[9].Width = 90;
                dataGridView1.Columns[9].HeaderText = "Phone";

                dataGridView1.Columns[10].HeaderText = "Email";
                dataGridView1.Columns[10].Width = 140;

            }

        }

        private void _fillcomboboxByColumnNames()
        {
            foreach (DataColumn column in _dtSubPople.Columns)
            {
                //if (column.ColumnName != String.Empty)
                comboBox1.Items.Add(column.ColumnName);

            }
            comboBox1.SelectedIndex = 0;
        }

        private void _sortListPeopleBy(string filter)
        {

            //DataRow[] filteredRows = result.Select("", $"{filter} Asc");
            //dataGridView1.DataSource = result;

            DataRow[] filteredRows = _dtSubPople.Select("", $"{filter} ASC");
            DataTable sortedDataTable = _dtSubPople.Clone(); // Clones the structure of the original DataTable

            // Add the sorted rows to the new DataTable
            foreach (DataRow row in filteredRows)
            {
                sortedDataTable.ImportRow(row);
            }

            // Bind the sorted DataTable to the DataGridView
            dataGridView1.DataSource = sortedDataTable;


        }
        public frmListPeople()
        {
            InitializeComponent();
        }

        private void ManagePeople_Load(object sender, EventArgs e)
        {

            

            _RefreshDataGridView();



            _fillcomboboxByColumnNames();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _sortListPeopleBy(comboBox1.SelectedItem.ToString());
        }

        // -----------------------------------------------------------------------------
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
            frmPersonDetails formDetails =
                new frmPersonDetails((int)dataGridView1.CurrentRow.Cells[0].Value);
            formDetails.ShowDialog();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            frmAdd_UpdatePerson Fadd = new frmAdd_UpdatePerson();
            Fadd.ShowDialog();

            _RefreshDataGridView();
        }

        private void Updagte_Click(object sender, EventArgs e)
        {
            frmAdd_UpdatePerson Fadd =
                new frmAdd_UpdatePerson((int)dataGridView1.CurrentRow.Cells[0].Value);
            Fadd.ShowDialog();

            _RefreshDataGridView();

        }

        private void email_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will apply Sooon", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Delete_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure you want to delete Person with ID: " + dataGridView1.CurrentRow.Cells[0].Value,
                "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (clsPerson.DeletePerson((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully", "Success");
                }
                else
                    MessageBox.Show("Person was not Deleted, Beacuse its have an integrity ", "Error");
            }


            _RefreshDataGridView();
        }

        private void phone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will apply Sooon", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd_UpdatePerson Fadd = new frmAdd_UpdatePerson();
            Fadd.ShowDialog();

            _RefreshDataGridView();
        }
    }

  



 }





