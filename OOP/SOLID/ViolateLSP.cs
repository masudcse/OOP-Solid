using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //Base Class
    public class Animal
    {
        public virtual void  CanSwim()
        {
            Console.WriteLine("Can Swim");
        }
       
    }

    //Derived Class/Child Clas
    public class Crodile : Animal
    {
        public override void CanSwim()
        {
            Console.WriteLine("Can Swim");
        }
    }
    public class Dog : Animal
    {
        public override void CanSwim()
        {
            Console.WriteLine("Can't Swim");
        }
    }
    public class Cat : Animal
    {
        public override void CanSwim()
        {
            Console.WriteLine("Can't Swim");
        }

        public void Climb()
        {
            Console.WriteLine("Can Climb");
        }
    }
}
