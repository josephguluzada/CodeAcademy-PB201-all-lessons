using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Abstraction
{
    public abstract class Animal
    {
        public abstract byte Age { get; set; }
        public string Name;
        public string ClassName;

        public abstract void MakeSound();
        public abstract void Eat();

        public void SetSound(byte value)
        {
            Console.WriteLine("Test");
        }
    }
}
