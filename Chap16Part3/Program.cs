using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * do
 * {
 *    set of statements;
 * } while(relational expression);
*/

namespace Chap16Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int sum = 0;
            while (number <= 10)
            {
                sum += number;
                ++number;
            }
            Console.WriteLine("The total is " + sum);
            number = 11;
            sum = 0;
            do
            {
                sum += number;
                ++number;
            } while (number <= 10);
            Console.WriteLine("The total is " + sum);
            Console.ReadKey();
        }
    }
}
