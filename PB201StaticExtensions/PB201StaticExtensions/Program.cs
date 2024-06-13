using PB201StaticExtensions.Models;

namespace PB201StaticExtensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product product1 = new Product();
            //product1.Name = "Iphone 15";
            //product1.CostPrice = 1300;
            //product1.SalePrice = 2000;
            //product1.StockCount = 7;

            //Console.WriteLine(product1.Id);

            //Product.SellProduct(product1);

            //Product product100 = new Product();
            //product100.Name = "Iphone 15";
            //product100.CostPrice = 1300;
            //product100.SalePrice = 2000;
            //product100.StockCount = 7;

            //Console.WriteLine(product100.Id);

            string name = "elIekbERzadE"; // Eli

            //Console.WriteLine(Capitalize(name));

            Console.WriteLine(name.Capitalize());



            //name.Capitalize();
            int a = 5;
            int b = 10;
            Console.WriteLine(a.Sum(b));


        }

        //static string Capitalize(string str)
        //{
        //    string newStr = string.Empty; // ""
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if(i == 0)
        //        {
        //            newStr += char.ToUpper(str[i]);
        //        }
        //        else
        //        {
        //            newStr += char.ToLower(str[i]);
        //        }
        //    }

        //    return newStr;
        //}

    }
}
