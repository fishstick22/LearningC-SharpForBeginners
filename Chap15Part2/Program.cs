using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            //for (int i = 0; i < numbers.Length; ++i)
            //    sum += numbers[i];
            //sum = numbers[0] + numbers[1];
            int[] numbers = new int[10];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; ++i)
                numbers[i] = rand.Next(1, 101);
            for (int i = 0; i < numbers.Length; ++i)
                Console.Write(numbers[i] + " ");
            for (int i = 0; i < numbers.Length; ++i)
                sum += numbers[i];
            Console.WriteLine();
            double average = sum / numbers.Length;
            Console.WriteLine("The average is " + average);

            Console.ReadKey();
        }
    }
}
