using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11Part9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            BuildList(numbers);
            Display(numbers);
            numbers.Sort();
            Display(numbers);
            numbers.Reverse();
            Display(numbers);
            Console.ReadKey();
        }

        static void BuildList(List<int> lyst)
        {
            Random rand = new Random();
            for (int i = 0; i < 10; ++i)
                lyst.Add(rand.Next(1, 101));
        }

        static void Display(List<int> lyst)
        {
            for (int i = 0; i < lyst.Count; ++i)
                Console.Write(lyst[i] + " ");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
