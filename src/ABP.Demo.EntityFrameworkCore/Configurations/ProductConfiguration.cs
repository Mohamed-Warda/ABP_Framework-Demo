using ABP.Demo.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ABP.Demo.Configurations;

internal class ProductConfiguration:IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        builder.ConfigureByConvention();
        builder.Property(x => x.NameAr).HasMaxLength(DemoConsts.GeneralTextMaxLength).IsRequired();
        builder.Property(x => x.NameEn).HasMaxLength(DemoConsts.GeneralTextMaxLength).IsRequired();
        builder.Property(x => x.DescriptionAr).HasMaxLength(DemoConsts.DescriptionTextMaxLength).IsRequired();
        builder.Property(x => x.DescriptionEn).HasMaxLength(DemoConsts.DescriptionTextMaxLength).IsRequired();

        builder.HasOne(x => x.Category)
            .WithMany()
            .HasForeignKey(x => x.CategoryId)
            .IsRequired();

    }
}