using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Controllers
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