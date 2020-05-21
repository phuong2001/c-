using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        public string Name
        {
            get{ return employeeName;}
            set{ employeeName = value;}
        }
        public double BaseSalary
        {
            get{ return employeeBaseSalary;}
            set{ employeeBaseSalary = value;}
        }
        public int ID
        {
            get{ return employeeId; }
            set{ employeeId = value; }
        }
        public Employee(String name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
        }
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        public string getName()
        {
            return this.Name;
        }
        private static int employeeCount = 1;

        public int getID()
        {
           return this.ID = employeeCount++;
        }
        public int getEmployeeID()
        {
            return this.ID;
        }
        public String toString()
        {
            return this.ID + "" + this.Name;
        }
        public virtual String employeeStatus()
        {
            return toString() + "is in the compaly's system";
        }
    }
}
