using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //2. Write a program to create a class Staff having data members as Name, 
    //    Department, Designation, Experience & Salary.Accept this data for 5 
    //    different staffs and display only names & salary of those staff who are
    //    HOD.

    internal class Staff
    {
        public string name;
        public string Department;
        public string Designation;
        public int Experience;
        public int Salary;

        public void GetDetails()
        {
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Dept : ");
            Department = Console.ReadLine();

            Console.WriteLine("Enter Designation : ");
            Designation = Console.ReadLine();

            Console.WriteLine("Enter Exp : ");
            Experience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Salary : ");
            Salary = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Salary : " + Salary);
        }

        public string Design()
        {
            return Designation;
        }
    }
}
