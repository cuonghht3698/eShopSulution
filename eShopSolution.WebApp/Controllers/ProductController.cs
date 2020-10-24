using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.Application.Catalog.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolution.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IPublicProductService _product;
        public ProductController(IPublicProductService product)
        {
            _product = product;
        }
        [HttpGet("{lang}")]
       
        public async Task<IActionResult> GetAll(string lang)
        {
            var data= await _product.GetAll(lang);
            return Ok(data);
        }
    }
}
