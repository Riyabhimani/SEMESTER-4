using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Extra_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program-1
            //Write a program to find and display all prime numbers within a given range. 
            //The user should input the starting and ending values of the range, and the program 
            //should output all the prime numbers in that range.

            //    Console.WriteLine("Enter Starting Value Of Range:");
            //    int Num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter Ending Value Of Range:");
            //    int Num2 = Convert.ToInt32(Console.ReadLine());

            //    int min = 0;
            //    int max = 0;
            //    int Count = 0;

            //    if (Num1 > Num2)
            //    {
            //        min = Num2;
            //        max = Num1;
            //    }
            //    else
            //    {
            //        min = Num1;
            //        max = Num2;
            //    }

            //    for (int i = min; i <= max; i++) 
            //    {
            //        for (int j = 2; j <= i/2; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                Count++;
            //            }
            //        }
            //        if (Count == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //        Count = 0;
            //    }
            //}

            // Program-2
            //Create a class Student with attributes RollNumber, Name, and Marks(5 subjects),
            //and methods InputDetails(), DisplayDetails(), CalculateTotalMarks(), CalculatePercentage(), and DetermineGrade()
            //to input/display details, compute total marks, percentage, and assign grade based on percentage.
            //•  90% and above: Grade A
            //•  75% to 89%: Grade B
            //•  50% to 74%: Grade C
            //•  Below 50%: Grade F




            // Progem-7
            //Create a program that demonstrates the use of a copy constructor with a Time object. 
            //The Time class should store time in hours, minutes, and seconds, and provide functionality 
            //for adding times.

            //Time t1 = new Time(2, 55, 50);
            //Console.WriteLine("Original Time t1:");
            //t1.Display();

            //Console.WriteLine("");

            //Time t2 = new Time(t1);
            //Console.WriteLine("Copied Time t2:");
            //t2.Display();

            //Console.WriteLine("");

            //Time t3 = new Time(3, 50, 40);
            //Console.WriteLine("Another Time t3:");
            //t3.Display();

            //Console.WriteLine("");

            //t1.AddTime(t3);
            //Console.WriteLine("After Adding t3 to t1:");
            //t1.Display();


            // Extra-1
            // Write a program to determine if two given strings are anagram of each other.
            // for example."listen" and "silent" are anagrams but "hello" and "worls" are not.

            Console.WriteLine("Enter str1:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter str2:");
            string str2 = Console.ReadLine();

            int Count = 0;
            while(str1.Length==str2.Length)
                for (int i = 0; i < str1.Length; i++)
                {
                    if (!str2.Contains(str1[i]))
                    {
                        Console.WriteLine("Not anagram!");
                        break;
                    }
                    else
                    {
                        Count++;
                    }
                }
                if (Count == str1.Length)
                {
                    Console.WriteLine("Anagram!");
                    
                }
        }
    }
}
