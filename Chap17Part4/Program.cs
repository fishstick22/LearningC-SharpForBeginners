using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Chap17Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = "c:\\data\\chars.txt";
            StreamWriter outFile = new StreamWriter(fileName);
            String line = "Now is the time for all good people";
            outFile.WriteLine(line);
            outFile.Close();
            StreamReader inFile = new StreamReader(fileName);
            string words = "";
            char letter;
            while (inFile.Peek() != -1)
            {
                letter = Convert.ToChar(inFile.Read());
                Console.WriteLine(letter);
                words += letter;
            }
            Console.WriteLine(words);
            Console.ReadKey();
        }
    }
}
