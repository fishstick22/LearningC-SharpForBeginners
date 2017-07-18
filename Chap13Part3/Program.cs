using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13Part3
{
    class Account
    {
        protected string id;
        protected decimal balance;

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
            if ((balance - amount) >= overdraw)
                balance -= amount;
            else
                Console.WriteLine("Insufficient funds");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount acct = new CheckingAccount("1", 1000);
            acct.withdraw(1500);
            Console.WriteLine(acct.ToString());

            Console.ReadKey();
        }
    }
}
