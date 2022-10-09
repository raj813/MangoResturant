﻿using Mango.Services.ProductAPI.Models.Dto;
using Mango.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.ProductAPI.Controllers
{
    [Route("api/products")]
    public class ProductAPIController : ControllerBase
    {
        protected ResponseDto _response;
        private IProductRepository _productRepository;

        public ProductAPIController( IProductRepository productRepository)
        {
            this._response =new ResponseDto();

            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
               IEnumerable<ProductDto> productDtos = await _productRepository.Getproducts();
                _response.Result = productDtos;
            }

            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<object> Get(int id) 
        {
            try 
            {
                ProductDto productDto =  await _productRepository.GetproductbyId(id);
                _response.Result = productDto; 
            }

            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString()};  
            }
            return _response;
        }

    }
}
