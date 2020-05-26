using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student

{
    class students
    {
        string strName;
        int intAge ;

         void Display()
        {
            Console.WriteLine("name " );
            string strName = Console.ReadLine();
            Console.WriteLine("Age ");
            int intAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("students name :" + strName);
            Console.WriteLine("students Age: " + intAge);

        }
        static void Main(string[] args)
        {
            students objstudents = new students();
            objstudents.Display();
        }
    }
}
