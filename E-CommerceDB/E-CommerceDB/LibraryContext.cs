using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_CommerceDB.Order_Items;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceDB
{
    public class LibraryContext: IdentityDbContext<User>
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Order_Details> Order_Details { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<UserAddress> UserAddress { get; set; }
        public DbSet<UserPayment> UserPayment { get; set; }
        public DbSet<ShoppingSession> ShoppingSession { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<PaymentDetails> Payment_Details { get; set; }

        //public LibraryContext(DbContextOptions options) : base(options)
        //{ 

        //}
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CategoryConfigurations().Configure(modelBuilder.Entity<Category>());
            new DiscountConfigurations().Configure(modelBuilder.Entity<Discount>());
            new InventoryConfigurations().Configure(modelBuilder.Entity<Inventory>());
            new Order_DetailsConfigurations().Configure(modelBuilder.Entity<Order_Details>());
            new ProductConfigurations().Configure(modelBuilder.Entity<Product>());
            new UserAddressConfigurations().Configure(modelBuilder.Entity<UserAddress>());
            new UserPaymentCongigurations().Configure(modelBuilder.Entity<UserPayment>());
            new ShoppingSessionConfigurations().Configure(modelBuilder.Entity<ShoppingSession>());
            new CartItemConfigurations().Configure(modelBuilder.Entity<CartItem>());
            new OrderItemsConfigurations().Configure(modelBuilder.Entity<OrderItems>());
            new PaymentDetailsConfigurations().Configure(modelBuilder.Entity<PaymentDetails>());



            modelBuilder.MappRelationships();
           // modelBuilder.SeedData();
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DB;Integrated Security=True");
        }
    }
}
