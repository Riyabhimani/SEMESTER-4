using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    //Program-6
    //6. Create a BankAccount class having constructor accepting initialBalance and
    //accountHolderName.Also create Deposite() and withdraw() overloaded
    //methods by which user can deposit/withdraw amount using different types
    //of parameters(ex.cash, check).

    internal class BankAccount
    {
        double initialBalance;
        string accountHolderName;

        public BankAccount(double initialBalance , string accountHolderName)
        {
            this.initialBalance = initialBalance;
            this.accountHolderName = accountHolderName;
        }

        public void deposite()
        {
            Console.WriteLine("This is a deposite method.");
        }
        public void deposite(string type)
        {
            if(type == "cash")
            {
                Console.WriteLine("Deposited in cash !! ");
                Console.WriteLine("Balance = " +initialBalance);
                Console.WriteLine("Holder Name = " + accountHolderName);
            }
            else
            {
                Console.WriteLine("Deposited in cheque !! ");
            }
        }

        public void withdraw()
        {
            Console.WriteLine("This is a withdraw method.");
        }

        public void withdraw(string type)
        {
            if (type == "cash")
            {
                Console.WriteLine("Withdraw by cash !! ");
                Console.WriteLine("Balance = " + initialBalance);
                Console.WriteLine("Holder Name = " + accountHolderName);
            }
            else
            {
                Console.WriteLine("Withdraw by cheque !! ");
            }
        }
    }
}
