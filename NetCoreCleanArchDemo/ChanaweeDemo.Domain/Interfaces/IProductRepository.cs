using ChanaweeDemo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChanaweeDemo.Domain.Interfaces
{
    public interface IProductRepository
    {
        IQueryable<Product> GetProducts();
        void Add(Product product);
    }
}
