using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DL.Issues.AspNetCore.Mvc.CustomRouting
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "test",
                    template: "david/liang/{type}",
                    defaults: new { area = "", controller = "home", action = "about" });

                routes.MapRoute(
                    name: "productListByTypeRoute",
                    template: "products/{type}",
                    defaults: new { area = "", controller = "products", action = "listByType" }
                );

                routes.MapRoute(
                    name: "productListByCategoryRoute",
                    template: "products/{type}/{category}",
                    defaults: new { area = "", controller = "products", action = "listByCategory" }
                );

                routes.MapRoute(
                    name: "productDetailsRoute",
                    template: "products/{type}/{category}/{product}",
                    defaults: new { area = "", controller = "products", action = "details" }
                );

                routes.MapRoute(
                    name: "areaRoute",
                    template: "{area:exists}/{controller=dashboard}/{action=index}/{id?}"
                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
