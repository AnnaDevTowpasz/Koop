using Koop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koop.Persistance.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);
            builder.OwnsOne(p => p.PersonName).Property(p => p.FirstName).HasColumnName("PersonName_FirstName").IsRequired();
            builder.OwnsOne(p => p.PersonName).Property(p => p.LastName).HasColumnName("PersonName_LastName").IsRequired();
            builder.OwnsOne(p => p.Email).Property(p => p.UserName).HasColumnName("Email_UserName").IsRequired();
            builder.OwnsOne(p => p.Email).Property(p => p.DomainName).HasColumnName("Email_DomainName").IsRequired();
            builder.Property(e => e.Telefon).IsRequired();
        }
    }
}
