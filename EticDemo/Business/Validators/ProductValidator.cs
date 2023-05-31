using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators
{
    public class ProductValidator:AbstractValidator<Product>, IProductValidator
    {
        public ProductValidator()
        {
            RuleFor(product => product.Title).NotEmpty().WithMessage("Product title is required").MinimumLength(3).WithMessage("Product title length can be minimum 3");
            RuleFor(product => product.Price).GreaterThanOrEqualTo(0).WithMessage("Price can not be negative number");
        }
    }
}
