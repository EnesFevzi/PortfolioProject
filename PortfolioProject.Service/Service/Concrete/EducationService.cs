using AutoMapper;
using EducationProject.Service.Service.Abstract;
using Microsoft.AspNetCore.Http;
using PortfolioProject.DataAccess.UnıtOfWorks.Abstract;
using PortfolioProject.Dto.DTO_s.Educations;
using PortfolioProject.Dto.DTO_s.Experiences;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Service.Extensions;
using PortfolioProject.Service.Helpers.Images.Abstract;
using PortfolioProject.Service.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.Service.Concrete
{
    public class EducationService : IEducationService
    {
        private readonly IUnıtOfWork _unıtOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ClaimsPrincipal _user;
        private readonly IMapper _mapper;
        private readonly IImageHelper _imageHelper;

        public EducationService(IUnıtOfWork unıtOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            _unıtOfWork = unıtOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
            _imageHelper = imageHelper;
        }
        public async Task CreateEducationAsync(EducationAddDto EducationAddDto)
        {
            var userID = _user.GetLoggedInUserId();
            var userEmail = _user.GetLoggedInEmail();
            var experience = new Education(EducationAddDto.Name, EducationAddDto.Content, userID, userEmail, EducationAddDto.StartTime, EducationAddDto.EndTime);
            await _unıtOfWork.GetRepository<Education>().AddAsync(experience);
            await _unıtOfWork.SaveAsync();
        }



        public async Task<List<EducationDto>> GetAllEducationsAsync()
        {
            var educations = await _unıtOfWork.GetRepository<Education>().GetAllAsync();
            var map = _mapper.Map<List<EducationDto>>(educations);
            return map;
        }

        public async Task<List<EducationDto>> GetAllEducationsDeletedAsync()
        {
            var educations = await _unıtOfWork.GetRepository<Education>().GetAllAsync(x => x.IsDeleted);
            var map = _mapper.Map<List<EducationDto>>(educations);
            return map;
        }

        public async Task<List<EducationDto>> GetAllEducationsNonDeletedAsync()
        {
            var educations = await _unıtOfWork.GetRepository<Education>().GetAllAsync(x => !x.IsDeleted);
            var list = educations.OrderBy(x => x.StartTime).ToList();
            var map = _mapper.Map<List<EducationDto>>(educations);
            return map;
        }


        public async Task<EducationDto> GetEducationWithUserNonDeletedAsync(Guid educationID)
        {
            var education = await _unıtOfWork.GetRepository<Education>().GetAsync(x => !x.IsDeleted && x.EducationID == educationID);
            var map = _mapper.Map<EducationDto>(education);
            return map;
        }

        public async Task<string> SafeDeleteEducationAsync(Guid educationID)
        {
            var userEmail = _user.GetLoggedInEmail();
            var education = await _unıtOfWork.GetRepository<Education>().GetByGuidAsync(educationID);
            education.IsDeleted = true;
            education.DeletedDate = DateTime.Now;
            education.DeletedBy = userEmail;
            await _unıtOfWork.GetRepository<Education>().UpdateAsync(education);
            await _unıtOfWork.SaveAsync();

            return education.Name;
        }

        public async Task<string> UndoDeleteEducationAsync(Guid educationID)
        {
            var education = await _unıtOfWork.GetRepository<Education>().GetByGuidAsync(educationID);
            education.IsDeleted = false;
            education.DeletedDate = null;
            education.DeletedBy = null;
            await _unıtOfWork.GetRepository<Education>().UpdateAsync(education);
            await _unıtOfWork.SaveAsync();

            return education.Name;
        }

        public async Task<string> UpdateEducationAsync(EducationUpdateDto educationUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();
            var experience = await _unıtOfWork.GetRepository<Education>().GetAsync(x => !x.IsDeleted && x.EducationID == educationUpdateDto.EducationID);

            var map = _mapper.Map(educationUpdateDto, experience);

            experience.ModifiedDate = DateTime.Now;
            experience.ModifiedBy = userEmail;
            await _unıtOfWork.GetRepository<Education>().UpdateAsync(experience);
            await _unıtOfWork.SaveAsync();

            return experience.Name;
        }
    }
}
