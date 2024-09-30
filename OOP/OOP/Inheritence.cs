using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person
    {
        protected int Age { get; set; }

        protected string Name { get; set; }
    }

    class Student : Person
    {
        public Student(string n)
        {
            Name = n;
        }

        public void Speak()
        {
            Console.Write("Name:" + Name);
        }

    }
}
