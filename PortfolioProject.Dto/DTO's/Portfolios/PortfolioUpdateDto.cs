using Microsoft.AspNetCore.Http;
using PortfolioProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Dto.DTO_s.Portfolios
{
    public class PortfolioUpdateDto
    {
        public Guid PortfolioID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string ProjectURL { get; set; }
        public Guid? ImageID { get; set; }
        public Image Image { get; set; }
        public IFormFile? Photo { get; set; }
    }
}
