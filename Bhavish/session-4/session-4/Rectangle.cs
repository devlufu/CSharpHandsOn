using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_4
{
    public class Rectangle:Shape
    {
        public override void Draw()//Derived class rectange property overriding the Draw method from the base class
        {
            Console.WriteLine("drawing rectangle");
        }
    }
}
