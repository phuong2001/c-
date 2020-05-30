using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metals
{
    class Metals
    {
        string metalType;
        public Metals(string type)
        {
            metalType = type;
            Console.WriteLine("Metal: \t\t" +metalType);
        }
    }
    class SteelCompany : Metals
    {
        string grade;
        public SteelCompany(string grade) : base("Steel")
        {
            grade = grade;
            Console.WriteLine("Grade: \t\t" +grade);
        }
    }
    class Automobiles : SteelCompany
    {
        string part;
        public Automobiles(string part) : base("Cast Iron")
        {
            part = part;
            Console.WriteLine("Part: \t\t" +part);
        }
        static void Main(string[] args)
        {
            Automobiles objAutomobiles = new Automobiles("Chassies");
        }
    }
}
