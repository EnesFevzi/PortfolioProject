using PortfolioProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Core.Entities.Concrete
{
    public class EntityBase : IEntityBase
    {
        public virtual string CreatedBy { get; set; } = "Enes Fevzi";
        public virtual string? ModifiedBy { get; set; } = "Enes Fevzi";
        public virtual string? DeletedBy { get; set; } = "Enes Fevzi";
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool IsDeleted { get; set; } = false;

    }
}
