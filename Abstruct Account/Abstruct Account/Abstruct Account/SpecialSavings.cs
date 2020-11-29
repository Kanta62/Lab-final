using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruct_Account
{
    class SpecialSavings : Account
    {


        private int transactionNo;

        public int TransactionNo
        {
            get { return transactionNo; }
            set { transactionNo = value; }
        }

        private int transCount;

        public int TransCount
        {
            get { return transCount; }
            set { transCount = value; }
        }

        private double openingBalance;

        public double OpeningBalance
        {
            get { return openingBalance; }
            set { openingBalance = value; }
        }

        private int depositeCount;

        public int DepositeCount
        {
            get { return depositeCount; }
            set { depositeCount = value; }
        }


        public SpecialSavings()
        {

        }

        public SpecialSavings(string accName, string accNo, double balance, int transactionNo) : base(accName, accNo, balance)
        {
            this.transactionNo = transactionNo;
            DepositeCount++;
            if (depositeCount == 1)
            {
                OpeningBalance = balance;

            }
            OpeningBalance = balance;
        }

        public override void Withdraw(double amount)
        {
            transCount++;
            if ((transCount <= transactionNo) && (Balance - amount >= (OpeningBalance / 5)))
            {
                Balance -= amount;
                Console.WriteLine("Special Savings Account withdraw successfull..");
            }
            else
            {
                if (transCount > transactionNo)
                {
                    Console.WriteLine("Minimal number of transaction reached.");
                }

                else
                    Console.WriteLine("Insufficient Balance");
            }

        }
    }
}
