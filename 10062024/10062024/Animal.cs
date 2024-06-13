namespace _10062024;

public record Animal(string name, byte age, double costPrice, double salePrice);

public interface Test2 
{

}

public record Person()
{
    public string Firstname { get; init; }
    public string Lastname { get; init; }
    public void Deconstruct(
      out string firstName,
      out string lastName
    )
    {
        (firstName, lastName) = (Firstname, Lastname);
    }
}

public record Test
{
    //public Test(string name, byte age, double costPrice, double salePrice) : base(name, age, costPrice, salePrice)
    //{
    //}
    public string Name{ get; set; }
    public Test(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Deconstruct(out int id, out string name)
    {
        (id, name) = (Id, Name) ;
    }

    public int Id { get; set; }

   
}