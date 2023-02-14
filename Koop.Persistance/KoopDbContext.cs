using Koop.Aplication.Common.Interfaces;
using Koop.Aplication.Interfaces;
using Koop.Domain.Common;
using Koop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Koop.Persistance
{
    public class KoopDbContext : DbContext, IKoopDbContext
    {
        private readonly IDateTime _iDateTime;
        public KoopDbContext(DbContextOptions<KoopDbContext> options, IDateTime dateTime) : base(options)
        {
            _iDateTime = dateTime;
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartLine> CartLines { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DictionaryCartStatus> DictionaryCartStatuses { get; set; }
        public DbSet<DictionaryOrderStatus> DictionaryOrderStatuses { get; set; }
        public DbSet<DictionaryUserStatus> DictionaryUserStatuses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPriceQuantity> OrderPriceQuantities { get; set; }
        public DbSet<OrderUserStatus> OrderUserStatuses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().OwnsOne(p => p.PersonName);
            modelBuilder.Entity<User>().OwnsOne(p => p.Email);
            modelBuilder.Entity<Order>().OwnsOne(p => p.OrderName);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "";
                        entry.Entity.Created = _iDateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = "";
                        entry.Entity.Modified = _iDateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = "";
                        entry.Entity.Modified = _iDateTime.Now;
                        entry.Entity.Inactivated = _iDateTime.Now;
                        entry.Entity.InactivatedBy = "";
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
