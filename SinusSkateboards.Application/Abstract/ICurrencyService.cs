using System.Threading.Tasks;

namespace SinusSkateboards.Application.Abstract
{
    public interface ICurrencyService
    {
        Task<decimal> GetEur();
    }
}