namespace _10062024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("fil", 3,5,4);
            Test test = new Test(2,"Dishonored");

            Console.WriteLine(test);

            Person person = new Person();

            var (lastName, firstName) = person;

            var (id,name2) = test;

            (string name, byte age, double costPrice, double salePrice) = animal1;

            //Animal animal2 = new Animal("fil", 3, 5, 6);
            //Animal animal3 = animal2 with { age = 4 };

            //Console.WriteLine(animal2);
            //Console.WriteLine(animal3);
        }
    }
}
