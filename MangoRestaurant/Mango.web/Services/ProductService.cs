﻿using Mango.web.Models;
using Mango.web.Services.IServices;


namespace Mango.web.Services
{
    public class ProductService : BaseService,IProductService
    {
        private readonly IHttpClientFactory _clientFactory ;

        public ProductService(IHttpClientFactory clientFactory) :base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> CreateProductAsync<T>(ProductDto productDto) 
        {
            return await SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = productDto,
                Url = SD.ProductAPIBase + "/api/products",
                AccessToken =""
            });
        }

        public async Task<T> GetAllProductAsync<T>() 
        {
            return await SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/products",
                AccessToken = ""
            });

        }
        public async Task<T> GetAllProductbyIdAsync<T>(int id) 
        {
            return await SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/products/" + id,
                AccessToken = ""
            });

        }

        public async Task<T> UpdateProductAsync<T>(ProductDto productDto) 
        {
            return await SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = productDto,
                Url = SD.ProductAPIBase + "/api/products",
                AccessToken = ""
            });

        }
        public async Task<T> DeleteProductAsync<T>(int id) 
        {
            return await SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.ProductAPIBase + "/api/products/"+ id,
                AccessToken = ""
            });

        }


    }
}
