using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap7Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello, world");
            //Console.WriteLine(1);
            //Console.WriteLine(2 + 3);
            //int num1 = 23;
            //Console.WriteLine(num1);
            String name = "Mary";
            String name1 = "Mark";
            //Console.WriteLine("hello, " + name);
            Console.WriteLine("hello, {0} and {1}", name, name1);
            Console.WriteLine("hello, " + name + " and " + name1);
            Console.ReadKey();
        }
    }
}
