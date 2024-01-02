using KarateClubDataAccessLayer;
using System.Data;

namespace KarateClubBusinessLayer
{
    public class clsBeltRank
    {
        private enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        public int RankID { get; private set; }

        public string RankName { get; set; }

        public double TestFees { get; set; }

        public clsBeltRank()
        {
            RankID = -1;
            RankName = " ";
            TestFees = 0;

            _Mode = enMode.AddNew;
        }

        private clsBeltRank(int RankID, string RankName, double TestFees)
        {
            this.RankID = RankID;
            this.RankName = RankName;
            this.TestFees = TestFees;

            _Mode = enMode.Update;
        }

        public static clsBeltRank Find(int RankID)
        {
            string RankName = "";
            double TestFees = 0;

            if (clsBeltRankDataAccess.GetBeltRankByID(RankID, ref RankName, ref TestFees))
            {
                return new clsBeltRank(RankID, RankName, TestFees);
            }

            return null;
        }

        public static clsBeltRank Find(string RankName)
        {
            int RankID = -1;
            double TestFees = 0;

            if (clsBeltRankDataAccess.GetBeltRankByName(RankName, ref RankID, ref TestFees))
            {
                return new clsBeltRank(RankID, RankName, TestFees);
            }

            return null;
        }

        public static int GetBeltRankID(string RankName)
        {
            return clsBeltRankDataAccess.GetBeltRankIDByName(RankName);
        }

        public static string GetBeltRankName(int RankID)
        {
            return clsBeltRankDataAccess.GetBeltRankName(RankID);
        }

        public static bool IsBeltRankExist(int RankID)
        {
            return clsBeltRankDataAccess.IsBeltRankExist(RankID);
        }

        public static bool IsBeltRankExist(string RankName)
        {
            return clsBeltRankDataAccess.IsBeltRankExist(RankName);
        }

        private bool _AddNewBeltRank()
        {
            RankID = clsBeltRankDataAccess.AddNewBeltRank(RankName, TestFees);
            return RankID != -1;
        }

        private bool _UpdateBeltRank()
        {
            return clsBeltRankDataAccess.UpdateBeltRank(RankID, RankName, TestFees);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBeltRank())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_UpdateBeltRank())
                    {
                        return true;
                    }
                    else
                        return false;
            }

            return false;
        }

        public static bool DeleteBeltRank(int RankID)
        {
            return clsBeltRankDataAccess.DeleteBeltRank(RankID);
        }

        public static DataTable ListBeltRanks()
        {
            return clsBeltRankDataAccess.GetAllBeltRanks();
        }
    }
}
