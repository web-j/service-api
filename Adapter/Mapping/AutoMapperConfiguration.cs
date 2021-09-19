using Microsoft.Extensions.DependencyInjection;
using System;

namespace Adapter.Mapping
{
    public static class AutoMapperConfiguration
    {
       public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile), typeof(DTOToDomainMappingProfile));
        }
    }
}
