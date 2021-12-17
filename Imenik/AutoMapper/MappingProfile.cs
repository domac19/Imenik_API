using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Imenik_API.Model;
using Imenik_API.Dto;

namespace Imenik_API.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Imenik, ImenikDto>();
            Mapper.CreateMap<ImenikDto, Imenik>();

            Mapper.CreateMap<ImenikSifarnikDrzava, SifarnikDrzavaDto>();
            Mapper.CreateMap<SifarnikDrzavaDto, ImenikSifarnikDrzava>();

            Mapper.CreateMap<ImenikSifarnikZupanija, SifarnikZupanijaDto>();
            Mapper.CreateMap<SifarnikZupanijaDto, ImenikSifarnikZupanija>();

        }
    }
}
