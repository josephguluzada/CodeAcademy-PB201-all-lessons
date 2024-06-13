namespace PB201Exceptions.Models;

public class Student
{
    private static int _counter;

    public int Id { get; set; }
    public string Fullname { get; set; }
    public double Point { get; set; }

    static Student()
    {
        _counter = 0;
    }

    public Student(string fullName, double point)
    {
        _counter++;
        Id = _counter;
        Fullname = fullName;
        Point = point;
    }

    public void StudentInfo()
    {
        Console.WriteLine($"{Id} - {Fullname} - {Point}");
    }

    public override string ToString()
    {
        return $"{Id} - {Fullname} - {Point}";
    }
}
