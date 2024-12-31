using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{

    //6. Write a program for implementing single inheritance which creates one
    //    class Account_Details for getting account information and another class
    //    Interest for calculating and displaying total interest from the data inserted
    //    from account details.
    
    // Base class
    internal class Account_Details
    {
        public string AccountHolder;
        public int AccountNumber;
        public double PrincipalAmount;
        public double RateOfInterest;
        public int TimePeriod;

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account Holder Name:");
            AccountHolder = Console.ReadLine();

            Console.WriteLine("Enter Account Number:");
            AccountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Principal Amount:");
            PrincipalAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Rate of Interest (in %):");
            RateOfInterest = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Time Period (in years):");
            TimePeriod = int.Parse(Console.ReadLine());
        }
    }

    class Interest : Account_Details
    {
        public void CalculateAndDisplayInterest()
        {
            double totalInterest = (PrincipalAmount * RateOfInterest * TimePeriod) / 100;
            Console.WriteLine("Account Holder: " + AccountHolder);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Total Interest: " + totalInterest);
        }
    }
}
