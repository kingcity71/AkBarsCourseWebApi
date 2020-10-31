using System;
using System.Collections.Generic;
using WebApi.Models;

namespace ImageService.Interfaces
{
    public interface IImageService
    {
        IEnumerable<Image> GetAll();
        IEnumerable<Image> GetImagesByProductId(Guid productId);
    }
}
