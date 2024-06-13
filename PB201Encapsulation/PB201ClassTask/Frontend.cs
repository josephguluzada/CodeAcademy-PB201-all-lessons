using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201ClassTask
{
    public class Frontend : Developer
    {
        private byte _reactExperienceYear;

        public Frontend(string name, string surname, sbyte experience) : base(name, surname, experience)
        {
            
        }

        public byte ReactExperienceYear
        {
            get => _reactExperienceYear;
            set
            {
                if (value >= 0)
                {
                    _reactExperienceYear = value;
                }
            }
        }
    }
}
