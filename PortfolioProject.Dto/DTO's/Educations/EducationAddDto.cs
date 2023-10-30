using PortfolioProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Dto.DTO_s.Educations
{
    public class EducationAddDto
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public Guid UserID { get; set; }
        public AppUser User { get; set; }
    }
}
