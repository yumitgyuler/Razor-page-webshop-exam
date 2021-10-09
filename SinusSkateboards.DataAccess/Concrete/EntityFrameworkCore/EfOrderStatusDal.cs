using SinusSkateboards.DataAccess.Abstract;
using SinusSkateboards.DataAccess.Context;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfOrderStatusDal : EfEntityRepositoryBase<OrderStatus>, IOrderStatusDal
    {
        public EfOrderStatusDal(DataContext context) : base(context)
        {

        }
    }
}