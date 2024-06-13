namespace PB201Generic.Models;

public class StudentList
{
    public Student[] Students = Array.Empty<Student>();

    public void Add(Student student)
    {
        Array.Resize(ref Students, Students.Length + 1);
        Students[^1] = student;
    }

    public void AddRange(params Student[] students) 
    {
        foreach (var student in students)
        {
            Add(student);
        }
    }

    public int Count()
    {
        return Students.Length;
    }

    public Student FindByIndex(int index)
    {
        return Students[index];
    }

}
