using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Employee
    {
        public int EmployeeID;
        public string Name;
        public double Salaries;
        public double TotalSalary;

        public void InputDetails()
        {
            Console.WriteLine("Enter EmployeeID :");
            int EmployeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name :");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Salaries :");
            double Salaries = Convert.ToDouble(Console.ReadLine());
        }
        public Employee()
        {
            this.EmployeeID = EmployeeID;
            this.Name = Name;
            this.Salaries = Salaries;
        }
        public void DisplayDetails(int EmployeeID,string Name,double Salaries)
        {
            Console.WriteLine("EmployeeId = " + EmployeeID);
            Console.WriteLine("Employee Name = " + Name);
            Console.WriteLine("Employee Salaries = " + Salaries);
        }

        public void CalculateAnnualSalary(double hra , double ta, double da)
        {
            double TotalSalary;
            TotalSalary = Salaries + hra + ta + da;
            Console.WriteLine("Total Salary = "+TotalSalary);
        }
        
        public void DeterminePerfomance()
        {
            
            if(TotalSalary < 250000)
            {
                Console.WriteLine("Needs Improvement !");
            }
            else if (TotalSalary > 250000 && TotalSalary < 499999)
            {
                Console.WriteLine("Good !");
            }
            else if (TotalSalary > 500000 && TotalSalary < 1000000)
            {
                Console.WriteLine("Excellent !");
            }
            else if (TotalSalary > 1000000)
            {
                Console.WriteLine("Outstanding !");
            }
        }
    }
}
