using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            number = number + 1;
            number = number - 1;
            ++number;
            number++;
            --number;
            number--;
            number += 2; // number = number + 2;
            number -= 3; // number = number - 3;
            number *= 4;
            number /= 5;

        }
    }
}
