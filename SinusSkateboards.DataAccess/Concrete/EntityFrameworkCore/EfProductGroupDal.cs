using SinusSkateboards.DataAccess.Abstract;
using SinusSkateboards.DataAccess.Context;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfProductGroupDal : EfEntityRepositoryBase<ProductGroup>, IProductGroupDal
    {
        public EfProductGroupDal(DataContext context) : base(context)
        {

        }
    }
}