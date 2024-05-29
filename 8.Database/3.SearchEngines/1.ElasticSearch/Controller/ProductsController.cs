using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _1.ElasticSearch.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ElasticsearchService _elasticService;

        public ProductsController(IConfiguration configuration)
        {
            var client = ElasticsearchClientProvider.GetClient(configuration);
            _elasticService = new ElasticsearchService(client);
        }

        [HttpPost("create-index")]
        public async Task<IActionResult> CreateIndex()
        {
            var result = await _elasticService.CreateIndexAsync();
            if (result) return Ok();
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> IndexProduct([FromBody] Product product)
        {
            var result = await _elasticService.IndexProductAsync(product);
            if (result) return Ok();
            return BadRequest();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _elasticService.GetProductAsync(id);
            if (product != null) return Ok(product);
            return NotFound();
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchProducts([FromQuery] string query)
        {
            var result = await _elasticService.SearchProductsAsync(query);
            return Ok(result.Documents);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await _elasticService.DeleteProductAsync(id);
            if (result) return Ok();
            return BadRequest();
        }
    }
}