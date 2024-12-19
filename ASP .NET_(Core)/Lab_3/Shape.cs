using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_3
{
    //7. Write a program to create interface named Shape.In this interface, we
    //have three methods Circle(), Triangle() and Square() which calculates area
    //of Circle, Triangle and Square respectively.Implement Shape interface. 
    internal interface Shape
    {
        double circle(double r);
        double triangle(double h, double w);
        double square(double l);
    }
    class Area : Shape
    {
        public double circle(double r)
        {
            double area = 3.14 * r * r;
            return area;
        }
        public double triangle(double h,double w)
        {
            double area1 = 0.5 * h * w;
            return area1;
        }
        public double square(double l)
        {
            double area2 = l * l;
            return area2;
        }
    }
}
