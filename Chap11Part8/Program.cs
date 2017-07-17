using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11Part8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            BuildList(numbers);
            Display(numbers);
            int item;
            Console.Write("Enter an item: ");
            item = Convert.ToInt32(Console.ReadLine());
            //int position = numbers.IndexOf(item);
            if (numbers.Contains(item))
                Console.WriteLine(item + " is at position " + numbers.IndexOf(item));
            else
                Console.WriteLine(item + " not found.");
            Console.ReadKey();
        }

        static void BuildList(List<int> lyst)
        {
            Random rand = new Random();
            for (int i = 0; i < 100; ++i)
                lyst.Add(rand.Next(1, 101));
        }

        static void Display(List<int> lyst)
        {
            for (int i = 0; i < lyst.Count; ++i)
                if (i % 25 == 0)
                    Console.WriteLine();
                else
                    Console.Write(lyst[i] + " ");
            Console.WriteLine();
        }
    }
}
