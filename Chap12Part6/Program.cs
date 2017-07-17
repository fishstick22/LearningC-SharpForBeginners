using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12Part6
{
    class Calculator
    {
        private double result;

        public Calculator()
        {
            result = 0;
        }

        public double Add(double operand1, double operand2)
        {
            result = operand1 + operand2;
            return result;
        }

        public double Subtract(double operand1, double operand2)
        {
            result = operand1 - operand2;
            return result;
        }

        public double Product(double operand1, double operand2)
        {
            result = operand1 * operand2;
            return result;
        }

        public double Divide(double operand1, double operand2)
        {
            result = operand1 / operand2;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(1, 1));
            Console.WriteLine(calc.Subtract(12.2, 1.1));
            Console.WriteLine(calc.Product(12, 12));
            Console.WriteLine(calc.Divide(2.3, .75));
            Console.ReadKey();
        }
    }
}
