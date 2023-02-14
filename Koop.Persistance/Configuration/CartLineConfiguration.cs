using Koop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koop.Persistance.Configuration
{
    class CartLineConfiguration : IEntityTypeConfiguration<CartLine>
    {
        public void Configure(EntityTypeBuilder<CartLine> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Quantity).IsRequired();
            builder.Property(e => e.Quantity).HasDefaultValue(1);
            builder.Property(e => e.EUnit).IsRequired();
            builder.Property(e => e.EUnit).HasDefaultValue(EUnit.szt);
            builder.Property(e => e.Price).IsRequired();
            builder.Property(e => e.Price).HasPrecision(2);
            builder.Property(e => e.Value).IsRequired();
            builder.Property(e => e.Value).HasPrecision(2);
            //może że format walutowy
        }
    }
}
