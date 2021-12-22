using Imenik_API.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using Imenik_API.AutoMapper;

namespace Imenik_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());
            var host = CreateHostBuilder(args).Build();

            using(var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbContext = services.GetRequiredService<ApiContext>();

                ImenikData.Initialize(services);
                DrzavaData.Initialize(services);
                ZupanijaData.Initialize(services);
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
