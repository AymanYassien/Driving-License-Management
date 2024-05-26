using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCarLicences
{
    public class clsTestTypesData
    {

        public static bool getTestTypeInfoByID(int t_typeID, ref string name, ref string desc, ref decimal fee, ref sbyte degree)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "Select * From TestTypes  WHERE TestTypeID = @ID ;";



            SqlCommand Command = new SqlCommand(Query, connection);

            //Command.Parameters.AddWithValue("@Fee", fee);
            Command.Parameters.AddWithValue("@ID", t_typeID);

            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    t_typeID = (int)reader["TestTypeID"];
                    name = (string)reader["TestTypeTitle"];
                    desc = (string)reader["TestTypeDescription"];
                    fee = (decimal)reader["TestTypeFees"];
                    degree = (sbyte)reader["DefaultPassDegree"];

                }
                else
                    isFound = false;

                reader.Close();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return isFound;
        }

        public static DataTable getAllTestTypes()
        {
            DataTable _dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "Select * From TestTypes";

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
    }
}
