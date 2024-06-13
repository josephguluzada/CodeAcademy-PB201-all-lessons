using ShopERP.Business.DTOs.ProductDtos;
using ShopERP.Business.Services.Abstracts;
using ShopERP.Business.Services.Concretes;

namespace ShopERP.CA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductService();

            ProductCreateDto productCreateDto = new ProductCreateDto("Iphone 15", 1200, 1600);
            ProductCreateDto productCreateDto2 = new ProductCreateDto("Iphone 15 Pro", 1400, 2000);


            productService.Create(productCreateDto);
            productService.Create(productCreateDto2);


            productService.Delete(2);

            productService.GetAll().ForEach(product => Console.WriteLine(product));
        }
    }
}
