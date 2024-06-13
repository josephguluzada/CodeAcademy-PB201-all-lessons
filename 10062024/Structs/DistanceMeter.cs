namespace Structs;

public struct DistanceMeter : ITest
{
    public int Width { get; set; }
    public int Height { get; set; }

    public DistanceMeter(int width, int heigt)
    {
        Width = width;
        Height = heigt;
    }

    public void ShowData()
    {
        Console.WriteLine(Width + " " + Height);
    }

    public void ShowDifferences(DistanceMeter distanceMeter)
    {
        Console.WriteLine($"{this.Width - distanceMeter.Width} --- {this.Height - distanceMeter.Height} ");
    }
}

public interface ITest 
{
    void ShowData();
    void ShowDifferences(DistanceMeter distanceMeter);
}
