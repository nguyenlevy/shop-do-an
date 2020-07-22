using Microsoft.Extensions.DependencyInjection;
using ProductModule.Services.Products;

namespace ProductModule.Core
{
    public static class DIService
    {
        public static IServiceCollection AddFeatureServiceProduct(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWorkProduct, UnitOfWorkProduct>();
            services.AddScoped<ProductDbContext>();
            services.AddScoped<IProductManufacturerService, ProductManufacturerService>();
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
