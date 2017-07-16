using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 9;
            Console.WriteLine(Math.Sqrt(number));
            number = -9;
            Console.WriteLine(Math.Abs(number));
            Console.WriteLine(Math.Pow(number, 3));
            Console.ReadKey();
        }
    }
}
