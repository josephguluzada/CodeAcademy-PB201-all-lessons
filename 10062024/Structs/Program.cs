namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DistanceMeter distanceMeter = new DistanceMeter();
            distanceMeter.Width = 100;
            distanceMeter.Height = 200;

            DistanceMeter distanceMeter1 = distanceMeter;

            DistanceMeter distanceMeter2 = new DistanceMeter(600, 900);

            distanceMeter1.Width = 500;

            distanceMeter1.ShowDifferences(distanceMeter);

            Object obj1 = distanceMeter; // boxing

            DistanceMeter distanceObj = (DistanceMeter)obj1 ; // unboxing
        }
    }
}
