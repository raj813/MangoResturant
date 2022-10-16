using Mango.web.Services.IServices;
using Mango.web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Mango.web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> ProductIndex()
        {
            List<ProductDto> list = new ();
            var response = await _productService.GetAllProductAsync<ResponseDto>();
            if (response != null && response.IsSuccess) 
            {
                list = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }
            return View(list);
        }
    }
}
