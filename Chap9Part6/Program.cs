using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap9Part6
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i < 101; i += 2)
            //    Console.Write(i + " ");
            String word = "hello world";
            for (int i = word.Length - 1; i > -1; --i)
                Console.Write(word.Substring(i, 1));
            Console.ReadKey();
        }
    }
}
