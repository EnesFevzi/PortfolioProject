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
	public class RoleMap : IEntityTypeConfiguration<AppRole>
	{
		public void Configure(EntityTypeBuilder<AppRole> builder)
		{
			builder.HasKey(r => r.Id);

			// Index for "normalized" role name to allow efficient lookups
			builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

			// Maps to the AspNetRoles table
			builder.ToTable("AspNetRoles");

			// A concurrency token for use with the optimistic concurrency checking
			builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

			// Limit the size of columns to use efficient database types
			builder.Property(u => u.Name).HasMaxLength(256);
			builder.Property(u => u.NormalizedName).HasMaxLength(256);

			// The relationships between Role and other entity types
			// Note that these relationships are configured with no navigation properties

			// Each Role can have many entries in the UserRole join table
			builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

			// Each Role can have many associated RoleClaims
			builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

			builder.HasData(new AppRole
			{
				Id = Guid.Parse("343F8370-28D4-4ADE-91DF-7965041B98F1"),
				Name = "Superadmin",
				NormalizedName = "SUPERADMIN",
				ConcurrencyStamp = Guid.NewGuid().ToString()
			},
			new AppRole
			{
				Id = Guid.Parse("F0A0B477-42AA-47FD-9E01-A81DA466848D"),

				Name = "Admin",
				NormalizedName = "ADMIN",
				ConcurrencyStamp = Guid.NewGuid().ToString()
			});
		}
	}
}
