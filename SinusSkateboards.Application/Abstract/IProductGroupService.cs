using System.Collections.Generic;
using System.Threading.Tasks;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.Application.Abstract
{
    public interface IProductGroupService
    {
        Task Add(ProductGroup productGroup);
        Task Update(ProductGroup productGroup);
        Task Delete(ProductGroup productGroup);
        Task<ProductGroup> Get(string id);
        Task<List<ProductGroup>> GetAll();
        Task<List<ProductGroup>> GetAllByParentSku(string parentSku,bool calculatePrice = true);
        Task<List<ProductGroup>> GetAllByCategory(string category, bool calculatePrice = true);
    }
}