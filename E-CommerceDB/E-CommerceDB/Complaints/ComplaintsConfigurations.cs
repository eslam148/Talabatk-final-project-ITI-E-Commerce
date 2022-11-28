using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    internal class ComplaintsConfigurations : IEntityTypeConfiguration<Complaints>
    {
        public void Configure(EntityTypeBuilder<Complaints> builder)
        {
            builder.ToTable("Complaints");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
           // builder.Property(x => x.SellerId).IsRequired();
           // builder.Property(x => x.BuyerId).IsRequired();
            builder.Property(x => x.Noted).IsRequired();
            builder.Property(x => x.Date).IsRequired();
           // builder.Property(x => x.ProductId).IsRequired();
            builder.Property(x => x.Progress).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();


        }
    }
}
