using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    class Animal1
    {
        protected string Food;
        protected string Activity;
    }
    class Cat : Animal1
    {
        static void Main(string[] args)
        {
            Cat objCat = new Cat();
            objCat.Food = "Mouse";
            objCat.Activity = "laze around";
            Console.WriteLine("The Cat loves to eat " +objCat.Food + ".") ;
            Console.WriteLine("The Cat loves to " +objCat.Activity + ".");
        }
    }
}
