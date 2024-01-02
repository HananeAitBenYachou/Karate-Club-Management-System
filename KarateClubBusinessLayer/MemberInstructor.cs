using KarateClubDataAccessLayer;
using System;
using System.Data;

namespace KarateClubBusinessLayer
{
    public class clsMemberInstructor
    {
        private enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        public int MemberInstructorID { get; private set; }

        public int MemberID { get; set; }

        public int InstructorID { get; set; }

        public DateTime AssignDate { get; set; }

        public clsMemberInstructor()
        {
            this.MemberInstructorID = -1;
            this.MemberID = -1;
            this.InstructorID = -1;
            this.AssignDate = DateTime.Now;
            _Mode = enMode.AddNew;
        }

        private clsMemberInstructor(int MemberInstructorID, int MemberID, int InstructorID, DateTime AssignDate)
        {
            this.MemberInstructorID = MemberInstructorID;
            this.MemberID = MemberID;
            this.InstructorID = InstructorID;
            this.AssignDate = AssignDate;

            _Mode = enMode.Update;
        }

        public static clsMemberInstructor Find(int MemberInstructorID)
        {
            int MemberID = -1, InstructorID = -1;
            DateTime AssignDate = DateTime.Now;

            bool isFound = clsMemberInstructorDataAccess.GetMemberInstructorByID(MemberInstructorID, ref MemberID, ref InstructorID, ref AssignDate);

            if (isFound)
                return new clsMemberInstructor(MemberInstructorID, MemberID, InstructorID, AssignDate);

            else
                return null;
        }

        public static bool IsMemberInstructorExist(int MemberInstructorID)
        {
            return clsMemberInstructorDataAccess.IsMemberInstructorExist(MemberInstructorID);
        }

        private bool _AddNewMemberInstructor()
        {
            MemberInstructorID = clsMemberInstructorDataAccess.AddNewMemberInstructor(MemberID, InstructorID, AssignDate);
            return MemberInstructorID != -1;
        }

        private bool _UpdateMemberInstructor()
        {
            return clsMemberInstructorDataAccess.UpdateMemberInstructor(MemberInstructorID, MemberID, InstructorID, AssignDate);
        }

        public static bool DeleteMemberInstructor(int MemberInstructorID)
        {
            return clsMemberInstructorDataAccess.DeleteMemberInstructor(MemberInstructorID);

        }

        public static DataTable ListMemberInstructors()
        {
            return clsMemberInstructorDataAccess.GetAllMemberInstructors();
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMemberInstructor())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_UpdateMemberInstructor())
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
