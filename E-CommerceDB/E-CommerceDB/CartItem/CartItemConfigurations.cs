using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class CartItemConfigurations: IEntityTypeConfiguration<CartItem>

    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.ToTable("CartItem");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.ModefiedAt).IsRequired();
        //    builder.Property(x => x.SessionId).IsRequired();
            builder.Property(x => x.Product_id).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

        }
    }
}
