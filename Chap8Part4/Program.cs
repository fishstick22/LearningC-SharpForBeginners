using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// if (relational expression) 
// { 
//     statement block;
// }
// if (relational expression) {
//    statement block;
// }
// else {
//    statement block;
// }

namespace Chap8Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary, hoursWorked;
            double grossPay = 0.0;
            Console.Write("Enter your salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter hours worked: ");
            hoursWorked = Convert.ToInt32(Console.ReadLine());
            if (hoursWorked <= 40)
            {
                grossPay = salary * hoursWorked;
            }
            else
            {
                grossPay = (salary * 40) + ((salary * 1.5) *
                  (hoursWorked - 40));
            }
            Console.WriteLine("Gross pay is: " + grossPay);
            Console.ReadKey();
        }
    }
}
