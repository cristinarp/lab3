using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microsoft.eShopOnContainers.Services.NewTypes.NewTypes.API
{
    class NewTypeEntityTypeConfiguration
        : IEntityTypeConfiguration<NewType>
    {
        public void Configure(EntityTypeBuilder<NewType> builder)
        {
            builder.ToTable("CatalogType");

            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.Id)
               .UseHiLo("catalog_type_hilo")
               .IsRequired();

            builder.Property(cb => cb.Type)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
