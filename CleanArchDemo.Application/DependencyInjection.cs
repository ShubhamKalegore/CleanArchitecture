using CleanArchDemo.Application.Interfaces;
using CleanArchDemo.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchDemo.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();

        return services;
    }
}