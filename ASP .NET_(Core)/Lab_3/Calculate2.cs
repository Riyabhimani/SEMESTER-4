using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    interface Calculate2
    {
        int addition(int a , int b);
        int subtraction(int a , int b);
    }

    class Result : Calculate2
    {
        public int addition(int a, int b)
        {
            int addition = a + b;
            Console.WriteLine(a + " + " + b + " = " + addition);
            return addition;
        }
        public int subtraction(int a, int b)
        {
            int subtraction = a - b;
            Console.WriteLine(a + " - " + b + " = " + subtraction);
            return subtraction;
        }
    }
}
