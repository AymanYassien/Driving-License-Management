using System;
using System.Data;
using System.Security.Cryptography;
namespace DriverCarLicences
{
    public class clsManageLicenseClasses
    {

        int ID { get; set; }
        string name { get; set; }
        string desc { get; set; }
        byte MinimumAllowAge { get; set; }
        byte DefaultValidateLength { get; set; }
        decimal ClassFees { get; set; }

        public clsManageLicenseClasses() { }

        private clsManageLicenseClasses(int iD, string name, string desc, byte minimumAllowAge, byte defaultValidateLength, decimal classFees)
        {
            ID = iD;
            this.name = name;
            this.desc = desc;
            MinimumAllowAge = minimumAllowAge;
            DefaultValidateLength = defaultValidateLength;
            ClassFees = classFees;
        }

        public static DataTable getAllLisenseClasses()
        {
            return clsManageLicenseClassesData.getAllLisenseClasses();
        }

        public static clsManageLicenseClasses getLicenseClassInfoByID(int ID )
        {
            string name = "", desc = "";
            byte MinimumAllowAge = 0, DefaultValidateLength = 0;
            decimal ClassFees = 0;

            bool isFound = clsManageLicenseClassesData.getLicenseClassInfoByID(ID, ref name, ref desc, ref MinimumAllowAge, ref DefaultValidateLength, 
               ref ClassFees);

            if (isFound)
                return new clsManageLicenseClasses(ID, name, desc, MinimumAllowAge, DefaultValidateLength, ClassFees);
            else
                return null;


        }
    }
}
