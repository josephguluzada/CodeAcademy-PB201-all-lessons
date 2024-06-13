using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Virtual
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override void CalcArea()
        {
            Console.WriteLine(Area = Width * Height);
        }
    }
}
