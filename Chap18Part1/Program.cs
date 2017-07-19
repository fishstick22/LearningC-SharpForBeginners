using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap18Part1
{
    class Program
    {
        static int a = 100; // global or class-level

        static void Main(string[] args)
        {
            Console.Write(a);
            for (int j = 0; j < 100; ++j)
                Console.Write(a); // block-level scope

        }

        static void TestMethod()
        {
            int a = 100; // local scope
            Console.Write(a);
        }
    }
}
