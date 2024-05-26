using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using DriverCarLicences.Properties;

namespace DriverCarLicences
{
    public partial class frmAdd_UpdatePerson : Form
    {

        public delegate void DataBackEventHandler(object sender, int personID);
        public event DataBackEventHandler DataBack;

        enum enMode { Add = 0, Update = 1 }
        enMode _Mode = enMode.Update;

        int _personID = -1;

        clsPerson _person; // !!

        private string uploadedImagePath = string.Empty;  // tricky 
        
        public frmAdd_UpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public frmAdd_UpdatePerson(int personID)
        {
            InitializeComponent();

            _personID = personID ;
            _Mode = enMode.Update;

        }
        
        private void _LoadData()
        {
            _person = clsPerson.find(_personID);

            // more check
            if (_person == null)
            {
                MessageBox.Show("No Person with ID: " + _personID, "Person Not Founded", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblPersonIDValue.Text = _personID.ToString();
            tbFirstName.Text = _person.FirstName;
            tbSecondName.Text = _person.SecondName;
            tbThirdName.Text = _person.ThirdName;
            tbEmail.Text = _person.Email;
            tbLastName.Text = _person.LastName;
            tbNationalNumber.Text = _person.NationalNumber;
            tbAddress.Text = _person.Address;
            mtbPhone.Text = _person.Phone;
            dtpDate.Value = _person.DateOfBirth;

            if (_person.gender == 0)
                rbMale.Checked = true;
            else rbFemale.Checked = true;

            cbCountries.SelectedIndex = cbCountries.FindString(_person.countryInfo.CountryName);

            if (_person.gender == 1) pbPersonImage.Image = Properties.Resources.Female_512_1_;
            else pbPersonImage.Image = Properties.Resources.Male_512_2_;

            if (_person.imagePath != null)
                pbPersonImage.ImageLocation = _person.imagePath;
            
            // default image was setted and rb changed event eill handle it;
            
                llDeleteImage.Visible = (_person.imagePath != "");
            
            


        } 

        private bool  _HandleImage()
        {
            /*
             this function aim to handle img bath in system .

            the user actually has one of three options to handle his image
            1- add , 2- delete if exist, 3- delete if exist then add (update).

            the first if perform delete if exist  .. which mean form in update mode .. mean his data in object .. so chk if there r img or not
            the second chk if user add an img .. so that perform copy it to function 

            add use second one
            delete use first one
            update use both 

            where call this function?

            in save, before fill obj ,
            so if user delete => delete it first 
            if add just add it first and rename it then fill obj.


             */


            // idea, where call
            if(_person.imagePath != pbPersonImage.ImageLocation)
            {
                if (_person.imagePath != "")
                {
                    try
                    {
                        File.Delete(_person.imagePath);

                    }catch(IOException iox)
                    {
                        //MessageBox.Show(iox.Message, "Error");
                    }

                    
                }

                if (pbPersonImage.ImageLocation != "")
                {
                    string srcImgFile = pbPersonImage.ImageLocation.ToString();

                    if(clsUtil.CopyImageToProjectImageFolder(ref srcImgFile))
                    {
                        pbPersonImage.ImageLocation = srcImgFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Coping Image", "Error");
                        return false;

                    }
                        

                }



            }
            return true;
        }
        private void Add_UpdatePerson_Load(object sender, EventArgs e)
        {
            //dtpDate.MaxDate = DateTime.Now.AddYears(-18);
            //getAllCountriesName();
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
            {
                
                _LoadData();
            }
                
            

        } 

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            /*nullable
             * contain " @ . " but not followed them & between more 1, not start, not end
             */

            int chkDot = tbEmail.Text.IndexOf("@");
            if (!((tbEmail.Text.Contains("@")
                && tbEmail.Text.Contains('.')
                && !tbEmail.Text.EndsWith("@")
                && !tbEmail.Text.EndsWith(".")
                && !tbEmail.Text.StartsWith("@")
                && !tbEmail.Text.StartsWith("@")
                && tbEmail.Text[chkDot  + 1] != '.'
                && tbEmail.Text[chkDot + 1] != '.'
                ) || String.IsNullOrWhiteSpace(tbEmail.Text)))
            {
                e.Cancel = true;
                tbEmail.Focus();
                errorProvider1.SetError(tbEmail, "Email is not valid");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbEmail, "");
            }

            // OR 
            /*
            try { new System.Net.Mail.MailAddress(tbEmail.Text); }
            catch (FormatException) { }
            */

        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                e.Cancel = true;
                tbFirstName.Focus();
                errorProvider1.SetError(tbFirstName, "First Name is Required");
            }
            else if (tbFirstName.Text.Length < 3)
            {
                e.Cancel = true;
                tbFirstName.Focus();
                errorProvider1.SetError(tbFirstName, "First Name is not valid");

            }
            else if (!Regex.IsMatch(tbFirstName.Text, @"^[a-zA-Z]+$"))
            {
                e.Cancel = true;
                tbFirstName.Focus();
                errorProvider1.SetError(tbFirstName, "First Name is not valid");

            }
            else
            {
                e.Cancel = false;
                
                errorProvider1.SetError(tbFirstName, "");
            }
        }

