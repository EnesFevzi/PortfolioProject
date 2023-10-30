using AutoMapper;
using PortfolioProject.Dto.DTO_s.Educations;
using PortfolioProject.Dto.DTO_s.Experiences;
using PortfolioProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.AutoMapper.Educations
{
    public class EducationProfile : Profile
    {
        public EducationProfile()
        {
            CreateMap<EducationDto, Education>().ReverseMap();
            CreateMap<EducationAddDto, Education>().ReverseMap();
            CreateMap<EducationUpdateDto, EducationDto>().ReverseMap();
            CreateMap<EducationUpdateDto, Education>().ReverseMap();

        }
    }
}
