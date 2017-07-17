using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11Part6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>() { 50, 60, 70, 80, 90, 100 };
            DisplayList(grades);
            Console.Write("The average of the grades is ");
            Console.WriteLine(average(grades));
            Console.WriteLine();
            curveGrades(grades);
            DisplayList(grades);
            Console.ReadKey();
        }

        static void DisplayList(List<int> lyst)
        {
            for (int i = 0; i < lyst.Count; ++i)
                Console.WriteLine(lyst[i]);
        }

        static double average(List<int> lyst)
        {
            //int sum = lyst.Sum();
            return lyst.Sum() / lyst.Count;
        }

        static void curveGrades(List<int> lyst)
        {
            for (int i = 0; i < lyst.Count; ++i)
                lyst[i] += 5;
        }
    }
}
