using E_CommerceDB;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Admin_Dashboard_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
            builder.Services.AddDbContext<LibraryContext>(options =>
            {
                options.UseLazyLoadingProxies()
                    .UseSqlServer(builder.Configuration.GetConnectionString("DBKey"));
            });
            builder.Services.AddTransient<ICategory, CategoryService>();
            builder.Services.AddTransient<IComplains, ComplainsService>();

            builder.Services.AddControllersWithViews();

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
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}