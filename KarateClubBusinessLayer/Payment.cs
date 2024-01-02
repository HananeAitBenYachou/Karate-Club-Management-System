using KarateClubDataAccessLayer;
using System;
using System.Data;

namespace KarateClubBusinessLayer
{
    public class clsPayment
    {
        private enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        public int PaymentID { get; private set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }

        public int MemberID { get; set; }

        public clsPayment()
        {
            this.PaymentID = -1;
            this.Amount = 0;
            this.Date = DateTime.Now;
            this.MemberID = -1;

            _Mode = enMode.AddNew;
        }

        private clsPayment(int PaymentID, double Amount, DateTime Date, int MemberID)
        {
            this.PaymentID = PaymentID;
            this.Amount = Amount;
            this.Date = Date;
            this.MemberID = MemberID;
            _Mode = enMode.Update;
        }

        public static clsPayment Find(int PaymentID)
        {
            double Amount = 0;
            DateTime Date = DateTime.Now;
            int MemberID = -1;

            if (clsPaymentDataAccess.GetPaymentByID(PaymentID, ref Amount, ref Date, ref MemberID))
            {
                return new clsPayment(PaymentID, Amount, Date, MemberID);
            }
            else
                return null;
        }

        public static bool IsPaymentExist(int PaymentID)
        {
            return clsPaymentDataAccess.IsPaymentExist(PaymentID);
        }

        private bool _AddNewPayment()
        {
            PaymentID = clsPaymentDataAccess.AddNewPayment(Amount, Date, MemberID);
            return PaymentID != -1;
        }

        private bool _UpdatePayment()
        {
            return clsPaymentDataAccess.UpdatePayment(PaymentID, Amount, Date, MemberID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPayment())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    if (_UpdatePayment())
                    {
                        return true;
                    }
                    else
                        return false;
            }

            return false;
        }

        public static bool DeletePayment(int PaymentID)
        {
            return clsPaymentDataAccess.DeletePayment(PaymentID);
        }

        public static int GetPaymentsCount()
        {
            return clsPaymentDataAccess.GetPaymentsCount();
        }

        public static DataTable ListPayments()
        {
            return clsPaymentDataAccess.GetAllPayments();
        }
    }
}
