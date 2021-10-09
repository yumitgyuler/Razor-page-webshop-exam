using System.Threading.Tasks;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.DataAccess.Abstract;

namespace SinusSkateboards.Application.Concrete
{
    public class CurrencyManager : ICurrencyService
    {
        private readonly ICurrencyDal _currencyDal;
        public CurrencyManager(ICurrencyDal currencyDal)
        {
            _currencyDal = currencyDal;
        }
        public async Task<decimal> GetEur()
        {
            return await _currencyDal.GetEur();
        }
    }
}