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
using TestTask_2.DataBaseAccess;
using TestTask_2.Infrastructure;
using TestTask_2.Repositories;

namespace TestTask_2
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


            services.AddTransient<IUser, UserRepository>();
            services.AddTransient<ICity, CityRepository>();
            services.AddDbContext<ApplicationContext_2>(options => options.UseSqlServer(Configuration["Data:SqlConnection_2:ConnectionString_2"]));
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {
                routes.MapRoute(
                name: "default",
                template: "{controller=Users}/{action=Index}/{id?}");
            });
        }
    }
}
