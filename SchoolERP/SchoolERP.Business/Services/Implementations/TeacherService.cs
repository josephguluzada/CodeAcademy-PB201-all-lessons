using SchoolERP.Business.Services.Interfaces;
using SchoolERP.Data.DAL;
using ShcoolERP.Core.Models;

namespace SchoolERP.Business.Services.Implementations;

public class TeacherService : ITeacherService
{
    public void Create(Teacher teacher)
    {
        SchoolERPDatabase.Teachers.Add(teacher);
    }

    public List<Teacher> GetAll()
    {
        return SchoolERPDatabase.Teachers;
    }

    public Teacher Get(int id)
    {
        Teacher? wantedTeacher = SchoolERPDatabase.Teachers.Find(x=> x.Id == id);

        if(wantedTeacher is not null)
        {
            return wantedTeacher;
        }

        throw new NullReferenceException("Teacher not found!");
    }

    public void Remove(int id)
    {
        IStudentService studentService = new StudentService();
        Teacher? wantedTeacher = SchoolERPDatabase.Teachers.Find(x => x.Id == id);

        if(wantedTeacher is not null )
        {
            var updatedStudents = studentService.GetAll().FindAll(x => x.Teacher?.Id == wantedTeacher.Id);

            updatedStudents.ForEach(x => x.Teacher = null);

            //wantedTeacher.Students.Clear();
            SchoolERPDatabase.Teachers.Remove(wantedTeacher);
        }
        else
        {
            throw new NullReferenceException("Teacher not found!");
        }
    }
}
