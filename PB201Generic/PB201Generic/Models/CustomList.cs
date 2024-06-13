namespace PB201Generic.Models;

public class CustomList<T> where T : class, new() //constraints
{
    public T[] Values = Array.Empty<T>(); 


    public void Add(T value)
    {
        Array.Resize(ref Values, Values.Length + 1);
        Values[^1] = value;
    }

    public void AddRange(params T[] values)
    {
        foreach (var number in values)
        {
            Add(number);
        }
    }

    public int Count()
    {
        return Values.Length;
    }

    public T FindByIndex(int index)
    {
        return Values[index];
    }


}
