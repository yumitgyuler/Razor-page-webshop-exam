using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.Domain.Entities;

namespace MyApp.Namespace
{
    [BindProperties]
    public class AddProductModel : PageModel
    {
        private readonly IProductGroupService _productGroupService;
        private readonly ICategoryService _categoryService;
        private readonly IAttributeTypeService _attributeTypeService;
        private readonly IHostingEnvironment _environment;
        public AddProductModel(IProductGroupService productGroupService, ICategoryService categoryService, IAttributeTypeService attributeTypeService, IHostingEnvironment environment)
        {
            _environment = environment;
            _attributeTypeService = attributeTypeService;
            _productGroupService = productGroupService;
            _categoryService = categoryService;
        }
        public ProductGroup ProductGroup { get; set; }
        public List<Category> Category { get; set; }
        public List<AttributeType> AttributeTypes { get; set; }
        public List<ProductAttribute> Color { get; set; }
        public List<ProductAttribute> Size { get; set; }
        public IFormFile Upload { get; set; }
        public async Task OnGet()
        {
            Category = await _categoryService.GetAll();
            AttributeTypes = await _attributeTypeService.GetAll();

            Color = new List<ProductAttribute>();

            foreach (var color in AttributeTypes.Where(n => n.Name == "Color"))
            {
                foreach (var item in color.ProductAttributes)
                {
                    Color.Add(new ProductAttribute
                    {
                        Id = item.Id,
                        Name = item.Name
                    });
                };
            }
            Size = new List<ProductAttribute>();

            foreach (var size in AttributeTypes.Where(n => n.Name == "Size"))
            {
                foreach (var item in size.ProductAttributes)
                {
                    Size.Add(new ProductAttribute
                    {
                        Id = item.Id,
                        Name = item.Name
                    });
                };
            }
        }
        public async Task<IActionResult> OnPost()
        {
            string uniqueFileName = String.Concat(Guid.NewGuid().ToString(), ".png");
            var file = Path.Combine(_environment.WebRootPath, "images/products", uniqueFileName);
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await Upload.CopyToAsync(fileStream);
            }
            ProductGroup.Thumbnail = uniqueFileName;
            await _productGroupService.Add(ProductGroup);
            return RedirectToPage("/Admin/Products");
        }
    }
}
