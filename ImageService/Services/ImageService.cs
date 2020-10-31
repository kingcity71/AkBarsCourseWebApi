using System;
using System.Collections.Generic;
using System.Linq;
using ImageService.Interfaces;
using WebApi.Models;

namespace ImageService.Services
{
     public class ImageService : IImageService
    {
        private IEnumerable<Image> _images =
            new[]
            {
                new Image
                {
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("{1B46B06C-98F9-4AC5-858B-9F5534A9C1CE}"),
                    Base64 = "Product 1 Image 1"
                },
                new Image
                {
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("{1B46B06C-98F9-4AC5-858B-9F5534A9C1CE}"),
                    Base64 = "Product 1 Image 2"
                },

                new Image
                {
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("{4715926E-E117-459F-9DA9-DF3F10EC4B2D}"),
                    Base64 = "Product 2 Image 1"
                },
                new Image
                {
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("{4715926E-E117-459F-9DA9-DF3F10EC4B2D}"),
                    Base64 = "Product 2 Image 2"
                },

                new Image
                {
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("{5641954D-BD76-45FE-8CA5-07734ADD66DD}"),
                    Base64 = "Product 3 Image 1"
                },
                new Image
                {
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("{5641954D-BD76-45FE-8CA5-07734ADD66DD}"),
                    Base64 = "Product 3 Image 2"
                }
            };

        public IEnumerable<Image> GetAll()
            => _images;
        public IEnumerable<Image> GetImagesByProductId(Guid productId)
            => _images
                .Where(image => image.ProductId == productId)
                .ToList();
    }
}
