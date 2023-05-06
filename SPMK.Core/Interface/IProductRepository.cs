using SPMK.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMK.Core.Interface
{
    public interface IProductRepository : ICrudReporitory<Product>
    {
        Task<Product> GetByNameProduct(string productName);
    }
}
