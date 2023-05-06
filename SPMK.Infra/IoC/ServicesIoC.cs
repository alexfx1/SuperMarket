using Microsoft.Extensions.DependencyInjection;
using SPMK.UseCase.Interface;
using SPMK.UseCase.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMK.Infra.IoC
{
    public static class ServicesIoC
    {
        [ExcludeFromCodeCoverage]
        public static void AddServicesIoC(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
