using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8Part8
{
    class Program
    {
        static void Main(string[] args)
        {
            String answer = "Watson";
            String response = "";
            Console.Write("Let's play a guessing game. ");
            Console.WriteLine("You get three tries.");
            Console.Write("Name the computer that played Jeopardy? ");
            response = Console.ReadLine();
            if (response == answer)
                Console.WriteLine("That's right!");
            else
            {
                Console.Write("Sorry. Guess again: ");
                response = Console.ReadLine();
                if (response == answer)
                    Console.WriteLine("That's right!");
                else
                {
                    Console.Write("Sorry, wrong again. One more guess: ");
                    response = Console.ReadLine();
                    if (response == answer)
                        Console.WriteLine("That's right!");
                    else
                        Console.WriteLine("Wrong again. The answer is Watson.");
                }
            }
            Console.ReadKey();
        }
    }
}
