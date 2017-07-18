using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;
            int[] numbers = new int[size];
            BuildArray(numbers, size, 101);
            DisplayArray(numbers);
            Curve(numbers, 5);
            Console.WriteLine();
            DisplayArray(numbers);
            Console.ReadKey();
        }

        static void BuildArray(int[] arr, int size, int limit)
        {
            Random rand = new Random();
            for (int i = 0; i < size; ++i)
                arr[i] = rand.Next(1, limit);
        }

        static void DisplayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
        }

        static void Curve(int[] arr, int points)
        {
            for (int i = 0; i < arr.Length; ++i)
                arr[i] += points;
        }
    }
}
