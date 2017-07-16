using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8Part9
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1, operand2;
            char op;
            Console.Write("Enter operand 1: ");
            operand1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operand 2: ");
            operand2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an operator: ");
            op = Convert.ToChar(Console.ReadLine());
            if (op == '+')
                Console.WriteLine(operand1 + operand2);
            else if (op == '-')
                Console.WriteLine(operand1 - operand2);
            else if (op == '*')
                Console.WriteLine(operand1 * operand2);
            else if (op == '/')
                Console.WriteLine(operand1 / operand2);
            else
                Console.WriteLine("Didn't recognize operator!");
            Console.ReadKey();
        }
    }
}
