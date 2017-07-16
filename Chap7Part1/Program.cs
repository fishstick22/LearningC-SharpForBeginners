using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap7Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //String name;
            //Console.Write("Enter your name: ");
            //name = Console.ReadLine();
            //Console.WriteLine("Your name is " + name + ".");
            char letter;
            Console.Write("Enter the letter Y or N: ");
            letter = Convert.ToChar(Console.Read());
            Console.WriteLine("You entered " + letter + ".");
            Console.ReadKey();
        }
    }
}
