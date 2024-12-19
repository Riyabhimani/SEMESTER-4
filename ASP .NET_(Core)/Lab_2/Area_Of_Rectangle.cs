using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Area_Of_Rectangle
    {
        public double Length;
        public double Width;
        public double Area;

        public void GetDetails()
        {
            Console.WriteLine("Enter Length : ");
            Length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Width : ");
            Width = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayArea()
        {
            Area = Length * Width;
            Console.WriteLine("Area Of Rectangle = " + Area);
        }
    }
}
