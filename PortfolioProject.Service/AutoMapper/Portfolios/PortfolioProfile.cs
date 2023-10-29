using AutoMapper;
using PortfolioProject.Dto.DTO_s.Portfolios;
using PortfolioProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.AutoMapper.Portfolios
{
    public class PortfolioProfile:Profile
    {
        public PortfolioProfile()
        {
            CreateMap<PortfolioDto, Portfolio>().ReverseMap();
            CreateMap<PortfolioAddDto, Portfolio>().ReverseMap();
            CreateMap<PortfolioUpdateDto, Portfolio>().ReverseMap();
            CreateMap<PortfolioUpdateDto, PortfolioDto>().ReverseMap();
        }
    }
}
