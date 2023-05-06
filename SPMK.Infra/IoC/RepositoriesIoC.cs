using Microsoft.Extensions.DependencyInjection;
using SPMK.Core.Interface;
using SPMK.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMK.Infra.IoC
{
    public static class RepositoriesIoC
    {
        [ExcludeFromCodeCoverage]
        public static void AddRepositoriesIoC(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
