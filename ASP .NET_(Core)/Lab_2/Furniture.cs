using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //9. Create a class Furniture with material, price as data members.Create
    //    another class Table with Height, surface_area as data members.Write a
    //    program to implement single inheritance. 
    internal class Furniture
    {
        public string material;
        public int price;

        public void data()
        {
            Console.WriteLine("Enter material : ");
            material = Console.ReadLine();
            Console.WriteLine("Enter Price : ");
            price = Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Material of furniture = " + material);
            Console.WriteLine("Price of material = " + price);
        }
    }

    class Table : Furniture
    {
        public float height;
        public float surface_area;

        public Table(string material, int price, float height, float surface_area)
        {
            this.material = material;
            this.price = price;
            this.height = height;
            this.surface_area = surface_area;
        }

        public void displayTableDetail()
        {
            display();
            Console.WriteLine("Height of table = " + height);
            Console.WriteLine("Surface area of table = " + surface_area);
        }
    }
}
