using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13Part1
{
    class Account
    {
        private string id;
        private decimal balance;

        public Account()
        {
            id = "";
            balance = 0;
        }

        public Account(string idNum, decimal bal)
        {
            id = idNum;
            balance = bal;
        }

        public void deposit(decimal amount)
        {
            balance += amount;
        }

        public void withdraw(decimal amount)
        {
            balance -= amount;
        }

        public override string ToString()
        {
            return id + ": " + balance;
        }
    }

    class CheckingAccount : Account
    {
        public CheckingAccount(string idNum, decimal bal)
            : base(idNum, bal)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account acct = new Account("1", 100);
            Console.WriteLine(acct.ToString());
            acct.withdraw(10);
            Console.WriteLine(acct.ToString());
            acct.deposit(100);
            Console.WriteLine(acct.ToString());
            CheckingAccount cacct = new CheckingAccount("2", 5000);
            cacct.deposit(500);
            Console.WriteLine(cacct.ToString());
            cacct.withdraw(1000);
            Console.WriteLine(cacct.ToString());
            Console.ReadKey();

        }
    }
}
