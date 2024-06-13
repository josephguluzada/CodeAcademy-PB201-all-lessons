namespace PB201Enums;

public class PersonNotFoundException : Exception
{
    public PersonNotFoundException()
    {
    }

    public PersonNotFoundException(string? message) : base(message)
    {
    }
}
