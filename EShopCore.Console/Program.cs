using EShopCore.DAL.Extensions;
using Microsoft.Extensions.Hosting;

var host = Host
    .CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.UseDataAccessLayer();
    })
    .Build();