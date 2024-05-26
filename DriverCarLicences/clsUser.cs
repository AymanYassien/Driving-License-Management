using System;
using System.Data;


namespace DriverCarLicences
{
    public class clsUser
    {
        public enum enMode { addNew = 0, update = 1 };
        enMode mode = enMode.addNew;

        public int UserID { get; set; }
        public int  personID {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        public bool ISActive { get; set; }

        public clsPerson PersonInfo;

        //public bool ISActive { get; set; }

        public clsUser ()
        {
            personID = -1;
            UserID = -1;
            UserName = "";
            Password    = string.Empty;
            Permissions = -1;
            ISActive = false;
        }

        private clsUser(int userID, int personID, string userName, string password,
            int permissions, bool isActive)
        {
            this.personID = personID;
            this.UserID = userID;
            this.UserName = userName;
            this.Password = password;
            this.Permissions = permissions;
            this.ISActive = isActive;

           
            this.PersonInfo = clsPerson.find(this.personID);

            mode = enMode.update;

        }

        private bool _addNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.personID, this.UserName, this.Password, this.ISActive, this.Permissions);

            return (this.UserID != -1);
        }

        private bool _updateUser()
        {
            return
             clsUserData.updateUser(this.UserID, this.personID, this.UserName, this.Password, this.ISActive, this.Permissions);
        }

        public static clsUser find(int userID)
        {
            int personID = -1, permissions = -1;
            string userName = "", password = "";
            bool isActive = false;


            bool isFound = clsUserData.getUserInfoByUserID(userID, ref personID, ref userName, ref password, ref isActive, ref permissions);

            if (isFound)
                return new clsUser(userID, personID, userName, password, permissions, isActive);
            else
                return null;
        }

        public static clsUser findUserByUNAndPwd(string userName, string password)
        {
            int personID = -1, permissions = -1, userID = -1;
            //string userName = "", password = "";
            bool isActive = false;


            bool isFound = clsUserData.getUserInfoByUserNammeAndPassword(ref userID, ref personID,  userName,  password, ref isActive, ref permissions);

            if (isFound)
                return new clsUser(userID, personID, userName, password, permissions, isActive);
            else
                return null;
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.addNew:
                    if (_addNewUser())
                    {
                        mode = enMode.update;
                        return true;
                    }
                    else
                        return false;

                case enMode.update:
                    return _updateUser();

            }

            return false;
        }
        public static DataTable getAllUsers()
        {
            return clsUserData.getAllUsers();
        }

        public static bool DeleteUser(int ID)
        {
            return clsUserData.DeleteUser(ID);
        }

        public static bool isUserExist(int ID)
        {
            return clsUserData.isUserExist(ID);
        }

        public static bool isUserExist(string userName)
        {
            return clsUserData.isUserExist(userName);
        }

        public static bool isPersonHasAUser(int PersonID)
        {
            return clsUserData.isPersonHasAUser(PersonID);
        }

    }
}
