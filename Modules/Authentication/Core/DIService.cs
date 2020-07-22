using Authentication.Services.Login;
using Authentication.Services.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Authentication.Core
{
    public static class DIService
    {
        public static IServiceCollection AddFeatureServiceAuthentication(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWorkAuthentication, UnitOfWorkAuthentication>();
            services.AddScoped<AuthenticationDbContext>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
