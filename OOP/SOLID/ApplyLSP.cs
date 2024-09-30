using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IAnimal
    {
        public void CanSwim();

    }

    public class Dogs : IAnimal
    {
        public void CanSwim()
        {
            Console.WriteLine("Can't Swim");
        }
    }

    public class Cats : IAnimal
    {
        public void CanSwim()
        {
            Console.WriteLine("Can't Swim");
        }
    }

    public class Crocodile : IAnimal
    {
        public void CanSwim()
        {
            Console.WriteLine("Can Swim");
        }
    }
}
