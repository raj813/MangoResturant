namespace Mango.web.Services.IServices
{
    public interface IProductService
    {
        Task<T> GetAllProductAsync<T>();
        Task<T> GetAllProductbyIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>();
        Task<T> UpdateProductAsync<T>();
        Task<T> DeleteProductAsync<T>(int id);
    }
}
