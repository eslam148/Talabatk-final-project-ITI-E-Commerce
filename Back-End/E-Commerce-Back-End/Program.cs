using E_CommerceDB;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using E_Commerce_Back_End.Services;

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
            builder.Services.AddTransient<Iaddress, UserAddressServices>();
            builder.Services.AddTransient<IuserPayment, UserPaymentServices>();
            builder.Services.AddTransient<Ipayment, PaymentServices>();
            #endregion
            builder.Services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            }); ;
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IProductServices, ProductServices>();

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(i =>
                {
                    i.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.UseCors();
            app.MapControllers();

            app.Run();
        }
    }
}