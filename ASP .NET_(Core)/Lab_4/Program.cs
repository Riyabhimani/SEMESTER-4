using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program-1
            //add(2, 3);
            //add(2.5, 3.5);

            //Program-2
            //double AreaOfSquare = area(5.0);
            //Console.WriteLine("Area Of Square = " + AreaOfSquare);

            //double AreaOfRectangle = area(5.0,3.0);
            //Console.WriteLine("Area Of Rectangle = " + AreaOfRectangle);

            //Program-3
            //RBI rBI = new RBI();
            //Console.WriteLine("Enter P : ");
            //double P = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter R : ");
            //float R = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Enter N : ");
            //float N = Convert.ToSingle(Console.ReadLine());
            //rBI.calculateInterest(P, R, N);

            //HDFC hDFC = new HDFC();
            //Console.WriteLine("Enter P1 : ");
            //double P1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter R1 : ");
            //float R1 = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Enter N1 : ");
            //float N1 = Convert.ToSingle(Console.ReadLine());
            //hDFC.calculateInterest(P1, R1, N1);

            //SBI sBI = new SBI();
            //Console.WriteLine("Enter P2 : ");
            //double P2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter R2 : ");
            //float R2 = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Enter N2 : ");
            //float N2 = Convert.ToSingle(Console.ReadLine());
            //sBI.calculateInterest(P2, R2, N2);

            //ICICI iCICI = new ICICI();
            //Console.WriteLine("Enter P3 : ");
            //double P3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter R3 : ");
            //float R3 = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Enter N3 : ");
            //float N3 = Convert.ToSingle(Console.ReadLine());
            //iCICI.calculateInterest(P3, R3, N3);

            //Program-4
            //Hospital hospital = new Hospital();
            //hospital.HospitalDetails();

            //Apollo apollo = new Apollo();
            //apollo.HospitalDetails();

            //Wockhardt wockhardt = new Wockhardt();
            //wockhardt.HospitalDetails();

            //Gokul_Superspeciality gokul_sup = new Gokul_Superspeciality();
            //gokul_sup.HospitalDetails();

            //Program-5
            //Area(10.5f);
            //Area(10,20);
            //Area(10);

            //Program-6
            BankAccount bankAccount = new BankAccount(50000,"Riya");
            bankAccount.deposite();
            bankAccount.deposite("cash");
            bankAccount.deposite("abc");
            bankAccount.withdraw();
            bankAccount.withdraw("cash");
            bankAccount.withdraw("abc");

        }

        // Program-1
        //1. Write a program using method overloading by changing datatype of
        //arguments to perform addition of two integer numbers and two float
        //numbers.

        public static void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void add(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        //Program-2
        //2. Write a program using method overloading by changing number of
        //uments to calculate area of square and rectangle.

        public static double area(double length)
        {
            return length * length;
        }
        public static double area(double length1, double width)
        {
            return length1 * width;
        }

        //Program-5
        //5. Write a programs to Find Area of Square, Rectangle and Circle using 
        //Method Overloading.

        public static void Area(float length)
        {
            Console.WriteLine("Area Of Square = " + (length*length));
        }

        public static void Area(double length , double width)
        {
            Console.WriteLine("Area Of Rectangle = " + (length * width));
        }
        public static void Area(double radius)
        {
            Console.WriteLine("Area Of Circle = " + (3.14*radius*radius));
        }
    }
}
