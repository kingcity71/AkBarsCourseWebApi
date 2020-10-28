using System;
using System.Collections.Generic;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IImageService _imageService;
        private readonly IPriceService _priceService;

        public ProductService(IImageService imageService, IPriceService priceService)
        {
            _imageService = imageService;
            _priceService = priceService;
        }

        public IEnumerable<Product> GetAll()
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

            foreach (var product in products)
            {
                product.Images = _imageService.GetImagesByProductId(product.Id);
                product.Prices = _priceService.GetPricesByProductId(product.Id);
            }

            return products;
        }
    }
}
