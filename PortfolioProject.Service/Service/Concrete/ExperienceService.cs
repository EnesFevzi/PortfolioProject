using AutoMapper;
using Microsoft.AspNetCore.Http;
using PortfolioProject.DataAccess.UnıtOfWorks.Abstract;
using PortfolioProject.Dto.DTO_s.Experiences;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Service.Extensions;
using PortfolioProject.Service.Helpers.Images.Abstract;
using PortfolioProject.Service.Service.Abstract;
using System.Security.Claims;

namespace PortfolioProject.Service.Service.Concrete
{
    public class ExperienceService : IExperienceService
    {
        private readonly IUnıtOfWork _unıtOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ClaimsPrincipal _user;
        private readonly IMapper _mapper;
        private readonly IImageHelper _imageHelper;

        public ExperienceService(IUnıtOfWork unıtOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            _unıtOfWork = unıtOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
            _imageHelper = imageHelper;
        }

        public async Task CreateExperienceAsync(ExperienceAddDto experienceAddDto)
        {
            var userID = _user.GetLoggedInUserId();
            var userEmail = _user.GetLoggedInEmail();

            var experience = new Experience(experienceAddDto.Name, experienceAddDto.Content, userID, userEmail, experienceAddDto.StartTime, experienceAddDto.EndTime);

            await _unıtOfWork.GetRepository<Experience>().AddAsync(experience);
            await _unıtOfWork.SaveAsync();
        }

        public async Task<List<ExperienceDto>> GetAllExperiencesAsync()
        {
            var experiences = await _unıtOfWork.GetRepository<Experience>().GetAllAsync();
            var map = _mapper.Map<List<ExperienceDto>>(experiences);
            return map;
        }

        public async Task<List<ExperienceDto>> GetAllExperiencesDeletedAsync()
        {
            var experiences = await _unıtOfWork.GetRepository<Experience>().GetAllAsync(x => x.IsDeleted);
            var map = _mapper.Map<List<ExperienceDto>>(experiences);
            return map;
        }

        public async Task<List<ExperienceDto>> GetAllExperiencesNonDeletedAsync()
        {
            var experiences = await _unıtOfWork.GetRepository<Experience>().GetAllAsync(x => !x.IsDeleted);
            experiences = experiences.OrderBy(x => x.StartTime).ToList();
            var map = _mapper.Map<List<ExperienceDto>>(experiences);
            return map;
        }

        public async Task<List<ExperienceDto>> GetAllExperiencesWithUserNonDeletedAsync()
        {
            var userID = _user.GetLoggedInUserId();
           // var userID = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C");
            var experiences = await _unıtOfWork.GetRepository<Experience>().GetAllAsync(x => !x.IsDeleted && x.UserID == userID);
            var map = _mapper.Map<List<ExperienceDto>>(experiences);
            return map;
        }

        public async Task<ExperienceDto> GetExperienceWithUserNonDeletedAsync(Guid experienceID)
        {
            var experience = await _unıtOfWork.GetRepository<Experience>().GetAsync(x => !x.IsDeleted && x.ExperienceID == experienceID);
            var map = _mapper.Map<ExperienceDto>(experience);
            return map;
        }

        public async Task<string> SafeDeleteExperienceAsync(Guid experienceID)
        {
            var userEmail = _user.GetLoggedInEmail();
            var experience = await _unıtOfWork.GetRepository<Experience>().GetByGuidAsync(experienceID);
            experience.IsDeleted = true;
            experience.DeletedDate = DateTime.Now;
            experience.DeletedBy = userEmail;
            await _unıtOfWork.GetRepository<Experience>().UpdateAsync(experience);
            await _unıtOfWork.SaveAsync();

            return experience.Name;
        }

        public async Task<string> UndoDeleteExperienceAsync(Guid experienceID)
        {
            var experience = await _unıtOfWork.GetRepository<Experience>().GetByGuidAsync(experienceID);
            experience.IsDeleted = false;
            experience.DeletedDate = null;
            experience.DeletedBy = null;
            await _unıtOfWork.GetRepository<Experience>().UpdateAsync(experience);
            await _unıtOfWork.SaveAsync();

            return experience.Name;
        }

        public async Task<string> UpdateExperienceAsync(ExperienceUpdateDto experienceUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();
            var experience = await _unıtOfWork.GetRepository<Experience>().GetAsync(x => !x.IsDeleted && x.ExperienceID == experienceUpdateDto.ExperienceID);

            var map = _mapper.Map(experienceUpdateDto, experience);

            experience.ModifiedDate = DateTime.Now;
            experience.ModifiedBy = userEmail;
            await _unıtOfWork.GetRepository<Experience>().UpdateAsync(experience);
            await _unıtOfWork.SaveAsync();

            return experience.Name;
        }
    }
}
