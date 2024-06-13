using ShopERP.Business.DTOs.ProductDtos;
using ShopERP.Business.Services.Abstracts;
using ShopERP.Core.Models;
using ShopERP.Data.DAL;
using System.Collections.Generic;

namespace ShopERP.Business.Services.Concretes;

public class ProductService : IProductService
{
    public void Create(ProductCreateDto dto)
    {
        Product? product = null;
        if (dto is not null)
        {
            product = new Product() { Name = dto.Name, CostPrice = dto.CostPrice, SalePrice = dto.SalePrice};
        }

        Database.Products.Add(product);
    }

    public void Delete(int id)
    {
        var product = Database.Products.Find(x => x.Id == id);

        if(product is not null)
        {
            Database.Products.Remove(product);
        }
    }

    public ProductGetDto Get(int id)
    {
        var product = Database.Products.Find(x => x.Id == id);
        ProductGetDto? dto = null;
        if(product is not null)
        {
            dto = new ProductGetDto(product.Id, product.Name, product.SalePrice);
        }

        return dto;
    }

    public List<ProductGetDto> GetAll()
    {
        //List <ProductGetDto> dtos = new List<ProductGetDto> ();
        //dtos = Database.Products.Select(x=> new ProductGetDto(x.Id,x.Name,x.SalePrice)).ToList();
        //List<Product> products = Database.Products;
        //foreach (var item in products)
        //{
        //    dtos.Add(new ProductGetDto(item.Id, item.Name,item.SalePrice));
        //}

        return Database.Products.Select(x=> new ProductGetDto(x.Id,x.Name,x.SalePrice)).ToList();
    }
}
