using ChanaweeDemo.Domain.Commands;
using ChanaweeDemo.Domain.Interfaces;
using ChanaweeDemo.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChanaweeDemo.Domain.CommandHandlers
{
    public class ProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;
        public ProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product()
            {
                Name = request.Name,
                Price = request.Price
            };
            _productRepository.Add(product);

            return Task.FromResult(true);
        }
    }
}
