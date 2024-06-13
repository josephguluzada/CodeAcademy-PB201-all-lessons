namespace PB201Tupples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant elephant = new Elephant();
            elephant.Name = "Jungle Fili";
            elephant.Age = 55;

            (string name, byte age) result  = elephant.GetInfo();

            Console.WriteLine(result.name + " " + result.age);

            //(string name, byte age) = elephant.GetInfo();
            //Console.WriteLine(name + " " + age);

            var tuple = ("55", "Abbas", 5,66,77);

            (string fullName, string pos)  = ("Abbas", "Employee");

            Console.WriteLine(fullName);

            Console.WriteLine(tuple.Item1);
        }
    }
}
