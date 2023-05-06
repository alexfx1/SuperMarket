using Microsoft.Extensions.Logging;
using SPMK.Core.Dto;
using SPMK.Core.Entity;
using SPMK.Core.Interface;
using SPMK.UseCase.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMK.UseCase.Service
{
    public class ProductService : IProductService
    {
        private readonly ILogger<ProductService> _logger;
        private readonly IProductRepository _productRepository;

        public ProductService(ILogger<ProductService> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        public async Task<ProductDto> Create(ProductDto productDto)
        {
            try
            {
                Product newProduct = new Product
                {
                    Id = productDto.id,
                    ProductName = productDto.ProductName,
                    Validade = productDto.Validade,
                    Marca = productDto.Marca,
                    PrecoUnitario = productDto.PrecoUnitario
                };


                var product = await _productRepository.Create(newProduct);

                ProductDto returnedProduct = new ProductDto
                {
                    id = product.Id,
                    ProductName = product.ProductName,
                    Validade = product.Validade,
                    Marca = product.Marca,
                    PrecoUnitario = product.PrecoUnitario,
                    CreatedAt = product.CreatedAt,
                    UpdatedAt = product.UpdatedAt,
                };

                return returnedProduct;

            } catch(Exception ex)
            {
                _logger.LogWarning($"[ERROR] ProductService - Create invalid {productDto} with exception: {ex.Message}");
                throw new InvalidOperationException("Invalid Product DTO");
            }
        }

        public async Task<ProductDto> DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            var listOfProducts = await _productRepository.GetAll();

            var productDtos = listOfProducts.Select(product => new ProductDto
            {
                id = product.Id,
                ProductName = product.ProductName,
                Validade = product.Validade,
                Marca = product.Marca,
                PrecoUnitario = product.PrecoUnitario,
                CreatedAt = product.CreatedAt,
                UpdatedAt = product.UpdatedAt,
            });

            return productDtos;
        }

        public async Task<ProductDto> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDto> GetByNameProduct(string productName)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDto> UpdateById(string id, ProductDto parametersDto)
        {
            throw new NotImplementedException();
        }
    }
}
