using KarateClubDataAccessLayer;
using System;
using System.Data;

namespace KarateClubBusinessLayer
{
    public class clsUser : clsPerson
    {
        private new enum enMode { AddNew = 0, Update = 1 };

        private new enMode _Mode;

        public int UserID { get; private set; }

        private new int PersonID;

        public string UserName { get; set; }

        public short Permissions { get; set; }

        public enum enUsersPermissions
        {
            eAll = -1, eManageMembers = 1, eManageUsers = 2, eManageInstructors = 4, eManageMemberInstructors = 8,
            eManageSubscriptions = 16, eManageBeltRanks = 32, eManageBeltTests = 64, eManagePayments = 128
        }
        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Permissions = 0;
            _Mode = enMode.AddNew;
        }

        private clsUser(int PersonID, string Name, string Address, string Phone, string Email, char Gender, DateTime DateOfBirth, string Password, string ImagePath,
            int UserID, string UserName, short Permissions)
        : base(PersonID, Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Permissions = Permissions;

            _Mode = enMode.Update;
        }

        public static new clsUser Find(int UserID)
        {
            int PersonID = -1;
            string Name = "", Address = "", Phone = "", Email = "", Password = "", ImagePath = "";
            char Gender = ' ';
            DateTime DateOfBirth = DateTime.Now;
            string UserName = "";
            short Permissions = 0;

            bool isUserFound = clsUserDataAccess.GetUserByID(UserID, ref PersonID, ref UserName, ref Permissions);

            if (isUserFound)
            {
                bool isPersonFound = clsPersonDataAccess.GetPersonByID(PersonID, ref Name, ref Address, ref Phone, ref Email, ref Gender, ref DateOfBirth, ref Password, ref ImagePath);

                if (isPersonFound)
                {
                    return new clsUser(PersonID, Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath, UserID, UserName, Permissions);
                }

                else
                    return null;
            }

            else
                return null;
        }

        public static clsUser Find(string UserName, string Password)
        {
            int PersonID = -1;
            string Name = "", Address = "", Phone = "", Email = "", ImagePath = "";
            char Gender = ' ';
            int UserID = -1;
            DateTime DateOfBirth = DateTime.Now;
            short Permissions = 0;

            bool isUserFound = clsUserDataAccess.GetUserByUserName(ref UserID, ref PersonID, UserName, ref Permissions);

            if (isUserFound)
            {
                bool isPersonFound = clsPersonDataAccess.GetPersonByIDAndPassword(PersonID, ref Name, ref Address, ref Phone, ref Email, ref Gender, ref DateOfBirth, Password, ref ImagePath);

                if (isPersonFound)
                {
                    return new clsUser(PersonID, Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath, UserID, UserName, Permissions);
                }

                else
                    return null;
            }

            else
                return null;
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserDataAccess.IsUserExist(UserID);
        }

        public static bool IsUserExist(string UserName)
        {
            return clsUserDataAccess.IsUserExist(UserName);
        }

        public static bool IsUserExist(string UserName, int UserID)
        {
            return clsUserDataAccess.IsUserExist(UserName, UserID);
        }

        private bool _AddNewUser()
        {
            base.PersonID = clsPersonDataAccess.AddNewPerson(Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath);

            if (base.PersonID != -1)
            {
                PersonID = base.PersonID;
                UserID = clsUserDataAccess.AddNewUser(PersonID, UserName, Permissions);
            }
            return UserID != -1;
        }

        private bool _UpdateUser()
        {
            bool isPersonUpdated = clsPersonDataAccess.UpdatePerson(PersonID, Name, Address, Phone, Email, Gender, DateOfBirth, Password, ImagePath);

            if (isPersonUpdated)
            {
                return clsUserDataAccess.UpdateUser(UserID, PersonID, UserName, Permissions);
            }

            else
                return false;
        }

        public static bool DeleteUser(int UserID)
        {
            int PersonID = clsUser.Find(UserID).PersonID;

            if (clsUserDataAccess.DeleteUser(UserID))
            {
                return clsPersonDataAccess.DeletePerson(PersonID);
            }

            else
                return false;
        }

        public static DataTable ListUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }

        public static int GetUsersCount()
        {
            return clsUserDataAccess.GetUsersCount();
        }

        public static bool CheckAccessPermissions(enUsersPermissions permission, short Permissions)
        {
            if (Permissions == -1)
                return true;

            else if ((Permissions & (short)permission) == (short)permission)
                return true;

            return false;
        }

        public bool CheckAccessPermissions(enUsersPermissions permission)
        {
            if (Permissions == -1)
                return true;

            else if ((Permissions & (short)permission) == (short)permission)
                return true;

            return false;
        }

        public new bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        base._Mode = clsPerson.enMode.Update;
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_UpdateUser())
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
