using AutoMapper;
using Microsoft.AspNetCore.Http;
using PortfolioProject.DataAccess.UnıtOfWorks.Abstract;
using PortfolioProject.Dto.DTO_s.Experiences;
using PortfolioProject.Dto.DTO_s.Skills;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Service.Extensions;
using PortfolioProject.Service.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.Service.Concrete
{
    public class SkillService : ISkillService
    {
        private readonly IUnıtOfWork _unıtOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ClaimsPrincipal _user;

        public SkillService(IUnıtOfWork unıtOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _unıtOfWork = unıtOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task CreateSkillAsync(SkillAddDto skillAddDto)
        {
            var userID = _user.GetLoggedInUserId();
            var userEmail = _user.GetLoggedInEmail();

            var skill = new Skill(skillAddDto.Title, skillAddDto.Value, userID, userEmail);

            await _unıtOfWork.GetRepository<Skill>().AddAsync(skill);
            await _unıtOfWork.SaveAsync();
        }

        public async Task<List<SkillDto>> GetAllSkillsAsync()
        {
            var skills = await _unıtOfWork.GetRepository<Skill>().GetAllAsync();
            var map = _mapper.Map<List<SkillDto>>(skills);
            return map;
        }

        public async Task<List<SkillDto>> GetAllSkillsDeletedAsync()
        {
            var skills = await _unıtOfWork.GetRepository<Skill>().GetAllAsync(x => x.IsDeleted);
            var map = _mapper.Map<List<SkillDto>>(skills);
            return map;
        }

        public async Task<List<SkillDto>> GetAllSkillsNonDeletedAsync()
        {
            var skills = await _unıtOfWork.GetRepository<Skill>().GetAllAsync(x => !x.IsDeleted);
            var map = _mapper.Map<List<SkillDto>>(skills);
            return map;
        }

        public async  Task<List<SkillDto>> GetAllSkillsWithUserNonDeletedAsync()
        {
            var userID = _user.GetLoggedInUserId();
            var skills = await _unıtOfWork.GetRepository<Skill>().GetAllAsync(x => !x.IsDeleted && x.UserID == userID);
            var map = _mapper.Map<List<SkillDto>>(skills);
            return map;
        }

        public async Task<SkillDto> GetSkillWithUserNonDeletedAsync(Guid skillID)
        {
            var skill = await _unıtOfWork.GetRepository<Skill>().GetAsync(x => !x.IsDeleted && x.SkillID == skillID);
            var map = _mapper.Map<SkillDto>(skill);
            return map;
        }

        public async  Task<string> SafeDeleteSkillAsync(Guid SkillID)
        {

            var userEmail = _user.GetLoggedInEmail();
            var skill = await _unıtOfWork.GetRepository<Skill>().GetByGuidAsync(SkillID);
            skill.IsDeleted = true;
            skill.DeletedDate = DateTime.Now;
            skill.DeletedBy = userEmail;
            await _unıtOfWork.GetRepository<Skill>().UpdateAsync(skill);
            await _unıtOfWork.SaveAsync();

            return skill.Title;
        }

        public  async Task<string> UndoDeleteSkillAsync(Guid SkillID)
        {
            var skill = await _unıtOfWork.GetRepository<Skill>().GetByGuidAsync(SkillID);
            skill.IsDeleted = false;
            skill.DeletedDate = null;
            skill.DeletedBy = null;
            await _unıtOfWork.GetRepository<Skill>().UpdateAsync(skill);
            await _unıtOfWork.SaveAsync();

            return skill.Title;
        }

        public async  Task<string> UpdateSkillAsync(SkillUpdateDto skillUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();
            var skill = await _unıtOfWork.GetRepository<Skill>().GetAsync(x => !x.IsDeleted && x.SkillID == skillUpdateDto.SkillID);

            var map = _mapper.Map(skillUpdateDto, skill);

            skill.ModifiedDate = DateTime.Now;
            skill.ModifiedBy = userEmail;
            await _unıtOfWork.GetRepository<Skill>().UpdateAsync(skill);
            await _unıtOfWork.SaveAsync();

            return skill.Title;
        }
    }
}
