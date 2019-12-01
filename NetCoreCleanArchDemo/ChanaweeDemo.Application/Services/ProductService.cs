using ChanaweeDemo.Application.Interfaces;
using ChanaweeDemo.Application.ViewModels;
using ChanaweeDemo.Domain.Commands;
using ChanaweeDemo.Domain.Core.Bus;
using ChanaweeDemo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMediatorHandler _bus;
        public ProductService(IProductRepository productRepository, IMediatorHandler bus)
        {
            _productRepository = productRepository;
            _bus = bus;
        }

        public void Create(ProductViewModel productViewModel)
        {
            var createProductCommand = new CreateProductCommand(
                productViewModel.Name,
                productViewModel.Price
                );
            _bus.SendCommand(createProductCommand);
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
