using Microsoft.Extensions.DependencyInjection;
using Shop.Application.Interfaces;
using Shop.Application.Services;
using Shop.Domain.Interfaces;
using Shop.Infra.Data.Repositories;

namespace Shop.Infrastructure.IoC
{
    public class ConfigureServices
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }

        public static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
