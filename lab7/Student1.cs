using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vd1
{
    class Student1
    {
        void printName(string firstName, string lastName)
        {
            Console.WriteLine("fist Name = {0}, last name = {1}", firstName, lastName);
        }
        static void Main(string[] args)
        {
            Student1 obj = new Student1();
            obj.printName("Henry","Parker");

            obj.printName(firstName: "Henry", lastName: "Parker");
            obj.printName(lastName: "Parker", firstName: "Henry");

            obj.printName("Henry", lastName: "Parker");
        }
    }
}
