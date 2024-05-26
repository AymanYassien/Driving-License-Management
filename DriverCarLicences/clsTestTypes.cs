using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCarLicences
{
    public class clsTestTypes
    {
        public string TestTypeName { get; set; }
        public string TestTypeDescription { get; set; }
        public int TestTypeID { get; set; }
        public int DefaultDegree { get; set; }
        public decimal TestTypeFee { get; set; }

        private clsTestTypes(int id, string title, string desc, decimal fee, int def)
        {
            TestTypeID = id;
            TestTypeName = title;
            TestTypeDescription = desc;
            DefaultDegree = def;
            TestTypeFee = fee;
          

        }

        public static DataTable getAllTestTypes()
        {
            return clsTestTypesData.getAllTestTypes();
        }

        private bool _updateTestTypeFee()
        {
            return clsTestTypesData.updateTestType(TestTypeID, TestTypeName, TestTypeDescription,
                TestTypeFee,  DefaultDegree);
        }

        public bool Save()
        {
            return _updateTestTypeFee();
        }

        public static clsTestTypes find(int ID)
        {
            sbyte def = 1;
            string title = "", desc = "";
            decimal Fee = -1;
            

            bool isFound = clsTestTypesData.getTestTypeInfoByID(ID, ref title, ref desc, ref Fee, ref def);

            if (isFound)
                return new clsTestTypes(ID,  title,  desc,  Fee,  def);
            else
                return null;
        }

    }
}
