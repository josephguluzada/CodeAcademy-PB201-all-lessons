namespace PB20104062024.Models;

public class Book
{
    private static int _counter;

    public int Id { get; private set; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public int PageCount { get; set; }

    public string Code { get; set; }

    static Book()
    {
        _counter = 10;
    }


    public Book(string name)
    {
        _counter++;
        Id = _counter;
        Name = name;
        Code = Name.Substring(0,2).ToUpper() + Id;
    }

    public override string ToString()
    {
        return $"{Id} - {Code} {Name} {AuthorName} {PageCount}";
    }
}
