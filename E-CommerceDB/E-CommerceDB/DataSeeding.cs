using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public static class DataSeeding
    {
        public static void SeedData(this ModelBuilder builder)
        {        
            builder.Entity<Category>()
                .HasData(new Category() {Id=1, Name="Electronic" ,Description="Electronic Devices"});

            builder.Entity<Category>()
              .HasData(new Category() { Id=2, Name="Clothes", Description="Electronic Devices" });
            builder.Entity<Category>()
              .HasData(new Category() { Id=3, Name="goods", Description="Electronic Devices" });

            builder.Entity<SubCategories>()
             .HasData(new SubCategories() { Id=1, BrandName="Samsung" ,CategoryId =1 });

            builder.Entity<SubCategories>()
             .HasData(new SubCategories() { Id=2, BrandName="Appile", CategoryId =1 });

            builder.Entity<SubCategories>()
          .HasData(new SubCategories() { Id=3, BrandName="Keriaze", CategoryId =3 });

            builder.Entity<User>()
               .HasData(new User() { First_Name="Mohamed",Last_Name="Ahmed",Email="Eslam@ss.com"});
            builder.Entity<User>()
                           .HasData(new User() { First_Name="Ahmed", Last_Name="Amir", Email="Eslam@ss.com" });

            builder.Entity<Inventory>().HasData(new Inventory() { Id = 1, Quantity = 5 });
            builder.Entity<Inventory>().HasData(new Inventory() { Id = 2, Quantity = 5 });


            builder.Entity<Discount>()
                .HasData(new Discount() { Id=1,  Description="gg",Disc_Percent=10,Name="hh"});

            builder.Entity<Product>()
          .HasData(new Product() { Id=1, SubCategories_Id=2, Name="Samasung A32", Description="Samsung Phone", Price = 5000, inventory_Id = 2});

            builder.Entity<Product>()
            .HasData(new Product() { Id=2, SubCategories_Id=2, Name="Samasung A52", Description="Samsung Phone", Price = 5000, inventory_Id = 2 });

           // builder.Entity<Complaints>().HasData(new Complaints() {Id=1,Noted="Bad Quality" });
            builder.Entity<Complaints>().HasData(new Complaints() { Id=1, Noted="Bad Quality", ProductId = 2,Progress=0 });
            builder.Entity<Complaints>().HasData(new Complaints() { Id=2, Noted="Bad Quality", ProductId = 2, Progress = 1 });
            builder.Entity<Complaints>().HasData(new Complaints() { Id=3, Noted="Bad Quality", ProductId = 2, Progress = 2 });


        }
    }
}
