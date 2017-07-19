using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Chap18Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num, denom;
            //num = 12;
            //denom = 0;
            //try
            //{
            //    Console.Write(num / denom);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.Write("Enter a non-zero denominator: ");
            //    denom = Convert.ToInt32(Console.ReadLine());
            //    Console.Write(num / denom);
            //}
            StreamReader inFile;
            string fileName;
            Console.Write("Enter a file name to open: ");
            fileName = Console.ReadLine();
            try
            {
                inFile = new StreamReader(fileName);
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine(fe.Message);
                Console.Write("Enter another file name: ");
                fileName = Console.ReadLine();
                inFile = new StreamReader(fileName);
            }
            Console.WriteLine(inFile.ReadLine());
            Console.ReadKey();
        }
    }
}
