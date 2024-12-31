using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2
{
    //10. Program to implement the following multiple inheritance using interface
    //    Interface : Gross
    //    Method- Gross_sal() 
    //    Class : Salary
    //    Data Members - HRA, TA,DA
    //    Methods - Disp_sal()
    //    Class : Employee
    //    Data Members - Name
    //    Methods - basic_sal()

    internal interface Gross
    {
        void Gross_Sal();
 
    }
    class Employee : Salary2, Gross
    {
        String Name;
        double Basic_sal;

        public Employee(double HRA , double TA , double DA)
        {
            this.HRA = HRA;
            this.TA = TA;
            this.DA = DA;
        }
        public void basic_sal(String Name, double Basic_sal)
        {
            Console.WriteLine("Employee Name = " + Name);
            Console.WriteLine("Basic Salary = " + Basic_sal);
        }

        public void Gross_Sal()
        {
            double Salary = Basic_sal + HRA + TA + DA;
            Console.WriteLine("Salary = " +Salary);

        }
    }

    class Salary2
    {
        public double HRA;
        public double TA;
        public double DA;

        public void Disp_Sal(double HRA, double TA , double DA)
        {
            Console.WriteLine("HRA = " + HRA);
            Console.WriteLine("TA = " + TA);
            Console.WriteLine("DA = " + DA);
        }
    }
}
