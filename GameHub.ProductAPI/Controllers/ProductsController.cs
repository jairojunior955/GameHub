using GameHub.ProductAPI.DTOs;
using GameHub.ProductAPI.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameHub.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> Get()
        {
            var produtosDto = await _productService.GetProducts();
            if (produtosDto == null)
                return NotFound("Products not found");

            return Ok(produtosDto);
        }

        [HttpGet("{id:int}", Name = "GetProduct")]
        public async Task<ActionResult<ProductDTO>> Get(int id)
        {
            var productDto = await _productService.GetProductById(id);
            if (productDto == null)
                return NotFound("Product not found");

            return Ok(productDto);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTO>> Post([FromBody] ProductDTO productDto)
        {
            if (productDto == null)
                return BadRequest("Invalid Data");

            await _productService.AddProduct(productDto);

            return new CreatedAtRouteResult("GetProduct", new { id = productDto.Id }, productDto);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] ProductDTO productDto)
        {
            if (id != productDto.Id)
                return BadRequest();

            else if (productDto == null)
                return BadRequest();
            await _productService.UpdateProduct(productDto);

            return Ok(productDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ProductDTO>> Delete(int id)
        {
            var productDto = await _productService.GetProductById(id);
            if (productDto == null)
                return NotFound("Category not found");

            await _productService.DeleteProduct(id);

            return Ok(productDto);
        }
    }
}
