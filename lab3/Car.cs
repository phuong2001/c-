using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        public string make;
        public string model;
        public string color;
        public int yearBuilt;

        public void Start()
        {
            System.Console.WriteLine(model + "started");
        }
        public void Strop() 
        { 
            System.Console.WriteLine(model + "stoppted");
        }
    }
}
