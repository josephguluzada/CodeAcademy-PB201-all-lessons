using PB201List.Models;
using System.Threading.Channels;

namespace PB201List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>(1025);

            //list.Add("Ilahe");
            //list.Add("Ilahe");
            //list.Add("Ilahe");
            //list.Add("Ilahe");
            //list.Add("Ilahe");

            //Console.WriteLine(list.Capacity);
            //Console.WriteLine(list.Count);

            //List<int> ints = [1,2,3,4];


            List<Student> students = new List<Student>();
            students.Add(new Student() { Name = "Abbas",Grade = 13});
            students.Add(new Student() { Name = "Shah Abbas",Grade = 93});
            var std = new Student() { Name = "Id Abbas", Grade = 3 };

            //foreach (var item in students)
            //{
            //    Console.WriteLine(item.Name);
            //}
            students.Add(std);

            students.ForEach(std => Console.WriteLine(std.Name));

            //students.RemoveAll(x => x.Name.Contains("Id"));
            //students.Clear();
            Console.WriteLine("After RemoveAll");
            bool check = students.Exists(x => x.Grade == 113);
            Console.WriteLine(check);
            Console.WriteLine(students.Capacity);
            students.Insert(23, new Student() { Name = "Abbas Eli", Grade = 0 });
            students.ForEach(std => Console.WriteLine(std.Name));
        }
    }
}
