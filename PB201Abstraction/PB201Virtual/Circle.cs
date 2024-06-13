using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Virtual
{
    public class Circle : Shape
    {
        public const double PI = Math.PI;
        public double Radius { get; set; }

        public override void CalcArea()
        {
            Console.WriteLine(Area = PI * Radius * Radius);
        }
    }
}
