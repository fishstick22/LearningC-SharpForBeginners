using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Chap17Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputfile = "c:\\data\\chars.txt";
            String outputFile = "c:\\data\\chars.bak";
            StreamReader inFile = new StreamReader(inputfile);
            StreamWriter outFile = new StreamWriter(outputFile);
            char ch;
            ch = Convert.ToChar(inFile.Read());
            while (inFile.Peek() != -1)
            {
                outFile.Write(ch);
                ch = Convert.ToChar(inFile.Read());
            }
            outFile.Close();
            inFile.Close();
            Console.Write("Finished.");
            Console.ReadKey();
        }
    }
}
