using AutoMapper;
using PortfolioProject.Dto.DTO_s.Roles;
using PortfolioProject.Entity.Entities;

namespace PortfolioProject.Service.AutoMapper.Roles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<AppRole, RoleDto>().ReverseMap();

        }
    }
}
