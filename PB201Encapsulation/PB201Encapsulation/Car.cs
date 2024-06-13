using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Encapsulation
{
    public class Car
    {
        private double _odoMeter;
        private string _brand;

        public string Model { get; set; }
        public double CurrentFuel { get; set; }
        public double FuelFor1Km { get; set; }
        public string Brand 
        { 
            get
            {
                return _brand;
            }
            set
            {
                if(value != null &&  value.Length >= 3) 
                {
                    _brand = value;
                }
            }
        }

        public double OdoMeter 
        { 
            get 
            { 
                return this._odoMeter;
            } 
            set 
            { 
                if(value >= 0)
                {
                    this._odoMeter = value;
                }
            } 
        }

        //public double GetOdoMeter()
        //{
        //    return this.OdoMeter;
        //}

        //public void SetOdoMeter(double value)
        //{
        //    if(value >= 0)
        //    {
        //        this.OdoMeter = value;
        //    }
        //}

        public void Drive(int km)
        {
            if(km > 0 && CurrentFuel >= FuelFor1Km*km) 
            {
                CurrentFuel -= FuelFor1Km*km;
                OdoMeter += km;
            }
            else
            {
                Console.WriteLine("Not enough fuel!");
            }
        }

        public void PrintAllData()
        {
            Console.WriteLine($"Brand: {this.Brand}\nModel: {this.Model}\nCurrent fuel: {this.CurrentFuel}\nFuelFor1Km: {this.FuelFor1Km}\nOdoMeter: {this.OdoMeter}");
        }
    }
}
