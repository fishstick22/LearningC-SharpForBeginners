using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5Part2
{
    class Name
    {
        private String first, middle, last;

        public Name(String fname, String mname, String lname)
        {
            first = fname;
            middle = mname;
            last = lname;
        }

        public override String ToString()
        {
            return first + " " + middle + " " + last;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Name myName = new Name("Michael", "Mason", "McMillan");
            Console.WriteLine(myName.ToString());
        }
    }
}
