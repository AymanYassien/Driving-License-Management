using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DriverCarLicences
{
    public partial class ctrlUser : UserControl
    {
        private clsUser _user;
        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }

        public clsUser SelectedUserInfo
        {
            get { return _user; }

        }

        public ctrlUser()
        {
            InitializeComponent();
        }

        public ctrlUser(int  userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void _ResetDefaultValues()
        {
            lblUserID.Text   = "???";
            lblUserID.Text   = "???";
            lblIsActive.Text = "???";

            ctrlPersonInfo_1._ResetDefaultValues();
        }

        public void _FillUserCard()
        {
            lblUserID.Text = _user.UserID.ToString() ;
            lblUserName.Text = _user.UserName.ToString() ;

            if (_user.ISActive == true) lblIsActive.Text = "Yes";
            else lblIsActive.Text = "No";

            ctrlPersonInfo_1.loadPersonInfo(_user.personID) ;



        }

        public void loadUserInfo(int id)
        {
            _UserID = id;
            _user = clsUser.find(id);


            if (_user == null)
            {
                _ResetDefaultValues();
                

                MessageBox.Show("User is not exist", "Error");
                return;
            }

            _FillUserCard();

        }

        
    }
}
