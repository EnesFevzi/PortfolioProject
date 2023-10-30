using FluentValidation;
using PortfolioProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.FluentValidations
{
    public class EducationValidator : AbstractValidator<Education>
    {
        public EducationValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(150)
                .WithName("Başlık");

            RuleFor(x => x.Content)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(3000)
                .WithName("İçerik");
            RuleFor(x => x.StartTime)
               .NotEmpty()
               .NotNull()
               .WithName("Başlangıç Tarihi");

            RuleFor(x => x.EndTime)
               .NotEmpty()
               .NotNull()
               .WithName("Bitiş Tarihi");

        }
    }
}
