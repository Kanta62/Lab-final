using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruct_Account
{
    class Fixed : Account
    {

        private int tenureYear;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }

        private int createYear;

        public int CreateYear
        {
            get { return CreateYear; }
            set { CreateYear = value; }
        }

        public Fixed()
        {

        }

        public Fixed(string accName, string accNo, double balance, int createYear, int tenureYear) : base(accName, accNo, balance)
        {

            this.createYear = createYear;
            this.tenureYear = tenureYear;

        }

        public override void Withdraw(double ammount)
        {
            string currentYear = DateTime.Now.Year.ToString();
            int cyear = Int32.Parse(currentYear);
            if ((cyear - createYear) >= tenureYear && Balance - ammount >= 0)
            {
                Balance -= ammount;
                Console.WriteLine("Fixed Account withdraw successfull..");
            }

            else
            {
                if ((cyear - createYear) < tenureYear)
                    Console.WriteLine("Account is not ready for withdraw ammount...");
                else
                    Console.WriteLine("Insufficient balance..");
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Account Opening Year: " + createYear);
            Console.WriteLine("Account Tenure Year: " + tenureYear);
        }
    }
}
