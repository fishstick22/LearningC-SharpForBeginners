using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Chap17Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextReader inFile = new StreamReader("c:\\data\\stuff.txt");
            //string line;
            //while (inFile.Peek() != -1)
            //{
            //    line = inFile.ReadLine();
            //    Console.WriteLine(line);
            //}
            //inFile.Close();
            TextWriter outFile = new StreamWriter("c:\\data\\grades.txt");
            int grade;
            for (int i = 1; i <= 5; ++i)
            {
                Console.Write("Enter a grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                outFile.WriteLine(grade);
            }
            outFile.Close();
            TextReader inFile = new StreamReader("c:\\data\\grades.txt");
            double average = 0.0;
            int total = 0;
            int count = 0;
            while (inFile.Peek() != -1)
            {
                grade = Convert.ToInt32(inFile.ReadLine());
                total += grade;
                ++count;
            }
            inFile.Close();
            average = total / count;
            Console.WriteLine("The average is " + average);
            Console.ReadKey();
        }
    }
}
