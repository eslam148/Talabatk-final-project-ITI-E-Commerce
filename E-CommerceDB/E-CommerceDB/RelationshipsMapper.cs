using E_CommerceDB.Order_Items;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public static class RelationshipsMapper
    {
        public static void MappRelationships(this ModelBuilder builder)
        {
            builder.Entity<Product>()
                          .HasOne(i => i.SubCategories)
                          .WithMany(i => i.products)
                          .HasForeignKey(i => i.SubCategories_Id)
                          .IsRequired().OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<Product>()
            //             .HasOne(i => i.inventory)
            //             .WithMany(i => i.products)
            //             .HasForeignKey(i => i.inventory_Id)
            //             .IsRequired().OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<Product>()
            //             .HasOne(i => i.discount)
            //             .WithMany(i=> i.products)
            //             .HasForeignKey(i => i.discount_Id)
            //             .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<OrderItems>()
                          .HasOne(i => i.Product)
                          .WithMany(i => i.OrderItems)
                          .HasForeignKey(i => i.Product_id)
                          .IsRequired().OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<CartItem>()
            //            .HasOne(i => i.Product)
            //            .WithMany(i => i.CartItem)
            //            .HasForeignKey(i => i.Product_id)
            //            .IsRequired().OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<ShoppingSession>()
            //            .HasOne(i => i.user)
            //            .WithMany(i => i.ShoppingSession)
            //            .HasForeignKey(i => i.UserId)
            //            .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<UserAddress>()
                         .HasOne(i => i.user)
                         .WithMany(i => i.UserAddress)
                         .HasForeignKey(i => i.user_id)
                         .IsRequired().OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<UserPayment>()
            //            .HasOne(i => i.user)
            //            .WithMany(i => i.UserPayment)
            //            .HasForeignKey(i => i.user_id)
            //            .IsRequired().OnDelete(DeleteBehavior.Cascade);



            builder.Entity<Order_Details>()
                      .HasOne(i => i.user)
                      .WithMany(i => i.Order_Details)
                      .HasForeignKey(i => i.User_id)
                      .OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<CartItem>()
            //           .HasOne(i => i.ShoppingSession)
            //           .WithMany(i => i.CartItem)
            //           .HasForeignKey(i => i.SessionId)
            //           .IsRequired().OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<Order_Details>()
            //          .HasOne(i => i.PaymentDetails)
            //          .WithOne(i => i.Order_Details)
            //          .HasForeignKey<Order_Details>(i => i.Payment_id)
            //          .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<OrderItems>()
                       .HasOne(i => i.Order_Details)
                       .WithMany(i => i.OrderItems)
                       .HasForeignKey(i => i.Order_Details_id)
                       .IsRequired().OnDelete(DeleteBehavior.Cascade);

                      

           


            builder.Entity<SubCategories>()
                    .HasOne(i => i.Category)
                    .WithMany(i => i.SubCategories)
                    .HasForeignKey(i => i.CategoryId)
                    .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Complaints>()
                   .HasOne(i => i.Product)
                   .WithMany(i => i.Complaints)
                   .HasForeignKey(i => i.ProductId)
                   .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Images>()
                 .HasOne(i => i.Product)
                 .WithMany(i => i.Images)
                 .HasForeignKey(i => i.ProductId)
                 .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Complaints>()
                  .HasOne(i => i.Buyer)
                  .WithMany(i => i.ComplaintsBuyer)
                  .HasForeignKey(i => i.BuyerId)
                  .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Complaints>()
                 .HasOne(i => i.Seller)
                 .WithMany(i => i.ComplaintsSeller)
                 .HasForeignKey(i => i.SellerId);
                
        
    }
    }
}
