using ArtMarketplace.Data.Contexts;
using ArtMarketplace.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ArtMarketplace
{
    public class Startup
    {
        public readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ArtContext>(cfg =>
            {
                cfg.UseSqlServer(_config.GetConnectionString("ArtMarketplaceConnectionString"));
            });

            services.AddTransient<IMailService, NullMailService>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //Add error page
            }

            app.UseStaticFiles();
            app.UseNodeModules();

            app.UseRouting();

            app.UseEndpoints(cfg => cfg.MapControllerRoute("Fallback", "{controller}/{action}/{id?}",
                new { controller = "App", action = "Index" }));
        }
    }
}
