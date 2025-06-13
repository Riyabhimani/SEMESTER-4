using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class ShoppingCart
    {
        public string ItemName;
        public int Quantity;
        public double Price;
        public int ItemCode;

        public ShoppingCart(string itemName, int quantity, double price, int itemCode)
        {
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
            ItemCode = itemCode;
        }

        public void AddItem(string ItemName, int Quantity)
        {
            Console.WriteLine("Quantity Of " + ItemName + " is " + Quantity);
        }

        public void AddItem(string ItemName, int Quantity, double Price)
        {
            Console.WriteLine("Quantity Of " + ItemName + " is " + Quantity+ " and price = "+Price);
        }

        public void AddItem(int ItemCode, int Quantity)
        {
            Console.WriteLine("Item Code is "+ItemCode+" and Quantity is "+Quantity);
        }
    }

}
