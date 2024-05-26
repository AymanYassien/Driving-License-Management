using System;
using System.Data.SqlClient;
using System.Data;
using System.Net.NetworkInformation;

namespace DriverCarLicences
{
    internal class clsCountryData
    {
        public static DataTable getAllCountries()
        {
            DataTable Countries = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "SELECT *  From Countries";

            SqlCommand Command = new SqlCommand(Query, connection);



            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows) { Countries.Load(reader); }


            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return Countries;

        }

        public static bool getCountryInfoByCountryID(int CountryID, ref string countryName)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "select * from Countries Where countryID = @countryID ;";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@countryID", CountryID);

            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    countryName = (string)reader["CountryName"];

                }
                else
                    isFound = false;

                reader.Close();



            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return isFound;
        }

        public static bool getCountryInfoByCountryName(string countryName, ref int CountryID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "select * from Countries Where CountryName = @CountryName ;";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@CountryName", countryName);

            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    CountryID = (int)reader["countryID"];

                }
                else
                    isFound = false;

                reader.Close();



            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return isFound;
        }



    }
}
