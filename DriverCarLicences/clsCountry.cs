using System;
using System.Data;


namespace DriverCarLicences
{
     public class clsCountry
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        private clsCountry(int id, string name)
        {
            CountryId = id;
            CountryName = name;

        }

        public static clsCountry find(int CountryID)
        {
            string name = "";

            bool isFound = clsCountryData.getCountryInfoByCountryID(CountryID, ref name);

            if (isFound)
                return new clsCountry(CountryID, name);
            else
                return null;

        }

        public static clsCountry find(string countryName)
        {
            int id = -1;

            bool isFound = clsCountryData.getCountryInfoByCountryName(countryName, ref id);

            if (isFound)
                return new clsCountry(id, countryName);
            else
                return null;

        }
        public static DataTable getAllCountries()
        {
            return clsCountryData.getAllCountries();

        }
    }

}
