using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SinusSkateboards.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, new()
    {
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task<List<T>> GetAll(Expression<Func<T, bool>> filter = null);
        Task<T> Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}