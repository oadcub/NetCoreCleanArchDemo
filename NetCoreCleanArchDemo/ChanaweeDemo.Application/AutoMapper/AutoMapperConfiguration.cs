using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(config =>
            {
                config.AddProfile(new ViewModelToDomainProfile());
                config.AddProfile(new DomainToViewModelProfile());
            });
        }
    }
}
