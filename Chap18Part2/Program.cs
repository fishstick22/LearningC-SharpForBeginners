using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap18Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Now is the time for all good people";
            //int start = 0;
            //int space = sentence.IndexOf(" ");
            //string word = sentence.Substring(start, space - start);
            //Console.WriteLine(word);
            //start = space + 1;
            //space = sentence.IndexOf(" ", space + 1);
            //word = sentence.Substring(start, space - start);
            //Console.WriteLine(word);
            char[] delimiter = new char[1] { ' ' };
            string[] words = sentence.Split(delimiter);
            foreach (string word in words)
                Console.WriteLine(word);
            Console.WriteLine("Finished");
            Console.ReadKey();
        }

        static void StringEx()
        {
            string name, record;
            record = "";
            int grade1, grade2;
            for (int i = 1; i < 26; ++i)
            {
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Grade 1: ");
                grade1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Grade 2: ");
                grade2 = Convert.ToInt32(Console.ReadLine());
                record += name + "," + grade1 + "," + grade2;
                // write record to file
                // reset data items
            }
        }

        static void StringBuilderEx()
        {
            string name;
            int grade1, grade2;
            StringBuilder record = new StringBuilder();
            for (int i = 1; i < 26; ++i)
            {
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Grade 1: ");
                grade1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Grade 2: ");
                grade2 = Convert.ToInt32(Console.ReadLine());
                record.Append(name).Append(",").Append(grade1).Append(",").Append(grade2);
                // write record to file
                // reset data items
            }
        }
    }
}
