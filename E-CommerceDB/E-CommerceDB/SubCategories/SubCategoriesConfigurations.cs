using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class SubCategoriesConfigurations : IEntityTypeConfiguration<SubCategories>
    {
        public void Configure(EntityTypeBuilder<SubCategories> builder)
        {
            builder.ToTable("SubCategories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.BrandName).IsRequired();
            builder.Property(x => x.CategoryId).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
        }
    }
}
