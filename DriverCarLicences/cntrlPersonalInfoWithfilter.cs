using System;

using System.ComponentModel;

using System.Windows.Forms;

namespace DriverCarLicences
{
    public partial class cntrlPersonalInfoWithfilter : UserControl
    {
        private int _PersonID;
        private clsPerson _Person;
        protected virtual void personSelected(int id)
        {
            Action<int> handler = onPersonSelected;
            if (handler != null)
                handler(id);
        }
        public event Action<int> onPersonSelected;

        
        private bool _showAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _showAddPerson;
            }
            set
            {
                _showAddPerson = value;
                btnAdd.Visible = _showAddPerson;
            }
        }

        private bool _enableFilter = true;
        public bool EnableFilter
        {
            get
            {
                return _enableFilter;
            }
            set 
            {
                _enableFilter = value;
                gbFilter.Enabled = _enableFilter;
            }
        }

        public int PersonID
        {
            get { return ctrlPersonInfo_1.PersonID; }
        }

        public clsPerson Person
        {
            get { return ctrlPersonInfo_1.SelectedPersonInfo; }

        }

        public void loadPersonInfo(int id)
        {
            cbFilterBy.SelectedIndex = 0;
            txtbFilter.Text = id.ToString();
            find();

        }

        private void find()
        {
            if (string.IsNullOrWhiteSpace(txtbFilter.Text))
                txtbFilter.Focus();

                switch (cbFilterBy.Text)
            {
                case "Person ID":
                    ctrlPersonInfo_1.loadPersonInfo(int.Parse(txtbFilter.Text));

                    break;

                case "National Number":
                    ctrlPersonInfo_1.loadPersonInfo(txtbFilter.Text);
                    break;

                default:
                    break;
            }

            

            if (onPersonSelected != null && EnableFilter)
            {
                onPersonSelected(ctrlPersonInfo_1.PersonID);
            }


        }
  
        public cntrlPersonalInfoWithfilter()
        {
            InitializeComponent();
            
        }  

        private void DataBackEvent( object sender, int id)
        {
            cbFilterBy.SelectedIndex = id;
            txtbFilter.Text = id.ToString();
            loadPersonInfo(id);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                
                MessageBox.Show("Some fileds are not valide!," +
                    " put the mouse over the red icon to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            find();
        }

        private void cntrlPersonalInfoWithfilter_Load(object sender, EventArgs e)
        {
            
            cbFilterBy.SelectedIndex = 0;
            txtbFilter.Focus();
        }

        private void txtbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
            }

            if (cbFilterBy.SelectedIndex == 0)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && 
                    ! char.IsControl(e.KeyChar);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd_UpdatePerson add = new frmAdd_UpdatePerson();
            add.DataBack += DataBackEvent;
            add.ShowDialog();
        }

        private void txtbFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbFilter.Text))
            {
                e.Cancel = true;
                //txtbFilter.Focus();
                errorProvider1.SetError(txtbFilter, "This field is required!");
            }
            else
            {
                
                errorProvider1.SetError(txtbFilter, null);
            }

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbFilter.Text = "";
        }

        public void FilterFocus()
        {
            txtbFilter.Focus();
        }
    }
}
