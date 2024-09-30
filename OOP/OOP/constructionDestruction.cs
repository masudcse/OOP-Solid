using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Created.");
        }

        ~Animal()
        {
            Console.WriteLine("Animal Deleted.");
        }
    }

    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Animal Created.");
        }

        ~Dog()
        {
            Console.WriteLine("Animal Deleted.");
        }
    }
}
