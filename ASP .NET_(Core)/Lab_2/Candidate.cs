using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //1. Write a program to create a class named Candidate with ID, Name, Age, 
    //    Weight and Height as data members & also create a member functions like
    //    GetCandidateDetails() and DisplayCandidateDetails().  
    internal class Candidate
    {
        public int ID;
        public string Name;
        public int Age;
        public double Weight;
        public double Height;

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter ID : ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name : ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Age : ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Weight : ");
            Weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Height : ");
            Height = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayCandidateDetails()
        {
            Console.WriteLine("ID = " + ID);
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Age = " + Age);
            Console.WriteLine("Weight = " + Weight);
            Console.WriteLine("Height = " + Height);
        }
    }
}
