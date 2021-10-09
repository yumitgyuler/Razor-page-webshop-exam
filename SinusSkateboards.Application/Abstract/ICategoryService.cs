using System.Collections.Generic;
using System.Threading.Tasks;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.Application.Abstract
{
    public interface ICategoryService
    {
        Task<int> Add(Category category);
        Task<List<Category>> GetAll();
        Task<Category> GetById(string id);
    }
}