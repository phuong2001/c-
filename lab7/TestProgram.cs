using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
    class TestProgram
    {
        void Count(int boys, int girls)
        {
            Console.WriteLine(boys + girls);
        }
        static void Main(string[] args)
        {
            TestProgram objTest = new TestProgram();
            objTest.Count(boys: 20, girls: 24);
        }
    }
}
