using ChanaweeDemo.Application.Interfaces;
using ChanaweeDemo.Application.Services;
using ChanaweeDemo.Domain.Interfaces;
using ChanaweeDemo.Infra.Data.Repository;
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
            //Application Layer
            services.AddScoped<IProductService, ProductService>();

            //Infra.Data Layer
            services.AddScoped<IProductRepository, ProductRepository>();


        }
    }
}
