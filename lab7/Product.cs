using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    static class Product
    {
        static int productId;
        static double price;
        static Product()
        {
            productId = 10;
            price = 156.32;
        }
        public static void Display()
        {
            Console.WriteLine("Product ID: " + productId);
            Console.WriteLine("Product price: " + price);
        }
    }

    class Medicine
    {
        static void Main(string[] args)
        {
            Product.Display();
        }
    }
}
