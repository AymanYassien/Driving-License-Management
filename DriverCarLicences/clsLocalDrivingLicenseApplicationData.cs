using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;


namespace DriverCarLicences
{
    public class clsLocalDrivingLicenseApplicationData
    {
        public static bool getLocalDrivingLicenseAplicationByLDLApplicationID(int LDLAPPID, ref int ApplicationID, ref int PersonID, ref DateTime ApplicationDate,
           ref int AppTypeID, ref byte AppStatus, ref DateTime LastStatusDate, ref decimal paidFees, ref int createdByUserID,
           ref int LicenseClassID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            // actually : Local Driving License Application
            string Query = "select * FROM LocalDrivingLicenseApplications " +
                            "INNER Join Applications " +
                            "ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID" +
                            " Where LocalDrivingLicenseApplicationID = @LDLAPPID ;";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@LDLAPPID", LDLAPPID);
            

            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    LDLAPPID   = (int)reader["LocalDrivingLicenseApplicationID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    PersonID        = (int)reader["PersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    AppTypeID       = (int)reader["ApplicationTypeID"];
                    AppStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate  = (DateTime)reader["LastStatusDate"];
                    paidFees        = (decimal)reader["PaidFees"];
                    createdByUserID = (int)reader["CreatedByUserID"];
                    LicenseClassID  = (int)reader["LicenseClaaID"];


                }
                else
                    isFound = false;

                reader.Close();



            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return isFound;
        }


        // this add in tow table, first of ALL add into Application Table
        // then add in local license Table

        public static int AddNewAplication(int PersonID, DateTime ApplicationDate,
           int AppTypeID,  byte AppStatus, DateTime LastStatusDate, decimal paidFees, int createdByUserID)
        {
            
            int id = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "INSERT into Applications VALUES(@PersonID, @ApplicationDate, @AppTypeID, @AppStatus," +
                " @LastStatusDate, @paidFees, @createdByUserID );Select SCOPE_Identity();";

            

            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@AppTypeID", AppTypeID);
            Command.Parameters.AddWithValue("@AppStatus", AppStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@paidFees", paidFees);
            Command.Parameters.AddWithValue("@createdByUserID", createdByUserID);



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
        
        // can perform update, the person actually van update only 2 fields!
        public static bool UpdateAplication(int ApplicationID, int PersonID, DateTime ApplicationDate,
           int AppTypeID, byte AppStatus, DateTime LastStatusDate, decimal paidFees, int createdByUserID)
        {

            int rowsAffect = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "update Applications set  PersonID = @PersonID , ApplicationDate = @ApplicationDate," +
                " AppTypeID = @AppTypeID, AppStatus = @AppStatus, LastStatusDate = @LastStatusDate,paidFees = @paidFees," +
                "  createdByUserID = @createdByUserID WHERE ApplicationID = @ApplicationID ;";



            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@AppTypeID", AppTypeID);
            Command.Parameters.AddWithValue("@AppStatus", AppStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@paidFees", paidFees);
            Command.Parameters.AddWithValue("@createdByUserID", createdByUserID);


            try
            {
                connection.Open();

                rowsAffect = Command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffect > 0);
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            int rowsAffect = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "DELETE From Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                rowsAffect = Command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffect > 0);
        }

        public static DataTable getAllLocalDrivingLicenseApplications()
        {
            DataTable Applications = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "SELECT *  From LocalDrivingLicenseApplicationsView_pre";

            SqlCommand Command = new SqlCommand(Query, connection);



            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows) { Applications.Load(reader); }


            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return Applications;


        }

        public static bool isPersonHasANewAppointmentFromSameLicenseClass(string PersonNational, string ApplicationClassName)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "SELECT LDLAPPID FROM LocalDrivingLicenseApplicationsView_pre" +
                " WHERE NationalNumber = @PersonNational AND ApplicationStatus = \'NEW\' AND DrivingClass = @ApplicationClass";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@PersonNational"  , PersonNational);
            Command.Parameters.AddWithValue("@ApplicationClass", ApplicationClassName);

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

        public static bool UpdateStatus(int ApplicationID, byte AppStatus)
        {
            int rowsAffect = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "update Applications set  ApplicationStatus = @AppStatus WHERE ApplicationID = @ApplicationID ;";



            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@AppStatus", AppStatus);
            


            try
            {
                connection.Open();

                rowsAffect = Command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return (rowsAffect > 0);

        }

        // -----------------------------------------------------------------------------------------------
        //can separateThis code into new class inherit current one | LocalDrivingLicenseApplications
        /*
        public static int AddNewLocalDrivingLicenseApplications(int PersonID, DateTime ApplicationDate,
           int AppTypeID, sbyte AppStatus, DateTime LastStatusDate, decimal paidFees, int createdByUserID, int LicenseClassID)
        {
            int applicationID = AddNewAplication(PersonID, ApplicationDate, AppTypeID, AppStatus, LastStatusDate, paidFees, createdByUserID);
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "INSERT into LocalDrivingLicenseApplications VALUES(@applicationID, @LicenseClassID);Select SCOPE_Identity();";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@applicationID", applicationID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int inserted)) { id = inserted; }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return applicationID;
        }


        public static bool UpdateLocalDrivingLicenseAplication(int ApplicationID, int PersonID, DateTime ApplicationDate,
           int AppTypeID, sbyte AppStatus, DateTime LastStatusDate, decimal paidFees, int createdByUserID, int local_D_L_ID, int LicenseClassID)
        {
            if (UpdateAplication(ApplicationID, PersonID, ApplicationDate, AppTypeID, AppStatus, LastStatusDate, paidFees, createdByUserID))
            {
                int rowsAffect = -1;
                SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

                string Query = "update LocalDrivingLicenseApplications set  LicenseClaaID = @LicenseClaaID WHERE LocalDrivingLicenseApplicationID = @local_D_L_ID ;";



                SqlCommand Command = new SqlCommand(Query, connection);

                Command.Parameters.AddWithValue("@LicenseClaaID", LicenseClassID);
                Command.Parameters.AddWithValue("@local_D_L_ID", local_D_L_ID);


                try
                {
                    connection.Open();

                    rowsAffect = Command.ExecuteNonQuery();

                }
                catch (Exception ex) { }
                finally { connection.Close(); }

                return (rowsAffect > 0);
            }
            else
                return false;



        }

        */

        public static int AddNewLocalDrivingLicenseApplications(int applicationID,int LicenseClassID)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string Query = "INSERT into LocalDrivingLicenseApplications VALUES(@applicationID, @LicenseClassID);Select SCOPE_Identity();";


            SqlCommand Command = new SqlCommand(Query, connection);


            Command.Parameters.AddWithValue("@applicationID", applicationID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

        public static bool UpdateLocalDrivingLicenseAplication(int local_D_L_ID, int LicenseClassID)
        {
            
                int rowsAffect = -1;
                SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

                string Query = "update LocalDrivingLicenseApplications set  LicenseClaaID = @LicenseClaaID WHERE LocalDrivingLicenseApplicationID = @local_D_L_ID ;";



                SqlCommand Command = new SqlCommand(Query, connection);

                Command.Parameters.AddWithValue("@LicenseClaaID", LicenseClassID);
                Command.Parameters.AddWithValue("@local_D_L_ID", local_D_L_ID);


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
