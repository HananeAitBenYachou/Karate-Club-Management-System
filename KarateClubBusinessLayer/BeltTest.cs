using KarateClubDataAccessLayer;
using System;
using System.Data;

namespace KarateClubBusinessLayer
{
    public class clsBeltTest
    {

        private enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        public int TestID { get; private set; }

        public int MemberID { get; set; }

        public int RankID { get; set; }

        public bool Result { get; set; }

        public DateTime Date { get; set; }

        public int TestedByInstructorID { get; set; }

        public int PaymentID { get; private set; }

        public clsBeltTest()
        {
            TestID = -1;
            MemberID = -1;
            RankID = -1;
            Result = false;
            Date = DateTime.Now;
            TestedByInstructorID = -1;
            PaymentID = -1;

            _Mode = enMode.AddNew;
        }

        private clsBeltTest(int TestID, int MemberID, int RankID, bool Result, DateTime Date, int TestedByInstructorID, int PaymentID)
        {
            this.TestID = TestID;
            this.MemberID = MemberID;
            this.RankID = RankID;
            this.Result = Result;
            this.Date = Date;
            this.TestedByInstructorID = TestedByInstructorID;
            this.PaymentID = PaymentID;

            _Mode = enMode.Update;
        }

        public static clsBeltTest Find(int TestID)
        {
            int MemberID = -1, RankID = -1, TestedByInstructorID = -1, PaymentID = -1;
            bool Result = false;
            DateTime Date = DateTime.Now;

            if (clsBeltTestDataAccess.GetBeltTestByID(TestID, ref MemberID, ref RankID, ref Result, ref Date, ref TestedByInstructorID, ref PaymentID))
            {
                return new clsBeltTest(TestID, MemberID, RankID, Result, Date, TestedByInstructorID, PaymentID);
            }
            return null;
        }

        public static bool IsBeltTestExist(int TestID)
        {
            return clsBeltTestDataAccess.IsBeltTetsExist(TestID);
        }

        private bool _AddNewBeltTest()
        {
            double Amount = clsBeltRankDataAccess.GetBeltRankTestFeesByID(RankID);

            PaymentID = clsPaymentDataAccess.AddNewPayment(Amount, DateTime.Now, MemberID);

            TestID = clsBeltTestDataAccess.AddNewBeltTest(MemberID, RankID, Result, Date, TestedByInstructorID, PaymentID);

            if (Result)
            {
                if (TestID != -1 && clsMemberDataAccess.UpdateMemberBeltRank(MemberID, RankID))
                {
                    return true;
                }
            }

            return TestID != -1;
        }

        private bool _UpdateBeltTest()
        {
            if (Result)
            {
                if (clsMemberDataAccess.UpdateMemberBeltRank(MemberID, RankID) &&
                   clsBeltTestDataAccess.UpdateBeltTest(TestID, MemberID, RankID, Result, Date, TestedByInstructorID, PaymentID))
                {
                    return true;
                }
            }

            return clsBeltTestDataAccess.UpdateBeltTest(TestID, MemberID, RankID, Result, Date, TestedByInstructorID, PaymentID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBeltTest())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_UpdateBeltTest())
                    {
                        return true;
                    }
                    else
                        return false;
            }

            return false;
        }

        public static bool DeleteBeltTest(int TestID)
        {
            return clsBeltTestDataAccess.DeleteBeltTest(TestID);
        }

        public static int GetBeltTestsCount()
        {
            return clsBeltTestDataAccess.GetBeltTestsCount();
        }

        public static DataTable ListBeltTests()
        {
            return clsBeltTestDataAccess.GetAllBeltTests();
        }
    }
}
