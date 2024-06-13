namespace PB201ClassMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();

            teacher.Name = "Test";
            teacher.Surname = "Test";
            teacher.Age = 1;
            teacher.Salary = 100000;



            Teacher teacher2 = new Teacher();
            teacher2.Name = "Eli";
            teacher2.Surname = "Eliyev";
            teacher2.Age = 33;
            teacher2.Salary = 3300;


            Teacher teacher3 = new Teacher();
            teacher3.Name = "Veli";
            teacher3.Surname = "Veliyev";
            teacher3.Age = 43;
            teacher3.Salary = 53300;

            Teacher[] teachers = {teacher,teacher2, teacher3};

            //foreach (var tch in teachers)
            //{
            //    tch.ShowFullData();
            //}

            string teacher3Data = teacher3.GetFullData();

            Console.WriteLine(teacher3Data);
        }
    }
}
