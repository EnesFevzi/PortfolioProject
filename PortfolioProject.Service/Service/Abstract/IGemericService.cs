using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.Service.Abstract
{
    public interface IGenericService<TDto> where TDto : class
    {
        Task<TDto> GetByIdAsync(Guid id);
        Task<List<TDto>> GetAllAsync();
        Task CreateAsync(TDto dto);
        Task UpdateAsync(TDto dto);
        Task DeleteAsync(Guid id);
    }
}
