using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap9Part7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i < 11; ++i)
            {
                sum += i;
            }
            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
