using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    internal class Order_DetailsConfigurations : IEntityTypeConfiguration<Order_Details>
    {
        public void Configure(EntityTypeBuilder<Order_Details> builder)
        {
            builder.ToTable("Order_Details");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Total).IsRequired();
            builder.Property(x => x.Created_at).IsRequired();
            builder.Property(x => x.Modified_at).IsRequired();
           // builder.Property(x => x.User_id);

        }
    }
}
