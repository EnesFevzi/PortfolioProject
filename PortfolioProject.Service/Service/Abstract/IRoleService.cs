using PortfolioProject.Dto.DTO_s.Roles;

namespace PortfolioProject.Service.Service.Abstract
{
	public interface IRoleService
	{
		Task<List<RoleDto>> GetAllRolesAsync();
	}
}
