using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.Application.Helpers;
using SinusSkateboards.DataAccess.Abstract;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.Application.Concrete
{
    public class AttributeTypeManager : IAttributeTypeService
    {
        private readonly IAttributeTypeDal _attributeTypeDal;

        public AttributeTypeManager(IAttributeTypeDal attributeTypeDal)
        {
            _attributeTypeDal = attributeTypeDal;

        }

        public async Task<List<AttributeType>> GetAll()
        {
            return await _attributeTypeDal.GetAll();
        }
    }
}