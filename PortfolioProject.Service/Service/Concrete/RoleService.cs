using AutoMapper;
using PortfolioProject.DataAccess.UnıtOfWorks.Abstract;
using PortfolioProject.Dto.DTO_s.Roles;
using PortfolioProject.Entity.Entities;

namespace PortfolioProject.Service.Service.Concrete
{
    public class RoleService : IRoleService
    {
        private readonly IUnıtOfWork _unıtOfWork;
        private readonly IMapper _mapper;

        public RoleService(IUnıtOfWork unıtOfWork, IMapper mapper)
        {
            _unıtOfWork = unıtOfWork;
            _mapper = mapper;
        }

        public async Task<List<RoleDto>> GetAllRolesAsync()
        {
            var result = await _unıtOfWork.GetRepository<AppRole>().GetAllAsync();
            var map = _mapper.Map<List<RoleDto>>(result);

            return map;
        }
    }
}
