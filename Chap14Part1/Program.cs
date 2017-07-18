using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// polymorphism - of many forms, or of multiple forms

namespace Chap14Part1
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
            List<Employee> names = new List<Employee>();
            Manager m1 = new Manager("Smith", 45000, "Sales");
            names.Add(m1);
            Employee e1 = new Employee("Brown", 20000);
            names.Add(e1);
            Manager m2 = new Manager("Green", 55000, "Finance");
            names.Add(m2);
            Employee e2 = new Employee("Jones", 15000);
            names.Add(e2);
            for (int i = 0; i < names.Count; ++i)
                Console.WriteLine(names[i].displayInfo());
            Console.ReadKey();
        }
    }
}
