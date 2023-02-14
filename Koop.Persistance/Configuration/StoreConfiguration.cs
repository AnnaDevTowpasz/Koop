using Koop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koop.Persistance.Configuration
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Quantity).IsRequired();
            builder.Property(e => e.Unit).IsRequired();
            builder.Property(e => e.Price).IsRequired();
        }
    }
}
