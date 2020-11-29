using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator basicCalculator = new BasicCalculator();

            Console.WriteLine(basicCalculator.sum(10, 5));
            Console.WriteLine(basicCalculator.sub(10, 5));
            Console.WriteLine(basicCalculator.multiplication(10, 5));
            Console.WriteLine(basicCalculator.division(10, 5));

            ScientificCalculator scientificCalculator = new ScientificCalculator();

            Console.WriteLine(scientificCalculator.root(121));
            Console.WriteLine(scientificCalculator.square(11));
            Console.WriteLine(scientificCalculator.sub(15, 5));
            Console.WriteLine(scientificCalculator.multiplication(15, 5));
            Console.ReadLine();


        }
    }
}
