using AutoMapper;
using PortfolioProject.Dto.DTO_s.Skills;
using PortfolioProject.Entity.Entities;

namespace PortfolioProject.Service.AutoMapper.Skills
{
    internal class SkillProfile : Profile
    {
        public SkillProfile()
        {
            CreateMap<SkillDto, Skill>().ReverseMap();
            CreateMap<SkillAddDto, Skill>().ReverseMap();
            CreateMap<SkillUpdateDto, Skill>().ReverseMap();
            CreateMap<SkillUpdateDto, SkillDto>().ReverseMap();

        }
    }
}
