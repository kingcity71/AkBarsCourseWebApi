using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
    }
}
