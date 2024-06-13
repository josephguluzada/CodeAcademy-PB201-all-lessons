using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201ClassTaskSolution
{
    public class Bicycle : Vehicle
    {
        public void ShowFullData()
        {
            Console.WriteLine($"{Color} - {WheelCount} ");
        }

        public string GetFullData()
        {
            return $"{Color} - {WheelCount}";
        }
    }
}
