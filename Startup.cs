using DutchTreat.Data;
using DutchTreat.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DutchTreat
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private readonly IConfiguration _config;
        //private readonly IWebHostEnvironment _env;

        public Startup(IConfiguration config/*, IWebHostEnvironment env*/)
        {
            _config = config;
            //_env = env;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DutchContext>(/*cfg =>
            {
                cfg.UseSqlServer(_config.GetConnectionString("DutchContextDb"));
            }*/);

            services.AddTransient<DutchSeeder>();

            services.AddTransient<IMailService, NullMailService>();

            /*services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Latest);*/

            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation();

            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Use a index.html
            //app.UseDefaultFiles();
            //if (env.IsEnvironment("Development")) //Production
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }
            
            app.UseStaticFiles();

            app.UseRouting();

            //MVC
            app.UseEndpoints(cfg =>
            {
                cfg.MapRazorPages();

                cfg.MapControllerRoute("Default",
                    "/{controller}/{action}/{id?}",//*"/app/index",*/
                    new { controller = "App", action = "Index" });
            });

            
            //Original
            /*if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("<html><body><h1>Hello World</h1></body></html>");
                });
            });*/
        }
    }
}
