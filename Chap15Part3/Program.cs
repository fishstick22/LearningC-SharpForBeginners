using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; ++i)
                numbers[i] = rand.Next(1, 101);
            for (int i = 0; i < numbers.Length; ++i)
                Console.Write(numbers[i] + " ");
            int sum = 0;
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; ++i)
                sum += numbers[i];
            Console.WriteLine("The sum from a loop is: " + sum);
            Console.WriteLine("The sum from the method sum is: " + numbers.Sum());
            double average = numbers.Sum() / numbers.Length;
            Console.WriteLine("The computed average is: " + average);
            Console.WriteLine("The average using a method is: " + numbers.Average());
            Console.ReadKey();
        }
    }
}
