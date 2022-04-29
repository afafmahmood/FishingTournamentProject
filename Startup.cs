using FishingTournament02.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FishingTournament02
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public void ConfigureServices(IServiceCollection services)
        {

            var connectiondatabase1 =
             

                 @"Server=(localdb)\mssqllocaldb; Database=FishingDb01;
                    Trusted_Connection=True;";
            services.AddDbContext<Database1Context>
                (options => options.UseSqlServer(connectiondatabase1));
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<Database1Context>()
                .AddDefaultTokenProviders();
            services.AddMvc();

            var connectiondatabase2 =

              @"Server=(localdb)\mssqllocaldb; Database=PictureDb;
                    Trusted_Connection=True;";
            services.AddDbContext<PictureDbContext>
                (options => options.UseSqlServer(connectiondatabase2));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

           app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");


            });
        }
    }
}
