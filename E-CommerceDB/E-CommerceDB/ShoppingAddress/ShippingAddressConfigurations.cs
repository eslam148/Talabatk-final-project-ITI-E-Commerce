using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class ShippingAddressConfigurations : IEntityTypeConfiguration<ShippingAddress>
    {
        public void Configure(EntityTypeBuilder<ShippingAddress> builder)
        {
            builder.ToTable("Shipping_Address");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.country).IsRequired();
            builder.Property(x => x.city).IsRequired();
            builder.Property(x => x.mobile).IsRequired();
            builder.Property(x => x.address_line1).IsRequired();
           // builder.Property(x => x.address_line2).IsRequired();
            builder.Property(x => x.postal_code).IsRequired();
        }
    }
}
