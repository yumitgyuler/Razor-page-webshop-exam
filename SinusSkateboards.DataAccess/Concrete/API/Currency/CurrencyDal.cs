using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using SinusSkateboards.DataAccess.Abstract;
using Newtonsoft.Json;
using SinusSkateboards.Domain.Entities;
using Microsoft.Extensions.Configuration;
using SinusSkateboards.DataAccess.Context;

namespace SinusSkateboards.DataAccess.Concrete.API.Currency
{
    public class CurrencyDal : ICurrencyDal
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IConfiguration _configuration;
        public CurrencyDal(IMemoryCache memoryCache, IConfiguration configuration)
        {
            _configuration = configuration;
            _memoryCache = memoryCache;
        }
        public async Task<decimal> GetEur()
        {
            if (_memoryCache.TryGetValue("eur", out decimal eurToSek))
            {
                return eurToSek;
            }
            else
            {
                using (HttpResponseMessage response = await ApiHelper.ApiContext.GetAsync(_configuration.GetConnectionString("CurrencyApiUrl")))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var res = await response.Content.ReadAsStringAsync();
                        Root result = JsonConvert.DeserializeObject<Root>(res);

                        _memoryCache.Set("eur", (decimal)result.rates.SEK, TimeSpan.FromHours(8));

                        return (decimal)result.rates.SEK;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
        }
    }
}