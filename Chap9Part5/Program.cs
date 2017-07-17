using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// for(init lcv; relational test; modify lcv)
// {
//    statement block;
// }

namespace Chap9Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; ++i)
            {
                sum += i;
            }
            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
