using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruct_Account
{


    abstract class Account
    {

        private string accName;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }

        private string accNo;

        public string AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }

        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }







        public Account()
        {

        }

        public Account(string accName, string accNo, double balance)
        {
            this.accName = accName;
            this.accNo = accNo;
            this.balance = balance;
        }

        public void Deposite(double ammount)
        {

            balance += ammount;


        }

        abstract public void Withdraw(double ammount);

        virtual public void ShowInfo()
        {
            Console.WriteLine("Acc Name: " + accName);
            Console.WriteLine("Acc No: " + accNo);
            Console.WriteLine("Balance: " + balance);
        }
    }

}