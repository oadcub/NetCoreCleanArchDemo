using AutoMapper;
using ChanaweeDemo.Application.ViewModels;
using ChanaweeDemo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
