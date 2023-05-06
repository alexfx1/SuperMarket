using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMK.Core.Entity
{
    public class Seller : BaseEntity
    {
        public required string Name { get; set; }
        public required string? Email { get; set; }
        public required Int64 Contact { get; set; }
    }
}
