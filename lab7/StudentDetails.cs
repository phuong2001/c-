using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class StudentDetails
    {

       public  string strucName ;
       public int rollNumber ;

        public StudentDetails(string strucName, int rollNumber)
        {
            this.strucName = strucName;
            this.rollNumber = rollNumber;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("name");
            String strucName = Console.ReadLine();
            Console.WriteLine("number");
            int rollNumber = Convert.ToInt32(Console.ReadLine());
            StudentDetails obj = new StudentDetails(strucName,rollNumber);
            Console.WriteLine("student name :" + strucName);
            Console.WriteLine("roll Number :" + rollNumber);

        }
    }
}
