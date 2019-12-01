using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly IMapper _autoMapper;
        public ProductService(IProductRepository productRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            _productRepository = productRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(ProductViewModel productViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateProductCommand>(productViewModel));
        }

        public IEnumerable<ProductViewModel> GetProducts()
        {
            return _productRepository.GetProducts().ProjectTo<ProductViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
