using Microsoft.AspNetCore.Identity;

namespace SinusSkateboards.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ShippingAdress ShippingAdress { get; set; }
        public virtual BillingAdress BillingAdress { get; set; }
    }
}