using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * switch(integral expression)
 * {
 *    case (expression):
 *       set of statements;
 *       break;
 *    case (expression):
 *       set of statements;
 *       break;
 *    default:
 *       set of statements;
 *       break;
 * }
*/

namespace Chap16Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            Console.Write("Enter a letter grade: ");
            letter = Convert.ToChar(Console.ReadLine());
            switch (letter)
            {
                case 'A':
                    Console.WriteLine("90 to 100");
                    break;
                case 'B':
                    Console.WriteLine("80 to 89");
                    break;
                case 'C':
                    Console.WriteLine("70 to 79");
                    break;
                case 'D':
                    Console.WriteLine("60 to 69");
                    break;
                case 'F':
                    Console.WriteLine("Below 60");
                    break;
                default:
                    Console.WriteLine("Didn't recognize input");
                    break;
            }
            Console.ReadKey();
        }
    }
}
