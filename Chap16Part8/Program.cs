using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap16Part8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number, guess;
            String cont;
            number = rand.Next(11);
            cont = "y";
            //while (cont == "y")
            //{
            //    Console.Write("Guess a number between 1 and 10: ");
            //    guess = Convert.ToInt32(Console.ReadLine());
            //    if (guess == number)
            //    {
            //        Console.WriteLine("That's right!");
            //        break;
            //    }
            //    Console.Write("Sorry. Want to guess again (y/n)? ");
            //    cont = Console.ReadLine();
            //}
            do
            {
                Console.Write("Guess a number between 1 and 10: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("That's right!");
                    break;
                }
                Console.Write("Sorry. Wnat to try again (y/n)? ");
                cont = Console.ReadLine();
            } while (cont == "y");
            Console.WriteLine("Thanks for playing.");
            Console.ReadKey();
        }
    }
}
