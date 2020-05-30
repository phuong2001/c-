﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employees
    {
        int empId = 1;
        string empName = "James Anderson";
        int age = 25;
        public void Display()
        {
            Console.WriteLine("Employee ID: " + empId);
            Console.WriteLine("Employee Name: " + empName);
        }
    }
    class Department : Employees
    {
        int deptId = 501;
        string deptName = "Sales";
        new void Display()
        {
            base.Display();
            Console.WriteLine("Department ID: " + deptId);
            Console.WriteLine("Department Name: " + deptName);
        }
        static void Main(string[] args)
        {
            Department objDepartment = new Department();
            objDepartment.Display();
        }
    }
}
