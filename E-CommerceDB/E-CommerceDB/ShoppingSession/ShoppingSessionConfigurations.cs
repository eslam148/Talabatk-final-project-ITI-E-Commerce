using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class ShoppingSessionConfigurations: IEntityTypeConfiguration<ShoppingSession>
    {
        public void Configure(EntityTypeBuilder<ShoppingSession> builder)
        {
            builder.ToTable("ShoppingSession");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.total).IsRequired();
            //builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.ModifiedAt).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
        }
    }
}
