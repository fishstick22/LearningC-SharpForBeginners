using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap16Part6
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
            List<CheckingAccount> accounts = new List<CheckingAccount>();
            CheckingAccount ca1 = new CheckingAccount("1", 500);
            CheckingAccount ca2 = new CheckingAccount("2", 1000);
            CheckingAccount ca3 = new CheckingAccount("3", 14000);
            CheckingAccount ca4 = new CheckingAccount("4", 2000);
            accounts.Add(ca1);
            accounts.Add(ca2);
            accounts.Add(ca3);
            accounts.Add(ca4);
            foreach (CheckingAccount acct in accounts)
            {
                Console.WriteLine(acct.ToString());
            }
            Console.ReadKey();
        }
    }
}
