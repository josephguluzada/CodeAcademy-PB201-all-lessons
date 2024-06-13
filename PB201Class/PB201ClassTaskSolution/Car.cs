using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201ClassTaskSolution
{
    public class Car : Vehicle
    {
        public double FuelCapacity;
        public double FuelPerKm;

        public void Drive(int km)
        {
            Console.WriteLine(FuelCapacity -= (FuelPerKm * km));
        }

        public void ShowFullData()
        {
            Console.WriteLine($"{Color} - {WheelCount} - {FuelCapacity} - {FuelPerKm}");
        }

        public string GetFullData()
        {
            return $"{Color} - {WheelCount} - {FuelCapacity} - {FuelPerKm}";
        }
    }
}
