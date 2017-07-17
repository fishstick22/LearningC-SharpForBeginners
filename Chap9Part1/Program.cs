using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap9Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, rate;
            balance = 1000;
            rate = 1.02;
            //balance *= rate;
            //balance *= rate;
            //balance *= rate;
            //balance *= rate;
            //balance *= rate;
            int years = 1;
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
