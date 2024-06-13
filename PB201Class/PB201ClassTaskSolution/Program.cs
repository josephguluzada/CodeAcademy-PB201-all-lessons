namespace PB201ClassTaskSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Color = "Red";
            car.WheelCount = 4;
            car.FuelPerKm = 5;
            car.FuelCapacity = 50;

            car.Drive(5); // 50 - 5*5 = 25

            car.ShowFullData();

            Bicycle bicycle = new Bicycle()
            {
                Color = "Black",
                WheelCount = 2
            };

            bicycle.ShowFullData();


        }
    }
}
