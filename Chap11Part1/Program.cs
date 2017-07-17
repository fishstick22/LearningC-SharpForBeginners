using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int grade1, grade2, grade3;
            //grade1 = 89;
            //grade2 = 78;
            //grade3 = 92;
            //int sum = grade1 + grade2 + grade3;
            //double average = sum / 3;
            //Console.WriteLine("The average is " + average);
            List<int> grades = new List<int>();
            grades.Add(89);
            grades.Add(78);
            grades.Add(92);
            double average = grades.Sum() / grades.Count();
            Console.WriteLine("The average is " + average);
            Console.ReadKey();
        }
    }
}
