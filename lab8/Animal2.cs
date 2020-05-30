using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eat
{
    class Animal2
    {
        public void eat()
        {
            Console.WriteLine("...");
        }
    }
    class Dog : Animal2
    {
        public void eat()
        {
            Console.WriteLine(".....");
        }
        public void Main(string[] args)
        {
            Dog objDog = new Dog();
            objDog.eat();
            base.eat();
        }
    }
}
