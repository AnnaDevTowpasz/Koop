using Koop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koop.Persistance.Configuration
{
    public class OrderPriceQuantityConfiguration : IEntityTypeConfiguration<OrderPriceQuantity>
    {
        public void Configure(EntityTypeBuilder<OrderPriceQuantity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Quantity).IsRequired();
            builder.Property(e => e.Unit).IsRequired();
            builder.Property(e => e.Price).IsRequired();
        }
    }
}
