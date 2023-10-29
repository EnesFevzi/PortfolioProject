using AutoMapper;
using PortfolioProject.Dto.DTO_s.Experiences;
using PortfolioProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.AutoMapper.Experiences
{
    public class ExperienceProfile : Profile
    {
        public ExperienceProfile()
        {
            CreateMap<ExperienceDto, Experience>().ReverseMap();
            CreateMap<ExperienceAddDto, Experience>().ReverseMap();
            CreateMap<ExperienceUpdateDto, Experience>().ReverseMap();
            CreateMap<ExperienceUpdateDto, ExperienceDto>().ReverseMap();
           
        }
    }
}
