using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grades = new int[5, 5];
            //int[,] grades = new int[2, 2] { { 88, 75 }, { 100, 99 } };
            Random rand = new Random();
            for (int row = 0; row < 5; ++row)
            {
                for (int col = 0; col < 5; ++col)
                    grades[row, col] = rand.Next(1, 101);
            }
            for (int row = 0; row < 5; ++row)
            {
                for (int col = 0; col < 5; ++col)
                    Console.Write(grades[row, col] + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
