using ChanaweeDemo.Domain.Interfaces;
using ChanaweeDemo.Domain.Models;
using ChanaweeDemo.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IQueryable<Product> GetProducts()
        {
            return _context.Products;
        }
        public void Add(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
        } 
    }
}
