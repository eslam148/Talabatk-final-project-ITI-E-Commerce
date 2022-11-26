using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class DiscountConfigurations : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.ToTable("Discount");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Disc_Percent).IsRequired();
            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.created_at).IsRequired();
           // builder.Property(x => x.deleted_at).IsRequired();
            builder.Property(x => x.modified_at).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

        }
    }
}
