using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap16Part9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int num in numbers)
                Console.Write(num + " ");
            Console.WriteLine();
            int[] numerals = new int[10];
            for (int i = 0; i < 10; ++i)
                numerals[i] = i + 1;
            //IEnumerable<int> nums = numbers;
            IEnumerable<int> numers = numerals;
            //IEnumerator<int> enumerator = nums.GetEnumerator();
            IEnumerator<int> enumerator = numers.GetEnumerator();
            while (enumerator.MoveNext())
                Console.Write(enumerator.Current + " ");
            Console.ReadKey();

        }
    }
}
