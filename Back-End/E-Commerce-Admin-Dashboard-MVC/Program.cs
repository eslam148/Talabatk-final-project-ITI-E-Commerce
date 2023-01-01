using E_Commerce_Admin_Dashboard_MVC.Services;
using E_Commerce_Admin_Dashboard_MVC;
using E_CommerceDB;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Globalization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileProviders;


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

            builder.Services.AddIdentity<User, IdentityRole>
            ().AddEntityFrameworkStores<LibraryContext>().AddDefaultTokenProviders();
     
            builder.Services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;

                options.Lockout.MaxFailedAccessAttempts = 50;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
                
            });

            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/admin/login";
                // options.AccessDeniedPath = "/User/NotAuthorized";
            });

            builder.Services.Configure<DataProtectionTokenProviderOptions>
                (options =>
                {
                    options.TokenLifespan = TimeSpan.FromMinutes(5);
                });
            #region inject service
            builder.Services.AddTransient<ICategory, CategoryService>();
                builder.Services.AddTransient<IProductServices, ProductServices>();
                builder.Services.AddTransient<ISubcategory, SubcategoryService>();
                builder.Services.AddTransient<IComplains, ComplainsService>();
                builder.Services.AddTransient<Iuser, UserServices>();
                builder.Services.AddTransient<Iorder, OrderServices>();
                builder.Services.AddTransient<IDiscount, DiscountService>();
                builder.Services.AddTransient<IAdmin, AdminServeice>();

            #endregion

            builder.Services.AddControllersWithViews()
                //locazation
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                })
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                        factory.Create(typeof(SharedResource));
                });
            builder.Services.AddScoped<IProductServices, ProductServices>();
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(i =>
                {
                    i.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
            var app = builder.Build();
            //read from Files
            app.UseStaticFiles(new StaticFileOptions()
            {
                RequestPath = "/wwwroot",
                FileProvider = new PhysicalFileProvider
            (Path.Combine(Directory.GetCurrentDirectory(),
            "wwwroot"))
            });
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

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCors();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=admin}/{action=login}/{id?}");

            app.Run();
        }
    }
}