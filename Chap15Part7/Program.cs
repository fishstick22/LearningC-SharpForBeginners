using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15Part7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int num;
            const int size = 101;
            int[] numbers = new int[size];
            for (int i = 1; i < size; ++i)
            {
                num = rand.Next(1, 101);
                numbers[num]++;
            }
            for (int i = 1; i < numbers.Length; ++i)
                Console.WriteLine(i + ": " + numbers[i]);
            Console.ReadKey();
        }
    }
}
