using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChanaweeDemo.Application.Interfaces;
using ChanaweeDemo.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ChanaweeDemo.Mvc.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View(_productService.GetProducts());
        }
    }
}