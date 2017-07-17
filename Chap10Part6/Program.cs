using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10Part6
{
    class Program
    {
        static void Main(string[] args)
        {
            //double amt, disc;
            //Console.Write("Enter the original cost: ");
            //amt = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter the discount in whole number form: ");
            //disc = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Your final cost is: " + discount(amt, disc));
            double bill, tip;
            Console.Write("Enter the amount of the bill: ");
            bill = Convert.ToDouble(Console.ReadLine());
            tip = tipCalc(bill);
            Console.WriteLine("Your should tip " + tip);
            Console.ReadKey();
        }

        static double discount(double amount, double percent)
        {
            return (amount - (amount * (percent / 100)));
        }

        static double tipCalc(double amount)
        {
            return amount * .15;
        }
    }
}
