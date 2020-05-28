using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Department
{

    class Department : IEnumerable
    {
        string[] departmentNames = { "Marketing", "Finance", "InformationTechnology", "Human Resources" };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < departmentNames.Length; i++)
            {
                yield return departmentNames[i];
            }
        }
        static void Main(string[] args)
        {
            Department objDepartment = new Department();
            Console.WriteLine("Department Names");
            Console.WriteLine();
            foreach (string str in objDepartment)
            {
                Console.WriteLine(str);
            }
        }
    }
}
