using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruct_Account
{
    class Savings : Account
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


        public Savings()
        {

        }

        public Savings(string accName, string accNo, double balance, int transactionNo) : base(accName, accNo, balance)
        {
            this.transactionNo = transactionNo;
        }

        public override void Withdraw(double amount)
        {
            transCount++;
            if (transCount <= transactionNo && Balance - amount >= 500)
            {
                Balance -= amount;
                Console.WriteLine("Savings Account withdraw successfull..");
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
