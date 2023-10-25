using Carcollection.Models;
using Microsoft.EntityFrameworkCore;

namespace Registration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //DI
            builder.Services.AddDbContext<CarDbContext>(options =>
                                    options.UseSqlServer(builder.Configuration.GetConnectionString("Carcollection")));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Cars}/{action=Create}/{id?}");

            app.Run();
        }
    }
}