using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Domain.Entities;

namespace WebMarket.Api
{
    public class WebMarketMapping : Profile
    {
        public WebMarketMapping()
        {
            CreateMap<Comment, Product>();
            CreateMap<Product, Comment>();
        }
    }
}
