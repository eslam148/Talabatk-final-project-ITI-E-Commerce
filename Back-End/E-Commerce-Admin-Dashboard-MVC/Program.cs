using E_Commerce_Admin_Dashboard_MVC.Services;
using E_Commerce_Admin_Dashboard_MVC;
using E_CommerceDB;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Globalization;

namespace E_Commerce_Admin_Dashboard_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //const string language = "en-GB"; 
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
            builder.Services.AddDbContext<LibraryContext>(options =>
            {
                options.UseLazyLoadingProxies()
                    .UseSqlServer(builder.Configuration.GetConnectionString("DBKey"));
            });
            builder.Services.AddTransient<ICategory, CategoryService>();
            builder.Services.AddTransient<IProductServices, ProductServices>();
            builder.Services.AddTransient<ISubcategory, SubcategoryService>();
            builder.Services.AddTransient<IComplains, ComplainsService>();
            builder.Services.AddTransient<Iuser, UserServices>();
            builder.Services.AddTransient<Iorder, OrderServices>();

           
            builder.Services.AddTransient<IDiscount, DiscountService>();


            builder.Services.AddControllersWithViews()
                //locazation
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                        factory.Create(typeof(SharedResource));
                   }); ;
            builder.Services.AddScoped<IProductServices, ProductServices>();

  
            var app = builder.Build();

           //Localiztion
            var supportedCultures = new[] {
                      new CultureInfo("ar-EG"),
                      new CultureInfo("en-US"),
             };
            //locaiztion
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-US"),//Default
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures,
                RequestCultureProviders = new List<IRequestCultureProvider>//cookies Best in clients
                {
                new QueryStringRequestCultureProvider(),
                new CookieRequestCultureProvider()
                }
            });
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