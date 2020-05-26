using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S17
{
    class Employees
    {
        string empName;
        int empAge;
        string deptName;
        Employees(string name, int num)
        {
            empName = name;
            empAge = num;
            deptName = "Research & Development";
        }
        static void Main(string[] args)
        {
            Employees objEmp = new Employees("John", 10);
            Console.WriteLine(objEmp.deptName);
        }
    }
}
