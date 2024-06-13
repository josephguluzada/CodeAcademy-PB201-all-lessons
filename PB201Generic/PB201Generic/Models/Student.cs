using PB201Generic.Helpers;

namespace PB201Generic.Models;

public class Student
{
    private static int _counter { get; set; }
    private string _fullName;
    public int Id { get; private set; }
    public string Fullname 
    {
        get => _fullName;
        set
        {
            if (Helper.CheckFullname(value))
            {
                _fullName = value;
            }
        }
    }
    public double Grade { get; set; }

    static Student()
    {
        _counter = 0;
    }

    public Student()
    {
        _counter++;
        Id = _counter;
    }


    public override string ToString()
    {
        return $"{this.Id} - {this.Fullname} - {this.Grade}";
    }

}
