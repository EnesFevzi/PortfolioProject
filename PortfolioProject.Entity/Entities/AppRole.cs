using Microsoft.AspNetCore.Identity;
using PortfolioProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Entity.Entities
{
    public class AppRole : IdentityRole<Guid>, IEntityBase
    {
    }
}
