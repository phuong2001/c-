using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtra
{
    public class Mainx
    {
         static void Main(string[] args)
        {
            Book[]  book = new Book[3];
            book[0] = new Book(1, "boo1", 100, "a");
            book[1] = new Book(2, "boo2", 200, "b");
            book[2] = new Book(3, "book3", 300, "c");
            MobilePhone[] phone = new MobilePhone[3];
            phone[0] = new MobilePhone(4, "phone1", 400, "d");
            phone[1] = new MobilePhone(5, "phone2", 500, "e");
            phone[2] = new MobilePhone(6, "phone3", 600, "f");

            double sum = 0;
            int i;
            for(i=0; i < products.Length; i++)
            {
                sum += products[i].computeTax();
            }
            Console.WriteLine("tong thue :" +sum);

            Class1 c = new Class1();
            c.hienthithue(book);
            c.hienthithue(phone);

        }
    }
}
