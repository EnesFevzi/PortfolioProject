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

        public About()
        {
            
        }
        public About(string title,string description,int age,string mail,string adress,string linkedin, string github,Guid imageid,Guid userid,string createdBy)
        {
			Title = title;
			Description = description;
			Age = age;
			Mail = mail;
			Address = adress;
			Linkedin = linkedin;
			GitHub = github;
			ImageID = imageid;
			UserID = userid;
			CreatedBy = createdBy;
            
        }
        public Guid AboutID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int Age { get; set; }
		public string Mail { get; set; }
		public string Address { get; set; }
		public string Linkedin { get; set; }
		public string GitHub { get; set; }

		public Guid? ImageID { get; set; }
		public Image Image { get; set; }

		public Guid UserID { get; set; }
		public AppUser User { get; set; }

	}
}