        private void tbSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbSecondName.Text))
            {
                e.Cancel = true;
                tbSecondName.Focus();
                errorProvider1.SetError(tbSecondName, "Second Name is Required");
            }
            else if (tbSecondName.Text.Length < 3)
            {
                e.Cancel = true;
                tbSecondName.Focus();
                errorProvider1.SetError(tbSecondName, "Second Name is not valid");

            }
            else if (!Regex.IsMatch(tbSecondName.Text, @"^[a-zA-Z]+$"))
            {
                e.Cancel = true;
                tbSecondName.Focus();
                errorProvider1.SetError(tbSecondName, "Second Name is not valid");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbSecondName, "");
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbLastName.Text)
                || tbLastName.Text.Length < 3
                || !Regex.IsMatch(tbLastName.Text, @"^[a-zA-Z]+$"))
            {
                e.Cancel = true;
                tbSecondName.Focus();
                errorProvider1.SetError(tbLastName, "Last Name is not valid");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbLastName, "");
            }

        }

        private void tbNationalNumber_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrWhiteSpace(tbNationalNumber.Text))
            {
                e.Cancel = true;
                tbNationalNumber.Focus();
                errorProvider1.SetError(tbNationalNumber, "National is Required");
            }
            else if (tbNationalNumber.Text.Length < 3)
            {
                e.Cancel = true;
                tbNationalNumber.Focus();
                errorProvider1.SetError(tbNationalNumber, "National number is not valid");

            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(tbNationalNumber, "");
            }

            if (tbNationalNumber.Text != _person.NationalNumber && clsPerson.isPersonExist(tbNationalNumber.Text.Trim()))
            {
                e.Cancel = true;
                tbNationalNumber.Focus();
                errorProvider1.SetError(tbNationalNumber, "National Number is Exist ");

            }


        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string imageLocation = string.Empty;
            try
            {
                OpenFileDialog imageDialog = new OpenFileDialog();

                imageDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*;";

                if (imageDialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = imageDialog.FileName;
                    pbPersonImage.ImageLocation = imageLocation;

                }
                uploadedImagePath = imageLocation;
                llDeleteImage.Visible = true;
            }
            catch (Exception){
                MessageBox.Show("Error when open image");
            }

        }

        private void llDeleteImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(rbMale.Checked)
            pbPersonImage.Image = Properties.Resources.Male_512_2_;
            else
                pbPersonImage.Image = Properties.Resources.Female_512_1_;

            uploadedImagePath = string.Empty;
            llDeleteImage.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            /*tbEmail.Text = String.Empty;
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbNationalNumber.Text = string.Empty;
            tbSecondName.Text = string.Empty;
            tbThirdName.Text = string.Empty;
            tbAddress.Text = string.Empty;
            mtbPhone.Text = string.Empty;
            pbPersonImage.Image = Properties.Resources.Male_512_2_;*/

            this.Close();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(uploadedImagePath == string.Empty)
                pbPersonImage.Image = Properties.Resources.Male_512_2_;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (uploadedImagePath == string.Empty)
                pbPersonImage.Image = Properties.Resources.Female_512_1_;
        }
        private void _fillcomboboxByCountries()
        {
            DataTable dt = clsCountryData.getAllCountries();

            foreach (DataRow row in dt.Rows)
                cbCountries.Items.Add(row["CountryName"]); 
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            // ----------------------------------------------------------------------
            if (! this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid: " , "Put the mouse over the red icon.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                
            }

            if (!_HandleImage())
            {
                return;
            }
            //                                 find return obj
            int nationalCountryID = clsCountry.find(cbCountries.Text).CountryId;

            _person.FirstName = tbFirstName.Text.Trim();
            _person.SecondName = tbSecondName.Text.Trim();
            _person.ThirdName = tbThirdName.Text.Trim();
            _person.LastName = tbLastName.Text.Trim();
            _person.Email = tbEmail.Text.Trim();
            _person.Phone = mtbPhone.Text.Trim();
            _person.Address = tbAddress.Text.Trim();
            _person.DateOfBirth = dtpDate.Value;    
            _person.NationalNumber =  tbNationalNumber.Text.Trim();
            _person.NationalCountryID = nationalCountryID;

            if (rbMale.Checked) _person.gender = 0;
            else _person.gender = 1;

            if (pbPersonImage.ImageLocation != "")
                _person.imagePath = pbPersonImage.ImageLocation;
            else _person.imagePath = "";

            if (_person.Save())
            {
                lblPersonIDValue.Text = _person.PersonId.ToString();
                _Mode = enMode.Update;
                lblBodyTitle.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Trigger the event to send 
                DataBack?.Invoke(this, _person.PersonId);
                
                //this.Close();
            }
            else
                MessageBox.Show("Error: Data is not Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        } 

        private void mtbPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbLastName.Text))
            {
                
                mtbPhone.Focus();
                errorProvider1.SetError(mtbPhone, "Last Name is not valid");

            }
            else
            {
                
                errorProvider1.SetError(mtbPhone, "");
            }

        }

       private void _ResetDefaultValues()
        {
            _fillcomboboxByCountries();

            if (_Mode == enMode.Add)
            {
                lblBodyTitle.Text = "Add New Person";
                _person = new clsPerson();
            }
            else
                lblBodyTitle.Text = "Update Person";

            // can delete this and next if statement
            if (uploadedImagePath == string.Empty && rbMale.Checked)
                pbPersonImage.Image = Properties.Resources.Male_512_2_;

            if (uploadedImagePath == string.Empty && rbFemale.Checked)
                pbPersonImage.Image = Properties.Resources.Female_512_1_;

            llDeleteImage.Visible = (uploadedImagePath != string.Empty);

            dtpDate.MaxDate = DateTime.Now.AddYears(-18);
            dtpDate.Value   = dtpDate.MaxDate;

            dtpDate.MinDate = DateTime.Now.AddYears(-120);

            cbCountries.SelectedIndex = cbCountries.FindString("Egypt");


            rbMale.Checked = true;
            tbEmail.Text = String.Empty;
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbNationalNumber.Text = string.Empty;
            tbSecondName.Text = string.Empty;
            tbThirdName.Text = string.Empty;
            tbAddress.Text = string.Empty;
            mtbPhone.Text = string.Empty;
            pbPersonImage.Image = Properties.Resources.Male_512_2_;




        } 

        
    }
}

