using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap16Part7
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
                Console.WriteLine(calc(operand1, operand2, op));
                Console.Write("Another calculation (y/n)? ");
                more = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Thank you for using the calculator.");
            Console.ReadKey();
        }

        static double calc(double operand1, double operand2, char op)
        {
            double result = 0.0;
            //if (op == '+')
            //    result = (operand1 + operand2);
            //else if (op == '-')
            //    result = (operand1 - operand2);
            //else if (op == '*')
            //    result = (operand1 * operand2);
            //else if (op == '/')
            //    result = (operand1 / operand2);
            switch (op)
            {
                case '+':
                    result = operand1 + operand2;
                    break;
                case '-':
                    result = operand1 - operand2;
                    break;
                case '*':
                    result = operand1 * operand2;
                    break;
                case '/':
                    result = operand1 / operand2;
                    break;
                default:
                    Console.WriteLine("Bad operator");
                    break;
            }
            return result;
        }
    }
}
