using Microsoft.EntityFrameworkCore;

namespace Koop.Persistance
{
    public class KoopDbContextFactory : DesignTimeDbContextFactoryBase<KoopDbContext>
    {
        protected override KoopDbContext CreateNewInstance(DbContextOptions<KoopDbContext> options)
        {
            return new KoopDbContext(options);
        }
    }
}
