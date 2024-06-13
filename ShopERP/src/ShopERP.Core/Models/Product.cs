namespace ShopERP.Core.Models;

public class Product
{
    private static int _counter = 0; 

    public int Id { get; set; }
    public string Name { get; set; }
    public double CostPrice { get; set; }
    public double SalePrice { get; set; }

    public Product()
    {
        Id = ++_counter;
    }
}
