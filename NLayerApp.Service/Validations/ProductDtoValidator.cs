using FluentValidation;
using NLayerApp.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Service.Validations
{
    public class ProductDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(p => p.Name).NotNull().WithMessage("{PropertName} is required").NotEmpty().WithMessage("{PropertName} is required");

            RuleFor(p => p.Price).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertName} must be greater  0");

            RuleFor(p => p.Stock).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertName} must be greater  0");

            RuleFor(p => p.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertName} must be greater  0");
        }
    }
}
