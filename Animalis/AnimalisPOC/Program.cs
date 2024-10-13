using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using Animalis.Database;

namespace AnimalisPOC;

class Program
{
    static void Main(string[] args)
    {

        var host = Host.CreateDefaultBuilder()
           .ConfigureServices((context, services) =>
           {
               services.AddDbContext<AppDbContext>(options =>
                   options.UseNpgsql(context.Configuration.GetConnectionString("DatabaseConnection")));
           })
           .Build();

        using var scope = host.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        var test = dbContext.Animals.ToList();
        Debugger.Break();

    } 
}
