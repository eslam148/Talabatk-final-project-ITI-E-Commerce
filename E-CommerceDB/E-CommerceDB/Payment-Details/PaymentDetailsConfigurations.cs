using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class PaymentDetailsConfigurations : IEntityTypeConfiguration<PaymentDetails>
    {
        public void Configure(EntityTypeBuilder<PaymentDetails> builder)
        {
            builder.ToTable("PaymentDetails");
            builder.HasKey(i => i.id);
            builder.Property(i => i.id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(i => i.Amount).IsRequired();
            builder.Property(i => i.Status).IsRequired();
            builder.Property(i => i.Provider).IsRequired();
            builder.Property(i => i.created_at).IsRequired();
            builder.Property(i => i.modified_at).IsRequired();
        }
    }
}
