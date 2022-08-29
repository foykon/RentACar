using Application.Features.Colors.Commands.CreateColor;
using Application.Features.Colors.Dtos;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Colors.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Color, CreatedColorDto>().ReverseMap();
            CreateMap<Color, CreateColorCommand>().ReverseMap();
        }
    }
}
