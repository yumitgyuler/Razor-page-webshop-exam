using System.Threading.Tasks;

namespace SinusSkateboards.DataAccess.Abstract
{
    public interface ICurrencyDal
    {
        Task<decimal> GetEur();
    }
}