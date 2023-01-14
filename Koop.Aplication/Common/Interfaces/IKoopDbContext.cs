using Koop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Koop.Aplication.Common.Interfaces
{
    public interface IKoopDbContext
    {
        DbSet<Cathegory> Cathegories { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Supplier> Suppliers { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancelationToken);
    }
}
