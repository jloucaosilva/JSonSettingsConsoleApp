using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace JSonSettingsConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        // Setup Host
        var host = CreateDefaultBuilder().Build();

        // Invoke Worker
        using (IServiceScope serviceScope = host.Services.CreateScope())
        {
            IServiceProvider provider = serviceScope.ServiceProvider;
            var running = provider.GetRequiredService<Running>();

            running.Run();
        }

        host.Run();
    }

    static IHostBuilder CreateDefaultBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration(app =>
            {
                app.AddJsonFile("appsettings.json");
            })
            .ConfigureServices(services =>
            {
                services.AddSingleton<Running>();
            });
    }
}