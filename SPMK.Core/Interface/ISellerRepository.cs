using SPMK.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMK.Core.Interface
{
    public interface ISellerRepository : ICrudReporitory<Seller>
    {
        Task<Seller> GetByNameSeller(string productName);
    }
}
