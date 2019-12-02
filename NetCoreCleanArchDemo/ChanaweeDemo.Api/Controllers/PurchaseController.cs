using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChanaweeDemo.Application.Interfaces;
using ChanaweeDemo.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChanaweeDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseService _purchaseService;
        public PurchaseController(IPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] PurchaseViewModel vm)
        {
            return Ok(_purchaseService.CalculatePrice(vm));
        }
    }
}