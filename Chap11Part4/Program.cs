using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            for (int i = 3; i < 101; ++i)
                numbers.Add(i);

            Console.ReadKey();
        }
    }
}
