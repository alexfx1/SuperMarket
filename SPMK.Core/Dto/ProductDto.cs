using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SPMK.Core.Dto
{
    public class ProductDto
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("ProductName")]
        public string ProductName { get; set; }

        [JsonPropertyName("Validade")]
        public DateTime Validade { get; set; }

        [JsonPropertyName("Marca")]
        public string Marca { get; set; }

        [JsonPropertyName("precoUnitario")]
        public double PrecoUnitario { get; set; }

        [JsonPropertyName("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
