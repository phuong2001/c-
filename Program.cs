﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee("Libby", 2000);

            var employee2 = new TechnicalEmployee("Zaynah");

            var employee3 = new BusinessEmployee("witer");

            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
}
