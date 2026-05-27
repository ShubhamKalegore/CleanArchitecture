using System.Reflection;
using CleanArchDemo.Application.Interfaces;
using CleanArchDemo.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchDemo.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped<IProductService, ProductService>();

        return services;
    }
}