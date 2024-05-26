using System;
using System.Data;
using System.Data.SqlClient;


namespace DriverCarLicences
{
    public class clsUserData
    {
        // getUserInfoByID |
        // add new User    |
        // updateUser      |
        // getAllUsers     |
        // DeleteUser      |
        // isPersonExist() | 

        public static bool getUserInfoByUserID(int UserID, ref int PersonID, ref string UserName,
            ref string Password, ref bool IsActive, ref int Permmisions)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "SELECT * FROM  Users Where UserID = @UserID ;";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    Permmisions = (int)reader["Permmisions"];
                    
               

                }
                else
                    isFound = false;

                reader.Close();



            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return isFound;
        }

        public static bool getUserInfoByUserNammeAndPassword(ref int UserID, ref int PersonID, string UserName,
            string Password, ref bool IsActive, ref int Permmisions)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "SELECT * FROM  Users Where UserName = @UserName  And Password = @Password;";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    Permmisions = (int)reader["Permmisions"];
                    


                }
                else
                    isFound = false;

                reader.Close();



            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return isFound;
        }

        public static int AddNewUser(int PersonID, string UserName,
            string Password, bool IsActive, int Permmisions)
        {

            int id = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "INSERT into Users VALUES(@PersonID, @UserName, @Password, @IsActive," +
                " @Permmisions);Select SCOPE_Identity();";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);

            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@Permmisions", Permmisions);


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

        public static bool updateUser(int UserID, int PersonID, string UserName,
            string Password, bool IsActive, int Permmisions)
        {

            int rowsAffect = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "update Users set  PersonID = @PersonID , UserName = @UserName," +
                " Password = @Password, IsActive = @IsActive, Permissions = @Permmision WHERE UserID = @UserID ;";

       

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);

            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@Permmision", Permmisions);
            

            try
            {
                connection.Open();

                rowsAffect = Command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffect > 0);
        }
        public static DataTable getAllUsers()
        {
            DataTable Users = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "SELECT *  From UsersView";

            SqlCommand Command = new SqlCommand(Query, connection);



            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows) { Users.Load(reader); }


            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return Users;


        }

        public static bool DeleteUser(int UserID)
        {
            int rowsAffect = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "DELETE From Users WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                rowsAffect = Command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffect > 0);
        }

        public static bool isUserExist(int UserID)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "Select UserID  From Users WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int gettingID))
                { id = gettingID; }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (id > -1);
        }

        public static bool isUserExist(string userName)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "Select UserID  From Users WHERE UserName = @userName";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@userName", userName);

            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int gettingID))
                { id = gettingID; }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (id > -1);
        }

        public static bool isPersonHasAUser(int PersonID)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "Select UserID  From Users WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int gettingID))
                { id = gettingID; }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (id > -1);
        }



        //public static bool ChangePassword(int userID)



    }
}
