﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            Console.WriteLine("num1: " + num1 + ", num2: " + num2);
            Swap(ref num1, ref num2);
            Console.WriteLine("num1: " + num1 + ", num2: " + num2);
            Console.ReadKey();
        }

        //static void Swap(int number1, int number2) // pass-by-value
        //{
        //    int temp = number1;
        //    number1 = number2;
        //    number2 = temp;
        //}
        static void Swap(ref int number1, ref int number2) // pass-by-reference
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }
    }
}
