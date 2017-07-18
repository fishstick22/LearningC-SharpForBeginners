using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15Part6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grades = { { 78, 82, 90 }, { 89, 86, 91 }, { 100, 98, 99 } };
            int sum = SumArray(grades);
            double average = sum / grades.Length;
            Console.WriteLine("The average grade is " + average);
            Console.ReadKey();
        }

        static int SumArray(int[,] arr)
        {
            int sum = 0;
            for (int row = 0; row <= arr.GetUpperBound(0); ++row)
            {
                for (int col = 0; col <= arr.GetUpperBound(1); ++col)
                    sum += arr[row, col];
            }
            return sum;
        }
    }
}
