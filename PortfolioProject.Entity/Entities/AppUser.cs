using Microsoft.AspNetCore.Identity;
using PortfolioProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>, IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ImageID { get; set; } = Guid.Parse("F71F4B9A-AA60-461D-B398-DE31001BF214");
        public Image Image { get; set; }

		public ICollection<Experience> Experiences { get; set; }
		public ICollection<Skill> Skills { get; set; }
		public ICollection<Education> Educations { get; set; }
		public ICollection<Portfolio> Projects { get; set; }
		public ICollection<SocialMedia> SocialMedias { get; set; }
		public ICollection<About> Abouts { get; set; }
	}
}