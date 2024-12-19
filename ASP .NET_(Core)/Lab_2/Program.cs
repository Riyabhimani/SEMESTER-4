using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Program-1
            //1.Write a program to create a class named Candidate with ID, Name, Age, 
            //    Weight and Height as data members & also create a member functions like
            //    GetCandidateDetails() and DisplayCandidateDetails().  

            //Candidate candidate = new Candidate();
            //candidate.GetCandidateDetails();
            //candidate.DisplayCandidateDetails();

            //Program-2
            //2.Write a program to create a class Staff having data members as Name, 
            //    Department, Designation, Experience & Salary.Accept this data for 5 
            //    different staffs and display only names & salary of those staff who are
            //    HOD.

            //Staff[] s = new Staff[2];
            //for (int i = 0; i < s.Length; i++)
            //{
            //    s[i] = new Staff();
            //    s[i].GetDetails();
            //}
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i].Designation == "HOD")
            //    {
            //        s[i].Display();
            //    }
            //}

            //Program-3
            //3.Write a pogram to Create a class Bank_Account with Account_No, Email,
            //User_Name, Account_Type and Account_Balance as data members.Also
            //create a Member function GetAccountDetails() & DisplayAccountDetails(). 

            //Bank_Account bank_Account = new Bank_Account();
            //bank_Account.GetAccountDetails();
            //bank_Account.DisplayAccountDetails();

            //Program-4
            //Write a program with following specifications:  
            //Class Name: Student
            //Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
            //Get Students Details using constructor and DisplayStudentDetails() using
            //member function. 

            //Student stu = new Student();
            //stu.DisplayStudentDetails();

            //Program-5
            //5.Write a program to calculate area of a Rectangle using constructor.

            //Area_Of_Rectangle area = new Area_Of_Rectangle();
            //area.GetDetails();
            //area.DisplayArea();

            // Program-6
            //6.Write a program for implementing single inheritance which creates one
            //class Account_Details for getting account information and another class
            //Interest for calculating and displaying total interest from the data inserted
            //from account details.

            //Interest interest = new Interest();
            //interest.GetAccountDetails();
            //interest.CalculateAndDisplayInterest();

            // Program-7
            //7.Write a program to Define a class Salary which will contain member
            //variable Basic, TA, DA, HRA. Write a program using Constructor with default 
            //values for DA and HRA and calculate the salary of employee.

            //Console.WriteLine("Enter Basic Salary : ");
            //double basic = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter TA : ");
            //double tA = Convert.ToDouble(Console.ReadLine());
            //Salary s = new Salary(basic, tA , 5000.2 , 7000);
            //s.salaryOfEmployee();

            //Program-8
            //8.Write a program to Define a class Distance have data members dist1, dist2,
            //dist3. Initialize the two data members using constructor and store their
            //addition in third data member using function and display addition.

            //Console.WriteLine("Enter dist1 : ");
            //float dist1 = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("Enter dist2 : ");
            //float dist2 = Convert.ToSingle(Console.ReadLine());
            //Distance distance = new Distance(dist1, dist2);
            //distance.add();

            //Program-9
            //9.Create a class Furniture with material, price as data members.Create
            //another class Table with Height, surface_area as data members.Write a
            //program to implement single inheritance.

            //Furniture fur = new Furniture();
            //fur.data();
            //fur.display();

            //Console.WriteLine("Enter height of a table : ");
            //float height = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("Enter surface area of a table : ");
            //float surface_area = Convert.ToSingle(Console.ReadLine());
            //Table tb = new Table(fur.material, fur.price, height, surface_area);
            //tb.displayTableDetail();

            // Program-10
            //10.Program to implement the following multiple inheritance using interface
            //Interface : Gross
            //Method- Gross_sal()
            //Class : Salary
            //Data Members - HRA, TA,DA
            //Methods - Disp_sal()
            //Class : Employee
            //Data Members - Name
            //Methods - basic_sal()

            Console.WriteLine("Enter your name : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Basic Salary : ");
            double Basic_sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter HRA : ");
            double HRA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter TA : ");
            double TA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter DA : ");
            double DA = Convert.ToDouble(Console.ReadLine());

            Salary2 salary2 = new Salary2();
            salary2.Disp_Sal(HRA,TA,DA);

            Employee employee = new Employee(HRA,TA,DA);
            employee.basic_sal(Name,Basic_sal);
            employee.Gross_Sal();
        }
}
}
