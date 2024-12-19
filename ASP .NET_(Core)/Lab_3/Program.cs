using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program-1
            //1.Write a program to Create a divide by zero exception and handle it. 

            //try
            //{
            //    Console.WriteLine("Enter Number1 : ");
            //    int number1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter a Number2 = ");
            //    int number2 = Convert.ToInt32(Console.ReadLine());
            //    double div = number2 / number1;
            //    Console.WriteLine("Division = " + div);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Exeption Occured !!");
            //}
            //finally
            //{
            //    Console.WriteLine("Finally Completed ! ");
            //}

            //Program-2 
            //2. Write a program that reads 5 numbers from user. Demonstrate concept of 
            //IndexOutOfRange Exception.

            //try
            //{
            //    int[] arr = new int[5];
            //    for (int i = 0; i < 6; i++)
            //    {
            //        Console.WriteLine("arr[" + i + "] = ");
            //        arr[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exeption Occured : ArrayOutOfBound !! ");
            //}

            //Program-3
            // 3. Write a program to create an abstract class Sum having abstract methods 
            //SumOfTwo(int a, int b) and SumOfThree(int a, int b, int c). Create another
            //class Calculate which extends the abstract class and implements the
            //abstract methods.

            //Calculate calculate = new Calculate();
            //calculate.SumOfTwo(10,20);
            //calculate.SumOfThree(10,20,30);

            // Program-4
            //4. Write a program to create interface Calculate. In this interface we have two 
            //member functions Addition() and Subtraction(). Implements this interface
            //in another class named Result.

            //Result result = new Result();
            //result.addition(10, 20);
            //result.subtraction(30, 20);

            // Program-5
            //5. Write program showing use of common methods of String class. 

            //string str;
            //Console.WriteLine("Enter a String : ");
            //str = Console.ReadLine();

            //// ToUpper() -- Converts characters in the string to uppercase
            //string newStr = str.ToUpper();
            //Console.WriteLine("ToUpper method - " + newStr);

            //// ToLower() -- Converts characters in the string to lowercase
            //string newStr1 = str.ToLower();
            //Console.WriteLine("ToLower method - " + newStr1);

            //// Concat() -- Concatenates (joins) strings
            //Console.WriteLine("Enter str2 for concate method : ");
            //string str2 = Console.ReadLine();
            //string newStr2 = string.Concat(str," ",str2);
            //Console.WriteLine("Concatination of " + str + " and " + str2 + " = " + newStr2);

            ////Equals() -- check equality of two strings
            //Console.WriteLine("Enter str3 for equals method : ");
            //string str3 = Console.ReadLine();
            //bool newStr3 = str.Equals(str3);
            //Console.WriteLine("Equality of "+str+" and "+str3+ " = " + newStr3);

            //// Substring() -- divided string into sub parts.
            //Console.Write("Substring method : ");
            //string newStr4 = str.Substring(0, 4);
            //Console.WriteLine("Substring of "+str+ " = " + newStr4);

            //// Remove() -- Deletes all the characters from begining to specified index.
            //string newStr5 = str.Remove(4);
            //Console.WriteLine("Remove till the 4th index in " + str + " = " + newStr5);

            //// EndsWith() -- check whether specified value is the last character of string.
            //bool newStr6 = str.EndsWith("i");
            //Console.WriteLine("Endswith i for "+str + " = " + newStr6);

            // Program-6
            //6.Write a program to Replace lower case characters to upper case and Vice-versa.

            //    Console.WriteLine("Enter a string:");
            //    string input = Console.ReadLine();

            //    char[] chars = input.ToCharArray();
            //    for (int i = 0; i < chars.Length; i++)
            //    {
            //        chars[i] = char.IsLower(chars[i]) ? char.ToUpper(chars[i]) : char.ToLower(chars[i]);
            //    }
            //Console.WriteLine(chars);

            // Program-7
            //7.Write a program to create interface named Shape.In this interface, we
            //have three methods Circle(), Triangle() and Square() which calculates area
            //of Circle, Triangle and Square respectively.Implement Shape interface. 

            //Area area = new Area();

            //Console.WriteLine("Enter Radius of Circle : ");
            //double r = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter Height of triangle : ");
            //double h = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter Width of triangle : ");
            //double w = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter Length of Square : ");
            //double l = Convert.ToDouble(Console.ReadLine());

            //double AreaOfCircle = area.circle(r);
            //Console.WriteLine(AreaOfCircle);

            //double AreaOfTriangle = area.triangle(h, w);
            //Console.WriteLine(AreaOfTriangle);

            //double AreaOfSquare = area.square(l);
            //Console.WriteLine(AreaOfSquare);

            // Program-8
            //8.Write a program to accept a number from the user and throw an exception
            //if the number is not an even number.

            //try
            //{
            //    Console.WriteLine("Enter a number:");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    if (number % 2 != 0)
            //    {
            //        throw new Exception("The number is not even!");
            //    }

            //    Console.WriteLine("The number is even.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            // Program-9
            //9.Write a program to find the longest word in a string.

            //Console.WriteLine("Enter a string:");
            //string input = Console.ReadLine();

            //string longestWord = "";
            //foreach (string word in input.Split(' '))
            //{
            //    if (word.Length > longestWord.Length)
            //        longestWord = word;
            //}
            //Console.WriteLine("Longest word: " + longestWord);

            // Program-10
            //10.Write a program to change the case of entered character.

            Console.WriteLine("Enter a character : ");
            char character = Convert.ToChar(Console.ReadLine());

            if (char.IsUpper(character))
            {
                char Letter = char.ToLower(character);
                Console.WriteLine(Letter);
            }
            else if (char.IsLower(character))
            {
                {
                    char letter = char.ToUpper(character);
                    Console.WriteLine(letter);
                }
            }
            else
            {
                Console.WriteLine("Entered character is special charcter !! \n" +
                    "Please Enter valid character !! ");
            }
        }
}
}
