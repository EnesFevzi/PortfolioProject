using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PortfolioProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.DataAccess.Mappings
{
	public class UserClaimMap : IEntityTypeConfiguration<AppUserClaim>
	{
		public void Configure(EntityTypeBuilder<AppUserClaim> builder)
		{
			builder.HasKey(uc => uc.Id);

			// Maps to the AspNetUserClaims table
			builder.ToTable("AspNetUserClaims");
		}
	}
}
