using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap9Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            //double average = 0.0;
            //int total, grade, count;
            //total = 0;
            //count = 0;
            //Console.Write("Enter a grade (-1 to quit): ");
            //grade = Convert.ToInt32(Console.ReadLine());
            //while (grade != -1)
            //{
            //    total += grade;
            //    ++count;
            //    Console.Write("Enter a grade (-1 to quit): ");
            //    grade = Convert.ToInt32(Console.ReadLine());
            //}
            //average = total / count;
            //Console.WriteLine("The average is " + average);
            int largest = 0;
            int number;
            Console.Write("Enter a number (0 to quit): ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                if (number > largest)
                    largest = number;
                Console.Write("Enter a number (0 to quit): ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The largest number is " + largest);
            Console.ReadKey();
        }
    }
}
