using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            Heading("McMillan", "08/05/11");
            Console.ReadKey();
        }

        static void Heading(String name, String date)
        {
            Console.WriteLine("************************");
            Console.WriteLine("*    " + name + "          *");
            Console.WriteLine("*    " + date + "          *");
            Console.WriteLine("************************");
        }
    }
}
