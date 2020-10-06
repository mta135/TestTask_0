using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestTask_0.DataBase;
using TestTask_0.Infrastructure;
using TestTask_0.Repositories;

namespace TestTask_0
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {



            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddTransient<IReview, ReviewRepository>();
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration["Data:SqlConnection:ConnectionString"]));
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {
                routes.MapRoute(
                name: "default",
                template: "{controller=Review}/{action=Index}/{id?}");
            });
        }
    }
}
