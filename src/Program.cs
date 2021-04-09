using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Far_Off_Wanderer.Website
{
    using Conesoft.Hosting;

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateHostBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}