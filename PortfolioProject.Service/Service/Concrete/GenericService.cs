using AutoMapper;
using Microsoft.AspNetCore.Http;
using PortfolioProject.DataAccess.UnıtOfWorks.Abstract;
using PortfolioProject.Service.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.Service.Concrete
{
    public class GenericService<TDto, TEntity> : IGenericService<TDto> where TDto : class where TEntity : class
    {
        private readonly IUnıtOfWork _unıtOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ClaimsPrincipal _user;

        public GenericService(IUnıtOfWork unıtOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _unıtOfWork = unıtOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
        }

        public Task CreateAsync(TDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
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
