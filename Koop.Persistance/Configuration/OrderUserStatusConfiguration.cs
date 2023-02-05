using Koop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koop.Persistance.Configuration
{
    public class OrderUserStatusConfiguration  : IEntityTypeConfiguration<OrderUserStatus>
    {
        public void Configure(EntityTypeBuilder<OrderUserStatus> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
