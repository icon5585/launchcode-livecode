using CodingEvents.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CodingEvents
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
            services.AddControllersWithViews();
            // 21.3.2.3 Comment out the EventDbContext configuration
            //services.AddDbContext<EventDbContext>(options =>
            //    options.UseMySql(Configuration.GetConnectionString("DefaultConnection")));

            // 21.3.2.3 Use the razor pages in identity
            services.AddRazorPages();

            // 21.5.1.1 ConfigureServices() update identity options to require passwords be 10 chars
            services.Configure<IdentityOptions>(options =>
                options.Password.RequiredLength = 10
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // 21.5.1.2 Configure() Makes the app use authentication
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                // 21.3.2.3 Follow the routing in _LoginPartial.cshtml
                endpoints.MapRazorPages();
            });
        }
    }
}
