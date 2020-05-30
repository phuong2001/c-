using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metals
{
    class Student
    {
        string studentName = "James";
        string address = "California";
public virtual void PrintDetails()
        {
            Console.WriteLine("Student Name: " +studentName);
            Console.WriteLine("Address: " +address);
        }
    }
    class Grade : Student
    {
        string class1 = "Four";
        float percent = 71.25F;
        public override void PrintDetails()
        {
            Console.WriteLine("Class: " +class1);
            Console.WriteLine("Percentage: " +percent);
        }
        static void Main(string[] args)
        {
            Student objStudent = new Student();
            Grade objGrade = new Grade();
            objStudent.PrintDetails();
            objGrade.PrintDetails();
        }
    }
}
