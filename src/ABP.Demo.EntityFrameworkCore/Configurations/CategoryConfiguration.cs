using ABP.Demo.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ABP.Demo.Configurations;

internal class CategoryConfiguration:IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");
        builder.ConfigureByConvention();
        //dont generate id automatically
        builder.Property(x => x.Id).ValueGeneratedNever();
        
        builder.Property(x => x.NameAr).HasMaxLength(DemoConsts.GeneralTextMaxLength).IsRequired();
        builder.Property(x => x.NameEn).HasMaxLength(DemoConsts.GeneralTextMaxLength).IsRequired();
        builder.Property(x => x.DescriptionAr).HasMaxLength(DemoConsts.DescriptionTextMaxLength).IsRequired();
        builder.Property(x => x.DescriptionEn).HasMaxLength(DemoConsts.DescriptionTextMaxLength).IsRequired();
    }
}