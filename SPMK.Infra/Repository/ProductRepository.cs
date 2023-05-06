using Microsoft.EntityFrameworkCore;
using SPMK.Core.Entity;
using SPMK.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMK.Infra.Repository
{
    public class ProductRepository : CrudRepository<Product>, IProductRepository
    {
        public ProductRepository(DbContext dbContext) : base(dbContext){}

        public async Task<Product> GetByNameProduct(string productName)
        {
            var product = await _dbSet.AsNoTracking().SingleOrDefaultAsync(p => p.ProductName.Equals(productName));

            if(product == null)
            {
                throw new InvalidOperationException("Product not found");
            }

            return product;
        }
    }
}
