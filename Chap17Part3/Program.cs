using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Chap17Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter outFile = File.AppendText("c:\\data\\stuff.txt");
            outFile.WriteLine("A new line");
            outFile.WriteLine("Another new line");
            outFile.Close();
            StreamReader inFile = new StreamReader("c:\\data\\stuff.txt");
            string line;
            while (inFile.Peek() != -1)
            {
                line = inFile.ReadLine();
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }
    }
}
