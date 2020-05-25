using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThongTin
{
    class ThongTin
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write( "nhập tên: " );
            Console.WriteLine("tên: " + Console.ReadLine());
            Console.Write("nhập địa chỉ: ");
            Console.WriteLine("địa chỉ:" + Console.ReadLine());
            Console.Write("nhập sdt: ");           
            Console.WriteLine("sđt:" + Console.ReadLine());
        }
    }
}
