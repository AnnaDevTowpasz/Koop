using Koop.Aplication.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Koop.Persistance
{
    public class KoopDbContextFactory : DesignTimeDbContextFactoryBase<KoopDbContext>
    {
        private readonly IDateTime _iDateTime;
        protected override KoopDbContext CreateNewInstance(DbContextOptions<KoopDbContext> options, IDateTime dateTime)
        {
            return new KoopDbContext(options, _iDateTime);
        }
    }
}
