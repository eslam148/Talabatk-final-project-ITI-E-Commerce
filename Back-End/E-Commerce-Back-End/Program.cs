using E_Commerce_Admin_Dashboard_MVC.Services;
using E_Commerce_Admin_Dashboard_MVC;
using E_CommerceDB;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Back_End
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<LibraryContext>(options =>
            {
                options.UseLazyLoadingProxies()
                    .UseSqlServer(builder.Configuration.GetConnectionString("DBKey"));
            });

            builder.Services.AddIdentity<User, IdentityRole>
            ().AddEntityFrameworkStores<LibraryContext>().AddDefaultTokenProviders();
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
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IProductServices, ProductServices>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}