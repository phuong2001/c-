using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vd
{
    class Book
    {
        string bookName;
        double price;

        public string Print()
        {
            return bookName;
            return price;
        }
        public void Input(string bkName,double pri)
        {
            bookName = bkName;
            price = pri;
        }
        static void Main(string[] args)
        {
            Book objBook = new Book();
            objBook.Input("ccbsj");
            Console.WriteLine(objBook.Print());
        }
    }
}
