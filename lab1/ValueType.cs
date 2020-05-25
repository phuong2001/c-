using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType
{
    class ValueType
    {
        static void Main(string[] args)
        {
            int valueVal = 5;
            Test (valueVal);
            Console.WriteLine("Giá trị của biến là {0}", valueVal);
            Console.ReadLine();
        }
        static void Test(int valueVal)
        {
            int temp = 5;
            valueVal = temp * 2;
        }
    }
}
