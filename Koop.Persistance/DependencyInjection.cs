using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Koop.Aplication.Common.Interfaces;

namespace Koop.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<KoopDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("KoopDatabase")));

            services.AddScoped<IKoopDbContext, KoopDbContext>();
            return services;
        }
    }
}
