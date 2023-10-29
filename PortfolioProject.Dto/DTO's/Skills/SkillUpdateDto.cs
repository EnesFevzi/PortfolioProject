using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Dto.DTO_s.Skills
{
    public class SkillUpdateDto
    {
        public Guid SkillID { get; set; }
        public string Title { get; set; }
        public int Value { get; set; }
    }
}
