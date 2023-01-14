using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using MediatR;
using MediatR.Pipeline;
using System.Reflection;
using Koop.Aplication.Common.Behaviours;

namespace Koop.Aplication
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IRequestPreProcessor<>), typeof(LoggingBehaviour<>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBahaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

            return services;
        }
    }
}
