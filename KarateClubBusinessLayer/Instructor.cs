using KarateClubDataAccessLayer;
using System;
using System.Data;

namespace KarateClubBusinessLayer
{
    public class clsInstructor : clsPerson
    {
        private new enum enMode { AddNew = 0, Update = 1 };

        private new enMode _Mode;

        public int InstructorID { get; private set; }

        private new int PersonID;

        public clsInstructor()
        {
            this.InstructorID = -1;
            this.PersonID = -1;

            _Mode = enMode.AddNew;
        }

        private clsInstructor(int PersonID, string Name, string Address, string Phone, string Email, char Gender, DateTime DateOfBirth, string Password, string ImagePath,
            int InstructorID)
        : base(PersonID, Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath)
        {
            this.InstructorID = InstructorID;
            this.PersonID = PersonID;

            _Mode = enMode.Update;
        }

        public static new clsInstructor Find(int InstructorID)
        {
            int PersonID = -1;
            string Name = "", Address = "", Phone = "", Email = "", Password = "", ImagePath = "";
            char Gender = ' ';
            DateTime DateOfBirth = DateTime.Now;

            bool isInstructorFound = clsInstructorDataAccess.GetInstructorByID(InstructorID, ref PersonID);

            if (isInstructorFound)
            {
                bool isPersonFound = clsPersonDataAccess.GetPersonByID(PersonID, ref Name, ref Address, ref Phone, ref Email, ref Gender, ref DateOfBirth, ref Password, ref ImagePath);

                if (isPersonFound)
                {
                    return new clsInstructor(PersonID, Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath, InstructorID);
                }

                else
                    return null;
            }

            else
                return null;
        }

        public static int GetInstructorID(string InstructorName)
        {
            return clsInstructorDataAccess.GetInstructorIDByName(InstructorName);
        }

        public static string GetInstructorName(int InstructorID)
        {
            return clsInstructorDataAccess.GetInstructorName(InstructorID);
        }

        public static bool IsInstructorExist(int InstructorID)
        {
            return clsInstructorDataAccess.IsInstructorExist(InstructorID);
        }

        private bool _AddNewInstructor()
        {
            base.PersonID = clsPersonDataAccess.AddNewPerson(Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath);

            if (base.PersonID != -1)
            {
                PersonID = base.PersonID;
                InstructorID = clsInstructorDataAccess.AddNewInstructor(PersonID);
            }

            return InstructorID != -1;
        }

        private bool _UpdateInstructor()
        {
            bool isPersonUpdated = clsPersonDataAccess.UpdatePerson(PersonID, Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath);

            if (isPersonUpdated)
            {
                return clsInstructorDataAccess.UpdateInstructor(InstructorID, PersonID);
            }

            else
                return false;
        }

        public static bool DeleteInstructor(int InstructorID)
        {
            int PersonID = clsInstructor.Find(InstructorID).PersonID;

            if (clsInstructorDataAccess.DeleteInstructor(InstructorID))
            {
                return clsPersonDataAccess.DeletePerson(PersonID);
            }

            else
                return false;
        }

        public static DataTable ListInstructors()
        {
            return clsInstructorDataAccess.GetAllInstructors();
        }

        public static DataTable ListInstructors(int MemberID)
        {
            return clsInstructorDataAccess.GetInstructors(MemberID);
        }

        public static int GetInstructorsCount()
        {
            return clsInstructorDataAccess.GetInstructorsCount();
        }

        public new bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInstructor())
                    {
                        base._Mode = clsPerson.enMode.Update;
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_UpdateInstructor())
                    {
                        return true;
                    }
                    else
                        return false;
            }

            return false;
        }
    }
}
