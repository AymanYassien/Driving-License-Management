using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace DriverCarLicences
{
    internal class clsPeopleData
    {
        // getPersonInfoByID
        // getPersonInfoByNational
        // add new person ==
        // updatePerson   == 
        // getAllpeople   ==
        // DeletePerson   == 
        // isPersonExist() + 2 override == 

        public static bool getPersonInfoByPersonID(int personID, ref string national, ref string first, ref string second, ref string third, ref string last,
            ref DateTime dateofBirth, ref byte gendor, ref string address, ref string phone, ref string Email,
            ref int countryID, ref string imagePath)
        {

            bool isFound = false; 
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "SELECT * FROM  People Where PersonID = @personID ;";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    first = (string)reader["FirstName"];
                    second = (string)reader["SecondName"];
                    national = (string)reader["NationalNumber"];


                    if (reader["ThirdName"] != DBNull.Value)
                        third = (string)reader["ThirdName"];
                    else
                        third = "";

                    last = (string)reader["LastName"];
                    dateofBirth = (DateTime)reader["DateOfBirth"];
                    gendor = (byte)reader["Gendor"];
                    address = (string)reader["Address"];
                    phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    countryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                        imagePath = (string)reader["ImagePath"];
                    else
                        imagePath = "";

                }
                else 
                    isFound = false;

                reader.Close();

                

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return isFound;
        }

        public static bool getPersonInfoByNationalNumber(ref int id, string national, ref string first, ref string second, ref string third, ref string last,
            ref DateTime dateofBirth, ref byte gendor, ref string address, ref string phone, ref string Email,
            ref int countryID, ref string imagePath)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "SELECT * FROM  People Where NationalNumber = @NationalNumber ;";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@NationalNumber", national);

            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    id = (int)reader["PersonID"];
                    first = (string)reader["FirstName"];
                    second = (string)reader["SecondName"];


                    if (reader["ThirdName"] != DBNull.Value)
                        third = (string)reader["ThirdName"];
                    else
                        third = "";

                    last = (string)reader["LastName"];
                    dateofBirth = (DateTime)reader["DateOfBirth"];
                    gendor = (byte)reader["Gendor"];
                    address = (string)reader["Address"];
                    phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    countryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                        imagePath = (string)reader["ImagePath"];
                    else
                        imagePath = "";

                }
                else
                    isFound = false;

                reader.Close();



            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return isFound;
        }

        public static  int AddNewPerson(string national, string first, string second, string third, string last,
            DateTime dateofBirth, byte gendor, string address, string phone, string Email,
            int countryID, string imagePath)
        {

            int id = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "INSERT into People VALUES(@national, @first, @second, @third," +
                " @last, @dateOfBirth, @gendor, @address,@phone, @email, @CountryID, @imagePath);Select SCOPE_Identity();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@national", national);
            Command.Parameters.AddWithValue("@first", first);
            Command.Parameters.AddWithValue("@second", second);

            if(third != "" && third != null)
                Command.Parameters.AddWithValue("@third", third);
            else
                Command.Parameters.AddWithValue("@third", DBNull.Value);

            Command.Parameters.AddWithValue("@last", last);
            Command.Parameters.Add("@dateOfBirth", dateofBirth);
            Command.Parameters.AddWithValue("@gendor", gendor.ToString());
            Command.Parameters.AddWithValue("@address", address);
            Command.Parameters.AddWithValue("@phone", phone);

            if (Email != "" && Email != null)
                Command.Parameters.AddWithValue("@email", Email);
            else
                Command.Parameters.AddWithValue("@email", DBNull.Value);


            Command.Parameters.AddWithValue("@CountryID", countryID.ToString());

            if (imagePath != "" && imagePath != null)
                Command.Parameters.AddWithValue("@imagePath", imagePath);
            else
                Command.Parameters.AddWithValue("@imagePath", DBNull.Value);

            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int inserted)) { id = inserted; }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return id;
        }

        public static bool updatePerson(int personID, string national, string first, string second, string third, string last,
            DateTime dateofBirth, byte gendor, string address, string phone, string Email,
            int countryID, string imagePath)
        {

            int rowsAffect = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "update People  set NationalNumber = @national, FirstName = @first, SecondName = @second, ThirdName = @third," +
                "LastName = @last, DateOfBirth = @dateOfBirth, Gendor = @gendor,Address = @address,Phone = @phone, Email = @email, NationalityCountryID =  @CountryID," +
                "ImagePath =  @imagePath WHERE PersonID = @personID ;";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@personID", personID);
            Command.Parameters.AddWithValue("@national", national);
            Command.Parameters.AddWithValue("@first", first);
            Command.Parameters.AddWithValue("@second", second);
            Command.Parameters.AddWithValue("@third", third);
            Command.Parameters.AddWithValue("@last", last);
            Command.Parameters.Add("@dateOfBirth", dateofBirth);
            Command.Parameters.AddWithValue("@gendor", gendor.ToString());
            Command.Parameters.AddWithValue("@address", address);
            Command.Parameters.AddWithValue("@phone", phone);
            Command.Parameters.AddWithValue("@email", Email);
            Command.Parameters.AddWithValue("@CountryID", countryID.ToString());
            Command.Parameters.AddWithValue("@imagePath", imagePath);

            try
            {
                connection.Open();

                rowsAffect = Command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffect > 0);
        }

        public static bool DeletePerson(int personID)
        {
            int rowsAffect = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "DELETE From People WHERE PersonID = @personID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();

                rowsAffect = Command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffect > 0);
        }
        
        public static DataTable getAllPeople()
        {
            DataTable People = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "SELECT *  From PeopleView";

            SqlCommand Command = new SqlCommand(Query, connection);

           

            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if(reader.HasRows) { People.Load(reader); }


            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return People;

        }

        public static bool isPersonExist(int PersonID) 
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "Select PersonID  From People WHERE PersonID = @personID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@personID", PersonID);

            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString() , out int gettingID)) { id = gettingID; }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (id > -1);
        }

        public static bool isPersonExist(string NationalNumber)
        {
            
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "Select NationalNumber  From People WHERE NationalNumber = @NationalNumber";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

            object result = null;

            try
            {
                connection.Open();

                 result = Command.ExecuteScalar();
                //if (result != null ) { result.ToString();}

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            string gettedNo = result.ToString();

            if (string.IsNullOrEmpty(gettedNo)) {  return false; }
            if (gettedNo == NationalNumber) { return true; }
            else { return false; }

            //return (gettedNo == NationalNumber && NationalNumber != null);
        }


    }

    
}
