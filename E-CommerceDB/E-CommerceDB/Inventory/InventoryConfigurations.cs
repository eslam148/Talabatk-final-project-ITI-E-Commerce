using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class InventoryConfigurations : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.ToTable("Inventory");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.SelledQuantity).IsRequired();
            builder.Property(x => x.created_at).IsRequired();
            builder.Property(x => x.modified_at).IsRequired();
           // builder.Property(x => x.deleted_at).IsRequired();

        }
    }
}
