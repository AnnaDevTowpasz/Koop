using Koop.Aplication.Common.Interfaces;
using Koop.Aplication.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Koop.Persistance
{
    public class KoopDbContextFactory : DesignTimeDbContextFactoryBase<KoopDbContext>
    {
        protected override KoopDbContext CreateNewInstance(DbContextOptions<KoopDbContext> options)
        {
            return new KoopDbContext(options);
        }

        //protected override KoopDbContext CreateNewInstance(DbContextOptions<KoopDbContext> options, IDateTime dateTime, ICurrentUserService userService)
        //{
        //    return new KoopDbContext(options, dateTime, userService);
        //}
    }
}
