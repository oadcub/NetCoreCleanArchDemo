using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChanaweeDemo.Application.Interfaces;
using ChanaweeDemo.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ChanaweeDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _productService.GetProducts();
            return Ok(products.Products);
        }
        [HttpPost]
        public IActionResult Post([FromBody] ProductViewModel productViewModel)
        {
            _productService.Create(productViewModel);
            return Ok(productViewModel);
        }
    }
}
