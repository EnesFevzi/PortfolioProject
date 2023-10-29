using Microsoft.AspNetCore.Http;
using PortfolioProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Dto.DTO_s.Portfolios
{
    public class PortfolioDto
    {
        public Guid PortfolioID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string ProjectURL { get; set; }
        public Image Image { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
