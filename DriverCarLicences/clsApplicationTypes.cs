using System;
using System.Data;


namespace DriverCarLicences
{
    public class clsApplicationTypes
    {
        public string ApplicationTypeName { get; set; }
        public int ApplicationTypeID { get; set; }
        public decimal ApplicationTypeFee{ get; set; }

        private clsApplicationTypes(int id, string title, decimal fee) 
        {
            this.ApplicationTypeID = id;
            this.ApplicationTypeFee = fee;
            this.ApplicationTypeName = title;

        }

        public static DataTable getAllAppTypes()
        {
            return clsApplicationTypesData.getAllApplicationTypes();
        }

        private  bool _updateApplicationTypeFee()
        {
            return clsApplicationTypesData.updateApplicationType(ApplicationTypeID, ApplicationTypeFee);
        }

        public bool  Save()
        {
            return _updateApplicationTypeFee();
        }

        public static clsApplicationTypes find(int ID)
        {
            //int id = -1;
            string title = "";
            decimal Fee = -1;


            bool isFound = clsApplicationTypesData.getApplicationTypeInfoByID(ID, ref title, ref Fee);

            if (isFound)
                return new clsApplicationTypes(ID, title, Fee);
            else
                return null;
        }




    }
}
