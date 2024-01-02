using KarateClubDataAccessLayer;
using System;

namespace KarateClubBusinessLayer
{
    public class clsPerson
    {
        protected enum enMode { AddNew = 0, Update = 1 };

        protected enMode _Mode;

        protected int PersonID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public char Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Password { get; set; }

        public string ImagePath { get; set; }

        protected clsPerson()
        {
            PersonID = -1;
            Name = "";
            Address = "";
            Phone = "";
            Email = "";
            Gender = ' ';
            DateOfBirth = DateTime.Now;
            Password = "";
            ImagePath = "";

            _Mode = enMode.AddNew;
        }

        protected clsPerson(int PersonID, string Name, string Address, string Phone, string Email, char Gender, DateTime DateOfBirth, string Password, string ImagePath)
        {
            this.PersonID = PersonID;
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.Password = Password;
            this.ImagePath = ImagePath;

            _Mode = enMode.Update;
        }

        protected static clsPerson Find(int PersonID)
        {
            string Name = "", Address = "", Phone = "", Email = "", Password = "", ImagePath = "";
            char Gender = ' ';
            DateTime DateOfBirth = DateTime.Now;

            bool isFound = clsPersonDataAccess.GetPersonByID(PersonID, ref Name, ref Address, ref Phone, ref Email, ref Gender, ref DateOfBirth, ref Password, ref ImagePath);

            if (isFound)
            {
                return new clsPerson(PersonID, Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath);
            }

            else
                return null;
        }

        protected static bool IsPersonExist(int PersonID)
        {
            return clsPersonDataAccess.IsPersonExist(PersonID);
        }

        private bool _AddNewPerson()
        {
            PersonID = clsPersonDataAccess.AddNewPerson(Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath);

            return PersonID != -1;
        }

        private bool _UpdatePerson()
        {
            return clsPersonDataAccess.UpdatePerson(PersonID, Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath);
        }

        protected bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_UpdatePerson())
                    {
                        return true;
                    }
                    else
                        return false;
            }

            return false;
        }

        protected static bool DeletePerson(int PersonID)
        {
            return clsPersonDataAccess.DeletePerson(PersonID);
        }

    }
}
