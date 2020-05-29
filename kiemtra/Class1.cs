using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtra
{
    class Class1
    {
        public void hienthithue(Product sh)
        {
            double a;
            a = sh.computeTax();
            Console.WriteLine("thue : {0}",a);
        }
    }
}
