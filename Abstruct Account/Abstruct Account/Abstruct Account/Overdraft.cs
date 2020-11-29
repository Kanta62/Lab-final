using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruct_Account
{
    class Overdraft : Account
    {
        private double overdraftLimit;

        public double OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }





        public Overdraft()
        {

        }

        public Overdraft(string accName, string accNo, double balance, double overdraftLimit) : base(accName, accNo, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {

            if (amount <= Balance + overdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine("Overdraft Account withdraw successfull..");
            }
            else
                Console.WriteLine("Overdraft Limit crossed");

        }

    }
}
