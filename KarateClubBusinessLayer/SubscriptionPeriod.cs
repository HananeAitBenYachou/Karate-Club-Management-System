using KarateClubDataAccessLayer;
using System;
using System.Data;

namespace KarateClubBusinessLayer
{
    public class clsSubscriptionPeriod
    {
        private enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        public int PeriodID { get; private set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double Fees { get; set; }

        public bool Paid { get; set; }

        public int MemberID { get; set; }

        public int? PaymentID { get; private set; }

        public clsSubscriptionPeriod()
        {
            PeriodID = -1;
            PaymentID = -1;
            MemberID = -1;
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            Fees = 0;
            Paid = false;

            _Mode = enMode.AddNew;
        }

        private clsSubscriptionPeriod(int PeriodID, int MemberID, int? PaymentID, DateTime StartDate, DateTime EndDate, double Fees, bool Paid)
        {
            this.PeriodID = PeriodID;
            this.PaymentID = PaymentID;
            this.MemberID = MemberID;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Fees = Fees;
            this.Paid = Paid;

            _Mode = enMode.Update;
        }

        public static clsSubscriptionPeriod Find(int PeriodID)
        {
            int MemberID = -1;
            int? PaymentID = -1;
            DateTime StartDate = DateTime.Now, EndDate = DateTime.Now;
            double Fees = 0;
            bool Paid = false;

            if (clsSubscriptionPeriodDataAccess.GetSubscriptionPeriodByID(PeriodID, ref MemberID, ref PaymentID, ref StartDate, ref EndDate, ref Fees, ref Paid))
            {
                return new clsSubscriptionPeriod(PeriodID, MemberID, PaymentID, StartDate, EndDate, Fees, Paid);
            }

            else
                return null;
        }

        public static bool IsSubscriptionPeriodExist(int PeriodID)
        {
            return clsSubscriptionPeriodDataAccess.IsSubscriptionPeriodExist(PeriodID);
        }

        public static bool IsSubscriptionPeriodPaid(int PeriodID)
        {
            return clsSubscriptionPeriodDataAccess.IsSubscriptionPeriodPaid(PeriodID);

        }

        private bool _AddNewSubscriptionPeriod()
        {
            if (Paid)
            {
                PaymentID = clsPaymentDataAccess.AddNewPayment(Fees, DateTime.Now, MemberID);
            }

            else
                PaymentID = null;

            PeriodID = clsSubscriptionPeriodDataAccess.AddNewSubscriptionPeriod(MemberID, PaymentID, StartDate, EndDate, Fees, Paid);
            return PeriodID != -1;
        }

        private bool _UpdateSubscriptionPeriod()
        {
            if (Paid && PaymentID == null)
            {
                PaymentID = clsPaymentDataAccess.AddNewPayment(Fees, DateTime.Now, MemberID);
            }

            return clsSubscriptionPeriodDataAccess.UpdateSubscriptionPeriod(PeriodID, MemberID, PaymentID, StartDate, EndDate, Fees, Paid);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSubscriptionPeriod())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_UpdateSubscriptionPeriod())
                    {
                        return true;
                    }
                    else
                        return false;
            }

            return false;
        }

        public static bool DeleteSubscriptionPeriod(int PeriodID)
        {
            return clsSubscriptionPeriodDataAccess.DeleteSubscriptionPeriod(PeriodID);
        }

        public static int GetSubscriptionPeriodsCount()
        {
            return clsSubscriptionPeriodDataAccess.GetSubscriptionPeriodsCount();
        }

        public static DataTable ListSubscriptionPeriods()
        {
            return clsSubscriptionPeriodDataAccess.GetAllSubscriptionPeriods();
        }
    }
}
