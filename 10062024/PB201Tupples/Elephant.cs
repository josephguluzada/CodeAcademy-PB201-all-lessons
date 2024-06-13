namespace PB201Tupples;

public class Elephant
{
    public string Name { get; set; }
    public byte Age { get; set; }


    public (string, byte) GetInfo()
    {
        return (Name, Age);
    }

    //public Tuple<string, byte> GetInfo()
    //{
    //    return new Tuple<string, byte>(Name, Age);
    //}
}
