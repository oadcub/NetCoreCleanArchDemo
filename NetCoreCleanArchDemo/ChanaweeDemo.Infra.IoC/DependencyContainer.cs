﻿using ChanaweeDemo.Application.Interfaces;
using ChanaweeDemo.Application.Services;
using ChanaweeDemo.Application.Services.Discount;
using ChanaweeDemo.Domain.CommandHandlers;
using ChanaweeDemo.Domain.Commands;
using ChanaweeDemo.Domain.Core.Bus;
using ChanaweeDemo.Domain.Interfaces;
using ChanaweeDemo.Infra.Bus;
using ChanaweeDemo.Infra.Data.Context;
using ChanaweeDemo.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateProductCommand, bool>, ProductCommandHandler>();

            //Application Layer
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IPurchaseService, PurchaseService>();
            services.AddScoped<IDiscountRuleService, DiscountRule1>();
            services.AddScoped<IDiscountRuleService, DiscountRule2>();
            services.AddScoped<IDiscountRuleService, DiscountRule3>();
            services.AddScoped<IDiscountRuleService, DiscountRule4>();

            //Infra.Data Layer
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ChanaweeDemoDBContext>();

        }
    }
}
