using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PriceService.Interfaces;
using WebApi.Models;

namespace PriceService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PriceController : ControllerBase
    {
        private readonly IPriceService _priceService;

        public PriceController(IPriceService priceService)
        {
            _priceService = priceService;
        }
        [HttpGet]
        public IEnumerable<Price> GetAll()
            => _priceService.GetAll();
    }
}
