using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S19
{
    public class Rectangle
    {
        double length;
        double breadth;
        public Rectangle()
        {
            length = 13.5;
            breadth = 20.5;
        }
        public Rectangle(double len, double wide)
        {
            length = len;
            breadth = wide;
        }
        public double Area()
        {
            return length * breadth;
        }
        static void Main(string[] args)
        {
            Rectangle objRect1 = new Rectangle();
            Console.WriteLine("Area of rectangle = " + objRect1.Area());
            Rectangle objRect2 = new Rectangle(2.5, 6.9);
            Console.WriteLine("Area of rectangle = " + objRect2.Area());
        }
    }
}
