using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
       
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id).ValueGeneratedOnAdd();
            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x=>x.Description).IsRequired();
           // builder.Property(x=>x.SKU).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.SubCategories_Id).IsRequired();
           // builder.Property(x => x.discount_Id).IsRequired();
            builder.Property(x => x.inventory_Id).IsRequired();
            builder.Property(x => x.Progress).IsRequired();
            builder.Property(x => x.created_at).IsRequired();
           // builder.Property(x => x.deleted_at).IsRequired();
            builder.Property(x => x.modified_at).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();


        }
    }
}
