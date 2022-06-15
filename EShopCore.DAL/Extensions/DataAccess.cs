namespace EShopCore.DAL.Extensions;

using Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public static class DataAccess
{
    public static IServiceCollection UseDataAccessLayer(
        this IServiceCollection services, DataAccessConfiguration config)
    {
        services.AddDbContext<DataAccessDbContext>(optionsAction: options => options.UseNpgsql(config.ConnectionString));

        return services;
    }
}
