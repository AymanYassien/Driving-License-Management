using DriverCarLicences;
using System;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace DriverCarLicences
{
    public class clsApplicationTypesData
    {

        public static bool getApplicationTypeInfoByID(int a_typeID, ref string name, ref decimal fee)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "Select * From ApplicationTypes  WHERE ApplicationTypeID = @ID ;";



            SqlCommand Command = new SqlCommand(Query, connection);

            //Command.Parameters.AddWithValue("@Fee", fee);
            Command.Parameters.AddWithValue("@ID", a_typeID);

            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    a_typeID = (int)reader["ApplicationTypeID"];
                    name = (string)reader["ApplicationTypeTitle"];
                    fee = (decimal)reader["ApplicationFees"];
                  
                }
                else
                    isFound = false;

                reader.Close();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return isFound;
        }

        public static DataTable getAllApplicationTypes()
        {
            DataTable _dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "Select * From ApplicationTypes";

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

        public static bool updateApplicationType(int id, decimal Fee)
        {
            int rowsAffect = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "update ApplicationTypes set  ApplicationFees = @Fee WHERE ApplicationTypeID = @ID ;";



            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@Fee", Fee);
            Command.Parameters.AddWithValue("@ID", id);
           


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
