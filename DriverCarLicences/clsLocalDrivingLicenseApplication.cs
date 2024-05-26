using System;
using System.Data;
using System.Data.SqlClient;


namespace DriverCarLicences
{
    
    public class clsLocalDrivingLicenseApplication
    {
        
        
        public enum enMode { addNew = 0, update = 1 };
        enMode mode = enMode.addNew;

        // --------------------
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        // -------------------
        public int ApplicationID { get; set; }

        int _personID = -1;
        public int PersonID 
        {
            get
            {
                return _personID;
            }
            set
            {
                _personID = value;
                PersonInfo = clsPerson.find(this.PersonID);
            }
        }
       
        public DateTime ApplicationDate { get; set; }

        private int _ApplicationTypeID = 1;
        public int AppTypeID 
        {
            get
            {
                return _ApplicationTypeID;
            }
            set
            {
                _ApplicationTypeID = value;
                ApplicationTypeInfo = clsApplicationTypes.find(this._ApplicationTypeID);
                

            }
        }
        public byte AppStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal paidFees { get; set; }
        public int createdByUserID { get; set; }

        public clsPerson PersonInfo;
        public clsApplicationTypes ApplicationTypeInfo;
        public clsUser UserInfo;

        public string statusText
        {
            get
            {
                switch(AppStatus)
                {
                    case 1:
                        return "NEW";
                    case 2:
                        return "Cancelled";
                    case 3:
                        return "Completed";
                    default:
                        return "UnKnown";
                }
            }
        }

        public clsLocalDrivingLicenseApplication()
        {
            ApplicationID = -1;
            PersonID = -1;
            ApplicationDate = DateTime.Now;
            AppTypeID = 1;
            ApplicationTypeInfo = clsApplicationTypes.find(AppTypeID);

            AppStatus = 0;
            LastStatusDate = DateTime.Now;
            paidFees = 0;
            createdByUserID = clsGlobal.CurrentUser.UserID;
        }

        private clsLocalDrivingLicenseApplication(int LocalDLID, int ApplicationID, int PersonID, DateTime ApplicationDate,
           int AppTypeID, byte AppStatus, DateTime LastStatusDate, decimal paidFees, int createdByUserID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDLID;
            this.ApplicationID   = ApplicationID ;
            this.PersonID        = PersonID ;
            this.ApplicationDate = ApplicationDate;
            this.AppTypeID       = AppTypeID;
            this.AppStatus       = AppStatus;
            this.LastStatusDate  = LastStatusDate ;
            this.paidFees        = paidFees;
            this.createdByUserID = createdByUserID;
            this.LicenseClassID  = LicenseClassID;
            //PersonInfo = clsPerson.find(this.PersonID);
            
            UserInfo = clsUser.find(createdByUserID);

        mode = enMode.update;
        }

        private bool _addNewApplication()
        {
            this.ApplicationID = clsLocalDrivingLicenseApplicationData.AddNewAplication(this.PersonID, this.ApplicationDate,
                this.AppTypeID, this.AppStatus, this.LastStatusDate, this.paidFees, this.createdByUserID);

            return (this.ApplicationID != -1);
        }

        private bool _updateApplication()
        {
            return
             clsLocalDrivingLicenseApplicationData.UpdateAplication(this.ApplicationID, this.PersonID, this.ApplicationDate,
                this.AppTypeID, this.AppStatus, this.LastStatusDate, this.paidFees, this.createdByUserID);
        }

        public bool Save()
        {

            
            switch (mode)
            {
                case enMode.addNew:
                    if (_addNewLocalDrivingLicenseApplication())
                    {
                        mode = enMode.update;
                        return true;
                    }
                    else
                        return false;

                case enMode.update:
                    return _updateLocalDrivingLicenseApplication();

            }

            return false;
        }

        public static clsLocalDrivingLicenseApplication findLocalDrivingLicenseApplication(int LocalDLID)
        {

            int ApplicationID = -1;
            int PersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int AppTypeID = -1;
            byte AppStatus = 0;
            DateTime LastStatusDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = clsGlobal.CurrentUser.UserID;
            int LicenseClassID = 0;


            bool isFound = clsLocalDrivingLicenseApplicationData.
                getLocalDrivingLicenseAplicationByLDLApplicationID(LocalDLID, ref ApplicationID,  ref PersonID, ref ApplicationDate,
           ref AppTypeID, ref AppStatus, ref LastStatusDate, ref paidFees, ref createdByUserID, ref LicenseClassID);

            if (isFound)
                return new clsLocalDrivingLicenseApplication(LocalDLID, ApplicationID, PersonID, ApplicationDate,
            AppTypeID, AppStatus, LastStatusDate, paidFees, createdByUserID, LicenseClassID);
            else
                return null;
        }

        public static DataTable getAllLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationData.getAllLocalDrivingLicenseApplications();
        }

        public static bool isPersonHasANewAppointmentFromSameLicenseClass(string PersonNational, string ApplicationClass)
        {
            return clsLocalDrivingLicenseApplicationData.isPersonHasANewAppointmentFromSameLicenseClass(PersonNational, ApplicationClass);
        }

        public bool Cancel()
        {
            return clsLocalDrivingLicenseApplicationData.UpdateStatus(ApplicationID, 2);
        }

        public bool setComplete()
        {
            return clsLocalDrivingLicenseApplicationData.UpdateStatus(ApplicationID, 3);
        }

        // ---------------------------------------------------------------------------------------
        //can separateThis code into new class inherit current one | LocalDrivingLicenseApplications ..
        //if do that .. check Save function 


        private  bool _addNewLocalDrivingLicenseApplication()
        {
            if(_addNewApplication())
            {
                this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplications(
                    this.ApplicationID, this.LicenseClassID); 
            }
            

            return this.LocalDrivingLicenseApplicationID != -1;
        }


        private bool _updateLocalDrivingLicenseApplication()
        {
            if (_updateApplication())
            {
                return
                 clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseAplication(this.LocalDrivingLicenseApplicationID, this.LicenseClassID);
            }
            return false;
        }

        // --------------------------------------------------------------------------------------------------

    }
}
