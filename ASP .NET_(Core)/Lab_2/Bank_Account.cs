using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //3. Write a pogram to Create a class Bank_Account with Account_No, Email,
    //User_Name, Account_Type and Account_Balance as data members.Also
    //create a Member function GetAccountDetails() & DisplayAccountDetails(). 

    internal class Bank_Account
    {
        public int Account_No;
        public string Email;
        public string User_Name;
        public string Account_Type;
        public int Account_Balance;

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account_No : ");
            Account_No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Email : ");
            Email = Console.ReadLine();

            Console.WriteLine("Enter User_Name : ");
            User_Name = Console.ReadLine();

            Console.WriteLine("Enter Account_Type : ");
            Account_Type = Console.ReadLine();

            Console.WriteLine("Enter account_Balance : ");
            Account_Balance = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account_No = " + Account_No);
            Console.WriteLine("Email = " + Email);
            Console.WriteLine("User_Name = " + User_Name);
            Console.WriteLine("Account_Type = " + Account_Type);
            Console.WriteLine("Account_Balance = " + Account_Balance);
        }
    }
}
