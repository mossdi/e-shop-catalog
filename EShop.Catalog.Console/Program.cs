using EShop.Catalog.DAL.Extensions;
using EShop.Catalog.Domain.Dto;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var host = Host
    .CreateDefaultBuilder(args)
    .ConfigureServices((builder, services) =>
    {
        services.UseDataAccessLayer(
            new DataAccessConfiguration(builder.Configuration.GetConnectionString("DefaultConnection")));
    })
    .Build();
    
host.Run();