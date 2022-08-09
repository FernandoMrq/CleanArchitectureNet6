using Microsoft.Extensions.DependencyInjection;
using Shop.Application.Interfaces;

namespace Shop.Infrastructure.IoC
{
    public class ConfigureServices
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, IProductService>();
        }

        public static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, IProductRepository>();
        }
    }
}
