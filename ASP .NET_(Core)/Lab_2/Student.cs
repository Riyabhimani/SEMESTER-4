using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{

    //Write a program with following specifications:  
    //Class Name: Student
    //Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
    //Get Students Details using constructor and DisplayStudentDetails() using
    //member function.

    internal class Student
    {
        public int Enrollment_No;
        public string Student_Name;
        public int Semester;
        public double CPI;
        public double SPI;

        public Student()
        {
            Console.WriteLine("Enter Enrollment_No : ");
            Enrollment_No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student_Name : ");
            Student_Name = Console.ReadLine();

            Console.WriteLine("Enter Semester : ");
            Semester = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter CPI : ");
            CPI = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter SPI : ");
            SPI = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("Enrollment_No : " + Enrollment_No);
            Console.WriteLine("Student_Name : " + Student_Name);
            Console.WriteLine("Semester : " + Semester);
            Console.WriteLine("CPI : " + CPI);
            Console.WriteLine("SPI : " + SPI);
        }
    }
}
