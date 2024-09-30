using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Man
    {
        public virtual void Bark()
        {
            Console.WriteLine("test!");
        }
    }
    class Child : Man
    {

        public override void Bark()
        {

            Console.WriteLine("Woof!");

        }

    }
}
