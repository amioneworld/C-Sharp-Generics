using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace HowToUseAutoMapper
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(configure =>
            {
                configure.AddProfile<CustomerProfile>();
                configure.AddProfile<OrderProfile>();
            });
        }
    }
}
