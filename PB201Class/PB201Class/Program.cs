namespace PB201Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Teymur", "Abbas", "Aynur", "Nazrin", "Huseyn" }; //5
            //string[] surnames = { "Mustafayev", "Bayramli", "Nazarli", "Alasgarli", "Jafarli" };//5
            //byte[] ages = { 20, 21, 19, 21 };//4

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine($"{names[i]} {surnames[i]} {ages[i]}");
            //}

            //var std1 = new { Name = "Teymur", Surname = "Mustafayev", Age = 20 };
            //var std2 = new { Name = "Abbas", Surname = "Bayramli", Age = 21, FailCount = 3 };
            //var std3 = new { Name = "Aynur", Surname = "Nazarli", Age = 19, Grant = 175 };

            //Student std1 = new Student();
            //std1.Name = "Eli";
            //std1.Surname = "Eliyev";
            //std1.Age = 13;
            //std1.Grant = 270;
            //Console.WriteLine(std1.Name + " " + std1.Surname + " " + std1.Age + " " + std1.Grant);


            //Student std2 = new Student { Name = "Aynur", Surname = "Nazarli", Age = 19, Grant = 175 };

            //Console.WriteLine(std2.Name + " " + std2.Grant);

            //Teacher teacher1 = new Teacher();
            //teacher1.Name = "Veli";
            //teacher1.Surname = "Veliyev";
            //teacher1.Age = 35;
            //teacher1.Salary = 5005;

            Human human = new Human("Abbas", "Bayramli",18);
            Console.WriteLine(human.Name + "-" + human.Surname + "-" + human.Age) ;

            Human human2 = human;
            human2.Name = "Eli";
            Console.WriteLine(human2.Name + "-" + human2.Surname + "-" + human2.Age);

            Human human3 = new Human();
            Console.WriteLine(human3.Name + "-" + human3.Surname + "-" + human3.Age);


        }


    }

    public class Human
    {
        public string Name;
        public string Surname;
        public byte Age;

        public Human()
        {
            Console.WriteLine("Human object created!");
            Name = "Unknown";
            Surname = "Unknown";
            Age = 0;
        }

        public Human(string name) : this()
        {
            Name = name;
        }
        public Human(string name, string surname) : this(name)
        {
            Surname = surname;
        }

        public Human(string name, string surname, byte age) : this(name,surname)
        {
            Age = age;
        }
    }

    //class Teacher : Human
    //{
    //    public Teacher()
    //    {

    //    }
    //    public decimal Salary;
    //}

    //class Student : Human
    //{
    //    public Student()
    //    {
            
    //    }

    //    public double Grant;
    //}

}
