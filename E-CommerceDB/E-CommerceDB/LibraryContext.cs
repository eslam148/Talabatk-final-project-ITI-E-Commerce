using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_CommerceDB.Order_Items;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceDB
{
   public enum progress
    {
        pending,
        Reject,
        Accept
    }
    public class LibraryContext: IdentityDbContext<User>
    {
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
      //  public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Order_Details> Order_Details { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<UserAddress> UserAddress { get; set; }
        //public virtual DbSet<UserPayment> UserPayment { get; set; }
        //public virtual DbSet<ShoppingSession> ShoppingSession { get; set; }
       // public virtual DbSet<CartItem> CartItem { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        //public virtual DbSet<PaymentDetails> Payment_Details { get; set; }
        public virtual DbSet<Complaints> Complaints { get; set; }
        public virtual DbSet<Images> ProductImages { get; set; }
        public virtual DbSet<SubCategories> SubCategories { get; set; }


        public LibraryContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CategoryConfigurations().Configure(modelBuilder.Entity<Category>());
            new DiscountConfigurations().Configure(modelBuilder.Entity<Discount>());
          //  new InventoryConfigurations().Configure(modelBuilder.Entity<Inventory>());
            new Order_DetailsConfigurations().Configure(modelBuilder.Entity<Order_Details>());
            new ProductConfigurations().Configure(modelBuilder.Entity<Product>());
            new UserAddressConfigurations().Configure(modelBuilder.Entity<UserAddress>());
         //   new UserPaymentCongigurations().Configure(modelBuilder.Entity<UserPayment>());
          //  new ShoppingSessionConfigurations().Configure(modelBuilder.Entity<ShoppingSession>());
           // new CartItemConfigurations().Configure(modelBuilder.Entity<CartItem>());
            new OrderItemsConfigurations().Configure(modelBuilder.Entity<OrderItems>());
           // new PaymentDetailsConfigurations().Configure(modelBuilder.Entity<PaymentDetails>());



            modelBuilder.MappRelationships();
            //modelBuilder.SeedData();
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
           //optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DB;Integrated Security=True");
        }
    }
}
