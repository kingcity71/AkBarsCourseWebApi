using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using WebApi.Models;

namespace ProductService.Clients
{
    public interface IImageClient
    {
        [Get("/Image")]
        Task<IEnumerable<Image>> GetAll();
    }
}