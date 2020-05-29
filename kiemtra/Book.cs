using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtra
{
    class Book : Product
    {
        public Book(int id,string name,double price,string producer) : base(id, name, price, producer)
        {
            this.price = price;
        }
        public override double computeTax()
        {
            Console.WriteLine("thue book:");
           return (price * 8/100);
        }
    }
    
}
