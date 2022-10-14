using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.web.Services.IServices
{
    public interface IProductService
    {
        Task<T> GetAllProductAsync<T>();
        Task<T> GetAllProductbyIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDto productDto);
        Task<T> UpdateProductAsync<T>(ProductDto productDto);
        Task<T> DeleteProductAsync<T>(int id);
    }
}
