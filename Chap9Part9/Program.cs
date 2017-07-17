using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap9Part9
{
    class Program
    {
        static void Main(string[] args)
        {
            String answer = "Watson";
            String response = "";
            //int tries = 1;
            //while (tries <= 3)
            //{
            //    Console.Write("Name the computer that played on Jeopardy? ");
            //    response = Console.ReadLine();
            //    if (response == answer)
            //    {
            //        Console.WriteLine("That's right!");
            //        break;
            //    }
            //    else if (tries < 3)
            //        Console.WriteLine("Sorry. Try again.");
            //    ++tries;
            //}
            for (int tries = 1; tries < 4; ++tries)
            {
                Console.Write("Name the computer that played on Jeopardy? ");
                response = Console.ReadLine();
                if (response == answer)
                {
                    Console.WriteLine("That's right!");
                    break;
                }
                else if (tries < 3)
                    Console.WriteLine("Sorry. Try again.");
            }
            if (response != answer)
                Console.WriteLine("Sorry. The answer is Watson.");

            Console.ReadKey();
        }
    }
}
