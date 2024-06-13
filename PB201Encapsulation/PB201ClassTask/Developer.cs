using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201ClassTask
{
    public class Developer
    {
        private byte _age;
        private sbyte _experience;

        public string Name { get; set; }
        public string Surname { get; set; }

        public Developer(string name)
        {
            Name = name;
        }

        public Developer(string name, string surname) : this(name) 
        {
            Surname = surname;
        }

        public Developer(string name, string surname, sbyte experience) : this(name,surname)
        {
            Experience = experience;
        }






        public byte Age 
        {
            // get => _age;
            get
            {
                return _age;
            }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    _age = value;
                }
            }
        }
        public sbyte Experience
        {
            get => _experience;
            set
            {
                if(value >= 0)
                {
                    _experience = value;
                }
            }
        }
    }
}
