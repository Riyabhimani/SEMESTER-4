using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //8. Write a program to Define a class Distance have data members dist1, dist2,
    //dist3. Initialize the two data members using constructor and store their
    //addition in third data member using function and display addition.
    internal class Distance
    {
        public float dist1;
        public float dist2;
        public float dist3;

        public Distance(float dist1, float dist2)
        {
            this.dist1 = dist1;
            this.dist2 = dist2;
        }

        public void add()
        {
            dist3 = dist1 + dist2;
            Console.WriteLine("Distance = " + dist3);
        }
    }
}
