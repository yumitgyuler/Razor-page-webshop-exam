using SinusSkateboards.DataAccess.Abstract;
using SinusSkateboards.DataAccess.Context;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category>, ICategoryDal
    {
        public EfCategoryDal(DataContext context) : base(context)
        {

        }
    }
}