using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// while (relational expression)
// {
//     statement block;
// }

namespace Chap9Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, rate;
            balance = 1000;
            rate = 1.02;
            int years = 1; // loop control variable
            while (years <= 5)
            {
                balance *= rate;
                ++years;
            }
            Console.WriteLine("The balance after five years is " + balance);
            Console.ReadKey();
        }
    }
}
