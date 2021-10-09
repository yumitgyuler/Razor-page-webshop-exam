using SinusSkateboards.DataAccess.Abstract;
using SinusSkateboards.DataAccess.Context;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfOrderDal : EfEntityRepositoryBase<Order>, IOrderDal
    {
        public EfOrderDal(DataContext context) : base(context)
        {

        }
    }
}