using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.Application.Helpers
{
    public static class ChangeCurrencyHelper
    {
        public static Product ChangeCurrency(this Product product, decimal exchange)
        {
            product.Price = product.Price / exchange;
            if (product.DiscountedPrice != 0)
            {
                product.DiscountedPrice = product.DiscountedPrice / exchange;
            }
            return product;
        }
    }
}