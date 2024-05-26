using System;
using System.Data;


namespace DriverCarLicences
{
    public class clsPerson
    {
        public enum enMode { addNew = 0, update = 1};
        enMode mode = enMode.addNew;

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }
        public string NationalNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte gender { get; set; } 
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int NationalCountryID { get; set; }
        public string imagePath { get; set; }

        public clsCountry countryInfo;

        public clsPerson() 
        {

            PersonId = -1;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            NationalNumber = string.Empty;
            DateOfBirth = DateTime.Now;
            Phone = string.Empty;
            Email = string.Empty;
            Address = string.Empty;
            NationalCountryID = -1;
            gender = 1;
            imagePath = string.Empty;

            mode = enMode.addNew;

        }

        private clsPerson(int personID, string national, string first, string second, string third, string last,
            DateTime dateofBirth, byte gendor, string address, string phone, string Email,
            int countryID, string imagePath)
        {
            this.PersonId = personID;
            this.NationalNumber = national;
            this.FirstName = first;
            this.SecondName = second;
            this.ThirdName = third; 
            this.LastName = last;
            this.DateOfBirth = dateofBirth;
            this.Phone = phone;
            this.Email = Email;
            this.Address = address;
            this.NationalCountryID = countryID;
            this.imagePath = imagePath;
            this.gender = gendor;
            this.countryInfo = clsCountry.find(countryID);

            mode = enMode.update;

        }

        private bool _addNewPerson()
        {
            this.PersonId = clsPeopleData.AddNewPerson(this.NationalNumber, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.DateOfBirth, this.gender, this.Address,this.Phone, this.Email, this.NationalCountryID, this.imagePath);

            return (this.PersonId != -1);
        }

        private bool _updatePerson()
        {
            return 
             clsPeopleData.updatePerson(this.PersonId, this.NationalNumber, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.DateOfBirth, this.gender, this.Address, this.Phone, this.Email, this.NationalCountryID, this.imagePath);

            
        }

        public static clsPerson find(int personID)
        {
            string national = "", first = "", second = "", third = "", last = "", address = "", phone = "", Email = "", imagePath = "";
            DateTime dateofBirth = DateTime.Now;
            int countryID = 0;
            byte gendor = 0;


            bool isFound = clsPeopleData.getPersonInfoByPersonID( personID, ref national, ref  first, ref  second, ref  third, ref  last,
            ref  dateofBirth, ref  gendor, ref  address, ref  phone, ref  Email,
            ref  countryID, ref  imagePath);

            if (isFound)
                return new clsPerson(personID, national, first, second, third, last, dateofBirth, gendor, address, phone, Email, countryID, imagePath);
            else
                return null;

        }

        public static clsPerson find(string national)
        {
            string first = "", second = "", third = "", last = "", address = "", phone = "", Email = "", imagePath = "";
            DateTime dateofBirth = DateTime.Now;
            int countryID = 0, id = -1;
            byte gendor = 0;


            bool isFound = clsPeopleData.getPersonInfoByNationalNumber(ref id, national, ref first, ref second, ref third, ref last,
            ref dateofBirth, ref gendor, ref address, ref phone, ref Email,
            ref countryID, ref imagePath);

            if (isFound)
                return new clsPerson(id, national, first, second, third, last, dateofBirth, gendor, address, phone, Email, countryID, imagePath);
            else
                return null;

        }

        public bool Save()
        {
            switch(mode)
            {
                case enMode.addNew:
                    if(_addNewPerson())
                    {
                        mode = enMode.update;
                        return true;
                    }
                    else
                        return false;

                case enMode.update:
                    return _updatePerson();

            }

            return false;
        }

        public static DataTable getAllPeople()
        {
            return clsPeopleData.getAllPeople();
        }

        public static bool DeletePerson(int ID)
        {
            return clsPeopleData.DeletePerson(ID);
        }

        public static bool isPersonExist(int ID)
        {
            return clsPeopleData.isPersonExist(ID);
        }

        public static bool isPersonExist(string national)
        {
            return clsPeopleData.isPersonExist(national);
        }


    }
}
