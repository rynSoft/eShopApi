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

            #region Line

            CreateMap<Line, LineDtoC>()
                .ReverseMap();
            CreateMap<LineDtoC, Line>()
                .ReverseMap();
            CreateMap<Line, LineDtoQ>()
                .ReverseMap();
            CreateMap<LineDtoQ, Line>()
                .ReverseMap();

            #endregion

            #region Camera

            CreateMap<Camera, CameraDtoC>()
                .ReverseMap();
            CreateMap<CameraDtoC, Camera>()
                .ReverseMap();
            CreateMap<Camera, CameraDtoQ>()
                .ReverseMap();
            CreateMap<CameraDtoQ, Camera>()
                .ReverseMap();

            #endregion

          
        }
    }
}
