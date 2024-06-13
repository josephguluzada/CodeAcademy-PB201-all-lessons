namespace PB201Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Brand = "To";
            car.Model = "Prius 30 COOOSA";
            car.CurrentFuel = 20; // 15
            car.FuelFor1Km = 1;
            car.OdoMeter = -1000; //278005


            //Console.WriteLine(car.Brand);
            //car._odoMeter = -20000;

            //Console.WriteLine(car.OdoMeter);
            //car.Drive(20);

            //car.SetOdoMeter(-5000);
            //Console.WriteLine(car.GetOdoMeter());
            car.PrintAllData();
        }
    }
}
