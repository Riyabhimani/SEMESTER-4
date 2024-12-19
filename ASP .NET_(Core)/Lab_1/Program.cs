using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program-1
            //    1.Write a program to print your name, address, contact number & city.

            //Console.WriteLine("Riya Bhimani");
            //Console.WriteLine("Haridarshan Appartment");
            //Console.WriteLine(7859863216);
            //Console.WriteLine("Morbi");

            //Program-2
            //    2.Write a program to get two numbers from user and print those two
            //        numbers.

            //Console.WriteLine("Enter Number 1 : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Number 2 : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number 1 = " +a);
            //Console.WriteLine("Number 2 = "+b);

            //Program-3
            //    3.Write program to prompt a user to input his/ her name and country name
            //        and then output will be shown as given: Hello<yourname> from country
            //        <countryname>

            //Console.WriteLine("Enter Your Name : ");
            //String Name = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Enter Your Country : ");
            //String Country = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Hello "+Name+" from country "+Country);

            //Program-4
            //    4.Write a program to calculate the size of the area in square - feet based on
            //        Specified length and width. 

            //Console.WriteLine("Enter a length : ");
            //double length = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter a width : ");
            //double width = Convert.ToDouble(Console.ReadLine());
            //double Area = length * width;
            //Console.WriteLine("Area = " + Area);

            //Program-5
            //    5.Write a program to calculate area of Square, Rectangle and Circle.

            //// Square
            //Console.WriteLine("Enter a length Of Square: ");
            //double l = Convert.ToDouble(Console.ReadLine());
            //double AreaOfSquare = l * l;
            //Console.WriteLine("Area Of Square = " + AreaOfSquare);

            //// Rectangle
            //Console.WriteLine("Enter a length Of Rectangle: ");
            //double length = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter a width Of Rectangle: ");
            //double width = Convert.ToDouble(Console.ReadLine());
            //double AreaOfRectangle  = length * width;
            //Console.WriteLine("Area Of Rectangle = " + AreaOfRectangle);

            //// Circle
            //Console.WriteLine("Enter a radius of Circle : ");
            //double radius = Convert.ToDouble(Console.ReadLine());
            //double AreaOfCircle = 3.14 * radius * radius;
            //Console.WriteLine("Area Of Circle = " + AreaOfCircle);

            //Program-6
            //    6.Write a program to calculate Celsius to Fahrenheit and vice - versa using
            //        function.

            //Console.WriteLine("Enter Temp in Celcuis : ");
            //double C = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Temp in Fehrenheit is " + fahrenheit(C));
            //Console.WriteLine("Enter Temp in Fehrenheit : ");
            //double F = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Temp in Celcuis is " + celcius(F));

            //Program-7
            //    7.Write a program to find out Simple Interest using function. (I = PRN / 100) 
            Console.WriteLine("Enter P : ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter R : ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter N : ");
            double N = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Simple Interest = " + interest(P,R,N));

            //Program-8
            //    8. Write a program to create a Simple Calculator for two numbers (Addition, 
            //        Multiplication, Subtraction, Division) [Also using if…else & Switch Case] 8. Write a program to create a Simple Calculator for two numbers (Addition, 
            //        Multiplication, Subtraction, Division) [Also using if…else & Switch Case] 

            //Console.WriteLine("Enter a first Number : ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter a second Number : ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter 1 for Addition\n" +
            //                "Enter 2 for Subtraction\n" +
            //                "Enter 3 for Multiplication\n" +
            //                "Enter 4 for for Division\n");
            //int c = Convert.ToInt32(Console.ReadLine());

            //// If-Else

            //if (c == 1)
            //{
            //    Console.WriteLine(a + "+" + b + "=" + (a+b));
            //}
            //else if (c == 2)
            //{
            //    Console.WriteLine(a + "-" + b + "=" + (a - b));
            //}
            //else if (c == 3)
            //{
            //    Console.WriteLine(a + "*" + b + "=" + (a * b));
            //}
            //else if (c == 4)
            //{
            //    Console.WriteLine(a + "/" + b + "=" + (a / b));
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Operator");
            //}

            //// Switch-Case

            //switch (c)
            //{
            //    case 1 : 
            //        Console.WriteLine(a + "+" + b + "=" + (a + b));
            //        break;
            //    case 2 :
            //        Console.WriteLine(a + "-" + b + "=" + (a - b));
            //        break;
            //    case 3 :
            //        Console.WriteLine(a + "*" + b + "=" + (a * b));
            //        break;
            //    case 4 :
            //        Console.WriteLine(a + "/" + b + "=" + (a / b));
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Operator");
            //        break;
            //}

            //Program-9
            //    9.Write a program to Swapping without using third variable. 

            //Console.WriteLine("Enter a first Number a : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a second Number b : ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //a = a + b;
            //b = a - b;
            //a = a - b;

            //Console.WriteLine("a = "+ a);
            //Console.WriteLine("b = "+ b);

            //Program-10
            //    10.Write a program to find maximum numbers from given 3 numbers using
            //        ternary operator. 

            //Console.WriteLine("Enter a first Number a : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a second Number b : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a third Number c : ");
            //int c = Convert.ToInt32(Console.ReadLine());

            //int max = ((a > b) ? ((a > c) ? a : c) : ((b>c) ? b : c ));
            //Console.WriteLine("Maximum Number is "+max);

        }

        // For Program-6
        //static double fahrenheit(double C)
        //{
        //    return (9 / 5 * C ) + 32 ;
        //}

        //static double celcius(double F)
        //{
        //    return ( F-32 )*5/9;
        //}

        // For Program-7
        static double interest(double P , double R , double N)
        {
            return (P*R*N) / 100;
        }
    }
}
