using EShopCore.DAL.Dto;
using EShopCore.DAL.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var host = Host
    .CreateDefaultBuilder(args)
    .ConfigureServices((builder, services) =>
    {
        services.UseDataAccessLayer(
            new DataAccessLayerConfiguration(builder.Configuration.GetConnectionString("DefaultConnection")));
    })
    .Build();
    
host.Run();