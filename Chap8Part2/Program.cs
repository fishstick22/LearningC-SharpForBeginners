using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Logical And - &&
// Logical Or - ||

namespace Chap8Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "John";
            String password = "letmein";
            Boolean flag;
            flag = (name == "John" || name == "john");
            Console.WriteLine(flag);
            Console.ReadKey();
        }
    }
}
