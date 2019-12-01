using ChanaweeDemo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
