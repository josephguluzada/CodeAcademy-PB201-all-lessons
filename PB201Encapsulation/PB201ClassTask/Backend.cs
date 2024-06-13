using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201ClassTask
{
    public class Backend : Developer
    {
		private sbyte _sqlExperienceYear;

        public Backend(string name,string surname, sbyte experience) : base(name,surname,experience)
        {
			   
        }

        public sbyte SqlExperienceYear
        {
			get => _sqlExperienceYear; 
			set 
			{ 
				if(value >= 0)
				{
					_sqlExperienceYear = value;
				}
			}
		}

	}
}
