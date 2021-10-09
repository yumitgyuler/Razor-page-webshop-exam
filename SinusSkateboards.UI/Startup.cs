using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.Application.Concrete;
using SinusSkateboards.DataAccess.Abstract;
using SinusSkateboards.DataAccess.Concrete.API.Currency;
using SinusSkateboards.DataAccess.Concrete.EntityFrameworkCore;
using SinusSkateboards.DataAccess.Context;

namespace SinusSkateboards.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddMemoryCache();
            services.AddSession();
            services.AddRazorPages();
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("DbConnection"));
            });

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            services.AddScoped<IProductGroupService, ProductGroupManager>();
            services.AddScoped<IProductGroupDal, EfProductGroupDal>();

            services.AddScoped<ICurrencyDal, CurrencyDal>();
            services.AddScoped<ICurrencyService, CurrencyManager>();

            services.AddScoped<IOrderDal, EfOrderDal>();
            services.AddScoped<IOrderService, OrderManager>();

            services.AddScoped<IOrderStatusDal, EfOrderStatusDal>();
            services.AddScoped<IOrderStatusService, OrderStatusManager>();

            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<IAttributeTypeDal, EfAttributeTypeDal>();
            services.AddScoped<IAttributeTypeService, AttributeTypeManager>();

            services.AddHttpContextAccessor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseSession();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
