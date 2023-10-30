using AutoMapper;
using PortfolioProject.Dto.DTO_s.Abouts;
using PortfolioProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.AutoMapper.Abouts
{
    public class AboutProfile:Profile
    {
        public AboutProfile()
        {
            CreateMap<AboutDto,About>().ReverseMap();

            CreateMap<AboutUpdateDto, About>()
            .ForMember(member1 => member1.Image, member2 => member2.MapFrom(x => x.Image))
            .ReverseMap();

            CreateMap<AboutUpdateDto, AboutDto>().ReverseMap();
            CreateMap<AboutAddDto,About>().ReverseMap();
           
        }
    }
}
