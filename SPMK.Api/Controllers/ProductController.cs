using Microsoft.AspNetCore.Mvc;
using SPMK.Core.Dto;
using SPMK.UseCase.Interface;

namespace SPMK.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpPost]
        [Route("")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<ProductDto>> Create([FromBody] ProductDto productDto)
        {
            _logger.LogInformation($"[START] ProductController - Create: {productDto}");
            ProductDto newProduct = await _productService.Create(productDto);
            _logger.LogInformation($"[FINISH] ProductController - Create: {productDto}");

            return newProduct;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAll()
        {
            _logger.LogInformation($"[START] ProductController - GETALL");
            IEnumerable<ProductDto> newProduct = await _productService.GetAll();
            _logger.LogInformation($"[FINISH] ProductController - GETALL");

            return Ok(newProduct);
        }
    }
}
