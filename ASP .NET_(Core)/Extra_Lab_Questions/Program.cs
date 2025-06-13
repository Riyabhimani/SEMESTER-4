using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Program-1

            //int[] arr = new int[5];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;
            //int min = 1;
            //int max = 1;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //    else if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}

            //Console.WriteLine("Maximum Number From Given Array = "+max);
            //Console.WriteLine("Minimum Number From Given Array = "+min);


            // Program-3

            //Console.WriteLine("Enter BookId :");
            //int BookID = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Book Title :");
            //string Title = Console.ReadLine();

            //Console.WriteLine("Enter Book Author :");
            //string Author = Console.ReadLine();

            //Book book = new Book(BookID, Title, Author);
            //book.DisplayBookDetails(BookID, Title, Author);


            // Program-4


            //Employee employee = new Employee();

            //Console.WriteLine("Enter EmployeeID :");
            //int EmployeeID = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name :");
            //string Name = Console.ReadLine();

            //Console.WriteLine("Enter Salaries :");
            //double Salaries = Convert.ToDouble(Console.ReadLine());

            //employee.DisplayDetails(EmployeeID,Name,Salaries);

            //Console.Write("Enter basic salary :");
            //double basic = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter hra :");
            //double hra = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter ta :");
            //double ta = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter da :");
            //double da = Convert.ToDouble(Console.ReadLine());

            //employee.CalculateAnnualSalary( hra, ta, da);
            //employee.DeterminePerfomance();


            //// Program-7

            //ArrayList arrayList = new ArrayList();
            //int count1 = 0;
            //int count2 = 0;

            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(1);
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(2);
            //arrayList.Add(2);

            //foreach (var item in arrayList) 
            //{
            //    if (item.Equals(1))
            //    {
            //        count1++;
            //    }
            //    else if (item.Equals(2)) 
            //    {
            //        count2++;
            //    }
            //}
            //Console.WriteLine("No Of 1 is "+count1);
            //Console.WriteLine("No Of 2 is "+count2);

            // Program-5

            Console.WriteLine("Enter ItemName :");
            string ItemName = Console.ReadLine();

            Console.WriteLine("Enter Quatity :");
            int Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter ItemCode :");
            int ItemCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Price :");
            int Price = Convert.ToInt32(Console.ReadLine());

            ShoppingCart cart = new ShoppingCart(ItemName,Quantity,Price,ItemCode);

            cart.AddItem(ItemCode, Quantity);
            cart.AddItem(ItemName,Quantity);
            cart.AddItem(ItemName, Quantity ,Price);


        }
    }
}
