using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using SPMK.Infra.DataBase;

namespace SPMK.Infra.DbConfig
{
    public static class DbConfig
    {
        [ExcludeFromCodeCoverage]
        public static void AddDbConfig(this IServiceCollection services, IConfiguration configurations)
        {
            var connectionString = configurations.GetConnectionString("SpmkDatabase");

            services.AddDbContext<SpmkContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
            );
        }
    }
}
