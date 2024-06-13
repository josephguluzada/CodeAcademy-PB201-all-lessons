using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Abstraction
{
    public class Cat : Animal
    {
        public double TailLength;

        public override byte Age { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eating like a cat");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Miyav Miyav");
        }
    }
}
