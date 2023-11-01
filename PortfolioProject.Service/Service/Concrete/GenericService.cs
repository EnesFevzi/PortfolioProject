using AutoMapper;
using Microsoft.AspNetCore.Http;
using PortfolioProject.DataAccess.UnıtOfWorks.Abstract;
using System.Security.Claims;

namespace PortfolioProject.Service.Service.Concrete
{
    public class GenericService<TEntity, TDto> where TEntity : class where TDto : class
    {
        private readonly IUnıtOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ClaimsPrincipal _user;

        public GenericService(IUnıtOfWork unıtOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unıtOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task CreateAsync(TDto dto)
        {
            //TEntity entity = _mapper.Map<TEntity>(dto);
            //await _unitOfWork.GetRepository<TEntity>().AddAsync(entity);
            //await _unitOfWork.SaveAsync();
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id)
        {
            //var entity = await _unitOfWork.Repository<TEntity>().GetByIdAsync(id);
            //if (entity != null)
            //{
            //    _unitOfWork.Repository<TEntity>().Delete(entity);
            //    await _unitOfWork.SaveChangesAsync();
            //}
            throw new NotImplementedException();
        }

        public Task<List<TDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
