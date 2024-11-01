using System;
using System.Linq;
using AutoMapper;
using eShop.Domain;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using eShop.Domain.Enum;
using eShop.Infrastructure.ViewModel;

namespace eShop.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {



            #region Product

            CreateMap<Product, ProductDtoC>()
                .ReverseMap();
            CreateMap<ProductDtoC, Product>()
                .ReverseMap();
            CreateMap<Product, ProductDtoQ>()
                .ReverseMap();
            CreateMap<ProductDtoQ, Product>()
                .ReverseMap();

            #endregion

          
        }
    }
}
