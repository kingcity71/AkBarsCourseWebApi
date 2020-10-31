using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductService.Clients;
using ProductService.Interfaces;
using WebApi.Models;

namespace ProductService.Services
{
    public class ProductService : IProductService
    {
        private readonly IImageClient _imageClient;
        private readonly IPriceClient _priceClient;

        public ProductService(IImageClient imageClient, IPriceClient priceClient)
        {
            _imageClient = imageClient;
            _priceClient = priceClient;
        }
        public async Task<IEnumerable<Product>> GetAll()
        {
            var products = new[]
            {
                new Product
                {
                    Id = Guid.Parse("{1B46B06C-98F9-4AC5-858B-9F5534A9C1CE}"),
                    Name = "Product1"
                },
                new Product
                {
                    Id = Guid.Parse("{4715926E-E117-459F-9DA9-DF3F10EC4B2D}"),
                    Name = "Product2"
                },
                new Product
                {
                    Id = Guid.Parse("{5641954D-BD76-45FE-8CA5-07734ADD66DD}"),
                    Name = "Product3"
                }
            };

            var allImages = await _imageClient.GetAll();
            var allPrices = await _priceClient.GetAll();

            foreach (var product in products)
            {
                product.Images = allImages.Where(x => x.ProductId == product.Id).ToList();
                product.Prices = allPrices.Where(x => x.ProductId == product.Id).ToList();
            }

            return products;
        }


    }
}
