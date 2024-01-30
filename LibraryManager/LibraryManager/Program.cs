using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using DataAccessLayer.Repository;
using Microsoft.Extensions.DependencyInjection;
using BusinessObjects.Entity;
using Services.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        apiCaller = host.Services.GetRequiredService<ICatalogService>();
    }

    private static IHost CreateHostBuilder(IConfigurationBuilder configuration)
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                // Configuration des services
                services.AddScoped<IGenericRepository<Book>, BookRepository>();
            })
            .Build();
    }
}