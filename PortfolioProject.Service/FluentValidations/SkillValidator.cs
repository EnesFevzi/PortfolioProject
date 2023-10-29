using FluentValidation;
using PortfolioProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.FluentValidations
{
	public class SkillValidator : AbstractValidator<Skill>
	{
		public SkillValidator()
		{
			RuleFor(x => x.Title)
				.NotEmpty()
				.NotNull()
				.MinimumLength(3)
				.MaximumLength(20)
				.WithName("Başlık");
		}
	}
}
