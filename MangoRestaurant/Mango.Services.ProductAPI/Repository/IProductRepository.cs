using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> Getproducts();
        Task<ProductDto> GetproductbyId(int productId);
        Task<ProductDto> CreateUpdateproduct(ProductDto ProductDto);
        Task<bool> Deleteproduct(int ProductId);

    }
}
