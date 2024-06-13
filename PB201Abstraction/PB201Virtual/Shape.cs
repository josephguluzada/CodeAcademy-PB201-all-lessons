using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Virtual
{
    public class Shape
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }

        public virtual void CalcArea()
        {
            Console.WriteLine("Area of Shape");
        }

        public void ShowInfo()
        {
            Console.WriteLine(Perimeter);
        }
    }
}
