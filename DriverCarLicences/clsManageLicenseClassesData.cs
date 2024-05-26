

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCarLicences
{
    public class clsManageLicenseClassesData
    {
        // will implement if need
        /*
        

        public static bool updateTestType(int id, string title, string desc, decimal Fee, int digree)
        {
            int rowsAffect = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "update TestTypes set  TestTypeFees = @Fee, TestTypeDescription = @desc, TestTypeTitle = @Title, " +
                "DefaultPassDegree = @degree WHERE TestTypeID = @ID ;";



            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@Fee", Fee);
            Command.Parameters.AddWithValue("@ID", id);
            Command.Parameters.AddWithValue("@desc", desc);
            Command.Parameters.AddWithValue("@Title", title);
            Command.Parameters.AddWithValue("@degree", digree);

            try
            {
                connection.Open();

                rowsAffect = Command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffect > 0);
        }
        */

        public static bool getLicenseClassInfoByID(int ID, ref string name, ref string desc, ref byte MinimumAllowAge,
            ref byte DefaultValidateLength, ref decimal ClassFees)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "Select * From LisenseClasses  WHERE LicenseClaasID = @ID ;";


            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["LicenseClaasID"];
                    name = (string)reader["ClassName"];
                    desc = (string)reader["ClassDescription"];
                    MinimumAllowAge = (byte)reader["MinimumAllowAge"];
                    DefaultValidateLength = (byte)reader["DefaultValidateLength"];
                    ClassFees = (decimal)reader["ClassFees"];

                }
                else
                    isFound = false;

                reader.Close();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return isFound;
        }

        public static DataTable getAllLisenseClasses()
        {
            DataTable _dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "Select * From LisenseClasses";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows) { _dt.Load(reader); }


            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return _dt;



        }
    }
}
