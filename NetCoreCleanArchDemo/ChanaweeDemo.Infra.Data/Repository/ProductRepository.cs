using ChanaweeDemo.Domain.Interfaces;
using ChanaweeDemo.Domain.Models;
using ChanaweeDemo.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Infra.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ChanaweeDemoDBContext _context;
        public ProductRepository(ChanaweeDemoDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }
    }
}
