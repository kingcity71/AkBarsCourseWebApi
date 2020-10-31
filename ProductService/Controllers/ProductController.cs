using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductService.Clients;
using ProductService.Interfaces;
using WebApi.Models;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IImageClient _imageClient;

        public ProductController(IProductService productService, IImageClient imageClient)
        {
            _productService = productService;
            _imageClient = imageClient;
        }
        [HttpGet]
        public async Task<IEnumerable<Product>> GetAll()
            => await _productService.GetAll();
    }
}