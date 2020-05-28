using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General2
{
    class General2<T, U>
    {
        T valOne;
        U valTwo;
        public void AcceptValues(T item)
        {
            valOne = item;
        }
        public void AcceptValues(U item)
        {
            valTwo = item;
        }
        public void Display()
        {
            Console.Write(valOne + "\t" +valTwo);
        }
    }
    class MethodOverload
    {
        static void Main(string[] args)
        {
            General2<int, string> objGenOne = new General2<int, string>();
            objGenOne.AcceptValues(10);
            objGenOne.AcceptValues("Smith");
            Console.WriteLine("ID\tName\tDesignation\tSalary");
            objGenOne.Display();
            General2<string, float> objGenTwo = new General2<string, float>();
            objGenTwo.AcceptValues("Mechanic");
            objGenTwo.AcceptValues(2500);
            Console.Write("\t");
            objGenTwo.Display();
            Console.WriteLine();
        }
    }
}
