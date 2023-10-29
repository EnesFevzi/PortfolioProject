using PortfolioProject.Core.Entities.Abstract;
using PortfolioProject.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Entity.Entities
{
    public class Portfolio : EntityBase, IEntityBase
    {
        public Portfolio()
        {
                
        }
        public Portfolio(string name, string projectUrl,string content, Guid imageid, Guid userid, string createdBy)
        {
            Name = name;
            ProjectURL = projectUrl;
            Content = content;
            ImageID = imageid;
            UserID = userid;
            CreatedBy = createdBy;
        }
        public Guid PortfolioID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string ProjectURL { get; set; }
        public Guid? ImageID { get; set; }
        public Image Image { get; set; }

        public Guid UserID { get; set; }
        public AppUser User { get; set; }

    }
}
