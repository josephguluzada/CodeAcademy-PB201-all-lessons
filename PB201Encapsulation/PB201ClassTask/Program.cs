namespace PB201ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Developer developer = new Developer("Eli","Eliyev",5);
            Backend backend = new Backend("Raul","Eliyev", 6);
            backend.SqlExperienceYear = 22;


            Console.WriteLine($"{backend.Name},{backend.Surname},{backend.Experience}, {backend.SqlExperienceYear}");

        }
    }
}
