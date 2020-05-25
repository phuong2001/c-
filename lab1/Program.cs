using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; /* để viết tiếng việt */

            Console.WriteLine("Nhập vào số thứ 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào số thứ 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào số thứ 3: ");
            int c = int.Parse(Console.ReadLine());

            int max = a;
         
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            Console.WriteLine("Max trong 3 số {0}, {1}, {2} là {3}", a, b, c, max);
        }
    }
}
