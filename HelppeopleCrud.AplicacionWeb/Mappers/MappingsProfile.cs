using AutoMapper;
using System;
using HelppeopleCrud.Models;
using HelppeopleCrud.AplicacionWeb.DTO_s;

namespace HelppeopleCrud.AplicacionWeb.Mappers
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {

            CreateMap<Ciudadano, CiudadanoDTO>().ReverseMap();

            CreateMap<List<Ciudadano>, List<CiudadanoDTO>>().ReverseMap();

            CreateMap<Vacante, VacanteDTO>().ReverseMap();

        }
    }
}
