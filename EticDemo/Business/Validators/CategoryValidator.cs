using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators
{
    public class CategoryValidator:AbstractValidator<Category>, ICategoryValidator
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Title).NotEmpty().NotNull().MinimumLength(3).WithMessage("Category title length can be minimum 3");
        }
    }
}
