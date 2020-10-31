using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;

namespace ProductService.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
    }
}
