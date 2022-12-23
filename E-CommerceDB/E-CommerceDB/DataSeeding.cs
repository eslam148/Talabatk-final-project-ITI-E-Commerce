using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public static class DataSeeding
    {


        public static async void SeedData(this ModelBuilder builder)
        {
           
            List<IdentityRole> Roles = new List<IdentityRole>()
            {
                new IdentityRole{Name = "Admin"},
                new IdentityRole{Name = "Seller"},
                new IdentityRole{Name = "Buyer"}
            };
            builder.Entity<IdentityRole>().HasData(Roles);
            User user = new User()
            {
                First_Name = "admin",
                Last_Name = "admin",
                UserName = "admin",
                Email = "Islam12476794@gmail.com",
                PhoneNumber ="01229384960"

            };
            //IdentityResult result = await UserManager.CreateAsync(user,"123456");
            //await UserManager.AddToRoleAsync(user, "Admin");
            builder.Entity<Category>()
                .HasData(new Category() { Id=1, Name="Electronic", Description="Electronic Devices" });

            builder.Entity<Category>()
              .HasData(new Category() { Id=2, Name="Clothes", Description="Electronic Devices" });
            builder.Entity<Category>()
              .HasData(new Category() { Id=3, Name="goods", Description="Electronic Devices" });
            builder.Entity<SubCategories>()
             .HasData(new SubCategories() { Id=1, BrandName="Samsung", CategoryId =1 });

            builder.Entity<SubCategories>()
             .HasData(new SubCategories() { Id=2, BrandName="Appile", CategoryId =1 });

            builder.Entity<SubCategories>()
          .HasData(new SubCategories() { Id=3, BrandName="Keriaze", CategoryId =3 });
            builder.Entity<User>()
              .HasData(new User() { First_Name="Mohamed", Last_Name="Ahmed", Email="Eslam@ss.com",UserName = "Admin" });

            builder.Entity<User>()
               .HasData(new User() { First_Name="Mohamed", Last_Name="Ahmed", Email="Eslam@ss.com" });
            builder.Entity<User>()
                           .HasData(new User() { First_Name="Ahmed", Last_Name="Amir", Email="Eslam@ss.com" });

            builder.Entity<Inventory>().HasData(new Inventory() { Id = 1, Quantity = 5 });
            builder.Entity<Inventory>().HasData(new Inventory() { Id = 2, Quantity = 5 });


            builder.Entity<Discount>()
                .HasData(new Discount() { Id=1, Description="gg", Disc_Percent=10, Name="hh" });

            builder.Entity<Product>()
          .HasData(new Product() { Id=1, SubCategories_Id=2, Name="Samasung A32", Description="Samsung Phone", Price = 5000, inventory_Id = 2 });

            builder.Entity<Product>()
            .HasData(new Product() { Id=2, SubCategories_Id=2, Name="Samasung A52", Description="Samsung Phone", Price = 6000, inventory_Id = 2 });
            builder.Entity<Product>()
           .HasData(new Product() { Id=3, SubCategories_Id=2, Name="Samasung A72", Description="Samsung Phone", Price = 7000, inventory_Id = 1 });

            //builder.Entity<Complaints>().HasData(new Complaints() { Id=1, Noted="Bad Quality", ProductId = 1, Progress=0 });
            // builder.Entity<Complaints>().HasData(new Complaints() { Id=2, Noted="Bad Quality", ProductId = 2, Progress = 1 });
            //  builder.Entity<Complaints>().HasData(new Complaints() { Id=3, Noted="Bad Quality", ProductId = 3, Progress = 2 });
            //builder.Entity<PaymentDetails>().HasData(new PaymentDetails() {id=1, Amount=5000,Provider="Maste Card",Status="active"});
            //builder.Entity<PaymentDetails>().HasData(new PaymentDetails() { id = 2,Amount=5000,Provider="Visa", Status="active" });


            //builder.Entity<Order_Details>().HasData(new Order_Details() { Id=1,Payment_id=1});
            //builder.Entity<Order_Details>().HasData(new Order_Details() { Id=2 ,Payment_id = 2});

            //builder.Entity<OrderItems>().HasData(new OrderItems() { Id=1, Order_Details_id = 1,Product_id = 1,Quantity = 3});
            //builder.Entity<OrderItems>().HasData(new OrderItems() { Id=2, Order_Details_id = 1, Product_id = 2, Quantity = 6 });
            //builder.Entity<OrderItems>().HasData(new OrderItems() { Id=3, Order_Details_id = 1, Product_id = 3, Quantity = 2 });

            //builder.Entity<OrderItems>().HasData(new OrderItems() { Id=4, Order_Details_id = 2, Product_id = 1, Quantity = 3 });
            //builder.Entity<OrderItems>().HasData(new OrderItems() { Id=5, Order_Details_id = 2, Product_id = 2, Quantity = 6 });
            //builder.Entity<OrderItems>().HasData(new OrderItems() { Id=6, Order_Details_id = 2, Product_id = 3, Quantity = 2 });


        }
    }
}
