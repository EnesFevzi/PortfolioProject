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
	public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
	{
		public void Configure(EntityTypeBuilder<AppUserRole> builder)
		{
			builder.HasKey(r => new { r.UserId, r.RoleId });

			// Maps to the AspNetUserRoles table
			builder.ToTable("AspNetUserRoles");

			builder.HasData(new AppUserRole
			{
				UserId = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C"),
				RoleId = Guid.Parse("343F8370-28D4-4ADE-91DF-7965041B98F1")
			},
			new AppUserRole
			{
				UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427"),
				RoleId = Guid.Parse("F0A0B477-42AA-47FD-9E01-A81DA466848D")
			});
		}
	}
}
