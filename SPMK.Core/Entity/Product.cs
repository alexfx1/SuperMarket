using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMK.Core.Entity
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public DateTime Validade { get; set; }
        public string Marca { get; set; }
        public double PrecoUnitario { get; set; }
    }
}
