using AutoMapper;
using Microsoft.AspNetCore.Http;
using PortfolioProject.DataAccess.UnıtOfWorks.Abstract;
using PortfolioProject.Dto.DTO_s.Abouts;
using PortfolioProject.Dto.DTO_s.Portfolios;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Entity.Enums;
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
    public class AboutService : IAboutService
    {
        private readonly IUnıtOfWork _unıtOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ClaimsPrincipal _user;
        private readonly IMapper _mapper;
        private readonly IImageHelper _imageHelper;

        public AboutService(IUnıtOfWork unıtOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            _unıtOfWork = unıtOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
            _imageHelper = imageHelper;
        }
        public async Task CreateAboutAsync(AboutAddDto aboutAddDto)
        {
            var userID = _user.GetLoggedInUserId();
            var userEmail = _user.GetLoggedInEmail();

            var imageUpload = await _imageHelper.Upload(aboutAddDto.Title, aboutAddDto.Photo, ImageType.User);
            Image image = new(imageUpload.FullName, aboutAddDto.Photo.ContentType, userEmail);
            await _unıtOfWork.GetRepository<Image>().AddAsync(image);
            var portfolio = new About(aboutAddDto.Title, aboutAddDto.Description, aboutAddDto.Age, aboutAddDto.Mail, aboutAddDto.Address, aboutAddDto.Linkedin, aboutAddDto.GitHub ,image.ImageID, userID, userEmail);
            await _unıtOfWork.GetRepository<About>().AddAsync(portfolio);
            await _unıtOfWork.SaveAsync();
        }

        public async Task CreateAboutWithoutImageAsync(AboutAddDto aboutAddDto)
        {
            var userID = _user.GetLoggedInUserId();
            var userEmail = _user.GetLoggedInEmail();

            var image = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA");

            var about = new About(aboutAddDto.Title, aboutAddDto.Description, aboutAddDto.Age, aboutAddDto.Mail, aboutAddDto.Address, aboutAddDto.Linkedin, aboutAddDto.GitHub, image, userID, userEmail);
            await _unıtOfWork.GetRepository<About>().AddAsync(about);
            await _unıtOfWork.SaveAsync();
        }

        public async Task<AboutDto> GetAboutNonDeletedAsync(Guid AboutID)
        {
            var about = await _unıtOfWork.GetRepository<About>().GetAsync(x => !x.IsDeleted && x.AboutID == AboutID, x => x.Image);
            var map = _mapper.Map<AboutDto>(about);
            return map;
        }

        public async Task<List<AboutDto>> GetAllAboutsNonDeletedAsync()
        {
            var abouts = await _unıtOfWork.GetRepository<About>().GetAllAsync(x => !x.IsDeleted, x => x.Image);
            var map = _mapper.Map<List<AboutDto>>(abouts);
            return map;
        }

        public async Task<List<AboutDto>> GetAllAboutsDeletedAsync()
        {
            var abouts = await _unıtOfWork.GetRepository<About>().GetAllAsync(x => x.IsDeleted, x => x.Image);
            var map = _mapper.Map<List<AboutDto>>(abouts);
            return map;
        }

        public async Task<string> SafeDeleteAboutAsync(Guid AboutID)
        {
            var userEmail = _user.GetLoggedInEmail();
            var about = await _unıtOfWork.GetRepository<About>().GetByGuidAsync(AboutID);
            about.IsDeleted = true;
            about.DeletedDate = DateTime.Now;
            about.DeletedBy = userEmail;
            await _unıtOfWork.GetRepository<About>().UpdateAsync(about);
            await _unıtOfWork.SaveAsync();
            return about.Title;
        }

        public async Task<string> UndoDeleteAboutAsync(Guid AboutID)
        {
            var about = await _unıtOfWork.GetRepository<About>().GetByGuidAsync(AboutID);
            about.IsDeleted = false;
            about.DeletedDate = null;
            about.DeletedBy = null;
            await _unıtOfWork.GetRepository<About>().UpdateAsync(about);
            await _unıtOfWork.SaveAsync();
            return about.Title;
        }

        public async Task<string> UpdateAboutAsync(AboutUpdateDto aboutUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();
            var about = await _unıtOfWork.GetRepository<About>().GetAsync(x => !x.IsDeleted && x.AboutID == aboutUpdateDto.AboutID, x => x.Image);

            if (aboutUpdateDto.Photo != null)
            {
                _imageHelper.Delete(about.Image.FileName);

                var imageUpload = await _imageHelper.Upload(aboutUpdateDto.Title, aboutUpdateDto.Photo, ImageType.User);
                Image image = new(imageUpload.FullName, aboutUpdateDto.Photo.ContentType, userEmail);
                await _unıtOfWork.GetRepository<Image>().AddAsync(image);
                aboutUpdateDto.ImageID = image.ImageID;

            }
            else
            {
                if (about.Image != null)
                {
                    aboutUpdateDto.ImageID = about.ImageID;
                    aboutUpdateDto.Image = about.Image;
                }

            }

            _mapper.Map(aboutUpdateDto, about);
            //about.Title = aboutUpdateDto.Title;
            //about.Description = aboutUpdateDto.Description;
            //about.Age = aboutUpdateDto.Age;
            //about.Mail = aboutUpdateDto.Mail;
            //about.Linkedin = aboutUpdateDto.Linkedin;
            //about.GitHub = aboutUpdateDto.GitHub;

            about.ModifiedDate = DateTime.Now;
            about.ModifiedBy = userEmail;

           await _unıtOfWork.GetRepository<About>().UpdateAsync(about);
           
            await _unıtOfWork.SaveAsync();

            return about.Title;
        }
    }
}
