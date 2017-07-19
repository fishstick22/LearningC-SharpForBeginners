using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Chap17Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter outFile = new StreamWriter("c:\\temp\\stuff.txt");
            string line;
            for (int i = 1; i <= 5; ++i)
            {
                Console.Write("Enter a line of data: ");
                line = Console.ReadLine();
                outFile.WriteLine(line);
            }
            outFile.Close();
            Console.ReadKey();
        }
    }
}
