namespace PB201StaticExtensions.Models;

public class Product
{
    private static int Count;

    static Product()
    {
        Count = 0;
    }
    public Product()
    {
        Count++;
        Id = Count;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public double CostPrice { get; set; }
    public double SalePrice { get; set; }
    public int StockCount { get; set; }

    public static void SellProduct(Product product)
    {
        
        Console.WriteLine(--product.StockCount);
    }
}
