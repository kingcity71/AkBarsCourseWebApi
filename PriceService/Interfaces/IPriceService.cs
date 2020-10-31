using System;
using System.Collections.Generic;
using WebApi.Models;

namespace PriceService.Interfaces
{
    public interface IPriceService
    {
        IEnumerable<Price> GetAll();
        IEnumerable<Price> GetPricesByProductId(Guid productId);
    }
}
