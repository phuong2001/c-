using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atom
{
    class Atoms
    {
         int number;
         string symbol;
         string fullName;
         float atomicWeight;

        
         void Display() 
        {
            Console.Write("Enter number :");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter symbol :");
            symbol = Console.ReadLine();
            Console.Write("Enter full name:");
            fullName = Console.ReadLine();
            Console.Write("Enter atomic weight:");
            atomicWeight = float.Parse(Console.ReadLine());
            Console.WriteLine("name" + fullName);
            Console.WriteLine("number" + number);
            Console.WriteLine("symbol" + symbol);
            Console.WriteLine("weight" + atomicWeight);
        }
        static void Main(string[] args)
        {
            Atoms objecA = new Atoms();
            objecA.Display();
        }
    }
}
