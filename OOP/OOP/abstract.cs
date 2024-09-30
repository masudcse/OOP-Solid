using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Pointer
    {
        public abstract void Draw();
    }
    class Circle1 : Pointer
    {
        public override void Draw()
        {
            // draw a circle...
            Console.WriteLine("Circle Draw");
        }
    }
    class Rectangle1 : Pointer
    {
        public override void Draw()
        {
            // draw a rectangle...
            Console.WriteLine("Rect Draw");
        }
    }
}
