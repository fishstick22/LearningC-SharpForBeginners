using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap9Part10
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1, operand2;
            char more = 'y';
            char op;
            while (more == 'y')
            {
                Console.Write("Enter operand 1: ");
                operand1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter operand 2: ");
                operand2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter operator: ");
                op = Convert.ToChar(Console.ReadLine());
                if (op == '+')
                    Console.WriteLine(operand1 + operand2);
                else if (op == '-')
                    Console.WriteLine(operand1 - operand2);
                else if (op == '*')
                    Console.WriteLine(operand1 * operand2);
                else if (op == '/')
                    Console.WriteLine(operand1 / operand2);
                Console.Write("Another calculation (y/n)? ");
                more = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Thank you for using the calculator.");
            Console.ReadKey();
        }
    }
}
