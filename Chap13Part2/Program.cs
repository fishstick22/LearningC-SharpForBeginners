using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13Part2
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

        public virtual void withdraw(decimal amount)
        {
            balance -= amount;
        }

        public override string ToString()
        {
            return id + ": " + balance;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
    }

    class CheckingAccount : Account
    {

        private decimal overdraw = -400;

        public CheckingAccount(string idNum, decimal bal)
            : base(idNum, bal)
        {
        }

        public override void withdraw(decimal amount)
        {
            if ((base.Balance - amount) >= overdraw)
                base.Balance -= amount;
            else
                Console.WriteLine("Insufficient funds");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount myacct = new CheckingAccount("1", 1000);
            myacct.deposit(2000);
            myacct.withdraw(1500);
            Console.WriteLine(myacct.ToString());
            Console.ReadKey();
        }
    }
}
