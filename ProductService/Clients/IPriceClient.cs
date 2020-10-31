using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using WebApi.Models;

namespace ProductService.Clients
{
    public interface IPriceClient
    {
        [Get("/Price")]
        Task<IEnumerable<Price>> GetAll();
    }
}