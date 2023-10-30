using FluentValidation;
using PortfolioProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.FluentValidations
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {

            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(150)
                .WithName("Başlık");

            RuleFor(x => x.Description)
               .NotEmpty()
               .NotNull()
               .MinimumLength(3)
               .MaximumLength(500)
               .WithName("İçerik");

            RuleFor(x => x.Mail)
               .NotEmpty()
               .NotNull()
               .WithName("Mail");

            RuleFor(x => x.Age)
              .NotEmpty()
              .NotNull()
              .GreaterThan(1)
              .LessThan(99)
              .WithName("Yaş");

            RuleFor(x => x.Address)
             .NotEmpty()
             .NotNull()
             .WithName("Adres");

            RuleFor(x => x.GitHub)
             .NotEmpty()
             .NotNull()
             .WithName("GitHub");

            RuleFor(x => x.Linkedin)
             .NotEmpty()
             .NotNull()
             .WithName("Linkedin");

        }
    }
}
