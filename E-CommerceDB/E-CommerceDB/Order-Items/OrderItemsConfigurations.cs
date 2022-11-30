using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB.Order_Items
{
    public class OrderItemsConfigurations : IEntityTypeConfiguration<OrderItems>
    {
        public void Configure(EntityTypeBuilder<OrderItems> builder)
        {
            builder.ToTable("OrderItems");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(i => i.Quantity).IsRequired();
            builder.Property(i => i.Order_Details_id).IsRequired();
          //  builder.Property(i => i.Product_id).IsRequired();
            builder.Property(i => i.created_at).IsRequired();
            builder.Property(i => i.modified_at).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

        }
    }
}
