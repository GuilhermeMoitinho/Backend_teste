using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using houseasy_API.Application.DTOs;
using houseasy_API.Domain.Models;

namespace houseasy_API.Application.Mappings
{
    public class EntitesToDTOMappingProfile : Profile
    {
        public EntitesToDTOMappingProfile()
        {
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<ServiceResponse<Usuario>, UsuarioDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Dados.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Dados.Nome))
                .ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => src.Dados.Endereco));
        }
    }

}