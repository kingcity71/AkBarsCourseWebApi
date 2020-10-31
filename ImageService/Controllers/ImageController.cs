using System.Collections.Generic;
using ImageService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace ImageService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;
        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet]
        public IEnumerable<Image> GetAll() 
            => _imageService.GetAll();
    }
}
