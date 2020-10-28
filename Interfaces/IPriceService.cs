using System;
using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IPriceService
    {
        IEnumerable<Price> GetAll();
        IEnumerable<Price> GetPricesByProductId(Guid productId);
    }
}
