using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window
{
    class Window
    {
        
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        // simulates drawing the window
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}",

            top, left);
        }
        
        protected int top;
        protected int left;
    }
}
