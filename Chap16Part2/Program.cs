using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap16Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter;
            Console.Write("Enter a letter grade: ");
            letter = Console.ReadLine();
            switch (letter)
            {
                case "A":
                case "B":
                case "C":
                    Console.WriteLine("Pass");
                    break;
                case "D":
                case "F":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Didn't recognize input");
                    break;
            }
            Console.ReadKey();
        }
    }
}
