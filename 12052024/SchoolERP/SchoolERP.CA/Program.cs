using SchoolERP.Business.Services.Implementations;
using SchoolERP.Business.Services.Interfaces;
using ShcoolERP.Core.Models;

namespace SchoolERP.CA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITeacherService teacherService = new TeacherService();
            IStudentService studentService = new StudentService();

            teacherService.Create(new Teacher() { Fullname = "Eli Eliyev", Salary = 2600, });
            var teacher2 = new Teacher() { Fullname = "Yusif Guluzada", Salary = 2600, };
            teacherService.Create(teacher2);
            Teacher teacher = null;
            try
            {
                teacher = teacherService.Get(1);
                Console.WriteLine(teacher);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //try
            //{
            //    teacherService.Remove(1);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Student student = new Student()
            {
                Fullname = "Abbas",
                Grade = 13,
                Teacher = teacher
            };

            Student student2 = new Student()
            {
                Fullname = "Yusif Osmanov",
                Grade = 13,
                Teacher = teacher2
            };
            studentService.Create(student);
            studentService.Create(student2);

            studentService.GetAll().ForEach(x=> Console.WriteLine(x));
            //try
            //{
            //    studentService.Remove(1);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            teacher.Students.Add(student);
            teacher2.Students.Add(student2);

            teacherService.Remove(1);
            teacherService.Remove(2);

            Console.WriteLine("Teacherin studentleri:");
            //teacher.Students.ForEach(student => Console.WriteLine(student));
            //Console.WriteLine(student.Teacher.Fullname);
            Console.WriteLine("========================================");
            studentService.GetAll().ForEach(x=> Console.WriteLine(x));
        }
    }
}
