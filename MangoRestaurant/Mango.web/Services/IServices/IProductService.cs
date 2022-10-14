using Mango.web.Models;

namespace Mango.web.Services.IServices
{
    public interface IProductService :IBaseService
    {
        Task<T> GetAllProductAsync<T>();
        Task<T> GetAllProductbyIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDto productDto);
        Task<T> UpdateProductAsync<T>(ProductDto productDto);
        Task<T> DeleteProductAsync<T>(int id);
    }
}
