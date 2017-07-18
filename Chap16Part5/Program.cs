using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * foreach(datatype object in collection)
 * {
 *    set of statements;
 * }
 */

namespace Chap16Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numbers.Length; ++i)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
            foreach (int num in numbers)
                Console.Write(num + " ");
            List<string> names = new List<string>() { "Ed", "Mary", "Bob", "Jane", "Elizabeth" };
            foreach (string name in names)
                Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
