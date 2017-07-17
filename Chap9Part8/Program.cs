using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap9Part8
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 1;
            //while (number < 100)
            //{
            //    Console.WriteLine(number);
            //    if (number == 50)
            //        break;
            //    number++;
            //}
            double numerator, denominator;
            char more = 'y';
            while (more == 'y')
            {
                Console.Write("Enter numerator: ");
                numerator = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter denominator: ");
                denominator = Convert.ToDouble(Console.ReadLine());
                if (denominator == 0)
                {
                    Console.WriteLine("Can't divide by 0.");
                    continue;
                }
                else
                    Console.WriteLine(numerator / denominator);
                Console.Write("Another problem (y/n)? ");
                more = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Finished.");
            Console.ReadKey();
        }
    }
}
