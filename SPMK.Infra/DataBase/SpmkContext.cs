using Microsoft.EntityFrameworkCore;
using SPMK.Core.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMK.Infra.DataBase
{
    public class SpmkContext : DbContext
    {
        [ExcludeFromCodeCoverage]
        public SpmkContext(DbContextOptions<SpmkContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        [ExcludeFromCodeCoverage]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                return;
            }

            modelBuilder.Entity<Product>().ToTable("tbl_product");
        }
    }
}
