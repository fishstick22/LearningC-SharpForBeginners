using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap16Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum, number;
            //sum = 0;
            //string more = "y";
            //while (more == "y")
            //{
            //    Console.Write("Enter a number: ");
            //    number = Convert.ToInt32(Console.ReadLine());
            //    sum += number;
            //    Console.Write("More (y/n)? ");
            //    more = Console.ReadLine();
            //}
            //Console.WriteLine("The sum is " + sum);
            int sum, number;
            string more;
            sum = 0;
            do
            {
                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;
                Console.Write("More (y/n)? ");
                more = Console.ReadLine();
            } while (more == "y");
            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
