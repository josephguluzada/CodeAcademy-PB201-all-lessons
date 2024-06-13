using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Abstraction
{
    public class Dog : Animal
    {
        public bool HasCollar;

        public override byte Age { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Hav Hav");
        }

        public override void Eat()
        {
            Console.WriteLine("Eating like a dog");
        }
    }
}
