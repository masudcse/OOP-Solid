using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Shape
    {
        public virtual void Draw()
        {

        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            // draw a circle...
            Console.WriteLine("Circle Draw");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            // draw a rectangle...
            Console.WriteLine("Rect Draw");
        }
    }
}
