using KarateClubDataAccessLayer;
using System;
using System.Data;

namespace KarateClubBusinessLayer
{
    public class clsMember : clsPerson
    {
        private new enum enMode { AddNew = 0, Update = 1 };

        private new enMode _Mode;

        public int MemberID { get; private set; }

        private new int PersonID;

        public string EmergencyContact { get; set; }

        public int LastBeltRankID { get; set; }

        public bool IsActive { get; set; }

        public clsMember()
        {
            this.MemberID = -1;
            this.PersonID = -1;
            this.EmergencyContact = "";
            this.LastBeltRankID = -1;
            this.IsActive = false;

            _Mode = enMode.AddNew;
        }

        private clsMember(int PersonID, string Name, string Address, string Phone, string Email, char Gender, DateTime DateOfBirth, string Password, string ImagePath,
            int MemberID, string EmergencyContact, int LastBeltRankID, bool IsActive)
        : base(PersonID, Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath)
        {
            this.MemberID = MemberID;
            this.PersonID = PersonID;
            this.EmergencyContact = EmergencyContact;
            this.LastBeltRankID = LastBeltRankID;
            this.IsActive = IsActive;

            _Mode = enMode.Update;
        }

        public static new clsMember Find(int MemberID)
        {
            int PersonID = -1;
            string Name = "", Address = "", Phone = "", Email = "", Password = "", ImagePath = "";
            char Gender = ' ';
            DateTime DateOfBirth = DateTime.Now;

            string EmergencyContact = "";
            int LastBeltRankID = -1;
            bool IsActive = false;

            bool isMemberFound = clsMemberDataAccess.GetMemberByID(MemberID, ref PersonID, ref EmergencyContact, ref LastBeltRankID, ref IsActive);

            if (isMemberFound)
            {
                bool isPersonFound = clsPersonDataAccess.GetPersonByID(PersonID, ref Name, ref Address, ref Phone, ref Email, ref Gender, ref DateOfBirth, ref Password, ref ImagePath);

                if (isPersonFound)
                {
                    return new clsMember(PersonID, Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath, MemberID, EmergencyContact, LastBeltRankID, IsActive);
                }

                else
                    return null;
            }

            else
                return null;
        }

        public static clsMember Find(string Email, string Password)
        {
            int PersonID = -1;
            int MemberID = -1;
            string Name = "", Address = "", Phone = "", ImagePath = "";
            char Gender = ' ';
            DateTime DateOfBirth = DateTime.Now;

            string EmergencyContact = "";
            int LastBeltRankID = -1;
            bool IsActive = false;

            bool isMemberFound = clsMemberDataAccess.GetMemberByEmailAndPassword(Email, Password, ref MemberID, ref PersonID, ref EmergencyContact, ref LastBeltRankID, ref IsActive);

            if (isMemberFound)
            {
                bool isPersonFound = clsPersonDataAccess.GetPersonByID(PersonID, ref Name, ref Address, ref Phone, ref Email, ref Gender, ref DateOfBirth, ref Password, ref ImagePath);

                if (isPersonFound)
                {
                    return new clsMember(PersonID, Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath, MemberID, EmergencyContact, LastBeltRankID, IsActive);
                }

                else
                    return null;
            }

            else
                return null;
        }

        public static int GetMemberID(string MemberName)
        {
            return clsMemberDataAccess.GetMemberIDByName(MemberName);
        }

        public static string GetMemberName(int MemberID)
        {
            return clsMemberDataAccess.GetMemberName(MemberID);
        }

        public static bool IsMemberExist(int MemberID)
        {
            return clsMemberDataAccess.IsMemberExist(MemberID);
        }

        private bool _AddNewMember()
        {
            base.PersonID = clsPersonDataAccess.AddNewPerson(Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath);

            if (base.PersonID != -1)
            {
                PersonID = base.PersonID;
                MemberID = clsMemberDataAccess.AddNewMember(PersonID, EmergencyContact, LastBeltRankID, IsActive);

            }
            return MemberID != -1;
        }

        private bool _UpdateMember()
        {
            bool isPersonUpdated = clsPersonDataAccess.UpdatePerson(PersonID, Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath);

            if (isPersonUpdated)
            {
                return clsMemberDataAccess.UpdateMember(MemberID, PersonID, EmergencyContact, LastBeltRankID, IsActive);
            }
            return false;
        }

        public static bool DeleteMember(int MemberID)
        {
            int PersonID = clsMember.Find(MemberID).PersonID;

            if (clsMemberDataAccess.DeleteMember(MemberID))
            {
                return clsPersonDataAccess.DeletePerson(PersonID);
            }

            else
                return false;
        }

        public static DataTable ListMembers()
        {
            return clsMemberDataAccess.GetAllMembers();
        }

        public static int GetMembersCount()
        {
            return clsMemberDataAccess.GetMembersCount();
        }

        public new bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMember())
                    {
                        base._Mode = clsPerson.enMode.Update;
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_UpdateMember())
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
