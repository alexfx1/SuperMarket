using SPMK.Core.Dto;
using SPMK.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMK.UseCase.Interface
{
    public interface IProductService
    {
        Task<ProductDto> Create(ProductDto productDto);
        Task<ProductDto> GetByNameProduct(string productName);
        Task<ProductDto> GetById(string id);
        Task<IEnumerable<ProductDto>> GetAll();
        Task<ProductDto> DeleteById(string id);
        Task<ProductDto> UpdateById(string id, ProductDto parametersDto);
    }
}
