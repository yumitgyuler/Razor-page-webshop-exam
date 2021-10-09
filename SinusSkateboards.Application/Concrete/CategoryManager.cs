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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Task<int> Add(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> Get(string name)
        {
            return await _categoryDal.Get(o => o.Name == name);
        }

        public async Task<List<Category>> GetAll()
        {
            return await _categoryDal.GetAll();
        }

        public Task<Category> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}