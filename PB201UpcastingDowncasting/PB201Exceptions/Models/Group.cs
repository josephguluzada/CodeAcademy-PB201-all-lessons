using MyHelperLibrary.Helpers;

namespace PB201Exceptions.Models;

public class Group
{
    private Student[] _students = Array.Empty<Student>();
    private static int _counter;
    private int _studentLimit;
    private string _groupNo;
    public int Id { get; private set; }
    public string GroupNo { get => _groupNo;
        set
        {
            if (Helper.CheckGroupNo(value))
            {
                _groupNo = value;
            }
        }
    }
    public int StudentLimit 
    {
        get => _studentLimit;
        set
        {
            if(value >= 5 && value <= 18)
            {
                _studentLimit = value;
            }
        }
    }

    public Group()
    {
        _counter++;
        Id = _counter;
    }


    public void AddStudent(Student student)
    {
        if(_students.Length < StudentLimit)
        {
           Helper.AddItemIntoArray(ref _students, student);
        }
    }

    public Student GetStudent(int? id)
    {
        foreach (var std in _students)
        {
            if(std.Id == id)
            {
                return std;
            }
        }
        return null;
    }

    public Student[] GetAllStudent()
    {
        return _students;
    }

    public void ShowAllStudents()
    {
        foreach (var std in _students)
        {
            Console.WriteLine(std);
        }
    }
}
