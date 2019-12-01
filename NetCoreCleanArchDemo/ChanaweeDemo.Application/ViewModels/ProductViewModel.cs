using ChanaweeDemo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Application.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
