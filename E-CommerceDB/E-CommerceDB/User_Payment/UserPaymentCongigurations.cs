using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class UserPaymentCongigurations : IEntityTypeConfiguration<UserPayment>
    {
        public void Configure(EntityTypeBuilder<UserPayment> builder)
        {
            builder.ToTable("User_Payment");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.paymenr_type).IsRequired();
            builder.Property(x => x.account_no).IsRequired();
            builder.Property(x => x.provider).IsRequired();
            builder.Property(x => x.expire_date).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

            //builder.Property(x => x.user_id).IsRequired();
        }
    }
}
