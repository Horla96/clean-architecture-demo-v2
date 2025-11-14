using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch_demo_v2.Infrastructure
{
    public static class ConfigurationServices
    {
        public static IServiceCollection AddInfrastructureServices
            (this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
