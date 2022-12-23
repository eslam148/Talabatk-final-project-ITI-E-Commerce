using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class UserAddressConfigurations : IEntityTypeConfiguration<UserAddress>
    {
        public void Configure(EntityTypeBuilder<UserAddress> builder)
        {
            builder.ToTable("User_Address");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.country).IsRequired();
            builder.Property(x => x.city).IsRequired();
            builder.Property(x => x.mobile).IsRequired();
            builder.Property(x => x.address_line1).IsRequired();
            builder.Property(x => x.postal_code).IsRequired();
           // builder.Property(x => x.user_id).IsRequired();
        }
    }
}
