using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// sign(x) = -1 if x < 0
//         = 0 if x = 0
//         = 1 if x > 0

namespace Chap8Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sign;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                sign = -1;
            }
            else
            {
                if (number == 0)
                {
                    sign = 0;
                }
                else
                {
                    sign = 1;
                }
            }
            Console.Write("The sign of " + number + " is " + sign);
            Console.ReadKey();
        }

    }
}
