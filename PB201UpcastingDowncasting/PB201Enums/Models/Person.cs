namespace PB201Enums.Models;

public class Person
{
    public int Id { get; set; }
    public string Fullname { get; set; }
    public Position Position { get; set; }



    public override string ToString()
    {
        return $"Id - {Id}: Fullname: {Fullname} - Position: {Position}";
    }
}
