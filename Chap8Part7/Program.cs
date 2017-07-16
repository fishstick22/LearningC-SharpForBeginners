using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8Part7
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade;
            String letterGrade;
            Console.Write("Enter a numeric grade: ");
            grade = Convert.ToInt32(Console.ReadLine());
            if (grade >= 90)
                letterGrade = "A";
            else if (grade >= 80)
                letterGrade = "B";
            else if (grade >= 70)
                letterGrade = "C";
            else if (grade >= 60)
                letterGrade = "D";
            else
                letterGrade = "F";
            Console.WriteLine("The letter grade is " + letterGrade);
            Console.ReadKey();
        }
    }
}
