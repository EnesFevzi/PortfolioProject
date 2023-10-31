using Microsoft.AspNetCore.Identity;
using PortfolioProject.Dto.DTO_s.Users;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.Service.Abstract
{
	public interface IUserService
	{
        Task<List<UserDto>> GetAllUsersWithRoleAsync();
        Task<List<AppRole>> GetAllRolesAsync();
        Task<IdentityResult> CreateUserAsync(UserAddDto userAddDto);
        Task<IdentityResult> UpdateUserAsync(UserUpdateDto userUpdateDto);
        Task<(IdentityResult identityResult, string? email)> DeleteUserAsync(Guid userId);
        Task<AppUser> GetAppUserByIdAsync(Guid userId);
        Task<string> GetUserRoleAsync(AppUser user);
        Task<UserProfileDto> GetUserProfileAsync();
        Task<UserDto> GetUserProfileAsyncWitRoleAsync();
        Task<bool> UserProfileUpdateAsync(UserProfileDto userProfileDto);
        Task<WeatherInfo> GetWeatherInfo();
    }
}
