using Business.Abstract;
using Business.Concrete;
using Business.Validators;
using DataAccess.Context;
using DataAccess.Repository.Abstract;
using DataAccess.Repository.Concrete;

namespace API.Extentions
{
    public static class ServiceExtentions
    {
        public static void AddServiceExtention(this IServiceCollection Services)
        {
            Services.AddDbContext<EticDbContext>();
            Services.AddScoped<ICategoryRepository, CategoryRepository>();
            Services.AddScoped<IOrderRepository, OrderRepository>();
            Services.AddScoped<IProductRepository, ProductRepository>();


            Services.AddScoped<IProductValidator, ProductValidator>();
            Services.AddScoped<IOrderValidator, OrderValidator>();
            Services.AddScoped<ICategoryValidator, CategoryValidator>();

            Services.AddScoped<ICategoryService, CategoryService>();
            Services.AddScoped<IProductService, ProductService>();
            Services.AddAutoMapper(typeof(Program));
            



        }
    }
}
