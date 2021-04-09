using Conesoft.Users;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Far_Off_Wanderer.Website
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddUsers("Conesoft Host", Conesoft.Hosting.Host.GlobalStorage / "Users");
            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseUsers();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
            });
        }
    }
}
