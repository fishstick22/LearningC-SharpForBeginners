using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13Part4
{
    class Employee
    {
        private string name;
        private decimal salary;

        public Employee(string n, decimal s)
        {
            name = n;
            salary = s;
        }

        public virtual string displayInfo()
        {
            return "Name: " + name + "\n" +
                "Salary: " + salary + "\n";
        }
    }

    class Manager : Employee
    {
        private string department;

        public Manager(string n, decimal s, string d)
            : base(n, s)
        {
            department = d;
        }

        public override string displayInfo()
        {
            return base.displayInfo() + "Department: " + department + "\n";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Smith", 20000);
            Console.WriteLine(e1.displayInfo());
            Manager m1 = new Manager("Brown", 40000, "Sales");
            Console.WriteLine(m1.displayInfo());
            Console.ReadKey();
        }
    }
}
