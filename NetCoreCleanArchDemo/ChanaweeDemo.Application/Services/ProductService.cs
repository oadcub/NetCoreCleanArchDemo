using ChanaweeDemo.Application.Interfaces;
using ChanaweeDemo.Application.ViewModels;
using ChanaweeDemo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public ProductViewModel GetProducts()
        {
            return new ProductViewModel()
            {
                Products = _productRepository.GetProducts()
            };
        }
    }
}
