using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<string> names = new List<string>();
            List<Boolean> flags = new List<Boolean>();
            List<char> letters = new List<char>();
            Console.WriteLine("The number of items in numbers is " + numbers.Count);
            numbers.Capacity = 10;
            Console.WriteLine("The number of items in numbers is " + numbers.Count);
            Console.ReadKey();
        }
    }
}
