namespace EShopCore.DAL.Extensions;

using Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public static class DataAccessLayerExtensions
{
    public static IServiceCollection UseDataAccessLayer(
        this IServiceCollection services, DataAccessLayerConfiguration config)
    {
        services.AddDbContext<DataAccessLayerDbContext>(optionsAction: options => options.UseNpgsql(config.ConnectionString));

        return services;
    }
}
