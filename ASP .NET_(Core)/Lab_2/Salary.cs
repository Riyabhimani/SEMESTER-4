using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //7. Write a program to Define a class Salary which will contain member variable Basic, TA, DA, HRA.
    //Write a program using Constructor with default values for DA and HRA and calculate the salary of employee.
    internal class Salary
    {
        public double Basic;
        public double TA;
        public double DA;
        public double HRA;

        public Salary(double basic, double tA, double d, double h)
        {
            Basic = basic;
            TA = tA;
            DA = d;
            HRA = h;
        }

        public void salaryOfEmployee()
        {
            double sal = Basic + TA + DA + HRA;
            Console.WriteLine("Salary of employee = " + sal);
        }
    }
}
