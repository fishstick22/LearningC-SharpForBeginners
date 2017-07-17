using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature;
            char scale;
            Console.Write("Enter a temperature to convert: ");
            temperature = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a scale to convert to (f or c): ");
            scale = Convert.ToChar(Console.ReadLine());
            //Console.Write(temperature + " C. equals ");
            //Console.WriteLine(ctof(temperature) + " F.");
            Console.WriteLine("The converted temperature is " +
                convert(temperature, scale));
            Console.ReadKey();
        }

        static double convert(double temp, char scale)
        {
            if (scale == 'f')
                return ctof(temp);
            else if (scale == 'c')
                return ftoc(temp);
            else
                return -1;
        }

        static double ftoc(double temp)
        {
            return (temp - 32.0) * (5.0 / 9.0);
        }

        static double ctof(double temp)
        {
            return (temp * 9 / 5) + 32.0;
        }
    }
}
