using PortfolioProject.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Entity.Entities
{
	public class About : EntityBase
	{
		public Guid AboutID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int Age { get; set; }
		public string Mail { get; set; }
		public string Address { get; set; }
		public string Website { get; set; }

		public Guid ImageID { get; set; } = Guid.Parse("F71F4B9A-AA60-461D-B398-DE31001BF214");
		public Image Image { get; set; }

		public Guid UserID { get; set; }
		public AppUser User { get; set; }

	}
}
