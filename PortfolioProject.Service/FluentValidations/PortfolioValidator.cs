using FluentValidation;
using PortfolioProject.Dto.DTO_s.Portfolios;
using PortfolioProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.FluentValidations
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
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
               .MaximumLength(500)
               .WithName("İçerik");

            RuleFor(x => x.ProjectURL)
              .NotEmpty()
              .NotNull()
              .WithName("Proje Linki");


        }
    }
    public class PortfolioAddValidator : AbstractValidator<PortfolioAddDto>
    {
        public PortfolioAddValidator()
        {

            RuleFor(x => x.Photo)
                .NotEmpty()
                .WithName("Resim dosyası");

        }
    }
}
