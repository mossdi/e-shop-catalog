namespace EShopCore.DAL.Extensions;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class DalExtensions
{
    public static IServiceCollection UseDataAccessLayer(this IServiceCollection services)
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile($"{Directory.GetCurrentDirectory()}/dbSettings.json")
            .AddEnvironmentVariables()
            .Build();

        services.AddDbContext<DalDbContext>(optionsAction: options =>
            options.UseNpgsql(connectionString: config.GetConnectionString(name: "DefaultConnection")));

        return services;
    }
}
