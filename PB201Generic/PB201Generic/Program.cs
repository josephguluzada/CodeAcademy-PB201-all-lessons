using PB201Generic.Models;

namespace PB201Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new();
            student1.Fullname = "Ali Aliyev";

            Student student2 = new();
            student2.Fullname = "Vali Valiyev";
            Student student3 = new();
            student3.Fullname = "Rustem Beyli";


            StudentList studentList = new StudentList();

            //Student[] students = {student2, student3};

            studentList.Add(student1);
            studentList.AddRange(student2, student3);

            Console.WriteLine(studentList.Count());

            Student? wantedStudent = null;

            try
            {
                wantedStudent = studentList.FindByIndex(12);
                Console.WriteLine(wantedStudent);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            foreach (var item in studentList.Students)
            {
                Console.WriteLine(item);
            }


            CustomList<Student> customList1 = new CustomList<Student>();

            customList1.Add(student1);
            customList1.AddRange(student1);
            customList1.FindByIndex(12);

        }
    }
}
