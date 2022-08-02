using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PetStore;
using PetStore.Data;
using PetStore.Logic;
using System.Text.Json;
using System.Text.Json.Serialization;

CreateHostBuilder(args).Build().Run();

static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

static IServiceProvider CreateServiceCollection()
{
    return new ServiceCollection()
        
        .BuildServiceProvider();
}