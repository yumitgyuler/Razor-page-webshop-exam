using System.Runtime.Serialization;

namespace SinusSkateboards.Domain.Enums
{
    public enum OrderStatuses
    {
        Processing,
        Cancelled,
        Refunded,
        Delivered
    }
}
