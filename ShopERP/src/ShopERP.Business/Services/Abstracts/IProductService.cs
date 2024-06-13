using ShopERP.Business.DTOs.ProductDtos;

namespace ShopERP.Business.Services.Abstracts;

public interface IProductService
{
    void Create(ProductCreateDto dto);
    ProductGetDto Get(int id);
    List<ProductGetDto> GetAll();
    void Delete(int id);
}
