using PortfolioProject.Dto.DTO_s.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.Service.Abstract
{
    public interface ISkillService
    {
        Task<List<SkillDto>> GetAllSkillsAsync();
        Task<List<SkillDto>> GetAllSkillsNonDeletedAsync();
        Task<List<SkillDto>> GetAllSkillsWithUserNonDeletedAsync();
        Task<List<SkillDto>> GetAllSkillsDeletedAsync();
        Task<SkillDto> GetSkillWithUserNonDeletedAsync(Guid skillID);
        Task CreateSkillAsync(SkillAddDto skillAddDto);
        Task<string> UpdateSkillAsync(SkillUpdateDto skillUpdateDto);
        Task<string> SafeDeleteSkillAsync(Guid SkillID);
        Task<string> UndoDeleteSkillAsync(Guid SkillID);
    }
}
