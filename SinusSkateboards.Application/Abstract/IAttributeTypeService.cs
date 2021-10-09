using System.Collections.Generic;
using System.Threading.Tasks;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.Application.Abstract
{
    public interface IAttributeTypeService
    {
        Task<List<AttributeType>> GetAll();
    }
}