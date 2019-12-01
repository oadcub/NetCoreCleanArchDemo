using AutoMapper;
using ChanaweeDemo.Application.ViewModels;
using ChanaweeDemo.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<ProductViewModel, CreateProductCommand>()
                .ConstructUsing(c => new CreateProductCommand(c.Name, c.Price));
        }
    }
}
