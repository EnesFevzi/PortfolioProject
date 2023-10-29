using AutoMapper;
using Microsoft.AspNetCore.Http;
using PortfolioProject.DataAccess.UnıtOfWorks.Abstract;
using PortfolioProject.Dto.DTO_s.Portfolios;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Entity.Enums;
using PortfolioProject.Service.Extensions;
using PortfolioProject.Service.Helpers.Images.Abstract;
using PortfolioProject.Service.Service.Abstract;
using System.Security.Claims;



namespace PortfolioProject.Service.Service.Concrete
{
    public class PortfolioService : IPortfolioService
    {
        private readonly IUnıtOfWork _unıtOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ClaimsPrincipal _user;
        private readonly IMapper _mapper;
        private readonly IImageHelper _imageHelper;

        public PortfolioService(IUnıtOfWork unıtOfWork, IHttpContextAccessor httpContextAccessor, IMapper mapper, IImageHelper imageHelper)
        {
            _unıtOfWork = unıtOfWork;
            _httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
            _mapper = mapper;
            _imageHelper = imageHelper;
        }

        public async Task CreatePortfolioAsync(PortfolioAddDto portfolioAddDto)
        {
            var userID = _user.GetLoggedInUserId();
            var userEmail = _user.GetLoggedInEmail();

            var imageUpload = await _imageHelper.Upload(portfolioAddDto.Name, portfolioAddDto.Photo, ImageType.Project);
            Image image = new(imageUpload.FullName, portfolioAddDto.Photo.ContentType, userEmail);
            await _unıtOfWork.GetRepository<Image>().AddAsync(image);

            var portfolio = new Portfolio(portfolioAddDto.Name, portfolioAddDto.ProjectURL, portfolioAddDto.Content, image.ImageID, userID, userEmail);
            await _unıtOfWork.GetRepository<Portfolio>().AddAsync(portfolio);
            await _unıtOfWork.SaveAsync();



        }
        public async Task<List<PortfolioDto>> GetAllPortfoliosAsync()
        {
            var portfolios = await _unıtOfWork.GetRepository<Portfolio>().GetAllAsync();
            var map = _mapper.Map<List<PortfolioDto>>(portfolios);
            return map;
        }

        public async Task<List<PortfolioDto>> GetAllPortfoliosDeletedAsync()
        {
            var portfolios = await _unıtOfWork.GetRepository<Portfolio>().GetAllAsync(x => x.IsDeleted);
            var map = _mapper.Map<List<PortfolioDto>>(portfolios);

            return map;
        }
        public async Task<List<PortfolioDto>> GetAllPortfoliosWithImageDeletedAsync()
        {
            var portfolios = await _unıtOfWork.GetRepository<Portfolio>().GetAllAsync(x => x.IsDeleted, x => x.Image);
            var map = _mapper.Map<List<PortfolioDto>>(portfolios);

            return map;
        }

        public async Task<List<PortfolioDto>> GetAllPortfoliosNonDeletedAsync()
        {
            var portfolios = await _unıtOfWork.GetRepository<Portfolio>().GetAllAsync(x => !x.IsDeleted);
            var map = _mapper.Map<List<PortfolioDto>>(portfolios);

            return map;
        }

        public async Task<List<PortfolioDto>> GetAllPortfoliosWithImageNonDeletedAsync()
        {
            var portfolios = await _unıtOfWork.GetRepository<Portfolio>().GetAllAsync(x => !x.IsDeleted, x => x.Image);
            var map = _mapper.Map<List<PortfolioDto>>(portfolios);

            return map;
        }


        public async Task<PortfolioDto> GetPortfolioWithUserNonDeletedAsync(Guid PortfolioID)
        {
            var portfolio = await _unıtOfWork.GetRepository<Portfolio>().GetAsync(x => !x.IsDeleted && x.PortfolioID == PortfolioID);
            var map = _mapper.Map<PortfolioDto>(portfolio);
            return map;
        }

        public async Task<string> SafeDeletePortfolioAsync(Guid PortfolioID)
        {
            var userEmail = _user.GetLoggedInEmail();
            var portfolio = await _unıtOfWork.GetRepository<Portfolio>().GetByGuidAsync(PortfolioID);
            portfolio.IsDeleted = true;
            portfolio.DeletedDate = DateTime.Now;
            portfolio.DeletedBy = userEmail;
            await _unıtOfWork.GetRepository<Portfolio>().UpdateAsync(portfolio);
            await _unıtOfWork.SaveAsync();
            return portfolio.Name;
        }

        public async Task<string> UndoDeletePortfolioAsync(Guid PortfolioID)
        {
            var portfolio = await _unıtOfWork.GetRepository<Portfolio>().GetByGuidAsync(PortfolioID);
            portfolio.IsDeleted = false;
            portfolio.DeletedDate = null;
            portfolio.DeletedBy = null;
            await _unıtOfWork.GetRepository<Portfolio>().UpdateAsync(portfolio);
            await _unıtOfWork.SaveAsync();
            return portfolio.Name;
        }

        public async Task<string> UpdatePortfolioAsync(PortfolioUpdateDto portfolioUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();
            var porfolio = await _unıtOfWork.GetRepository<Portfolio>().GetAsync(x => !x.IsDeleted && x.PortfolioID == portfolioUpdateDto.PortfolioID, x => x.Image);

            if (portfolioUpdateDto.Photo != null)
            {
                _imageHelper.Delete(porfolio.Image.FileName);

                var imageUpload = await _imageHelper.Upload(portfolioUpdateDto.Name, portfolioUpdateDto.Photo, ImageType.Project);
                Image image = new(imageUpload.FullName, portfolioUpdateDto.Photo.ContentType, userEmail);
                await _unıtOfWork.GetRepository<Image>().AddAsync(image);
                portfolioUpdateDto.ImageID = image.ImageID;

            }
            else
            {
                portfolioUpdateDto.ImageID = porfolio.ImageID;
            }

            _mapper.Map(portfolioUpdateDto, porfolio);
            //porfolio.ImageID = portfolioUpdateDto.ImageID;
            //porfolio.Name = portfolioUpdateDto.Name;
            //porfolio.ProjectURL = portfolioUpdateDto.ProjectURL;
            porfolio.ModifiedDate = DateTime.Now;
            porfolio.ModifiedBy = userEmail;

            await _unıtOfWork.GetRepository<Portfolio>().UpdateAsync(porfolio);
            await _unıtOfWork.SaveAsync();

            return porfolio.Name;
        }
    }
}
