using E_CommerceDB;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using E_Commerce_Back_End.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.FileProviders;

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
            builder.Services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;

                options.Lockout.MaxFailedAccessAttempts = 50;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);

                options.SignIn.RequireConfirmedEmail = true;
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
            builder.Services.AddTransient<Iaddress, UserAddressServices>();
            builder.Services.AddTransient<IuserPayment, UserPaymentServices>();
            builder.Services.AddTransient<Ipayment, PaymentServices>();
            #endregion
            builder.Services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });
            builder.Services.AddAuthentication
       (
           options =>
           {
               options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
               options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
               options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
           }
       )
       .AddJwtBearer(
           options =>
           {
               options.TokenValidationParameters
               = new TokenValidationParameters()
               {
                   ValidateIssuer=false,
                   ValidateAudience=false,
                   SaveSigninToken=true,
                   IssuerSigningKey
                    = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("IOLJYHSDSIoleJHsdsdsas98WeWsdsdQweweHgsgdf_&6#2"))
               };
           }
       );
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(i =>
                {
                    i.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IProductServices, ProductServices>();

         



            var app = builder.Build();

            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    RequestPath = "/wwwroot",
            //    FileProvider = new PhysicalFileProvider
            //(Path.Combine(Directory.GetCurrentDirectory(),
            //"wwwroot"))
            //});
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCors();
            app.MapControllers();

            app.Run();
        }
    }
}