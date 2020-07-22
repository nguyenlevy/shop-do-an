using Microsoft.Extensions.DependencyInjection;
using OrderModule.Services.Orders;

namespace OrderModule.Core
{
    public static class DIService
    {
        public static IServiceCollection AddFeatureServiceOrder(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWorkOrder, UnitOfWorkOrder>();
            services.AddScoped<OrderDbContext>();
            services.AddScoped<IOrderService, OrderService>();

            return services;
        }
    }
}
