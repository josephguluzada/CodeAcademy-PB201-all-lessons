namespace PB201Generic.Models;

public class IntList
{
    public int[] ints = Array.Empty<int>();

    public void Add(int number)
    {
        Array.Resize(ref ints, ints.Length + 1);
        ints[^1] = number;
    }

    public void AddRange(params int[] ints)
    {
        foreach (var number in ints)
        {
            Add(number);
        }
    }

    public int Count()
    {
        return ints.Length;
    }

    public int FindByIndex(int index)
    {
        return ints[index];
    }

}
