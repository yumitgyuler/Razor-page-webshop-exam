using System.Collections.Generic;
using System.Threading.Tasks;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.Application.Abstract
{
    public interface IProductService
    {
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(Product product);
        Task<Product> Get(string id);
        Task<List<Product>> GetAll();
        Task<List<Product>> GetByGroupId(string groupId);
    }
}