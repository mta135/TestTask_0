using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using TestTask_1.DataBaseAccess;
using TestTask_1.Infrastructure;
using TestTask_1.Repositories;

namespace TestTask_1
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
            // Add framework services.
            services.AddControllersWithViews().SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
            services.AddKendo();

            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddTransient<IReview, ReviewRepository>();
            services.AddDbContext<ApplicationContext_1>(options => options.UseSqlServer(Configuration["Data:SqlConnection_1:ConnectionString_1"]));
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
