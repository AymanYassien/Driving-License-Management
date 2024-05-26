using System;
using System.IO;


using System.Windows.Forms;
using static DriverCarLicences.clsPerson;

namespace DriverCarLicences
{
    public partial class ctrlPersonInfo_ : UserControl
    {
        private clsPerson _person;

        private int _personID = -1;

        public int PersonID
        {
             get { return _personID; }
        }

        public clsPerson  SelectedPersonInfo
        {
           get { return  _person; }

        }

        public ctrlPersonInfo_()
        {

            InitializeComponent();
            
        }

        public ctrlPersonInfo_(int id)
        {

            InitializeComponent();
            _personID = id;

        }

        // must private by default
        public void _ResetDefaultValues()
        {
            lblname.Text = "???";
            lblPhone.Text = "???";
            lblNational.Text = "???";
            lblCountry.Text = "???";
            lblAddress.Text = "???";
            lblEmail.Text = "???";
            lblGendor.Text = "???";
            blID.Text = "???";
            lblDate.Text = "???";
            pbPersonImage.Image = Properties.Resources.Male_512_2_;
            llEditPersonalInfo.Visible = false;

        }

        public void _FillPersonCard()
        {
            llEditPersonalInfo.Visible = true;

            lblname.Text = _person.FullName;
            lblPhone.Text = _person.Phone;
            lblNational.Text = _person.NationalNumber;
            lblCountry.Text = _person.countryInfo.CountryName;
            lblAddress.Text = _person.Address;
            lblEmail.Text = _person.Email;
            lblGendor.Text = _person.gender == 0 ? "Male" : "Female"; 
            blID.Text = _person.PersonId.ToString();
            lblDate.Text = _person.DateOfBirth.ToString();
            LoadPersonImage();




        }

        private void LoadPersonImage()
        {

            if (_person.gender == 0) pbPersonImage.Image = Properties.Resources.Male_512_2_;
            else pbPersonImage.Image = Properties.Resources.Female_512_1_;

            if (_person.imagePath != null) 
                if (File.Exists(_person.imagePath))
                    pbPersonImage.ImageLocation = _person.imagePath;
                else
                    MessageBox.Show("Cannot load Image", "Error");

        }

        public void loadPersonInfo(int id)
        {
            _personID = id;
            _person = clsPerson.find(id);

            if(_person == null ) 
            {
                _ResetDefaultValues();
                MessageBox.Show("Person is not exist", "Error");
                return;
            }

            _FillPersonCard();

        }

        public void loadPersonInfo(string national)
        {
            _person = clsPerson.find(national);
            _personID =  _person.PersonId;

            if (_person == null)
            {
                _ResetDefaultValues();
                MessageBox.Show("Person is not exist", "Error");
                return;
            }

            _FillPersonCard();

        }

        private void llEditPersonalInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdd_UpdatePerson form = new frmAdd_UpdatePerson(_personID);
            form.ShowDialog();

            // Refresh
            loadPersonInfo(PersonID);
        }
    }
}
