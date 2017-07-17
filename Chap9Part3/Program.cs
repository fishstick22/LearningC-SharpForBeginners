using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap9Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 1; // loop-control variable
            //int sum = 0;
            //while (number <= 10)
            //{
            //    sum += number;
            //    ++number;
            //}
            //Console.WriteLine("The sum is " + sum);
            double balance, rate;
            int years = 0;
            balance = 1000;
            rate = 1.02;
            while (balance < 5000)
            {
                balance *= rate;
                ++years;
            }
            Console.WriteLine("It will take " + years + " years to reach $5000.");
            Console.ReadKey();
        }
    }
}
