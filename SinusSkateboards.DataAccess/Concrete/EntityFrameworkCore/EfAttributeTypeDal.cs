using SinusSkateboards.DataAccess.Abstract;
using SinusSkateboards.DataAccess.Context;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfAttributeTypeDal : EfEntityRepositoryBase<AttributeType>, IAttributeTypeDal
    {
        public EfAttributeTypeDal(DataContext context) : base(context)
        {

        }
    }
}